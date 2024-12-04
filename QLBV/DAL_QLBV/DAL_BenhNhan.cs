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
    public class DAL_BenhNhan
    {
        ConnectDB conn = new ConnectDB();
        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATBENHNHAN");
                conn.getClose();
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ThemBenhNhan(ET_BenhNhan bn)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMBENHNHAN", conn.Conn);
            cmd.CommandText = "SP_THEMBENHNHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABN",bn.Id));
            cmd.Parameters.Add(new SqlParameter("HOBN", bn.Ho));
            cmd.Parameters.Add(new SqlParameter("TENBN", bn.Ten));
            cmd.Parameters.Add(new SqlParameter("SODTH", bn.Dth));
            cmd.Parameters.Add(new SqlParameter("DIACHI",bn.DiaChi));
            cmd.Parameters.Add(new SqlParameter("NGAYSINH", bn.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("PHAI", bn.Phai));
            cmd.Parameters.Add(new SqlParameter("MAPHG", bn.PhongDieuTri));
            if (cmd.ExecuteNonQuery() > 0) flag = true; 
            conn.getClose();
            return flag;
        }
        public bool XoaBenhNhan(ET_BenhNhan bn)
        {
            bool flag = false; 
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOABENHNHAN", conn.Conn);
            cmd.CommandText = "SP_XOABENHNHAN";
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABN", bn.Id));
            if(cmd.ExecuteNonQuery()>0) flag = true;
            conn.getClose();
            return flag;

        }
        public bool SuaBenhNhan(ET_BenhNhan bn)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUABENHNHAN", conn.Conn);
            cmd.CommandText = "SP_SUABENHNHAN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABN", bn.Id));
            cmd.Parameters.Add(new SqlParameter("HOBN", bn.Ho));
            cmd.Parameters.Add(new SqlParameter("TENBN", bn.Ten));
            cmd.Parameters.Add(new SqlParameter("SODTH", bn.Dth));
            cmd.Parameters.Add(new SqlParameter("DIACHI", bn.DiaChi));
            cmd.Parameters.Add(new SqlParameter("NGAYSINH", bn.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("PHAI", bn.Phai));
            cmd.Parameters.Add(new SqlParameter("MAPHG", bn.PhongDieuTri));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
