using DAL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNL;

namespace BUS
{
    public class BUS_GiaoVien
    {
        DAL_GiaoVien dalGv = new DAL_GiaoVien();
        public BUS_GiaoVien() { }
        public string autoCreateId()
        {
            return dalGv.autoCreateIdGiaoVien().ToString();
        }
        public void insertGiaoVien(DTO_GiaoVien gv)
        {
            dalGv.insertData(gv);
        }
        private bool isNumber(string number)
        {
            char[] charNum = number.ToCharArray();
            foreach (char item in charNum)
            {
                if (!Char.IsNumber(item)) return false;
            }
            return true;
        }
        public string errorCheck(DTO_GiaoVien gv)
        {
            if (string.IsNullOrEmpty(gv.TenGiaoVien))
            {
                return "Tên giáo viên không được để trống";
            } else if (string.IsNullOrEmpty(gv.SDT))
            {
                return "Số điện thoại không được để trống";   
            }
            else if (gv.SDT.Length < 8)
            {
                return "Số điện thoại không được dưới 8 chữ số";
            }
            else if (gv.SDT.Length > 11)
            {
                return "Số điện thoại không có trên 11 chữ số";
            }
            else if (!isNumber(gv.SDT))
            {
                return "Số điện thoại chỉ chứa kí tự số";
            }
            else if(string.IsNullOrEmpty(gv.CCCD))
            {
                return "Căn cước công dân không được để trống";
            }
            int years = (int)(((TimeSpan)(DateTime.Now - Convert.ToDateTime(gv.NgaySinh))).Days / 365.25);
            if (years <= 10)
            {
                return "Ngày sinh không hợp lệ";
            }
            else if (gv.GioiTinh != 0 && gv.GioiTinh != 1)
            {
                return "Giới tính không hợp lệ";
            }
            else if (string.IsNullOrEmpty(gv.LoaiGiaoVien))
            {
                return "Chưa có dữ liệu chức vụ";
            }else if (string.IsNullOrEmpty(gv.GiaTheoGio.ToString()))
            {
                return "Giá theo giờ của giáo viên không để trống";
            }else if (!isNumber(gv.GiaTheoGio.ToString()))
            {
                return "Giá theo giờ của giáo viên không có kí tự";
            }
            return "SuccessNoError";
        }
        public List<DTO_LoaiGiangVien> listLGV()
        {
            return dalGv.selectLoaiGiangVien();
        }

        public DataTable dataTableGv()
        {
            return dalGv.selectGiaoVien();
        }
        public string selectTenGv(string ma)
        {
            return dalGv.selectTenLoaiGV(ma);
        }
        public void deleteGv(string ma)
        {
            dalGv.deleteGiaoVien(ma);
        }
        public DTO_GiaoVien selectGV(string id)
        {
            return dalGv.selectGV(id);
        }
        public string getLoaiGV(string id)
        {
            return dalGv.getLoaiGV(id);
        }
        public void updateLoaiGV(DTO_GiaoVien gv)
        {
            dalGv.updateGiaoVien(gv);
        }
        public DataTable searchBMaGv(string maGv)
        {
            return dalGv.searchBMaGv(maGv);
        }

        public DataTable searchBTenGv(string tenGv)
        {
            return dalGv.searchBTenGv(tenGv);
        }
    }
}
