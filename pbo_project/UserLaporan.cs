using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace pbo_project
{
    public partial class UserLaporan : UserControl
    {
        public UserLaporan()
        {
            InitializeComponent();
            this.Load += UserLaporan_Load;
            this.btnKembali.Click += btnKembali_Click;

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

        private void UserLaporan_Load(object sender, EventArgs e)
        {
            TampilLaporan();
        }

        private void TampilLaporan()
        {
            try
            {
                using (SqlConnection conn = koneksi.GetConnection())
                {
                    conn.Open();

                    decimal masuk = 0, keluar = 0;

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COALESCE(SUM(nominal),0) FROM kas WHERE jenis='Masuk'", conn))
                        masuk = Convert.ToDecimal(cmd.ExecuteScalar());

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COALESCE(SUM(nominal),0) FROM kas WHERE jenis='Keluar'", conn))
                        keluar = Convert.ToDecimal(cmd.ExecuteScalar());

                    decimal saldo = masuk - keluar;

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Keterangan", typeof(string));
                    dt.Columns.Add("Jumlah", typeof(decimal));

                    // Pemasukan per kategori
                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT kategori, SUM(nominal) AS total
                        FROM kas WHERE jenis='Masuk'
                        GROUP BY kategori ORDER BY kategori", conn))
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                            dt.Rows.Add("Pemasukan — " + r["kategori"], Convert.ToDecimal(r["total"]));
                    }

                    // Pengeluaran per kategori
                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT kategori, SUM(nominal) AS total
                        FROM kas WHERE jenis='Keluar'
                        GROUP BY kategori ORDER BY kategori", conn))
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                            dt.Rows.Add("Pengeluaran — " + r["kategori"], Convert.ToDecimal(r["total"]));
                    }

                    // Pemisah
                    dt.Rows.Add("──────────────", DBNull.Value);

                    // Total
                    dt.Rows.Add("TOTAL PEMASUKAN", masuk);
                    dt.Rows.Add("TOTAL PENGELUARAN", keluar);
                    dt.Rows.Add("SALDO AKHIR", saldo);

                    dataGridView1.DataSource = dt;

                    // Format kolom jumlah sebagai Rupiah
                    dataGridView1.Columns["Jumlah"].DefaultCellStyle.Format = "N0";
                    dataGridView1.Columns["Jumlah"].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleRight;

                    // Warnai baris total
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string ket = row.Cells["Keterangan"].Value?.ToString() ?? "";

                        if (ket.StartsWith("Pemasukan"))
                            row.DefaultCellStyle.ForeColor = Color.DarkGreen;
                        else if (ket.StartsWith("Pengeluaran"))
                            row.DefaultCellStyle.ForeColor = Color.Firebrick;

                        if (ket.StartsWith("TOTAL") || ket.StartsWith("SALDO"))
                        {
                            row.DefaultCellStyle.Font = new Font("Calibri", 12F, FontStyle.Bold);
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.FindForm()?.Hide();
        }
    }
}
