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
    public class BUS_PhongDieuTri
    {
        DAL_PhongDieuTri dal_phongDieuTri = new DAL_PhongDieuTri();

        public DataTable getDataFromPhongDieuTri()
        {
            return dal_phongDieuTri.getData();
        }

        public bool ThemPhongDieuTri(ET_PhongDieuTri et_PhongDieuTri)
        {
            return dal_phongDieuTri.ThemPhongDieuTri(et_PhongDieuTri);
        }

        public bool XoaPhongDieuTri(ET_PhongDieuTri et_PhongDieuTri)
        {
            return dal_phongDieuTri.XoaPhongDieuTri(et_PhongDieuTri);
        }

        public bool SuaPhongDieuTri(ET_PhongDieuTri et_PhongDieuTri)
        {
            return dal_phongDieuTri.SuaPhongDieuTri(et_PhongDieuTri);
        }
    }
}
