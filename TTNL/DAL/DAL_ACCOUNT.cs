using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TTNL;

namespace DAL
{
    public class DAL_ACCOUNT
    {
        DTO_ACCOUNT a;
        SqlCommand cmd;
        public DAL_ACCOUNT() { }
        public DAL_ACCOUNT(int maTaiKhoan, string ghiChu, string tendangnhap, string matKhau, int phanQuyen,string email)
        {
            a = new DTO_ACCOUNT(maTaiKhoan,ghiChu,tendangnhap,matKhau,phanQuyen,email);
        }
        public List<DTO_ACCOUNT> checkLogin(string us,string pw)
        {
            string sql = "EXEC PS_CheckLogin '" + us + "' , '" + pw +"'";
            List<DTO_ACCOUNT> accs = new List<DTO_ACCOUNT>();
            Connection.connect();
            using (SqlConnection sqlConnection = Connection.conn)
            {
                cmd = new SqlCommand(sql, sqlConnection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    accs.Add(new DTO_ACCOUNT(reader.GetInt32(0),"", reader.GetString(2), reader.GetString(3), reader.GetInt32(4),""));
                }
                sqlConnection.Close();
            }
            return accs;
        }
        public bool add(string username, string pass, string email)
        {
            string sql = "exec PS_Register @a , @b , @c ";
            return Connection.actionQuery(sql,new object[] {username,pass,email});
        }
        public DataTable getByUserName(string username)
        {
            string sql = "select * from account where tenDangNhap ='" +username +"'" ;
            return Connection.selectQuery(sql);
        }
        public DataTable getPassWord(string email)
        {
            string sql = "select * from account where email ='" + email +"'" ;  
            return Connection.selectQuery(sql);
        }
        // Doi mat khau
        public bool updatePass(string username,string passold,string passnew)
        {
            string sql = "exec PS_Update @a , @b , @c ";
            return Connection.actionQuery(sql,new object[] {username, passold, passnew });
        }
    }
}
