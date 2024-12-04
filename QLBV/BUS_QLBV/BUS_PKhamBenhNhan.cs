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
    public class BUS_PKhamBenhNhan
    {
        DAL_PKhamBenhNhan dal_pKhamBenhNhan = new DAL_PKhamBenhNhan();

        public DataTable getDataFromPKhamBenhNhan()
        {
            return dal_pKhamBenhNhan.getData();
        }

        public bool ThemPKhamBenhNhan(ET_PKhamBenhNhan et_PKhamBenhNhan)
        {
            return dal_pKhamBenhNhan.ThemPKhamBenhNhan(et_PKhamBenhNhan);
        }

        public bool XoaPKhamBenhNhan(ET_PKhamBenhNhan et_PKhamBenhNhan)
        {
            return dal_pKhamBenhNhan.XoaPKhamBenhNhan(et_PKhamBenhNhan);
        }

        public bool SuaPKhamBenhNhan(ET_PKhamBenhNhan et_PKhamBenhNhan)
        {
            return dal_pKhamBenhNhan.SuaPKhamBenhNhan(et_PKhamBenhNhan);
        }
    }
}
