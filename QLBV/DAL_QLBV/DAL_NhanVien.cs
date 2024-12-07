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
    public class DAL_NhanVien
    {
        ConnectDB conn = new ConnectDB();

        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATNHANVIEN");
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
                DataTable kq = conn.FindData("SP_TIMNHANVIEN_BANGTEN", key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemNhanVien(ET_NhanVien nhanVien)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_THEMNHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", nhanVien.Id));
            cmd.Parameters.Add(new SqlParameter("@HONV", nhanVien.Ho));
            cmd.Parameters.Add(new SqlParameter("@TENNV", nhanVien.Ten));
            cmd.Parameters.Add(new SqlParameter("@SODTH", nhanVien.Dth));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", nhanVien.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@NGAYSINH", nhanVien.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@PHAI", nhanVien.Phai));
            cmd.Parameters.Add(new SqlParameter("@CHUCVU", nhanVien.ChucVu));
            cmd.Parameters.Add(new SqlParameter("@NGAYLV", nhanVien.NgayLV));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool XoaNhanVien(ET_NhanVien nhanVien)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_XOANHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", nhanVien.Id));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }

        public bool SuaNhanVien(ET_NhanVien nhanVien)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("", conn.Conn);
            cmd.CommandText = "SP_SUANHANVIEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", nhanVien.Id));
            cmd.Parameters.Add(new SqlParameter("@HONV", nhanVien.Ho));
            cmd.Parameters.Add(new SqlParameter("@TENNV", nhanVien.Ten));
            cmd.Parameters.Add(new SqlParameter("@SODTH", nhanVien.Dth));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", nhanVien.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@NGAYSINH", nhanVien.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@PHAI", nhanVien.Phai));
            cmd.Parameters.Add(new SqlParameter("@CHUCVU", nhanVien.ChucVu));
            cmd.Parameters.Add(new SqlParameter("@NGAYLV", nhanVien.NgayLV));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
