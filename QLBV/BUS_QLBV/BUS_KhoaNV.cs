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
    public class BUS_KhoaNV
    {
        DAL_KhoaNV dal_khoaNV = new DAL_KhoaNV();
        public DataTable getDataFromKhoaNV()
        {
            return dal_khoaNV.LoadData();
        }
        public bool ThemKhoaNV(ET_KhoaNV et_Khoanv)
        {
            return dal_khoaNV.ThemKhoaNV(et_Khoanv);
        }
        public bool XoaKhoaNV(ET_KhoaNV et_Khoanv)
        {
            return dal_khoaNV.XoaKhoaNV(et_Khoanv);
        }
        public bool SuaKhoaNV(ET_KhoaNV et_Khoanv)
        {
            return dal_khoaNV.SuaKhoaNV(et_Khoanv);
        }
        public DataTable FindData(string key)
        {
            return dal_khoaNV.FindData(key);
        }
    }
}
