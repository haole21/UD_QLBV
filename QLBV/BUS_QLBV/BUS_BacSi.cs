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
    public class BUS_BacSi
    {
        DAL_BacSi dal_bacsi = new DAL_BacSi();
        public DataTable getData()
        {
            return dal_bacsi.getData();
        }
        public bool ThemBacSi(ET_BacSi bs)
        {
            return dal_bacsi.ThemBacSi(bs);
        }
        public bool XoaBacSi(ET_BacSi bs)
        {
            return dal_bacsi.XoaBacSi(bs);
        }
        public bool SuaBacSi(ET_BacSi bs)
        {
            return dal_bacsi.SuaBacSi(bs);
        }
    }
}
