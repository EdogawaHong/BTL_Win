using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class KhachHang_BUL
    {
        KhachHang_DAL khachHang_DAL = new KhachHang_DAL();
        public DataTable GetTable_KH()
        {
            return khachHang_DAL.GetTable_KH();
        }
        public bool Them_KH(KhachHang kh)
        {
            return khachHang_DAL.Them_KH(kh);
        }
        public bool Sua_KH(KhachHang kh)
        {
            return khachHang_DAL.Sua_KH(kh);
        }
        public bool Xoa_KH(string ma)
        {
            return khachHang_DAL.Xoa_KH(ma);
        }
        public DataTable TimKiem_KH(string ma)
        {
            return khachHang_DAL.TimKiem_KH(ma);
        }
    }
}
