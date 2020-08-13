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
            string sql = "select * from NHAXUATBAN";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public bool Them_NXB(NXB nxb)
        {
            string sql = "insert into NHAXUATBAN(MaNXB,TenNXB,DiaChi,Sdt) values('" + nxb.manxb + "', N'" + nxb.tennxb + "', N'" + nxb.diachi + "', '" + nxb.sdt + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_NXB(NXB nxb)
        {
            string sql = "update NHAXUATBAN set TenNXB=N'"+nxb.tennxb+ "',DiaChi=N'" + nxb.diachi + "',Sdt='" + nxb.sdt + "' where MaNXB='" + nxb.manxb + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_NXB(string ma)
        {
            string sql = "delete from NHAXUATBAN where MaNXB='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public DataTable TimKiem_NXB(string ma)
        {
            DataTable dt;
            string sql = "select * from NHAXUATBAN where MaNXB='" + ma + "'";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
    }
}
