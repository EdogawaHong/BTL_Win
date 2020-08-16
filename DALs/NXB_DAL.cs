using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class NXB_DAL
    {
        public DataTable GetTable_NXB()
        {
            DataTable dt;
            string sql = "select * from NHA_XUAT_BAN";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public bool Them_NXB(NXB nxb)
        {
            string sql = "insert into NHA_XUAT_BAN(TenNXB,DiaChi,Sdt) values(N'" + nxb.tennxb + "', N'" + nxb.diachi + "', '" + nxb.sdt + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_NXB(NXB nxb)
        {
            string sql = "update NHA_XUA_TBAN set TenNXB=N'"+nxb.tennxb+ "',DiaChi=N'" + nxb.diachi + "',Sdt='" + nxb.sdt + "' where MaNXB='" + nxb.manxb + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_NXB(string ma)
        {
            string sql = "delete from NHA_XUAT_BAN where MaNXB='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public DataTable TimKiem_NXB(string ma)
        {
            DataTable dt;
            string sql = "select * from NHA_XUAT_BAN where MaNXB='" + ma + "'";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
    }
}
