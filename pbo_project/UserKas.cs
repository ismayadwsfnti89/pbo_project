using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace pbo_project
{
    public partial class UserKas : UserControl
    {
        public UserKas()
        {
            InitializeComponent();

            // Hook event tombol
            btnSimpan.Click += btnSimpan_Click;
            btnEdit.Click += btnEdit_Click;
            btnHapus.Click += btnHapus_Click;
            btnBatal.Click += (s, e) => Bersihkan();
            btnKembali.Click += btnKembali_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Isi dropdown Jenis
            cbJenis.Items.Clear();
            cbJenis.Items.Add("Masuk");
            cbJenis.Items.Add("Keluar");

            // Isi dropdown Kategori
            cbKategori.Items.Clear();
            cbKategori.Items.AddRange(new object[] {
                "Donasi",
                "Infaq Jumat",
                "Sewa Aula",
                "ZIS",
                "Listrik",
                "Honor Imam",
                "Beli Alat",
                "Lainnya"
            });

            tbId.ReadOnly = true;

            TampilData();
            Bersihkan();
        }

        // =====================================================
        // TAMPIL DATA
        // =====================================================
        private void TampilData()
        {
            try
            {
                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            id_kas      AS [ID],
                            jenis       AS [Jenis],
                            kategori    AS [Kategori],
                            keterangan  AS [Keterangan],
                            nominal     AS [Nominal],
                            tanggal     AS [Tanggal]
                        FROM kas
                        ORDER BY tanggal DESC, id_kas DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data kas:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // BERSIHKAN FORM
        // =====================================================
        private void Bersihkan()
        {
            tbId.Clear();
            tbKeterangan.Clear();
            tbNominal.Clear();
            cbJenis.SelectedIndex = -1;
            cbKategori.SelectedIndex = -1;
            dtTanggal.Value = DateTime.Now;
            tbId.ReadOnly = true;
        }

        // =====================================================
        // SIMPAN
        // =====================================================
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cbJenis.Text.Trim() == "" || cbKategori.Text.Trim() == "")
            {
                MessageBox.Show("Jenis dan Kategori wajib dipilih!");
                return;
            }
            if (tbNominal.Text.Trim() == "")
            {
                MessageBox.Show("Nominal wajib diisi!");
                return;
            }
            if (!decimal.TryParse(tbNominal.Text, out decimal nominal))
            {
                MessageBox.Show("Nominal harus berupa angka!");
                return;
            }

            try
            {
                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO kas (jenis, kategori, keterangan, nominal, tanggal)
                        VALUES (@jenis, @kategori, @keterangan, @nominal, @tanggal)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@jenis", cbJenis.Text);
                        cmd.Parameters.AddWithValue("@kategori", cbKategori.Text);
                        cmd.Parameters.AddWithValue("@keterangan",
                            string.IsNullOrWhiteSpace(tbKeterangan.Text) ? "-" : tbKeterangan.Text.Trim());
                        cmd.Parameters.AddWithValue("@nominal", nominal);
                        cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.Date);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data kas berhasil disimpan!",
                    "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // EDIT / UPDATE
        // =====================================================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Trim() == "")
            {
                MessageBox.Show("Pilih data yang ingin diedit terlebih dahulu!");
                return;
            }
            if (!decimal.TryParse(tbNominal.Text, out decimal nominal))
            {
                MessageBox.Show("Nominal harus berupa angka!");
                return;
            }

            try
            {
                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE kas
                        SET jenis      = @jenis,
                            kategori   = @kategori,
                            keterangan = @keterangan,
                            nominal    = @nominal,
                            tanggal    = @tanggal
                        WHERE id_kas = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbId.Text));
                        cmd.Parameters.AddWithValue("@jenis", cbJenis.Text);
                        cmd.Parameters.AddWithValue("@kategori", cbKategori.Text);
                        cmd.Parameters.AddWithValue("@keterangan",
                            string.IsNullOrWhiteSpace(tbKeterangan.Text) ? "-" : tbKeterangan.Text.Trim());
                        cmd.Parameters.AddWithValue("@nominal", nominal);
                        cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.Date);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data kas berhasil diubah!",
                    "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // HAPUS
        // =====================================================
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (tbId.Text.Trim() == "")
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!");
                return;
            }

            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (hasil != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM kas WHERE id_kas = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data kas berhasil dihapus!",
                    "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // KLIK DI GRIDVIEW
        // =====================================================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            tbId.Text = row.Cells["ID"].Value?.ToString();
            cbJenis.Text = row.Cells["Jenis"].Value?.ToString();
            cbKategori.Text = row.Cells["Kategori"].Value?.ToString();
            tbKeterangan.Text = row.Cells["Keterangan"].Value?.ToString();
            tbNominal.Text = row.Cells["Nominal"].Value?.ToString();

            if (row.Cells["Tanggal"].Value != null &&
                row.Cells["Tanggal"].Value != DBNull.Value)
            {
                dtTanggal.Value = Convert.ToDateTime(row.Cells["Tanggal"].Value);
            }
        }

        // =====================================================
        // KEMBALI KE DASHBOARD
        // =====================================================
        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();

            Form parent = this.FindForm();
            if (parent != null) parent.Hide();
        }
    }
}