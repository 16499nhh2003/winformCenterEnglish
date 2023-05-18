using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_PHONGHOC
    {
        private string id;
        private string tenPhongHoc;
        private string ghiChu;
        private int soChoNgoi;
        public DTO_PHONGHOC() {}

        public DTO_PHONGHOC(string id, string tenPhongHoc, string ghiChu, int soChoNgoi)
        {
            this.id = id;
            this.tenPhongHoc = tenPhongHoc;
            this.ghiChu = ghiChu;
            this.soChoNgoi = soChoNgoi;
        }

        public string Id { get => id; set => id = value; }
        public string TenPhongHoc { get => tenPhongHoc; set => tenPhongHoc = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int SoChoNgoi { get => soChoNgoi; set => soChoNgoi = value; }
    }
}
