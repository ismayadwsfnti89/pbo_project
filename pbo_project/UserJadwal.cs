using System;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace pbo_project
{
    public partial class UserJadwal : UserControl
    {
        private DateTime bulanAktif = DateTime.Now;
        private string idKotaCache = "";

        public UserJadwal()
        {
            InitializeComponent();

            // Hook event dari constructor (paling aman)
            this.Load += UserJadwal_Load;
            this.btnKembali.Click += btnKembali_Click;
            this.btnPrev.Click += btnPrev_Click;
            this.btnNext.Click += btnNext_Click;
            this.button1.Click += button1_Click;

            if (dataGridView1 != null)
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Font = new Font("Calibri", 11F);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11F, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.EnableHeadersVisualStyles = false;
            }
        }

        private async void UserJadwal_Load(object sender, EventArgs e)
        {
            await AmbilJadwalSholatBulanan();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await AmbilJadwalSholatBulanan();
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            bulanAktif = bulanAktif.AddMonths(-1);
            await AmbilJadwalSholatBulanan();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            bulanAktif = bulanAktif.AddMonths(1);
            await AmbilJadwalSholatBulanan();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.FindForm()?.Hide();
        }

        private async Task AmbilJadwalSholatBulanan()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    if (bulan != null)
                    {
                        bulan.Text = bulanAktif.ToString("MMMM yyyy",
                            new System.Globalization.CultureInfo("id-ID"));
                    }

                    // Cari ID kota (cache)
                    if (string.IsNullOrEmpty(idKotaCache))
                    {
                        string urlCari = "https://api.myquran.com/v3/sholat/kota/cari/tasikmalaya";
                        string respCari = await client.GetStringAsync(urlCari);
                        JObject jsonCari = JObject.Parse(respCari);

                        foreach (var item in jsonCari["data"])
                        {
                            if (item["lokasi"].ToString().ToUpper().Contains("KOTA"))
                            {
                                idKotaCache = item["id"].ToString();
                                break;
                            }
                        }
                        if (string.IsNullOrEmpty(idKotaCache))
                            idKotaCache = jsonCari["data"][0]["id"].ToString();
                    }

                    string periode = bulanAktif.ToString("yyyy-MM");
                    string urlBulanan = $"https://api.myquran.com/v3/sholat/jadwal/{idKotaCache}/{periode}?tz=Asia/Jakarta";

                    string respBulanan = await client.GetStringAsync(urlBulanan);
                    JObject json = JObject.Parse(respBulanan);

                    JToken dataToken = json["data"];
                    JToken jadwalToken = null;

                    if (dataToken is JArray)
                        jadwalToken = dataToken;
                    else if (dataToken is JObject)
                        jadwalToken = dataToken["jadwal"] ?? dataToken["list"];

                    if (jadwalToken == null)
                    {
                        if (dataGridView1 != null)
                            dataGridView1.DataSource = null;
                        MessageBox.Show($"Data jadwal untuk {bulanAktif:MMMM yyyy} belum tersedia.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Tanggal", typeof(string));
                    dt.Columns.Add("Hari", typeof(string));
                    dt.Columns.Add("Imsak", typeof(string));
                    dt.Columns.Add("Subuh", typeof(string));
                    dt.Columns.Add("Dzuhur", typeof(string));
                    dt.Columns.Add("Ashar", typeof(string));
                    dt.Columns.Add("Maghrib", typeof(string));
                    dt.Columns.Add("Isya", typeof(string));

                    if (jadwalToken is JArray jArray)
                    {
                        foreach (var item in jArray)
                            TambahBaris(dt, item["tanggal"]?.ToString(), item);
                    }
                    else if (jadwalToken is JObject jObject)
                    {
                        foreach (var prop in jObject.Properties())
                            TambahBaris(dt, prop.Name, prop.Value);
                    }

                    if (dataGridView1 != null)
                        dataGridView1.DataSource = dt;
                }
                catch (System.Net.Http.HttpRequestException)
                {
                    if (dataGridView1 != null)
                        dataGridView1.DataSource = null;
                    MessageBox.Show($"Data jadwal untuk {bulanAktif:MMMM yyyy} belum tersedia di server.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat jadwal sholat: " + ex.Message);
                }
            }
        }

        private void TambahBaris(DataTable dt, string tanggalStr, JToken item)
        {
            string namaHari = "";
            if (DateTime.TryParse(tanggalStr, out DateTime tgl))
                namaHari = tgl.ToString("dddd", new System.Globalization.CultureInfo("id-ID"));

            dt.Rows.Add(
                tanggalStr ?? "-",
                namaHari,
                item["imsak"]?.ToString() ?? "-",
                item["subuh"]?.ToString() ?? "-",
                item["dzuhur"]?.ToString() ?? "-",
                item["ashar"]?.ToString() ?? "-",
                item["maghrib"]?.ToString() ?? "-",
                item["isya"]?.ToString() ?? "-"
            );
        }
    }
}