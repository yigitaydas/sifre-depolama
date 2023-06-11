using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace sifre_depolama.CLS
{
    public class SQLConnectionClass
    {
        private static string SQLConnectionString = @"Server = DESKTOP-DQ2875K\SQLEXPRESS ; Database = sifre-depolama; Trusted_Connection = True;";
        private static SqlConnection con = new SqlConnection();
        private static SqlDataAdapter da = new SqlDataAdapter();
        private static SqlCommand com = new SqlCommand();


        public static void Baglanti()
        {
            con = new SqlConnection(SQLConnectionString);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public static object Command(string query)
        {
            object obj;
            com.Connection = con;
            com.CommandText = query;
            obj = com.ExecuteScalar();
            return obj;
        }

        public static DataTable Table(string query)
        {
            DataTable dt = new DataTable();
            com.Connection = con;
            com.CommandText = query;
            da.SelectCommand = com;
            da.Fill(dt);
            return dt;
        }
    }
}