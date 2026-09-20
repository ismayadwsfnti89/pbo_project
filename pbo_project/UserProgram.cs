using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace pbo_project
{
    public partial class UserProgram : UserControl
    {
        public UserProgram()
        {
            InitializeComponent();
            btnsimpn.Click += btnsimpn_Click;
            btnedit.Click += btnedit_Click;
            btnhapus.Click += btnhapus_Click;
            btnbatal.Click += btnbatal_Click;
            dgvProgram.CellClick += dgvProgram_CellClick;
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Aktif");
            cbStatus.Items.Add("Selesai");
            cbStatus.Items.Add("Tidak Aktif");
            cbStatus.SelectedIndex = 0; 
            idProgram.ReadOnly = true;
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
                            id_program,
                            nama_program,
                            target,
                            deskripsi,
                            status,
                            created_at,
                            updated_at
                        FROM program
                        ORDER BY id_program DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvProgram.DataSource = dt;
                    }
                }

                // Judul kolom
                if (dgvProgram.Columns.Count > 0)
                {
                    dgvProgram.Columns["id_program"].HeaderText = "ID";
                    dgvProgram.Columns["nama_program"].HeaderText = "Nama Program";
                    dgvProgram.Columns["target"].HeaderText = "Target";
                    dgvProgram.Columns["deskripsi"].HeaderText = "Deskripsi";
                    dgvProgram.Columns["status"].HeaderText = "Status";
                    dgvProgram.Columns["created_at"].HeaderText = "Dibuat";
                    dgvProgram.Columns["updated_at"].HeaderText = "Diubah";
                }

                dgvProgram.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // BERSIHKAN FORM
        // =====================================================
        private void Bersihkan()
        {
            idProgram.Clear();
            NamaProgram.Clear();
            tbTarget.Clear();
            tbDeskripsi.Clear();

            if (cbStatus.Items.Count > 0)
                cbStatus.SelectedIndex = 0;

            idProgram.ReadOnly = true;

            NamaProgram.Focus();
        }

        // =====================================================
        // SIMPAN
        // =====================================================
        private void btnsimpn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi
                if (NamaProgram.Text.Trim() == "")
                {
                    MessageBox.Show("Nama program harus diisi!");
                    NamaProgram.Focus();
                    return;
                }

                if (tbTarget.Text.Trim() == "")
                {
                    MessageBox.Show("Target harus diisi!");
                    tbTarget.Focus();
                    return;
                }

                if (tbDeskripsi.Text.Trim() == "")
                {
                    MessageBox.Show("Deskripsi harus diisi!");
                    tbDeskripsi.Focus();
                    return;
                }

                if (cbStatus.Text.Trim() == "")
                {
                    MessageBox.Show("Status harus dipilih!");
                    cbStatus.Focus();
                    return;
                }

                // Ubah target menjadi decimal
                decimal target;

                if (!decimal.TryParse(tbTarget.Text, out target))
                {
                    MessageBox.Show("Target harus berupa angka!");
                    tbTarget.Focus();
                    return;
                }

                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    // Cari ID program berikutnya
                    string queryId = @"
                        SELECT ISNULL(MAX(id_program), 0) + 1
                        FROM program";

                    int idProgramBaru;

                    using (SqlCommand cmdId =
                           new SqlCommand(queryId, conn))
                    {
                        idProgramBaru =
                            Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    // INSERT
                    string query = @"
                        INSERT INTO program
                        (
                            id_program,
                            nama_program,
                            target,
                            deskripsi,
                            status,
                            created_at,
                            updated_at
                        )
                        VALUES
                        (
                            @IdProgram,
                            @NamaProgram,
                            @Target,
                            @Deskripsi,
                            @Status,
                            GETDATE(),
                            GETDATE()
                        )";

                    using (SqlCommand cmd =
                           new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@IdProgram",
                            idProgramBaru);

                        cmd.Parameters.AddWithValue(
                            "@NamaProgram",
                            NamaProgram.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Target",
                            target);

                        cmd.Parameters.AddWithValue(
                            "@Deskripsi",
                            tbDeskripsi.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Status",
                            cbStatus.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Program berhasil disimpan!",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Refresh DGV
                TampilData();

                // Bersihkan form
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menyimpan program:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // EDIT
        // =====================================================
        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProgram.Text.Trim() == "")
                {
                    MessageBox.Show("Pilih data yang ingin diedit!");
                    return;
                }

                if (NamaProgram.Text.Trim() == "")
                {
                    MessageBox.Show("Nama program harus diisi!");
                    return;
                }

                if (tbTarget.Text.Trim() == "")
                {
                    MessageBox.Show("Target harus diisi!");
                    return;
                }

                decimal target;

                if (!decimal.TryParse(tbTarget.Text, out target))
                {
                    MessageBox.Show("Target harus berupa angka!");
                    return;
                }

                int id = Convert.ToInt32(idProgram.Text);

                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE program
                        SET
                            nama_program = @NamaProgram,
                            target = @Target,
                            deskripsi = @Deskripsi,
                            status = @Status,
                            updated_at = GETDATE()
                        WHERE id_program = @IdProgram";

                    using (SqlCommand cmd =
                           new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@IdProgram",
                            id);

                        cmd.Parameters.AddWithValue(
                            "@NamaProgram",
                            NamaProgram.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Target",
                            target);

                        cmd.Parameters.AddWithValue(
                            "@Deskripsi",
                            tbDeskripsi.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@Status",
                            cbStatus.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Program berhasil diubah!",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengubah program:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // HAPUS
        // =====================================================
        private void btnhapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProgram.Text.Trim() == "")
                {
                    MessageBox.Show("Pilih data yang ingin dihapus!");
                    return;
                }

                int id = Convert.ToInt32(idProgram.Text);

                DialogResult hasil = MessageBox.Show(
                    "Apakah kamu yakin ingin menghapus program ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (hasil != DialogResult.Yes)
                    return;

                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        DELETE FROM program
                        WHERE id_program = @IdProgram";

                    using (SqlCommand cmd =
                           new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@IdProgram",
                            id);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Program berhasil dihapus!",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                TampilData();
                Bersihkan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menghapus program:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // BATAL
        // =====================================================
        private void btnbatal_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        // =====================================================
        // KLIK DATA GRIDVIEW
        // =====================================================
        private void dgvProgram_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row =
                    dgvProgram.Rows[e.RowIndex];

                idProgram.Text =
                    row.Cells["id_program"].Value?.ToString();

                NamaProgram.Text =
                    row.Cells["nama_program"].Value?.ToString();

                tbTarget.Text =
                    row.Cells["target"].Value?.ToString();

                tbDeskripsi.Text =
                    row.Cells["deskripsi"].Value?.ToString();

                cbStatus.Text =
                    row.Cells["status"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mengambil data:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttnkembali_Click(object sender, EventArgs e)
        {

        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.FindForm().Hide();
        }
    }
}