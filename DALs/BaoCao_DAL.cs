using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class BaoCao_DAL
    {
        public DataTable BaoCao_Ngay()
        {
            DataTable dt;
            string sql = "select NgayMua,SUM(SoLuong*DonGia) as 'ThanhTien' from CHITIETHOADON inner join SACH on CHITIETHOADON.MaSach = SACH.MaSach " +
                "inner join HOADON on CHITIETHOADON.MaHD = HOADON.MaHD group by NgayMua";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public DataTable BaoCao_Nam()
        {
            DataTable dt;
            string sql = "select Year(NgayMua) as 'Nam',SUM(SoLuong*DonGia) as 'ThanhTien'  " +
                "from CHITIETHOADON inner join SACH on CHITIETHOADON.MaSach = SACH.MaSach " +
                "inner join HOADON on CHITIETHOADON.MaHD = HOADON.MaHD " +
                "group by Year(NgayMua)";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public DataTable BaoCao_Thang()
        {
            DataTable dt;
            string sql = "select CONVERT(NVARCHAR(7),NgayMua,120) as 'ThangNam',SUM(SoLuong*DonGia) as 'ThanhTien' " +
                "from CHITIETHOADON inner join SACH on CHITIETHOADON.MaSach = SACH.MaSach " +
                "inner join HOADON on CHITIETHOADON.MaHD = HOADON.MaHD " +
                "group by CONVERT(NVARCHAR(7), NgayMua, 120)";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public int BaoCao_TongDT()
        {
            try
            {
                DataTable dt;
                string sql = "select SUM(SoLuong*DonGia) as 'TongTien' " +
                 "from CHITIETHOADON inner join SACH on CHITIETHOADON.MaSach = SACH.MaSach";
                dt = XuLy.CreateTable(sql);
                DataRow dr = dt.Rows[0];
                int sum = Convert.ToInt32(dr["TongTien"].ToString());
                return sum;
            }
            catch { return (int)0; }
        }
    }
}
