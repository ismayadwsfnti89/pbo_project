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
    public partial class UserProfile : UserControl
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT id_donasi, nama_donatur, nominal, status, bukti, tanggal FROM donasi";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvdonasi.DataSource = dt;
            }
        }
        private void dgvdonasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO donasi (nama_donatur, nominal, status, bukti, tanggal, created_at, updated_at) " +
                               "VALUES (@nama, @nominal, @status, @bukti, @tanggal, GETDATE(), GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", tbnamadn.Text);
                cmd.Parameters.AddWithValue("@nominal", tbnominal.Text);
                cmd.Parameters.AddWithValue("@status", cbstatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@bukti", pbbukti.Text); // path file dari Upload
                cmd.Parameters.AddWithValue("@tanggal", dateTimePicker1.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Donasi berhasil disimpan!");
                //UserProfile_Load();
            }
        }

        private void btnhps_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM donasi WHERE id_donasi=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@id", txtIdDonasi.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data donasi berhasil dihapus!");
                //LoadData();
            }
        }

        private void btnupbukti_Click(object sender, EventArgs e)
        { 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                btnupbukti.Text = ofd.FileName; // simpan path ke database
                pbbukti.Image = Image.FromFile(ofd.FileName); // preview foto
            }
        }

    }
}


