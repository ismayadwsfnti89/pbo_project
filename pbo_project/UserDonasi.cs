using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace pbo_project
{
    public partial class UserDonasi : UserControl
    {
        private string bukti = "";

        public UserDonasi()
        {
            InitializeComponent();

            // Hook event
            btnsimpan.Click += btnsimpan_Click;
            btnedit.Click += btnedit_Click;
            btnhps.Click += btnhps_Click;
            btnbatal.Click += (s, e) => Bersihkan();
            btnkembali.Click += btnkembali_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Isi dropdown metode
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Transfer");
            cbStatus.Items.Add("QRIS");

            tbId.ReadOnly = true;

            // Load program ke ComboBox
            LoadProgramComboBox();

            TampilData();
            Bersihkan();
        }

        // =====================================================
        // LOAD PROGRAM KE COMBOBOX
        // =====================================================
        private void LoadProgramComboBox()
        {
            try
            {
                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();
                    string q = "SELECT id_program, nama_program FROM program WHERE status='Aktif' ORDER BY nama_program";

                    using (SqlDataAdapter da = new SqlDataAdapter(q, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbProgram.DataSource = dt;
                        cbProgram.DisplayMember = "nama_program";
                        cbProgram.ValueMember = "id_program";
                        cbProgram.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat program: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            d.id_donasi,
                            d.id_users,
                            d.id_program,
                            p.nama_program,
                            d.nama_donatur,
                            d.nominal,
                            d.status,
                            d.tanggal,
                            d.bukti
                        FROM donasi d
                        LEFT JOIN program p ON d.id_program = p.id_program
                        ORDER BY d.id_donasi DESC";

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
                MessageBox.Show("Gagal menampilkan data donasi:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // BERSIHKAN
        // =====================================================
        private void Bersihkan()
        {
            tbId.Clear();
            tbNma.Clear();
            tbNominal.Clear();
            cbProgram.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            date.Value = DateTime.Now;
            pictureBoxBukti.Image = null;
            bukti = "";
            tbId.ReadOnly = true;
        }

        // =====================================================
        // UPLOAD BUKTI
        // =====================================================
        private void btnupload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp";
                openFile.Title = "Pilih Bukti Donasi";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    bukti = openFile.FileName;
                    using (Image temp = Image.FromFile(bukti))
                    {
                        pictureBoxBukti.Image = new Bitmap(temp);
                    }
                    pictureBoxBukti.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        // =====================================================
        // SIMPAN
        // =====================================================
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (tbNma.Text.Trim() == "" || tbNominal.Text.Trim() == "" ||
                cbProgram.SelectedValue == null || cbStatus.SelectedItem == null)
            {
                MessageBox.Show("Data belum lengkap! Pastikan semua field terisi.",
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        INSERT INTO donasi
                        (id_users, id_program, nama_donatur, nominal, status, tanggal, bukti)
                        VALUES
                        (@IdUsers, @IdProgram, @NamaDonatur, @Nominal, @Status, @Tanggal, @Bukti)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdUsers", Session.IdUsers);
                        cmd.Parameters.AddWithValue("@IdProgram", Convert.ToInt32(cbProgram.SelectedValue));
                        cmd.Parameters.AddWithValue("@NamaDonatur", tbNma.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nominal", nominal);
                        cmd.Parameters.AddWithValue("@Status", cbStatus.Text);
                        cmd.Parameters.AddWithValue("@Tanggal", date.Value.Date);
                        cmd.Parameters.AddWithValue("@Bukti", string.IsNullOrEmpty(bukti) ? (object)DBNull.Value : bukti);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data donasi berhasil disimpan!",
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
        // EDIT
        // =====================================================
        private void btnedit_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin diedit dulu!");
                return;
            }
            if (cbProgram.SelectedValue == null)
            {
                MessageBox.Show("Pilih program dulu!");
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
                        UPDATE donasi
                        SET id_users = @IdUsers,
                            id_program = @IdProgram,
                            nama_donatur = @Nama,
                            nominal = @Nominal,
                            status = @Status,
                            tanggal = @Tanggal,
                            bukti = @Bukti
                        WHERE id_donasi = @IdDonasi";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdDonasi", Convert.ToInt32(tbId.Text));
                        cmd.Parameters.AddWithValue("@IdUsers", Session.IdUsers);
                        cmd.Parameters.AddWithValue("@IdProgram", Convert.ToInt32(cbProgram.SelectedValue));
                        cmd.Parameters.AddWithValue("@Nama", tbNma.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nominal", nominal);
                        cmd.Parameters.AddWithValue("@Status", cbStatus.Text);
                        cmd.Parameters.AddWithValue("@Tanggal", date.Value.Date);
                        cmd.Parameters.AddWithValue("@Bukti", string.IsNullOrEmpty(bukti) ? (object)DBNull.Value : bukti);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data donasi berhasil diubah!",
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
        private void btnhps_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin dihapus dulu!");
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "DELETE FROM donasi WHERE id_donasi = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbId.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data donasi berhasil dihapus!",
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
        // KLIK GRID
        // =====================================================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            tbId.Text = row.Cells["id_donasi"].Value?.ToString();
            tbNma.Text = row.Cells["nama_donatur"].Value?.ToString();
            tbNominal.Text = row.Cells["nominal"].Value?.ToString();
            cbStatus.Text = row.Cells["status"].Value?.ToString();

            // Set ComboBox Program
            if (row.Cells["id_program"].Value != null &&
                row.Cells["id_program"].Value != DBNull.Value)
            {
                cbProgram.SelectedValue = Convert.ToInt32(row.Cells["id_program"].Value);
            }

            if (row.Cells["tanggal"].Value != null &&
                row.Cells["tanggal"].Value != DBNull.Value)
            {
                date.Value = Convert.ToDateTime(row.Cells["tanggal"].Value);
            }

            // Bukti
            if (row.Cells["bukti"].Value != null &&
                row.Cells["bukti"].Value != DBNull.Value)
            {
                bukti = row.Cells["bukti"].Value.ToString();
                if (File.Exists(bukti))
                {
                    using (Image temp = Image.FromFile(bukti))
                    {
                        pictureBoxBukti.Image = new Bitmap(temp);
                    }
                    pictureBoxBukti.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBoxBukti.Image = null;
                }
            }
            else
            {
                bukti = "";
                pictureBoxBukti.Image = null;
            }
        }

        // =====================================================
        // KEMBALI
        // =====================================================
        private void btnkembali_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.FindForm()?.Hide();
        }
    }
}