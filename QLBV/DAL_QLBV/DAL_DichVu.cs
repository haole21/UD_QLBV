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
    public class DAL_DichVu
    {
        ConnectDB conn = new ConnectDB();
        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATDICHVU");
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
                DataTable kq = conn.FindData("SP_TIMDICHVU_BANGTEN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemDichVu(ET_DichVu dv)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMDV", conn.Conn);
            cmd.CommandText = "SP_THEMDV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MADV", dv.Id));
            cmd.Parameters.Add(new SqlParameter("TENDV", dv.Ten));
            cmd.Parameters.Add(new SqlParameter("GIA", dv.Gia));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool XoaDichVu(ET_DichVu dv)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOADV", conn.Conn);
            cmd.CommandText = "SP_XOADV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MADV", dv.Id));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;

        }
        public bool SuaDichVu(ET_DichVu dv)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUADV", conn.Conn);
            cmd.CommandText = "SP_SUADV";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MADV", dv.Id));
            cmd.Parameters.Add(new SqlParameter("TENDV", dv.Ten));
            cmd.Parameters.Add(new SqlParameter("GIA", dv.Gia));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
