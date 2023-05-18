using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_GiaoVien
    {
        public DTO_GiaoVien() { }
        string maGiaoVien;
        string tenGiaoVien;
        string ngaySinh;
        string cccd;
        string sdt;
        int gioiTinh;
        string diaChi;
        int giaTheoGio;
        string loaiGiaoVien;
        public DTO_GiaoVien(string maGiaoVien, string tenGiaoVien, string ngaySinh, string cccd, string sdt, int gioiTinh, string diaChi, int giaTheoGio, string loaiGiaoVien)
        {
            this.maGiaoVien = maGiaoVien;
            this.tenGiaoVien = tenGiaoVien;
            this.ngaySinh = ngaySinh;
            this.cccd = cccd;
            this.sdt = sdt;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.giaTheoGio = giaTheoGio;
            this.loaiGiaoVien = loaiGiaoVien;
        }

        public string MaGiaoVien { get { return this.maGiaoVien; } set { this.maGiaoVien = value;} }
        public string TenGiaoVien { get { return this.tenGiaoVien; } set { this.tenGiaoVien = value;} }
        public string NgaySinh { get { return this.ngaySinh; } set { this.ngaySinh = value;} }
        public string CCCD { get { return this.cccd; } set { this.cccd = value;} }
        public string SDT { get { return this.sdt; } set { this.sdt = value;} } 
        public int GioiTinh { get { return this.gioiTinh; } set { this.gioiTinh= value;} }
        public string DiaChi { get { return this.diaChi; } set { this.diaChi = value;} }
        public int GiaTheoGio { get { return this.giaTheoGio; } set { this.giaTheoGio= value;} } 
        public string LoaiGiaoVien { get { return this.loaiGiaoVien; } set { this.loaiGiaoVien= value;} }   
    }
}
