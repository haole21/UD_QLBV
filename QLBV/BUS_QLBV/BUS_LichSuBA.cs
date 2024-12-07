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
    public class BUS_LichSuBA
    {
        DAL_LichSuBA dal_lichsu = new DAL_LichSuBA();
        public DataTable getDataFromKhoa()
        {
            return dal_lichsu.LoadData();
        }
        public bool ThemLichSu(ET_LichSuBA et_lichsu)
        {
            return dal_lichsu.ThemLichSuBenhAn(et_lichsu);
        }
        public bool XoaLichSu(ET_LichSuBA et_lichsu)
        {
            return dal_lichsu.XoaLichSuBenhAn(et_lichsu);
        }
        public bool SuaLichSu(ET_LichSuBA et_lichsu)
        {
            return dal_lichsu.SuaLichSuBenhAn(et_lichsu);
        }
        public DataTable FindData(string key)
        {
            return dal_lichsu.FindData(key);
        }
    }
}
