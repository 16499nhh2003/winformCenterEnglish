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
    public class DAL_PHONGHOC
    {
        DTO_PHONGHOC a;
        SqlCommand cmd;
        public DAL_PHONGHOC()
        {
            a = new DTO_PHONGHOC();
        }
        public DAL_PHONGHOC(string id, string tenPhongHoc, string ghiChu, int soChoNgoi)
        {
            a = new DTO_PHONGHOC(id,tenPhongHoc,ghiChu,soChoNgoi);
        }
       
        public string ps()
        {
            string kq = "";
            string s = "select top 1 id from phonghoc order by id desc";
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count > 0)
            {
                kq = dt.Rows[0][0].ToString();
                kq = kq.Substring(kq.Length - 4, 4);
                int stt = int.Parse(kq) + 1;
                if (stt < 10)
                {
                    kq = "P" + "000" + stt.ToString();
                }
                else if (stt < 100)
                {
                    kq = "P" + "00" + stt.ToString();
                }
                else if (stt < 1000)
                {
                    kq = "P" + "0" + stt.ToString();
                }
                else
                {
                    kq = "P" + stt.ToString();
                }
            }
            else
            {
                kq = "P" + "0001";
            }
            return kq;
        }
        public DataTable getAll()
        {
            string sql = "select phonghoc.id,phonghoc.tenPhonghoc,phonghoc.sochongoi from phonghoc";
            return Connection.selectQuery(sql);
        }
        public bool add(string a,string b, int c)
        {
            string sql = "insert into phonghoc(id,tenphonghoc,sochongoi) values( @a , @b , @c ) ";
            return Connection.actionQuery(sql,new object[] {a,b,c});
        }
        public bool delete(string id)
        {
            string sql = "delete from phonghoc where id = '" +id + "'";
            return Connection.actionQuery(sql);
        }
        public bool update(string a1,string b,int c)
        {
            string sql = "update phonghoc set tenPhongHoc = @b , sochongoi = @c where id = @a1 ";
            return Connection.actionQuery(sql, new object[] {b,c,a1});
        }
    }
}
