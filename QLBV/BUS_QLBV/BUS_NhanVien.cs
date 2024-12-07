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
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_nhanVien = new DAL_NhanVien();

        public DataTable getDataFromNhanVien()
        {
            return dal_nhanVien.getData();
        }

        public bool ThemNhanVien(ET_NhanVien et_NhanVien)
        {
            return dal_nhanVien.ThemNhanVien(et_NhanVien);
        }

        public bool XoaNhanVien(ET_NhanVien et_NhanVien)
        {
            return dal_nhanVien.XoaNhanVien(et_NhanVien);
        }

        public bool SuaNhanVien(ET_NhanVien et_NhanVien)
        {
            return dal_nhanVien.SuaNhanVien(et_NhanVien);
        }
        public DataTable FindData(string key)
        {
            return dal_nhanVien.FindData(key);
        }
    }
}
