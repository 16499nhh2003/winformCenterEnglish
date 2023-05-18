using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_NhanVien
    {
        private string id;
        private string tenNhanVien;
        private int gioiTinh;
        private string sdt;
        private string ngaySinh;
        private string email;
        private string chucVu;
        private string maAnh;
        public DTO_NhanVien(string tenNhanVien, int gioiTinh, string sdt, string ngaySinh, string email, string chucVu)
        {
            this.tenNhanVien = tenNhanVien;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.ngaySinh = ngaySinh;
            this.email = email;
            this.chucVu = chucVu;
        }

        public DTO_NhanVien() { }
        public string Id { get { return id; } set { id = value; } }
        public string TenNhanVien { get { return tenNhanVien; } set { tenNhanVien = value; } }
        public int GioiTinh { get { return gioiTinh; }set { gioiTinh = value; } }
        public string Sdt { get { return sdt; } set { sdt = value; } }
        public string NgaySinh { get { return ngaySinh; } set { ngaySinh = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string ChucVu { get { return chucVu; } set { chucVu = value; } }

        public string MaAnh { get { return maAnh; } set { maAnh = value; } }    
    }
}
