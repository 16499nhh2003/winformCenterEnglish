using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TTNL;

namespace BUS
{
    public class BUS_KHOAHOC
    {
        DAL_KHOAHOC a;
        public BUS_KHOAHOC()
        {
            a = new DAL_KHOAHOC();
        }
        public BUS_KHOAHOC(string id, string tenKhoaHoc, string idCaHoc, string idNgayHoc, DateTime ngaybatdau, DateTime ngayketthuc, float hocPhi, int solophoc, int soBuoi)
        {
            a = new DAL_KHOAHOC(id, tenKhoaHoc, idCaHoc, idNgayHoc, ngaybatdau, ngayketthuc, hocPhi, solophoc, soBuoi);
        }
        public DataTable getAllKhoaHoc()
        {
            return a.getAllKhoaHoc();
        }

        public DataTable getNgayHoc()
        {
            return a.getNgayHoc();
        }
        public DataTable getCaHoc()
        {
            return a.getCaHoc();
        }

        public string ps()
        {
            return a.ps();
        }
        public bool add(string id, string tenKhoaHoc, string idCaHoc, string idNgayHoc, DateTime ngaybatdau, DateTime ngayketthuc, float hocPhi, int solophoc, int soBuoi)
        {
            return a.add(id, tenKhoaHoc, idCaHoc, idNgayHoc, ngaybatdau, ngayketthuc, hocPhi, solophoc, soBuoi);
        }
        public bool delete(string id)
        {
            return a.delete(id);
        }
        public bool update(string id, string tenKhoaHoc, string idCaHoc, string idNgayHoc, DateTime ngaybatdau, DateTime ngayketthuc, float hocPhi, int solophoc, int soBuoi)
        {
            return a.update(id, tenKhoaHoc, idCaHoc, idNgayHoc, ngaybatdau, ngayketthuc, hocPhi, solophoc, soBuoi);
        }
        public DataTable timkiem(string content)
        {
            return a.timkiem(content);
        }
        public DataTable PS_searchnbdbnkt(DateTime a1, DateTime b)
        {
            return a.PS_searchnbdbnkt(a1, b);
        }
        public DataTable PS_searchHvByKhoaHoc(string a1)
        {
            return a.PS_searchHvByKhoaHoc(a1);
        }
        public DataTable PS_XemKhoaHocHocvienDangky(string s)
        {
            return a.PS_XemKhoaHocHocvienDangky(s);
        }
        public bool PS_InsertDangKyKhoaHoc(string s1, DateTime s2, string s3)
        {
            return a.PS_InsertDangKyKhoaHoc(s1, s2, s3);
        }
        public bool deleteChiTietLopHoc(string s,string s1)
        {
            return a.deleteChiTietLopHoc(s, s1);
        }
        public DataTable PS_GetPriceByKhoaHoc(string s)
        {
            return a.PS_GetPriceByKhoaHoc(s);
        }
        public DataTable PS_getNamebyIDHv(string s)
        {
            return a.PS_getNamebyIDHv(s);
        }
        public DataTable PS_GetNameByIdMaKhoaHoc(string s)
        {
            return a.PS_GetNameByIdMaKhoaHoc(s);
        }
        public string psphieuthu()
        {
            return a.psphieuthu();
        }
        public bool PS_InsertPhieuThu(string q,DateTime w, float e)
        {
            return a.PS_InsertPhieuThu(q,w,e);  
        }
        public DataTable PS_ShowDoanhThu(DateTime s,DateTime s1)
        {
            return a.PS_ShowDoanhThu(s, s1);
        }
        public DataTable PS_DOANHTHU(DateTime s, DateTime s1)
        {
            return a.PS_DOANHTHU(s, s1);
        }
    }
}
