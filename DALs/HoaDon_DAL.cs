using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class HoaDon_DAL
    {
        public DataTable GetTable_HD()
        {
            DataTable dt;
            string sql = "select MaHD,TenNV,TenKH,NgayMua from HOA_DON inner join NHAN_VIEN on HOA_DON.MaNV=NHAN_VIEN.MaNV inner join KHACH_HANG on HOA_DON.MaKH=KHACH_HANG.MaKH";
            dt = XuLy.CreateTable(sql);
            return dt;
        }
        public bool Them_HD(HoaDon hd)
        {
            string sql = "insert into HOA_DON(MaNV,MaKH,NgayMua) values('" + hd.manv + "', '" + hd.makh + "', '" + hd.ngaymua + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Sua_HD(HoaDon hd)
        {
            string sql = "update HOA_DON set MaNV='" + hd.manv + "',MaKH='" + hd.makh + "',NgayMua='" + hd.ngaymua + "' where MaHD='" + hd.mahd + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public bool Xoa_HD(string ma)
        {
            string sql = "delete from HOA_DON where MaHD='" + ma + "'";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
        public List<HoaDon_TimKiem> TimKiem_HD(string key, int position)
        {
            try
            {
                List<HoaDon_TimKiem> listHD = new List<HoaDon_TimKiem>();
                DataTable dt = GetTable_HD();

                foreach (var row in dt.AsEnumerable())
                {
                    HoaDon_TimKiem hd = new HoaDon_TimKiem();

                    foreach (var prop in hd.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = hd.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(hd, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    listHD.Add(hd);
                }
                List<HoaDon_TimKiem> listHD_TK = new List<HoaDon_TimKiem>();
                switch (position)
                {
                    case 0:
                        foreach(HoaDon_TimKiem item in listHD)
                        {
                            if (string.Compare(item.mahd,key,false)==0) listHD_TK.Add(item);
                        }
                        break;
                    case 1:
                        foreach (HoaDon_TimKiem item in listHD)
                        {
                            if (item.tenkh.ToUpper().Contains(key.ToUpper())) listHD_TK.Add(item);
                        }
                        break;
                    case 2:
                        foreach (HoaDon_TimKiem item in listHD)
                        {
                            if (item.tennv.ToUpper().Contains(key.ToUpper())) listHD_TK.Add(item);
                        }
                        break;
                    default:
                        listHD_TK = null;
                        break;
                }
                return listHD_TK;
            }
            catch
            {
                return null;
            }
        }
        public HoaDon_TimKiem TimKiem_MaHD(string ma)
        {
            DataTable dt;
            string sql = "select MaHD,TenNV,TenKH,NgayMua from HOA_DON inner join NHAN_VIEN on HOA_DON.MaNV=NHAN_VIEN.MaNV inner join KHACHHANG on HOADON.MaKH=KHACH_HANG.MaKH where MaHD='" + ma + "'";
            dt = XuLy.CreateTable(sql);
            HoaDon_TimKiem hd = new HoaDon_TimKiem();
            foreach (var row in dt.AsEnumerable())
            {
                foreach (var prop in hd.GetType().GetProperties())
                {
                    try
                    {
                        PropertyInfo propertyInfo = hd.GetType().GetProperty(prop.Name);
                        propertyInfo.SetValue(hd, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            return hd;
        }
    }
}
