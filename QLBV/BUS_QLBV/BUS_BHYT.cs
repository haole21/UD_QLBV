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
    public class BUS_BHYT
    {
        DAL_BHYT dal_bhyt = new DAL_BHYT();
        public DataTable getData()
        {
            return dal_bhyt.getData();
        }
        public bool ThemBHYT(ET_BHYT bhyt)
        {
            return dal_bhyt.ThemBHYT(bhyt);
        }
        public bool XoaBHYT(ET_BHYT bhyt)
        {
            return dal_bhyt.XoaBHYT(bhyt);
        }
        public bool SuaBHYT(ET_BHYT bhyt)
        {
            return dal_bhyt.SuaBHYT(bhyt);
        }
    }
}
