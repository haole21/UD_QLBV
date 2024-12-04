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
    public class DAL_DieuTri
    {
        ConnectDB conn = new ConnectDB();
        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATDIEUTRI");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemDieuTri(ET_DieuTri dt)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMDIEUTRI", conn.Conn);
            cmd.CommandText = "SP_THEMDIEUTRI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MAK", dt.MaKhoa));
            cmd.Parameters.Add(new SqlParameter("MABN", dt.MaBenhNhan));         
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool XoaDieuTri(ET_DieuTri dt)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOADIEUTRI", conn.Conn);
            cmd.CommandText = "SP_XOADIEUTRI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MAK", dt.MaKhoa));
            cmd.Parameters.Add(new SqlParameter("MABN", dt.MaBenhNhan));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;

        }
       
    }
}
