using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TTNL;

namespace BUS
{
    public class BUS_HOCVIEN
    {
        DAL_HOCVIEN a;
        public BUS_HOCVIEN() 
        {
            a = new DAL_HOCVIEN();
        }
        public BUS_HOCVIEN(string id, string tenHocVien, int gioitinh, string sdt, string email, string ghichu,string cccd, DateTime ngaysinh, int tinhTrangHocTap, DateTime ngayCapNhatGanNhat)
        {
            a = new DAL_HOCVIEN(id, tenHocVien, gioitinh, sdt, email, ghichu, cccd, ngaysinh, tinhTrangHocTap, ngayCapNhatGanNhat);
        }
        public DataTable getHocVien()
        {
            return a.getHocVien();
        }
        public bool add(string id, string tenHocVien, int gioitinh, string sdt, string email, string ghichu,string cccd, DateTime ngaysinh, int tinhTrangHocTap, DateTime ngayCapNhatGanNhat)
        {
            return a.add(id, tenHocVien, gioitinh, sdt, email, ghichu,cccd, ngaysinh, tinhTrangHocTap, ngayCapNhatGanNhat);
        }
        public bool delete(string id)
        {
            return a.delete(id);
        }
        public bool update(string id, string tenHocVien, int gioitinh, string sdt, string email, string ghichu, string cccd, DateTime ngaysinh, DateTime ngayCapNhatGanNhat)
        {
            return a.update(id, tenHocVien, gioitinh, sdt, email, ghichu, cccd, ngaysinh, ngayCapNhatGanNhat);
        }
        public string ps()
        {
            return a.ps();
        }
        public void deleteAll()
        {
            a.deleteAll();
        }
    }
}
