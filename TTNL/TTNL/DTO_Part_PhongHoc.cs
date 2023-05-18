using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNL
{
    public class DTO_Part_PhongHoc
    {
        string id;
        string tenPhongHoc;
        public DTO_Part_PhongHoc(string id, string tenPhongHoc)
        {
            this.id = id;
            this.tenPhongHoc = tenPhongHoc;
        }
        public DTO_Part_PhongHoc() { }
        public string Id { get { return this.id; }set { id = value; } }
        public string TenPhongHoc { get { return this.tenPhongHoc; }set { tenPhongHoc = value;} }
    }
}
