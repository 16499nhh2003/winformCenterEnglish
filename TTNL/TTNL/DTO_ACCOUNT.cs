using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_ACCOUNT
    {
        private int maTaiKhoan;
        private string ghiChu;
        private string tendangnhap;
        private string matKhau;
        private int phanQuyen;
        private string email;
        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        public string Email { get => email; set => email = value; }
        public DTO_ACCOUNT(int maTaiKhoan, string ghiChu, string tendangnhap, string matKhau, int phanQuyen, string email)
        {
            MaTaiKhoan = maTaiKhoan;
            GhiChu = ghiChu;
            Tendangnhap = tendangnhap;
            MatKhau = matKhau;
            PhanQuyen = phanQuyen;
            Email = email;
        }
    }
}
