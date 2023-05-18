using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_HOCVIEN
    {
        private string id;
        private string tenHocVien;
        private int gioitinh;
        private string sdt;
        private string email   ;
        private string ghichu;
        private DateTime ngaysinh;
        private int tinhTrangHocTap;
        private DateTime ngayCapNhatGanNhat;
        private string cccd;

        public DTO_HOCVIEN() {}
        public DTO_HOCVIEN(string id, string tenHocVien, int gioitinh, string sdt, string email, string ghichu,string cccd, DateTime ngaysinh, int tinhTrangHocTap, DateTime ngayCapNhatGanNhat)
        {
            this.id = id;
            this.tenHocVien = tenHocVien;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.email = email;
            this.ghichu = ghichu;
            this.ngaysinh = ngaysinh;
            this.tinhTrangHocTap = tinhTrangHocTap;
            this.ngayCapNhatGanNhat = ngayCapNhatGanNhat;
            this.Cccd = cccd;
        }

        public string Id { get => id; set => id = value; }
        public string TenHocVien { get => tenHocVien; set => tenHocVien = value; }
        public int Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public int TinhTrangHocTap { get => tinhTrangHocTap; set => tinhTrangHocTap = value; }
        public DateTime NgayCapNhatGanNhat { get => ngayCapNhatGanNhat; set => ngayCapNhatGanNhat = value; }
        public string Cccd { get => cccd; set => cccd = value; }
    }
}
