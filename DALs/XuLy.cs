using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class XuLy
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static string strConnection = @"Data Source=DESKTOP-0GHR3KF\SQLEXPRESS;Initial Catalog=QLBS;Integrated Security=True";

        public static DataTable CreateTable(String sql)
        {
            conn = new SqlConnection(strConnection);
            conn.Open();
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecuteNonQuery(String sql)
        {
            int res = 0;
            try
            {
                conn = new SqlConnection(strConnection);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                res = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }
            return res;
        }
    }
}
