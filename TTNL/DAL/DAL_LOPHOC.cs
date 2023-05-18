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
    public class DAL_LOPHOC
    {
        DTO_LOPHOC a;
        SqlCommand cmd;
        public DAL_LOPHOC()
        {
            a = new DTO_LOPHOC();
        }
        public DAL_LOPHOC(string id, string idGiangVien, string idKhoaHoc, string idNhanVien, string idPhongHoc, string tenLopHoc, string tinhtrang)
        {
            a = new DTO_LOPHOC(id, idGiangVien,idKhoaHoc,idNhanVien,idPhongHoc,tenLopHoc,tinhtrang);
        }
        public DataTable getAllLopHoc()
        {
            string sql = "select *,lophoc.id as[Mã Lớp Học] from lophoc";
            return Connection.selectQuery(sql);
        }
        public DataTable PS_searchbykhoaandlop(string khoa , string lop)
        {
            string sql = "exec PS_searchbykhoaandlop '" +khoa +"','" +lop +"'" ;
            return Connection.selectQuery(sql);
        }
        public DataTable PS_searchLopHocbyKhoaHoc(string khoa)
        {
            string sql = "exec PS_searchLopHocbyKhoaHoc '" + khoa + "'";
            return Connection.selectQuery(sql);
        }

        public string ps()
        {
            string kq = "";
            string s = "select top 1 id from lophoc order by id desc";
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count > 0)
            {
                kq = dt.Rows[0][0].ToString();
                kq = kq.Substring(kq.Length - 4, 4);
                int stt = int.Parse(kq) + 1;
                if (stt < 10)
                {
                    kq = "LH" + "000" + stt.ToString();
                }
                else if (stt < 100)
                {
                    kq = "LH" + "00" + stt.ToString();
                }
                else if (stt < 1000)
                {
                    kq = "LH" + "0" + stt.ToString();
                }
                else
                {
                    kq = "LH" + stt.ToString();
                }
            }
            else
            {
                kq = "LH" + "0001";
            }
            return kq;
        }
    }
}
