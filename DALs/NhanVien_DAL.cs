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
    public class NhanVien_DAL
    {
        public List<NhanVien> GetList_NV()
        {
            try
            {
                List<NhanVien> listNV = new List<NhanVien>();
                DataTable dt;
                string sql = "select * from NHANVIEN";
                dt = XuLy.CreateTable(sql);

                foreach (var row in dt.AsEnumerable())
                {
                    NhanVien nv = new NhanVien();

                    foreach (var prop in nv.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = nv.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(nv, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    listNV.Add(nv);
                }
                return listNV;
            }
            catch
            {
                return null;
            }
        }

        public bool Them_NV(NhanVien nv)
        {
            string sql = "insert into NHANVIEN(MaNV,TenNV,DiaChi,Sdt,MatKhau) values('" + nv.manv + "', N'" + nv.tennv+ "', N'" + nv.diachi + "', '" + nv.sdt + "', '" + nv.matkhau + "')";
            if (XuLy.ExecuteNonQuery(sql) > 0) return true;
            else return false;
        }
    }
}
