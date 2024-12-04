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
    public class BUS_DieuTri
    {
        DAL_DieuTri dal_DieuTri = new DAL_DieuTri();
        public DataTable getData()
        {
            return dal_DieuTri.getData();
        }
        public bool ThemDieuTri(ET_DieuTri dt)
        {
            return dal_DieuTri.ThemDieuTri(dt);
        }
        public bool XoaDieuTri(ET_DieuTri dt)
        {
            return dal_DieuTri.XoaDieuTri(dt);
        }
      
    }
}
