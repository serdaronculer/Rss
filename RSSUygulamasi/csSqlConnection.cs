using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RSSUygulamasi
{
    class csSqlConnection
    {
        private static SqlConnection conn = null;
        public static SqlConnection baglanti()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=RSSDataBase;Integrated Security=True";
            return conn;
        }
    }
}
