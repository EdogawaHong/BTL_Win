﻿using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class KhachHang_DAL
    {
        public DataTable GetTable_KH()
        {
            DataTable dt;
            string sql = "select * from KHACHHANG";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public bool Them_KH(KhachHang kh)
        {
            string sql = "insert into KHACHHANG(MaKH,TenKH,DiaChi,Sdt) values('" + kh.makh + "', N'" + kh.tenkh + "', N'" + kh.diachi + "', '" + kh.sdt + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_KH(KhachHang kh)
        {
            string sql = "update KHACHHANG set TenKH=N'" + kh.tenkh + "',DiaChi=N'" + kh.diachi + "',Sdt='" + kh.sdt + "' where MaKH='" + kh.makh + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_KH(string ma)
        {
            string sql = "delete from KHACHHANG where MaKH='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public DataTable TimKiem_KH(string ma)
        {
            DataTable dt;
            string sql = "select * from KHACHHANG where MaKH='" + ma + "'";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
    }
}
