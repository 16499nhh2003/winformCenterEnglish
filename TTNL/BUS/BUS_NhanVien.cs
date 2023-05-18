using DAL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TTNL;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public BUS_NhanVien() { }
        public DataTable getData()
        {
            return dalNhanVien.getData();
        }

        public DataTable searchData(string ChucVu,string GioiTinh,string Name)
        {
            return dalNhanVien.searchData(ChucVu,GioiTinh,Name);
        }

        public void insertData(DTO_NhanVien nhanvien)
        {
            dalNhanVien.insertData(nhanvien.TenNhanVien, nhanvien.GioiTinh, nhanvien.Sdt, nhanvien.NgaySinh, nhanvien.Email, nhanvien.ChucVu,nhanvien.MaAnh);
        }

        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);

            return regex.IsMatch(email);
        }

        public bool isNumber(string number)
        {
            char[] charNum = number.ToCharArray();
            foreach(char item in charNum)
            {
                if(!Char.IsNumber(item)) return false;
            }
            return true;
        }
        public string checkData(DTO_NhanVien nhanvien)
        {
            if (string.IsNullOrEmpty(nhanvien.TenNhanVien))
            {
                return "Vui lòng thêm tên nhân viên";
            }
            if (string.IsNullOrEmpty(nhanvien.Sdt))
            {
                return "Vui lòng thêm số điện thoại";
            }
            else if(nhanvien.Sdt.Length < 8) {
                return "Số điện thoại không được dưới 8 chữ số";
            }
            else if(nhanvien.Sdt.Length > 11)
            {
                return "Số điện thoại không có trên 11 chữ số";
            }
            else if(!isNumber(nhanvien.Sdt))
            {
                return "Số điện thoại chỉ chứa kí tự số";    
            }
            if (!IsEmail(nhanvien.Email))
            {
                return "Email chưa đúng định dạng";
            }
            int years = (int)(((TimeSpan)(DateTime.Now - Convert.ToDateTime(nhanvien.NgaySinh))).Days / 365.25);
            if(years <= 10)
            {
                return "Ngày sinh không hợp lệ";
            }
            if(nhanvien.GioiTinh != 0 && nhanvien.GioiTinh != 1)
            {
                return "Giới tính không hợp lệ";
            }
            if (string.IsNullOrEmpty(nhanvien.ChucVu))
            {
                return "Chưa có dữ liệu chức vụ";
            }
            return "";
        }

        public string futureId()
        {
            return dalNhanVien.autoCreateIdNhanVien();
        }

        public bool checkMaAnh(string maAnh)
        {
            return dalNhanVien.checkMaAnh(maAnh);
        }
        public void insertAnh(string maAnh,string duongDan,string tenFile)
        {
            dalNhanVien.insertAnh(maAnh,duongDan,tenFile);
        }

        public DTO_NhanVien getDataBaseOnId(string id)
        {
            return dalNhanVien.getDataBaseOnId(id);
        }

        public byte[] getAnh(string maAnh)
        {
            return dalNhanVien.getAnh(maAnh);
        }

        public string getMaAnh(string idNhanVien)
        {
            return dalNhanVien.getMaAnh(idNhanVien); 
        }

        public void deleteData(string id) {
            dalNhanVien.deleteData(id);
        }

        public void updateData(DTO_NhanVien nv)
        {
            dalNhanVien.updateData(nv);
        }

        public string getDuongDan(string maAnh)
        {
            return dalNhanVien.getDuongDan(maAnh);
        }
    }
}
