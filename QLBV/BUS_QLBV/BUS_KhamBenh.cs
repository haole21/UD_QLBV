﻿using DAL_QLBV;
using ET_QLBV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLBV
{
    public class BUS_KhamBenh
    {
        DAL_KhamBenh dal_KhamBenh = new DAL_KhamBenh();
        public DataTable getDataFromKhamBenh()
        {
            return dal_KhamBenh.LoadData();
        }
        public bool ThemKhamBenh(ET_KhamBenh et_khambenh)
        {
            return dal_KhamBenh.ThemKhamBenh(et_khambenh);
        }
        public bool XoaKhamBenh(ET_KhamBenh et_khambenh)
        {
            return dal_KhamBenh.XoaKhamBenh(et_khambenh);
        }
        public bool SuaKhamBenh(ET_KhamBenh et_khambenh)
        {
            return dal_KhamBenh.SuaKhamBenh(et_khambenh);
        }
    }
}
