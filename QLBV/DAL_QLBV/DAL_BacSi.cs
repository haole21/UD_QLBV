using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using ET_QLBV;

namespace DAL_QLBV
{
    
    public class DAL_BacSi
    {
        ConnectDB conn  = new ConnectDB();
        public DataTable getData()
        {
            try
            {
                conn.getConnect();
                DataTable kq = conn.LoadData("SP_XUATBACSI");
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
                DataTable kq = conn.FindData("SP_TIMBACSI_BANGTEN",key);
                conn.getClose();
                return kq;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ThemBacSi(ET_BacSi bs)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_THEMBACSI", conn.Conn);
            cmd.CommandText = "SP_THEMBACSI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABS", bs.Id));
            cmd.Parameters.Add(new SqlParameter("HOBS", bs.Ho));
            cmd.Parameters.Add(new SqlParameter("TENBS", bs.Ten));
            cmd.Parameters.Add(new SqlParameter("CHUCVU", bs.ChucVu));
            cmd.Parameters.Add(new SqlParameter("MaK", bs.Khoa));
            if(cmd.ExecuteNonQuery()>0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool XoaBacSi(ET_BacSi bs)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_XOABACSI", conn.Conn);
            cmd.CommandText = "SP_XOABACSI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABS", bs.Id));          
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
        public bool SuaBacSi(ET_BacSi bs)
        {
            bool flag = false;
            conn.getConnect();
            SqlCommand cmd = new SqlCommand("SP_SUABACSI", conn.Conn);
            cmd.CommandText = "SP_SUABACSI";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("MABS", bs.Id));
            cmd.Parameters.Add(new SqlParameter("HOBS", bs.Ho));
            cmd.Parameters.Add(new SqlParameter("TENBS", bs.Ten));
            cmd.Parameters.Add(new SqlParameter("CHUCVU", bs.ChucVu));
            cmd.Parameters.Add(new SqlParameter("MaK", bs.Khoa));
            if (cmd.ExecuteNonQuery() > 0) flag = true;
            conn.getClose();
            return flag;
        }
    }
}
