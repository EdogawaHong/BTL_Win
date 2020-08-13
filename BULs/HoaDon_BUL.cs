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
    public class HoaDon_BUL
    {
        HoaDon_DAL hoaDon_DAL = new HoaDon_DAL();
        public DataTable GetTable_HD()
        {
            return hoaDon_DAL.GetTable_HD();
        }
        public bool Them_HD(HoaDon hd)
        {
            return hoaDon_DAL.Them_HD(hd);
        }
        public bool Sua_HD(HoaDon hd)
        {
            return hoaDon_DAL.Sua_HD(hd);
        }
        public bool Xoa_HD(string ma)
        {
            return hoaDon_DAL.Xoa_HD(ma);
        }
        public List<HoaDon_TimKiem> TimKiem_HD(string key,int position)
        {
            return hoaDon_DAL.TimKiem_HD(key, position);
        }
        public HoaDon_TimKiem TimKiem_MaHD(string ma)
        {
            return hoaDon_DAL.TimKiem_MaHD(ma);
        }
    }
}
