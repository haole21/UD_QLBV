using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLBV
{
    public class ConnectDB
    {
        SqlConnection conn;

        public SqlConnection Conn { get => conn; }
        public void getConnect()
        {
            conn = new SqlConnection("Data Source=DESKTOP-G20M4PR;Initial Catalog=QLBV;Integrated Security=True;");
            conn.Open();
        }
        public void getClose()
        {
            if (conn.State == ConnectionState.Closed) return; 
            conn.Close();
        }
        public DataTable LoadData(string sql)
        {
            if(sql == null) return null;
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; 
        }
        public DataTable FindData(string sql, string key)
        {
            if (sql == null || key == null) return null;
            
            try
            {

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TEN",key));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
