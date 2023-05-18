using DAL;
using System;
using System.Data;

namespace BUS
{
    public class BUS_LOPHOC
    {
        DAL_LOPHOC a;
        public BUS_LOPHOC()
        {
            a = new DAL_LOPHOC();
        }
        public BUS_LOPHOC(string id, string idGiangVien, string idKhoaHoc, string idNhanVien, string idPhongHoc, string tenLopHoc, string tinhtrang)
        {
            a = new DAL_LOPHOC(id, idGiangVien, idKhoaHoc, idNhanVien, idPhongHoc, tenLopHoc, tinhtrang);
        }
        public DataTable getAllLopHoc()
        {
            return a.getAllLopHoc();
        }

        public DataTable PS_searchbykhoaandlop(string khoa,string lop) {
            return a.PS_searchbykhoaandlop(khoa, lop);
        }
        public DataTable PS_searchLopHocbyKhoaHoc(string khoa)
        {
            return a.PS_searchLopHocbyKhoaHoc(khoa);
        }
        public string ps()
        {
            return a.ps();
        }
    }
}
