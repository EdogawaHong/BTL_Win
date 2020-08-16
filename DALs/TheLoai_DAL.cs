using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace DALs
{
    public class TheLoai_DAL
    {
        public DataTable GetTable_TL()
        {
            DataTable dt;
            string sql = "select * from THE_LOAI";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public bool Them_TL(TheLoai tl)
        {
            string sql = "insert into THE_LOAI(TenTL) values(N'" + tl.tentl + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_TL(TheLoai tl)
        {
            string sql = "update THE_LOAI set TenTL=N'" + tl.tentl + "' where MaTL='" + tl.matl + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_TL(string ma)
        {
            string sql = "delete from THE_LOAI where MaTL='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public DataTable TimKiem_TL(string ma)
        {
            DataTable dt;
            string sql = "select * from THE_LOAI where MaTL='" + ma + "'";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
    }
}
