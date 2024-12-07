using DAL_QLBV;
using ET_QLBV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBV
{
    public class BUS_PhongKham
    {
        DAL_PhongKham dal_phongKham = new DAL_PhongKham();

        public DataTable getDataFromPhongKham()
        {
            return dal_phongKham.getData();
        }

        public bool ThemPhongKham(ET_PhongKham et_PhongKham)
        {
            return dal_phongKham.ThemPhongKham(et_PhongKham);
        }

        public bool XoaPhongKham(ET_PhongKham et_PhongKham)
        {
            return dal_phongKham.XoaPhongKham(et_PhongKham);
        }

        public bool SuaPhongKham(ET_PhongKham et_PhongKham)
        {
            return dal_phongKham.SuaPhongKham(et_PhongKham);
        }
        public DataTable FindData(string key)
        {
            return dal_phongKham.FindData(key);
        }
    }
}
