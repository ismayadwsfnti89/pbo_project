using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pbo_project
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProgressDonasi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Progress error: " + ex.Message);
            }

            try
            {
                LoadStatistik();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Statistik error: " + ex.Message);
            }
        }

        private void TampilkanUsersControl(UserControl userControl)
        {
            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDonasi_Click(object sender, EventArgs e) { TampilkanUsersControl(new UserDonasi()); }
        private void btnJadwal_Click(object sender, EventArgs e) { TampilkanUsersControl(new UserJadwal()); }
        private void btnprogram_Click(object sender, EventArgs e) { TampilkanUsersControl(new UserProgram()); }
        private void btnlaporan_Click(object sender, EventArgs e) { TampilkanUsersControl(new UserLaporan()); }
        private void btnkas_Click(object sender, EventArgs e) { TampilkanUsersControl(new UserKas()); }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void LoadProgressDonasi()
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        COALESCE(SUM(nominal), 0) AS Terkumpul,
                        (SELECT COALESCE(SUM(target), 0) FROM program WHERE status = 'Aktif') AS Target
                    FROM donasi";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        decimal terkumpul = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                        decimal target = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);

                        int persentase = 0;
                        if (target > 0)
                        {
                            persentase = (int)((terkumpul / target) * 100);
                            if (persentase > 100) persentase = 100;
                        }

                        if (progressdonasi != null)
                        {
                            progressdonasi.Minimum = 0;
                            progressdonasi.Maximum = 100;
                            progressdonasi.Value = persentase;
                        }

                        if (lblprogress != null)
                            lblprogress.Text = $"{persentase}% Tercapai (Rp {terkumpul:N0} / Rp {target:N0})";
                    }
                }
            }
        }

        private void LoadStatistik()
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();

                // Total Donasi
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT COALESCE(SUM(nominal), 0) FROM donasi", conn))
                    {
                        decimal total = Convert.ToDecimal(cmd.ExecuteScalar());
                        if (lblStat1Value != null) lblStat1Value.Text = "Rp " + total.ToString("N0");
                    }
                }
                catch { }

                // Program Aktif
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM program WHERE status = 'Aktif'", conn))
                    {
                        int jml = Convert.ToInt32(cmd.ExecuteScalar());
                        if (lblStat2Value != null) lblStat2Value.Text = jml.ToString();
                    }
                }
                catch { }

                // Saldo Kas
                try
                {
                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT 
                            COALESCE(SUM(CASE WHEN jenis='Masuk' THEN nominal ELSE 0 END), 0) -
                            COALESCE(SUM(CASE WHEN jenis='Keluar' THEN nominal ELSE 0 END), 0)
                        FROM kas", conn))
                    {
                        decimal saldo = Convert.ToDecimal(cmd.ExecuteScalar());
                        if (lblStat3Value != null)
                        {
                            lblStat3Value.Text = "Rp " + saldo.ToString("N0");
                            lblStat3Value.ForeColor = saldo < 0 ? Color.Firebrick : Color.ForestGreen;
                        }
                    }
                }
                catch { }

                // Kegiatan (kalau tabel tidak ada, skip)
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM kegiatan", conn))
                    {
                        int jml = Convert.ToInt32(cmd.ExecuteScalar());
                        if (lblStat4Value != null) lblStat4Value.Text = jml.ToString();
                    }
                }
                catch
                {
                    if (lblStat4Value != null) lblStat4Value.Text = "-";
                }
            }
        }
    }
}