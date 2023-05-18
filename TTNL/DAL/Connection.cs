using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public static class Connection
    {
        public static SqlConnection conn;
        public static void connect()
        {
            string s = "Data Source=.;Initial Catalog=trungtamngoaingu;Integrated Security=True";
            conn = new SqlConnection(s);
            conn.Open();
        }
        public static bool actionQuery(string sql, object[] parameter = null)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (parameter != null)
            {
                string[] listPara = sql.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }
        public static DataTable selectQuery(string sql)
        {
            connect();  
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}