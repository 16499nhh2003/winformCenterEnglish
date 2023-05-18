using DAL;
using System;
using System.Data;
using System.Linq;

namespace BUS
{
    public class BUS_PHONGHOC
    {
        DAL_PHONGHOC a;
        public BUS_PHONGHOC()
        {
            a = new DAL_PHONGHOC();
        }
        public BUS_PHONGHOC(string id, string tenPhongHoc, string ghiChu, int soChoNgoi)
        {
            a = new DAL_PHONGHOC(id, tenPhongHoc, ghiChu, soChoNgoi);
        }
        public string ps()
        {
            return a.ps();
        }
        public DataTable getAll()
        {
            return a.getAll();
        }
        public bool add(string a1, string b, int c)
        {
            return a.add(a1, b, c);
        }
        public bool delete(string a1)
        {
            return a.delete(a1);
        }
        public bool update(string a1, string b, int c)
        {
            return a.update(a1, b, c);
        }

    }
}
