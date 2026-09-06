using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pbo_project
{
    internal class koneksi
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(
            "Data Source=.\\SQLEXPRESS;" +
            "Initial Catalog=db_masjid_cicangkudu;" + // Nama Database
            "Integrated Security=True;" + // Mode Keamanan Windows
            "TrustServerCertificate=True;" // Validasi Sertifikat
             );

            return conn;

        }
    }
}