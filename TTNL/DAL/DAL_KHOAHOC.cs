using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNL;

namespace DAL
{
    public class DAL_KHOAHOC
    {
        DTO_KHOAHOC a;
        SqlCommand cmd;
        public DAL_KHOAHOC()
        {
            a = new DTO_KHOAHOC();
        }
        public DAL_KHOAHOC(string id, string tenKhoaHoc, string idCaHoc, string idNgayHoc, DateTime ngaybatdau, DateTime ngayketthuc, float hocPhi, int solophoc, int soBuoi)
        {
            a = new DTO_KHOAHOC(id,tenKhoaHoc,idCaHoc,idNgayHoc,ngaybatdau,ngayketthuc,hocPhi,solophoc,soBuoi);
        }
        
        // lấy các khóa học
        public DataTable getAllKhoaHoc()
        {
            string sql = "exec PS_allKhoaHoc";
            return Connection.selectQuery(sql);
        }

        //Lấy ca học
        public DataTable getCaHoc()
        {
            string sql = "select * from cahoc";
            return Connection.selectQuery(sql);
        }

       // lấy ngày học

        public DataTable getNgayHoc()
        {
            string sql = "select * from ngayhoc";
            return Connection.selectQuery(sql);
        }
        // Tạo mã phát sinh tự động khóa học
        public string ps()
        {
            string kq = "";
            string s = "select top 1 id from khoahoc order by id desc";
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count > 0)
            {
                kq = dt.Rows[0][0].ToString();
                kq = kq.Substring(kq.Length - 3, 3);
                int stt = int.Parse(kq) + 1;
                if (stt < 10)
                {
                    kq = "KH" + "00" + stt.ToString();
                }
                else if(stt<100)
                {
                    kq = "KH"  +"0"+ stt.ToString();
                }
                else
                {
                    kq = "KH" +stt.ToString();
                }
            }
            else
            {
                kq = "KH" + "001";
            }
            return kq;
        }

        // thêm khóa học
        public bool add(string id, string tenKhoaHoc, string idCaHoc, string idNgayHoc, DateTime ngaybatdau, DateTime ngayketthuc, float hocPhi, int solophoc, int soBuoi)
        {
            string sql = "exec PS_InsertKhoaHoc @a1 , @a2 , @a3 , @a4 , @a5 , @a6 , @a7 , @a8 , @a9 ";
            return Connection.actionQuery(sql,new object[] { id, tenKhoaHoc, idCaHoc, idNgayHoc, ngaybatdau.ToString(), ngayketthuc.ToString(), hocPhi, solophoc, soBuoi });
        }

        //xóa khóa hcoj
        public bool delete(string id)
        {
            string sql = "delete from khoahoc where id='" + id + "'";
            return Connection.actionQuery(sql);
        }

        // cập nhật khóa học
        public bool update(string id, string tenKhoaHoc, string idCaHoc, string idNgayHoc, DateTime ngaybatdau, DateTime ngayketthuc, float hocPhi, int solophoc, int soBuoi)
        {
            string sql = "exec PS_updateKhoaHoc @a1 , @a2 , @a3 , @a4 , @a5 , @a6 , @a7 , @a8 , @a9 ";
            return Connection.actionQuery(sql, new object[] { id, tenKhoaHoc, idCaHoc, idNgayHoc, ngaybatdau.ToString(), ngayketthuc.ToString(), hocPhi, solophoc, soBuoi });
        }
        
        // tìm kiếm
        public DataTable timkiem(string content)
        {
            string sql = "exec PS_SearchKhoaHoc '" + content +"'";
            return Connection.selectQuery(sql);
        }

        ///
        public DataTable PS_searchnbdbnkt(DateTime a1 , DateTime b)
        {
            string sql = "exec PS_searchnbdbnkt '" + a1.ToString() +"','" + b.ToString() +"'";
            return Connection.selectQuery(sql);
        }
        public DataTable PS_searchHvByKhoaHoc(string khoahoc )
        {
            string sql = "exec PS_searchHvByKhoaHoc '" + khoahoc.ToString() + "'";
            return Connection.selectQuery(sql);
        }
        public DataTable PS_XemKhoaHocHocvienDangky(string s)
        {
            string sql = "exec PS_XemKhoaHocHocvienDangky '" + s + "'"; 
            return Connection.selectQuery(sql); 
        }
        public bool PS_InsertDangKyKhoaHoc(string s1,DateTime s2, string s3)
        {
            string sql = "exec PS_InsertDangKyKhoaHoc @a , @b , @c ";
            return Connection.actionQuery(sql, new object[] { s1, s2.ToString(), s3 });
        }
        public bool deleteChiTietLopHoc(string s,string s2)
        {
            string sql = "delete from chitietlophoc  where idLopHoc = @a and idHocVien = @b ";
            return Connection.actionQuery(sql, new object[] { s, s2.ToString()});
        }
        public DataTable PS_GetPriceByKhoaHoc(string s)
        {
            string sql = "exec PS_GetPriceByKhoaHoc '" + s + "'";
            return Connection.selectQuery(sql);
        }
        public DataTable PS_getNamebyIDHv(string s)
        {
            string sql = "exec PS_getNamebyIDHv '" + s + "'";
            return Connection.selectQuery(sql);
        }
            public DataTable PS_GetNameByIdMaKhoaHoc(string s)
        {
            string sql = "exec PS_GetNameByIdMaKhoaHoc '" + s + "'";
            return Connection.selectQuery(sql);
        }
        public string psphieuthu()
        {
            string kq = "";
            string s = "select top 1 id from phieuthu order by id desc";
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count > 0)
            {
                kq = dt.Rows[0][0].ToString();
                kq = kq.Substring(kq.Length - 4, 4);
                int stt = int.Parse(kq) + 1;
                if (stt < 10)
                {
                    kq = "PT" + "000" + stt.ToString();
                }
                else if (stt < 100)
                {
                    kq = "PT" + "00" + stt.ToString();
                }
                else if(stt < 1000)
                {
                    kq = "PT" + "0" + stt.ToString();
                }
                else
                {
                    kq = "PT" + stt.ToString();
                }
            }
            else
            {
                kq = "PT" + "0001";
            }
            return kq;
        }
        public bool PS_InsertPhieuThu(string q, DateTime w, float e)
        {
            string sql = "exec PS_InsertPhieuThu @a , @b , @c ";
            return Connection.actionQuery(sql,new object[] { q, w.ToString(), e});
        }
        public DataTable PS_ShowDoanhThu(DateTime s,DateTime s1)
        {
            string sql = "exec PS_ShowDoanhThu '" + s.ToString() + "','" + s1.ToString() + "'";
            return Connection.selectQuery(sql);
        }
        public DataTable PS_DOANHTHU(DateTime s, DateTime s1)
        {
            string sql = "exec PS_DOANHTHU '" + s.ToString() + "','" + s1.ToString() + "'";
            return Connection.selectQuery(sql);
        }
    }
}
            