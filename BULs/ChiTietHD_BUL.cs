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
    public class ChiTietHD_BUL
    {
        ChiTietHD_DAL chiTietHD_DAL = new ChiTietHD_DAL();
        public DataTable GetTable_CT(string ma)
        {
            return chiTietHD_DAL.GetTable_CT(ma);
        }
        public bool Them_CT(ChiTietHD ct)
        {
            return chiTietHD_DAL.Them_CT(ct);
        }
        public bool Sua_CT(ChiTietHD ct)
        {
            return chiTietHD_DAL.Sua_CT(ct);
        }
        public bool Xoa_CT(string masach,string mahd)
        {
            return chiTietHD_DAL.Xoa_CT(masach, mahd);
        }
        public bool Xoa_CT_MaHD(string mahd)
        {
            return chiTietHD_DAL.Xoa_CT_MaHD(mahd);
        }
        public int TongTien(string ma)
        {
            return chiTietHD_DAL.TongTien(ma);
        }
    }
}
