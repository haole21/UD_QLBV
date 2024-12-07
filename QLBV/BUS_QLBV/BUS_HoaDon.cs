using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBV;
using ET_QLBV;

namespace BUS_QLBV
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dal_hoadon = new DAL_HoaDon();
        public DataTable getDataFromHoaDon()
        {
            return dal_hoadon.LoadData();
        }
        public bool ThemHoaDon(ET_HoaDon et_HoaDon)
        {
            return dal_hoadon.ThemHD(et_HoaDon);
        }
        public bool XoaHoaDon(ET_HoaDon et_HoaDon)
        {
            return dal_hoadon.XoaHoaDon(et_HoaDon);
        }

        public bool SuaHoaDon(ET_HoaDon et_HoaDon)
        {
            return dal_hoadon.SuaHoaDon(et_HoaDon);
        }
        public DataTable FindData(string key)
        {
            return dal_hoadon.FindData(key);
        }
    }
}
