using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;

namespace DALs
{
    public class ChiTietHD_DAL
    {
        public DataTable GetTable_CT(string ma)
        {
            DataTable dt;
            string sql = "select TenSach,SoLuong,DonGia,SUM(SoLuong*DonGia) as 'ThanhTien' from CHITIETHOADON inner join SACH on CHITIETHOADON.MaSach=SACH.MaSach where MaHD='" + ma + "' group by TenSach,SoLuong,DonGia";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public bool Them_CT(ChiTietHD ct)
        {
            string sql = "insert into CHITIETHOADON(SoLuong,MaSach,MaHD) values('" + ct.soluong + "', '" + ct.masach + "', '" + ct.mahd + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_CT(ChiTietHD ct)
        {
            string sql = "update CHITIETHOADON set SoLuong='" + ct.soluong + "' where MaSach='" + ct.masach + "' and MaHD='" + ct.mahd + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_CT(string masach, string mahd)
        {
            string sql = "delete from CHITIETHOADON where MaSach='" + masach + "' and MaHD='" + mahd + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_CT_MaHD(string mahd)
        {
            string sql = "delete from CHITIETHOADON where MaHD='" + mahd + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public int TongTien(string ma)
        {
            try
            {
                DataTable dt;
                string sql = "select SUM(SoLuong*DonGia) as 'TongTien' from CHITIETHOADON inner join SACH on CHITIETHOADON.MaSach=SACH.MaSach where MaHD='" + ma + "'";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["TongTien"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
    }
}
