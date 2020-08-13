using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class Sach_DAL
    {
        public DataTable GetTable_Sach()
        {
            DataTable dt;
            string sql = "select MaSach,TenSach,TacGia,DonGia,TenTL,TenNXB from SACH inner join THELOAI on SACH.MaTL=THELOAI.MaTL inner join NHAXUATBAN on SACH.MaNXB=NHAXUATBAN.MaNXB";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public bool Them_Sach(Sach s)
        {
            string sql = "insert into SACH(MaSach,TenSach,TacGia,DonGia,MaTL,MaNXB) values('" + s.masach + "', N'" + s.tensach + "', N'" + s.tacgia + "', '" + s.dongia + "', '" + s.matl + "', '" + s.manxb+ "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_Sach(Sach s)
        {
            string sql = "update SACH set TenSach=N'" + s.tensach + "',TacGia= N'" + s.tacgia + "',DonGia='" + s.dongia + "',MaTL='" + s.matl + "',MaNXB='" + s.manxb + "' where MaSach='" + s.masach + "'";
            //update NHAXUATBAN set TenNXB = N'"+nxb.tennxb+ "',DiaChi = N'" + nxb.diachi + "',Sdt = '" + nxb.sdt + "' where MaNXB = '" + nxb.manxb + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_Sach(string ma)
        {
            string sql = "delete from SACH where MaSach='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public DataTable TimKiem_Sach(string ma)
        {
            DataTable dt;
            string sql = "select MaSach,TenSach,TacGia,DonGia,TenTL,TenNXB from SACH inner join THELOAI on SACH.MaTL=THELOAI.MaTL inner join NHAXUATBAN on SACH.MaNXB=NHAXUATBAN.MaNXB where MaSach='" + ma + "'";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
    }
}
