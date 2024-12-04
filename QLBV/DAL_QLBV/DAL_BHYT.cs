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
    public class DAL_BHYT
    {
        ConnectDB conn = new ConnectDB();
        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATBHYT");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemBHYT(ET_BHYT bhyt)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMBHYT", conn.Conn);
            cmd.CommandText = "SP_THEMBHYT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABHYT", bhyt.Id));
            cmd.Parameters.Add(new SqlParameter("MABN", bhyt.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("NGAYCAP", bhyt.NgayCap));
            cmd.Parameters.Add(new SqlParameter("NGAYHETHAN", bhyt.NgayHetHan));
         
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool XoaBHYT(ET_BHYT bhyt)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOABHYT", conn.Conn);
            cmd.CommandText = "SP_XOABHYT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABHYT", bhyt.Id));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;

        }
        public bool SuaBHYT(ET_BHYT bhyt)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUABHYT", conn.Conn);
            cmd.CommandText = "SP_SUABHYT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABHYT", bhyt.Id));
            cmd.Parameters.Add(new SqlParameter("MABN", bhyt.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("NGAYCAP", bhyt.NgayCap));
            cmd.Parameters.Add(new SqlParameter("NGAYHETHAN", bhyt.NgayHetHan));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
