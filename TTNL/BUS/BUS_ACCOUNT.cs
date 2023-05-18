using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNL;

namespace BUS
{
    public class BUS_ACCOUNT
    {
        DAL_ACCOUNT a;
        public BUS_ACCOUNT() 
        {
            a = new DAL_ACCOUNT();
        }
        public BUS_ACCOUNT(int maTaiKhoan, string ghiChu, string tendangnhap, string matKhau, int phanQuyen, string email)
        {
            a = new DAL_ACCOUNT(maTaiKhoan, ghiChu, tendangnhap, matKhau, phanQuyen, email);
        }
        public List<DTO_ACCOUNT> checkLogin(string us,string pw)
        {
            return a.checkLogin(us, pw);
        }
        public bool add(string username, string pass, string email)
        {
            return a.add(username,pass,email);
        }
        public DataTable getByUserName(string username)
        {
            return a.getByUserName(username);
        }
        public DataTable getPassWord(string pass)
        {
           return a.getPassWord(pass);
        }
        public bool updatePass(string username, string passold, string passnew) {
            return a.updatePass(username, passold, passnew);
        }
    }
}
