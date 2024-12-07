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
    public class DAL_MuaThuoc
    {
        private ConnectDB conn = new ConnectDB();
        public DataTable LoadData()
        {
            conn.getConnect();
            DataTable dt = new DataTable();
            dt = conn.LoadData("SP_XUATMUATHUOC");
            conn.getClose();
            return dt;
        }
        public DataTable FindData(string key)
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.FindData("SP_TIMMUA_THUOC_BANGTENTHUOC", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemMuaThuoc(ET_MuaThuoc muathuoc)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMMAUTHUOC", conn.Conn);
            cmd.CommandText = "SP_THEMMAUTHUOC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MATHUOC", muathuoc.Thuoc));
            cmd.Parameters.Add(new SqlParameter("@MABN", muathuoc.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("@SL", muathuoc.Sl));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
        public bool XoaMuaThuoc(ET_MuaThuoc muathuoc)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOAMUATHUOC", conn.Conn);
            cmd.CommandText = "SP_XOAMUATHUOC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MATHUOC", muathuoc.Thuoc));
            cmd.Parameters.Add(new SqlParameter("@MABN", muathuoc.BenhNhan));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
        public bool SuaMuaThuoc(ET_MuaThuoc muathuoc)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUAMUATHUOC", conn.Conn);
            cmd.CommandText = "SP_SUAMUATHUOC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MATHUOC", muathuoc.Thuoc));
            cmd.Parameters.Add(new SqlParameter("@MABN", muathuoc.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("@SL", muathuoc.Sl));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
    }
}
