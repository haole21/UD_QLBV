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
    public class DAL_BenhAn
    {
        ConnectDB conn = new ConnectDB();
        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq =  conn.LoadData("SP_XUATBENHAN");
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
                DataTable kq = conn.FindData("SP_TIMBENHAN_BANGTENBN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemBenhAn(ET_BenhAn ba)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMBENHAN", conn.Conn);
            cmd.CommandText = "SP_THEMBENHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABA", ba.Id));
            cmd.Parameters.Add(new SqlParameter("MABN", ba.MaBenhNhan));
            cmd.Parameters.Add(new SqlParameter("KETQUA", ba.KetQua));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool XoaBenhAn(ET_BenhAn ba)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOABENHAN", conn.Conn);
            cmd.CommandText = "SP_XOABENHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABA", ba.Id));        
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool SuaBenhAn(ET_BenhAn ba)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUABENHAN", conn.Conn);
            cmd.CommandText = "SP_SUABENHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABA", ba.Id));
            cmd.Parameters.Add(new SqlParameter("MABN", ba.MaBenhNhan));
            cmd.Parameters.Add(new SqlParameter("KETQUA", ba.KetQua));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
   
    }
}
