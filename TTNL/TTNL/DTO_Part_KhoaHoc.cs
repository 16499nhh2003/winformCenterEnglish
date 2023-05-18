using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_Part_KhoaHoc
    {
        string id;
        string tenKhoaHoc;
        public DTO_Part_KhoaHoc(string id, string tenKhoaHoc)
        {
            this.id = id;
            this.tenKhoaHoc = tenKhoaHoc;
        }
        public DTO_Part_KhoaHoc() { }
        public string Id { get { return id; } set { id = value; } }
        public string TenKhoaHoc { get { return tenKhoaHoc; } set { tenKhoaHoc = value; } }
    }

}
