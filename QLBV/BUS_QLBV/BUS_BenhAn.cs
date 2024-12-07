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
    public class BUS_BenhAn
    {
        DAL_BenhAn dal_benhan = new DAL_BenhAn();
        public DataTable getData()
        {
            return dal_benhan.getData();
        }
        public bool ThemBenhAn(ET_BenhAn ba)
        {
            return dal_benhan.ThemBenhAn(ba);
        }
        public bool XoaBenhAn(ET_BenhAn ba)
        {
            return dal_benhan.XoaBenhAn(ba);
        }
        public bool SuaBenhAn(ET_BenhAn ba)
        {
            return dal_benhan.SuaBenhAn(ba);
        }
        public DataTable FindData(string key)
        {
            return dal_benhan.FindData(key);
        }
    }
}
