using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNL;

namespace BUS
{
    public class BUS_ChucVu
    {
        DAL_ChucVu dAL_CV = new DAL_ChucVu();

        public List<ChucVu> getListChucVu()
        {
            List<ChucVu> list = dAL_CV.getChucVuList();
            return list;
        }
    }
}
