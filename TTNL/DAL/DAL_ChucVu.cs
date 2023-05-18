using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNL;

namespace DAL
{
    public class DAL_ChucVu
    {
        public List<ChucVu> getChucVuList()
        {
            Connection.connect();
            SqlConnection _conn = Connection.conn;
            try
            {
                List<ChucVu> list = new List<ChucVu>();
                string strCmd = "select * from ChucVu";
                SqlCommand cmd = new SqlCommand(strCmd, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new ChucVu() { Id = reader["id"].ToString(), Name = reader["ten"].ToString() });
                }
                return list;
            }
            catch (Exception ex) { throw ex; }
            finally { _conn.Close(); }
        }
    }
}
