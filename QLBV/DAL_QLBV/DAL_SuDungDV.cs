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
    public class DAL_SuDungDV
    {
        ConnectDB conn = new ConnectDB();

        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATSUDUNGDICHVU");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable FindData(string key)
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.FindData("SP_TIMSUDUNG_DICHVU_BANGTENBN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemSuDungDV(ET_SuDungDV suDungDV)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_THEMSUDUNGDICHVU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADV", suDungDV.DichVu));
            cmd.Parameters.Add(new SqlParameter("@MABN", suDungDV.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("@TGIAN", suDungDV.Ngay));
            cmd.Parameters.Add(new SqlParameter("@SL", suDungDV.Sl));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool XoaSuDungDV(ET_SuDungDV suDungDV)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_XOASUDUNGDICHVU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADV", suDungDV.DichVu));
            cmd.Parameters.Add(new SqlParameter("@MABN", suDungDV.BenhNhan));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool SuaSuDungDV(ET_SuDungDV suDungDV)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_SUASUDUNGDICHVU";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADV", suDungDV.DichVu));
            cmd.Parameters.Add(new SqlParameter("@MABN", suDungDV.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("@TGIAN", suDungDV.Ngay));
            cmd.Parameters.Add(new SqlParameter("@SL", suDungDV.Sl));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
