using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_LoaiGiangVien
    {
        string ma;
        string ten;
        public DTO_LoaiGiangVien(string ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
        public DTO_LoaiGiangVien() { }
        public string Ma { get { return ma; } set { this.ma = value; } }
        public string Ten { get { return ten;} set { this.ten = value; } }
    }
}
