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
    public class BUS_SuDungDV
    {
        DAL_SuDungDV dal_suDungDV = new DAL_SuDungDV();

        public DataTable getDataFromSuDungDV()
        {
            return dal_suDungDV.getData();
        }

        public bool ThemSuDungDV(ET_SuDungDV et_SuDungDV)
        {
            return dal_suDungDV.ThemSuDungDV(et_SuDungDV);
        }

        public bool XoaSuDungDV(ET_SuDungDV et_SuDungDV)
        {
            return dal_suDungDV.XoaSuDungDV(et_SuDungDV);
        }

        public bool SuaSuDungDV(ET_SuDungDV et_SuDungDV)
        {
            return dal_suDungDV.SuaSuDungDV(et_SuDungDV);
        }
        public DataTable FindData(string key)
        {
            return dal_suDungDV.FindData(key);
        }
    }
}
