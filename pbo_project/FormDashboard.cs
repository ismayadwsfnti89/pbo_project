using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace pbo_project
{
    public partial class FormDashboard : Form
    {
        private int id_program = 1;
        public FormDashboard()
        {
            InitializeComponent();
            progressdonasi.Visible = false;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadProgressDonasi();
        }
        private void TampilkanUsersControl(UserControl userControl)
        {
            panel1.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDonasi_Click(object sender, EventArgs e)
        {
            TampilkanUsersControl(new UserDonasi());
        }

        private void btnJadwal_Click(object sender, EventArgs e)
        {
            TampilkanUsersControl(new UserJadwal());
        }

        private void btnKegiatan_Click(object sender, EventArgs e)
        {
            TampilkanUsersControl(new UserKegiatan());
        }

        //private void btnProfile_Click(object sender, EventArgs e)
        //{
        //    TampilkanUsersControl(new UserProfile());
        //}

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            login.Show();

            this.Hide();
        }

        private void btnprogram_Click(object sender, EventArgs e)
        {
            TampilkanUsersControl(new UserProgram());
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            TampilkanUsersControl(new UserLaporan());
        }
        private void LoadProgressDonasi()
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Contoh query untuk mengambil total donasi terkumpul dan target dari tabel program
                    string query = "SELECT COALESCE(SUM(d.nominal), 0) AS Terkumpul, p.target " +
                                   "FROM program p LEFT JOIN donasi d ON p.id_program = d.id_program " +
                                   "WHERE p.id_program = @id GROUP BY p.target";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id_program);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal terkumpul = reader.GetDecimal(0);
                                decimal target = reader.GetDecimal(1);

                                // Hitung persentase
                                int persentase = 0;
                                if (target > 0)
                                {
                                    persentase = (int)((terkumpul / target) * 100);
                                    if (persentase > 100) persentase = 100; // Batasi maksimal 100%
                                }

                                // Set nilai ke ProgressBar di Dashboard
                                progressdonasi.Minimum = 0;
                                progressdonasi.Maximum = 100;
                                progressdonasi.Value = persentase;

                                // Tampilkan teks informasi di Label
                                lblprogress.Text = $"{persentase}% Tercapai (Rp {terkumpul:N0} / Rp {target:N0})";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat progres: " + ex.Message);
                }
            }
        }
        private void progressdonasi_Click(object sender, EventArgs e)
        {
            LoadProgressDonasi();
        }

        private void btnkas_Click(object sender, EventArgs e)
        {
            TampilkanUsersControl(new UserKas());
        }
    }
}
