using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace pbo_project
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = tbemail.Text;
            string password = tbpassword.Text;

            using (SqlConnection conn = koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT role FROM Users WHERE email=@Email AND password=@Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                object role = cmd.ExecuteScalar();

                if (role != null)
                {
                    MessageBox.Show("Login berhasil sebagai " + role.ToString(),
                                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormDashboard dashboard = new FormDashboard();
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Email atau password salah!",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
