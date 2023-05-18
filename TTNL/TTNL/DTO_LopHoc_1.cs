using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_LopHoc_1
    {
        string idLopHoc;
        string tenLopHoc;
        string idGiangVien;
        string idKhoaHoc;
        string idTroGiang;
        string idPhongHoc;
        string tinhTrang;
        public DTO_LopHoc_1(string idLopHoc, string tenLopHoc, string idGiangVien, string idKhoaHoc, string idTroGiang, string idPhongHoc, string tinhTrang)
        {
            this.idLopHoc = idLopHoc;
            this.tenLopHoc = tenLopHoc;
            this.idGiangVien = idGiangVien;
            this.idKhoaHoc = idKhoaHoc;
            this.idTroGiang = idTroGiang;
            this.idPhongHoc = idPhongHoc;
            this.tinhTrang = tinhTrang;
        }
        public DTO_LopHoc_1() { } 
        public string IdLopHoc { get { return idLopHoc; } set { idLopHoc = value;} }
        public string TenLopHoc { get { return tenLopHoc; } set { tenLopHoc = value;} }
        public string IdGiangVien { get { return idGiangVien; } set { idGiangVien = value;} }
        public string IdKhoaHoc { get { return idKhoaHoc; }
            set
            {
                idKhoaHoc = value;
            } }
        public string IdTroGiang { get { return idTroGiang; }
            set
            {
                idTroGiang = value;
            } }
        public string IdPhongHoc { get { return idPhongHoc; } set { idPhongHoc= value;} }
        public string TinhTrang { get { return tinhTrang; } set { tinhTrang = value; } }
    }
}
