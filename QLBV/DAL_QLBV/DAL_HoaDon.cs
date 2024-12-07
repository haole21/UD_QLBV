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
    public class DAL_HoaDon
    {
        private ConnectDB conn = new ConnectDB();
        public DataTable LoadData()
        {
            conn.getConnect();
            DataTable dt = new DataTable();
            dt = conn.LoadData("SP_XUATHOADON");
            conn.getClose();
            return dt;
        }
        public DataTable FindData(string key)
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.FindData("SP_TIMHOADON_BANGTENBN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemHD(ET_HoaDon hoadon)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMHOADON", conn.Conn);
            cmd.CommandText = "SP_THEMHOADON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", hoadon.Id));
            cmd.Parameters.Add(new SqlParameter("@MADV", hoadon.DichVu));
            cmd.Parameters.Add(new SqlParameter("@MABN", hoadon.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("@THUOC", hoadon.Thuoc));
            cmd.Parameters.Add(new SqlParameter("@SL", hoadon.Sl));
            cmd.Parameters.Add(new SqlParameter("@THANHTIEN", hoadon.ThanhTien));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
        public bool XoaHoaDon(ET_HoaDon hoadon)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOAHOADON", conn.Conn);
            cmd.CommandText = "SP_XOAHOADON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", hoadon.Id));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
        public bool SuaHoaDon(ET_HoaDon hoadon)
        {
            bool flat = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUAHOADON", conn.Conn);
            cmd.CommandText = "SP_SUAHOADON";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", hoadon.Id));
            cmd.Parameters.Add(new SqlParameter("@MADV", hoadon.DichVu));
            cmd.Parameters.Add(new SqlParameter("@MABN", hoadon.BenhNhan));
            cmd.Parameters.Add(new SqlParameter("@THUOC", hoadon.Thuoc));
            cmd.Parameters.Add(new SqlParameter("@SL", hoadon.Sl));
            cmd.Parameters.Add(new SqlParameter("@THANHTIEN", hoadon.ThanhTien));
            if (cmd.ExecuteNonQuery() > 0)
            {
                flat = true;
            }
            conn.getClose();
            return flat;
        }
    }
}
