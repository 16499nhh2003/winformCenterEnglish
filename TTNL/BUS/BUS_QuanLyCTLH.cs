using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_QuanLyCTLH
    {
        DAL_QuanLyCTLH dalQl = new DAL_QuanLyCTLH();
        public DataTable selectData()
        {
            return dalQl.selectData();
        }

        public DataTable selectDataChecked(string idLopHoc)
        {
            return dalQl.selectDataChecked(idLopHoc);
        }
        
        public void deleteData(string idLopHoc)
        {
            dalQl.deleteData(idLopHoc);
        }

        public void insertCTData(string idLopHoc,string idHocVien)
        {
            dalQl.insertCTData(idLopHoc,idHocVien);
        }
    }
}
