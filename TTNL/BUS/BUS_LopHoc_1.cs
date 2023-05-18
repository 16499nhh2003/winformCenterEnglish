using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNL;

namespace BUS
{
    public class BUS_LopHoc_1
    {
        DAL_LopHoc_1 dalLh = new DAL_LopHoc_1();
        public BUS_LopHoc_1() { }
        public List<DTO_Part_KhoaHoc> getListKhoaHoc()
        {
            return dalLh.selectKhoaHoc();
        }
        public List<DTO_Part_PhongHoc> getListPhongHoc()
        {
            return dalLh.selectPhongHoc();
        }

        public string idLopHoc()
        {
            return dalLh.autoCreateId();
        }

        public void insertData(DTO_LopHoc_1 lopHoc)
        {
            dalLh.insertData(lopHoc);
        }
        public string errorCheck(DTO_LopHoc_1 lopHoc)
        {
            if (string.IsNullOrEmpty(lopHoc.IdLopHoc))
                return "Mã lớp học chưa được cập nhật";
            else if (string.IsNullOrEmpty(lopHoc.TenLopHoc))
                return "Tên lớp học đang trống";
            else if (string.IsNullOrEmpty(lopHoc.IdGiangVien))
                return "Mã giảng viên đang trống";
            else if (string.IsNullOrEmpty(lopHoc.IdKhoaHoc))
                return "Không có dữ liệu khóa học";
            else if (string.IsNullOrEmpty(lopHoc.IdPhongHoc))
                return "Không có dữ liệu phòng học";
            return "Success";
        }
        public DataTable selectData()
        {
            return dalLh.selectData();
        }

        public void deleteData(string id)
        {
            dalLh.deleteData(id);
        }

        public DTO_LopHoc_1 selectLop(string id)
        {
            return dalLh.selectLop(id);
        }


    }
}
