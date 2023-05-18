using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_LOPHOC
    {
        private string id;
        private string idGiangVien;
        private string idKhoaHoc;
        private string idNhanVien;
        private string idPhongHoc;
        private string tenLopHoc;
        private string tinhtrang;

        public DTO_LOPHOC() { } 
        public DTO_LOPHOC(string id, string idGiangVien, string idKhoaHoc, string idNhanVien, string idPhongHoc, string tenLopHoc, string tinhtrang)
        {
            this.Id = id;
            this.IdGiangVien = idGiangVien;
            this.IdKhoaHoc = idKhoaHoc;
            this.IdNhanVien = idNhanVien;
            this.IdPhongHoc = idPhongHoc;
            this.TenLopHoc = tenLopHoc;
            this.Tinhtrang = tinhtrang;
        }

        public string Id { get => id; set => id = value; }
        public string IdGiangVien { get => idGiangVien; set => idGiangVien = value; }
        public string IdKhoaHoc { get => idKhoaHoc; set => idKhoaHoc = value; }
        public string IdNhanVien { get => idNhanVien; set => idNhanVien = value; }
        public string IdPhongHoc { get => idPhongHoc; set => idPhongHoc = value; }
        public string TenLopHoc { get => tenLopHoc; set => tenLopHoc = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
    }
}
