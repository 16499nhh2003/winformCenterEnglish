using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_KHOAHOC
    {
        private string id;
        private string tenKhoaHoc;
        private string idCaHoc;
        private string idNgayHoc;
        private DateTime ngaybatdau;
        private DateTime ngayketthuc;
        private float hocPhi;
        private int solophoc;
        private int soBuoi;
        public DTO_KHOAHOC() { }

        public DTO_KHOAHOC(string id, string tenKhoaHoc, string idCaHoc, string idNgayHoc, DateTime ngaybatdau, DateTime ngayketthuc, float hocPhi, int solophoc, int soBuoi)
        {
            this.Id = id;
            this.TenKhoaHoc = tenKhoaHoc;
            this.IdCaHoc = idCaHoc;
            this.IdNgayHoc = idNgayHoc;
            this.Ngaybatdau = ngaybatdau;
            this.Ngayketthuc = ngayketthuc;
            this.HocPhi = hocPhi;
            this.Solophoc = solophoc;
            this.SoBuoi = soBuoi;
        }

        public string Id { get => id; set => id = value; }
        public string TenKhoaHoc { get => tenKhoaHoc; set => tenKhoaHoc = value; }
        public string IdCaHoc { get => idCaHoc; set => idCaHoc = value; }
        public string IdNgayHoc { get => idNgayHoc; set => idNgayHoc = value; }
        public DateTime Ngaybatdau { get => ngaybatdau; set => ngaybatdau = value; }
        public DateTime Ngayketthuc { get => ngayketthuc; set => ngayketthuc = value; }
        public float HocPhi { get => hocPhi; set => hocPhi = value; }
        public int Solophoc { get => solophoc; set => solophoc = value; }
        public int SoBuoi { get => soBuoi; set => soBuoi = value; }
    }
}
