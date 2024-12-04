using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ET_QLBV;

namespace DAL_QLBV
{
    public class DAL_PKhamBenhNhan
    {
        ConnectDB conn = new ConnectDB();

        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATPKHAMBENHNHAN");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ThemPKhamBenhNhan(ET_PKhamBenhNhan pKhamBenhNhan)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_THEMPKHAMBENHNHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPK", pKhamBenhNhan.PhongKham));
            cmd.Parameters.Add(new SqlParameter("@MABN", pKhamBenhNhan.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("@TGIAN", pKhamBenhNhan.NgayKham1));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool XoaPKhamBenhNhan(ET_PKhamBenhNhan pKhamBenhNhan)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_XOAPKHAMBENHNHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPK", pKhamBenhNhan.PhongKham));
            cmd.Parameters.Add(new SqlParameter("@MABN", pKhamBenhNhan.BenhNhan));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool SuaPKhamBenhNhan(ET_PKhamBenhNhan pKhamBenhNhan)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_SUAPKHAMBENHNHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPK", pKhamBenhNhan.PhongKham));
            cmd.Parameters.Add(new SqlParameter("@MABN", pKhamBenhNhan.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("@TGIAN", pKhamBenhNhan.NgayKham1));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
