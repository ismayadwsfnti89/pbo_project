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
            

            // Event untuk tombol yang belum terhubung di Designer
            btnsimpan.Click += btnsimpan_Click;
            btnedit.Click += btnedit_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;

            TampilData();
            Bersihkan();
        }
        // TAMPIL DATA
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
                        LEFT JOIN program p 
                            ON d.id_program = p.id_program
                        ORDER BY d.id_donasi DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data donasi!\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error
                );
            }
        }
        private void Bersihkan()
        {
            tbId.Clear();
            tbIdUsers.Clear();
            tbIDProgram.Clear();
            tbNma.Clear();
            tbNominal.Clear();
            cbStatus.SelectedIndex = -1;
            date.Value = DateTime.Now;
            pictureBoxBukti.Image = null;
            bukti = "";
            tbId.ReadOnly = true;
        }
        private void btnupload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter =
                    "File Gambar|*.jpg;*.jpeg;*.png;*.bmp";
                openFile.Title = "Pilih Bukti Donasi";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    bukti = openFile.FileName;using (Image temp = Image.FromFile(bukti))
                    {
                        pictureBoxBukti.Image = new Bitmap(temp);
                    }

                    pictureBoxBukti.SizeMode =PictureBoxSizeMode.Zoom;
                }
            }
        }
        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi
                if (tbIdUsers.Text == "" ||
                    tbIDProgram.Text == "" ||
                    tbNma.Text == "" ||
                    tbNominal.Text == "")
                {
                    MessageBox.Show("Data belum lengkap!");
                    return;
                }
                int idUsers = Convert.ToInt32(tbIdUsers.Text);
                int idProgram = Convert.ToInt32(tbIDProgram.Text);
                decimal nominal = Convert.ToDecimal(tbNominal.Text);
                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();
                    // Ambil ID donasi berikutnya
                    string queryId = "SELECT ISNULL(MAX(id_donasi), 0) + 1 FROM donasi";

                    int idDonasiBaru;

                    using (SqlCommand cmdId = new SqlCommand(queryId, conn))
                    {
                        idDonasiBaru = Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    // Simpan data
                    string query = @"
                INSERT INTO donasi
                (
                    id_donasi,id_users,id_program,nama_donatur,nominal,status,tanggal,bukti
                )
                VALUES
                (
                    @IdDonasi,@IdUsers,@IdProgram,@NamaDonatur,@Nominal,@Status,@Tanggal,@Bukti
                )";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdDonasi", idDonasiBaru);
                        cmd.Parameters.AddWithValue("@IdUsers", idUsers);
                        cmd.Parameters.AddWithValue("@IdProgram", idProgram);
                        cmd.Parameters.AddWithValue("@NamaDonatur", tbNma.Text);
                        cmd.Parameters.AddWithValue("@Nominal", nominal);
                        cmd.Parameters.AddWithValue("@Status", cbStatus.Text);
                        cmd.Parameters.AddWithValue("@Tanggal", date.Value.Date);
                        cmd.Parameters.AddWithValue("@Bukti", bukti);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data donasi berhasil disimpan!");
                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan data:\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error
                );
            }
        }
        private void btnsmpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi
                if (tbIdUsers.Text == "" ||tbIDProgram.Text == "" ||tbNma.Text == "" ||tbNominal.Text == "")
                {
                    MessageBox.Show("Data belum lengkap!");
                    return;
                }

                int idUsers = Convert.ToInt32(tbIdUsers.Text);
                int idProgram = Convert.ToInt32(tbIDProgram.Text);
                decimal nominal = Convert.ToDecimal(tbNominal.Text);

                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    // Ambil ID donasi berikutnya
                    string queryId = "SELECT ISNULL(MAX(id_donasi), 0) + 1 FROM donasi";

                    int idDonasiBaru;

                    using (SqlCommand cmdId = new SqlCommand(queryId, conn))
                    {
                        idDonasiBaru = Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    // Simpan data
                    string query = @"
                INSERT INTO donasi
                (
                    id_donasi,id_users,id_program,nama_donatur,nominal,status,tanggal,bukti
                )
                VALUES
                (
                    @IdDonasi,@IdUsers,@IdProgram,@NamaDonatur,@Nominal,@Status,@Tanggal,@Bukti
                )";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdDonasi", idDonasiBaru);
                        cmd.Parameters.AddWithValue("@IdUsers", idUsers);
                        cmd.Parameters.AddWithValue("@IdProgram", idProgram);
                        cmd.Parameters.AddWithValue("@NamaDonatur", tbNma.Text);
                        cmd.Parameters.AddWithValue("@Nominal", nominal);
                        cmd.Parameters.AddWithValue("@Status", cbStatus.Text);
                        cmd.Parameters.AddWithValue("@Tanggal", date.Value.Date);
                        cmd.Parameters.AddWithValue("@Bukti", bukti);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data donasi berhasil disimpan!");
                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan data:\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error
                );
            }
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin diedit terlebih dahulu!");
                return;
            }
            if (!int.TryParse(tbId.Text, out int idDonasi))
            {
                MessageBox.Show("ID Donasi tidak valid!");
                return;
            }
            if (!int.TryParse(tbIdUsers.Text, out int idUsers))
            {
                MessageBox.Show("ID Users harus berupa angka!");
                return;
            }
            if (!int.TryParse(tbIDProgram.Text, out int idProgram))
            {
                MessageBox.Show("ID Program harus berupa angka!");
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
                        SET
                            id_users = @idUsers,
                            id_program = @idProgram,
                            nominal = @nominal,
                            bukti = @bukti,
                            status = @status,
                            tanggal = @tanggal,
                            updated_at = GETDATE(),
                            nama_donatur = @nama
                        WHERE id_donasi = @idDonasi";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idDonasi", idDonasi);
                        cmd.Parameters.AddWithValue("@idUsers", idUsers);
                        cmd.Parameters.AddWithValue("@idProgram", idProgram);
                        cmd.Parameters.AddWithValue("@nominal", nominal);

                        if (bukti == "")
                            cmd.Parameters.AddWithValue("@bukti", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@bukti", bukti);
                            cmd.Parameters.AddWithValue("@status",cbStatus.Text);
                            cmd.Parameters.AddWithValue("@tanggal",date.Value.Date);
                            cmd.Parameters.AddWithValue("@nama",tbNma.Text);
                            cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data donasi berhasil diubah!","Sukses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data!\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnhps_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!");
                return;
            }
            DialogResult hasil = MessageBox.Show("Yakin ingin menghapus data ini?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (hasil == DialogResult.No)
                return;
            if (!int.TryParse(tbId.Text, out int idDonasi))
            {
                MessageBox.Show("ID Donasi tidak valid!");
                return;
            }
            try
            {
                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();
                    string query =
                        "DELETE FROM donasi WHERE id_donasi = @idDonasi";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idDonasi",idDonasi);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data donasi berhasil dihapus!","Sukses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data!\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnbatal_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }
        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =dataGridView1.Rows[e.RowIndex];tbId.Text =
                            row.Cells["id_donasi"].Value?.ToString();tbIdUsers.Text =
                            row.Cells["id_users"].Value?.ToString();tbIDProgram.Text =
                            row.Cells["id_program"].Value?.ToString();tbNma.Text =
                            row.Cells["nama_donatur"].Value?.ToString();tbNominal.Text =
                            row.Cells["nominal"].Value?.ToString();cbStatus.Text =
                            row.Cells["status"].Value?.ToString();
            if (row.Cells["tanggal"].Value != null &&
                row.Cells["tanggal"].Value != DBNull.Value)
            {
                date.Value =Convert.ToDateTime(row.Cells["tanggal"].Value);
            }

            // Ambil lokasi bukti
            if (row.Cells["bukti"].Value != null &&
                row.Cells["bukti"].Value != DBNull.Value)
            {
                bukti =
                    row.Cells["bukti"].Value.ToString();
                if (File.Exists(bukti))
                {
                    using (Image temp = Image.FromFile(bukti))
                    {
                        pictureBoxBukti.Image =new Bitmap(temp);
                    }
                    pictureBoxBukti.SizeMode =PictureBoxSizeMode.Zoom;
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
        private void btnkembali_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            // Sembunyikan form atau user control saat ini
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Hide();
            }
        }
    }
}