using System;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace pbo_project
{
    public partial class UserJadwal : UserControl
    {
        // Bulan yang sedang ditampilkan
        private DateTime bulanAktif = DateTime.Now;
        private string idKotaCache = "";

        public UserJadwal()
        {
            InitializeComponent();

            // Hook event tombol
            if (button1 != null) button1.Click += button1_Click;      // REFRESH
            if (btnPrev != null) btnPrev.Click += btnPrev_Click;      // SEBELUMNYA
            if (btnNext != null) btnNext.Click += btnNext_Click;      // SELANJUTNYA
            if (btnKembali != null) btnKembali.Click += btnKembali_Click;   // KEMBALI

            // Setup DataGridView
            if (dataGridView1 != null)
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        // Event Load (nama dari Designer: UserJadwal_Load_1)
        private async void UserJadwal_Load_1(object sender, EventArgs e)
        {
            await AmbilJadwalSholatBulanan();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // REFRESH — muat ulang bulan yang sedang aktif
            await AmbilJadwalSholatBulanan();
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            // Mundur 1 bulan
            bulanAktif = bulanAktif.AddMonths(-1);
            await AmbilJadwalSholatBulanan();
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            // Maju 1 bulan
            bulanAktif = bulanAktif.AddMonths(1);
            await AmbilJadwalSholatBulanan();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Kembali ke Dashboard
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            Form parentForm = this.FindForm();
            if (parentForm != null) parentForm.Hide();
        }

        private async Task AmbilJadwalSholatBulanan()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Update label bulan
                    if (bulan != null)
                    {
                        bulan.Text = bulanAktif.ToString("MMMM yyyy",
                            new System.Globalization.CultureInfo("id-ID"));
                        bulan.Font = new System.Drawing.Font("Calibri", 14F,
                            System.Drawing.FontStyle.Bold);
                    }

                    // === Cari ID Kota (cache) ===
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

                    // === Ambil jadwal bulan aktif ===
                    string periode = bulanAktif.ToString("yyyy-MM");
                    string urlBulanan = $"https://api.myquran.com/v3/sholat/jadwal/{idKotaCache}/{periode}?tz=Asia/Jakarta";

                    string respBulanan = await client.GetStringAsync(urlBulanan);
                    JObject json = JObject.Parse(respBulanan);

                    // Cek status response
                    string status = json["status"]?.ToString() ?? "";
                    if (status != "true" && status.ToLower() != "success")
                    {
                        // Kosongkan DataGridView
                        if (dataGridView1 != null)
                            dataGridView1.DataSource = null;

                        MessageBox.Show(
                            $"Data jadwal untuk {bulanAktif:MMMM yyyy} belum tersedia.\nSilakan pilih bulan lain.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // === Parsing JSON ===
                    JToken dataToken = json["data"];
                    JToken jadwalToken = null;

                    if (dataToken is JArray)
                        jadwalToken = dataToken;
                    else if (dataToken is JObject)
                        jadwalToken = dataToken["jadwal"] ?? dataToken["list"];

                    if (jadwalToken == null ||
                        (jadwalToken is JArray arr && arr.Count == 0) ||
                        (jadwalToken is JObject obj && obj.Count == 0))
                    {
                        if (dataGridView1 != null)
                            dataGridView1.DataSource = null;

                        MessageBox.Show(
                            $"Data jadwal untuk {bulanAktif:MMMM yyyy} kosong.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // === Bangun DataTable ===
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Tanggal", typeof(string));
                    dt.Columns.Add("Hari", typeof(string));
                    dt.Columns.Add("Imsak", typeof(string));
                    dt.Columns.Add("Subuh", typeof(string));
                    dt.Columns.Add("Dzuhur", typeof(string));
                    dt.Columns.Add("Ashar", typeof(string));
                    dt.Columns.Add("Maghrib", typeof(string));
                    dt.Columns.Add("Isya", typeof(string));

                    if (jadwalToken is JArray jArray2)
                    {
                        foreach (var item in jArray2)
                            TambahBaris(dt, item["tanggal"]?.ToString(), item);
                    }
                    else if (jadwalToken is JObject jObject2)
                    {
                        foreach (var prop in jObject2.Properties())
                            TambahBaris(dt, prop.Name, prop.Value);
                    }

                    if (dataGridView1 != null)
                        dataGridView1.DataSource = dt;
                }
                catch (System.Net.Http.HttpRequestException httpEx)
                {
                    // Error 404 = bulan belum tersedia di API
                    if (dataGridView1 != null)
                        dataGridView1.DataSource = null;

                    MessageBox.Show(
                        $"Data jadwal untuk {bulanAktif:MMMM yyyy} belum tersedia di server.\n" +
                        "Coba pilih bulan lain atau klik REFRESH.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat jadwal sholat: " + ex.Message);
                }
            }
        }s

        private void TambahBaris(DataTable dt, string tanggalStr, JToken item)
        {
            string namaHari = "";
            if (DateTime.TryParse(tanggalStr, out DateTime tgl))
            {
                namaHari = tgl.ToString("dddd",
                    new System.Globalization.CultureInfo("id-ID"));
            }

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