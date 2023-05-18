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
    public class DAL_HOCVIEN
    {
        DTO_HOCVIEN a;
        SqlCommand cmd;
        public DAL_HOCVIEN() 
        {
            a = new DTO_HOCVIEN();
        }
        public DAL_HOCVIEN(string id, string tenHocVien, int gioitinh, string sdt, string email, string ghichu,string cccd, DateTime ngaysinh, int tinhTrangHocTap, DateTime ngayCapNhatGanNhat)
        {
            a = new DTO_HOCVIEN(id,tenHocVien,gioitinh,sdt,email,ghichu, cccd, ngaysinh,tinhTrangHocTap,ngayCapNhatGanNhat);
        }
        public bool add(string id, string tenHocVien, int gioitinh, string sdt, string email, string ghichu,string cccd, DateTime ngaysinh, int tinhTrangHocTap, DateTime ngayCapNhatGanNhat)
        {
            string sql = "exec PS_InsertHocVien @a , @b , @c , @d , @e , @f , @g , @h , @i , @j ";
            return Connection.actionQuery(sql,new object[] {id,tenHocVien,gioitinh,sdt,email,ghichu,cccd,ngaysinh.ToString(),tinhTrangHocTap,ngayCapNhatGanNhat.ToString()});
        }
        public DataTable getHocVien()
        {
            string sql = "exec PS_getStudent";
            return Connection.selectQuery(sql);
        }
        public bool delete(string id)
        {
            string sql = "delete from hocvien where id ='" + id +"'";
            return Connection.actionQuery(sql);
        }
        public bool update(string id, string tenHocVien, int gioitinh, string sdt, string email, string ghichu, string cccd, DateTime ngaysinh, DateTime ngayCapNhatGanNhat)
        {
            string sql = "exec PS_UpdateHocVien @a , @b , @c , @d , @e , @f , @g , @h , @i ";
            return Connection.actionQuery(sql, new object[] { id, tenHocVien, gioitinh, sdt, email, ghichu, cccd, ngaysinh.ToString(),ngayCapNhatGanNhat.ToString()});
        }
        public void deleteAll()
        {
            string sql = "delete from hocvien";
            Connection.actionQuery(sql);
        }
        public string ps()
        {
            string kq = "";
            string s = "select top 1 id from hocvien order by id desc";
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count > 0)
            {
                kq = dt.Rows[0][0].ToString();
                kq = kq.Substring(kq.Length - 4, 4);
                int stt = int.Parse(kq) + 1;
                if (stt < 10)
                {
                    kq = "HV" + "000" + stt.ToString();
                }
                else if (stt < 100)
                {
                    kq = "HV" + "00" + stt.ToString();
                }
                else if (stt < 1000)
                {
                    kq = "HV" + "0" + stt.ToString();
                }
                else
                {
                    kq = "HV" + stt.ToString();
                }
            }
            else
            {
                kq = "HV" + "0001";
            }
            return kq;
        }
    }
}
