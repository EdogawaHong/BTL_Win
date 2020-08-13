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
    public class Sach_BUL
    {
        Sach_DAL sach_DAL = new Sach_DAL();
        public DataTable GetTable_Sach()
        {
            return sach_DAL.GetTable_Sach();
        }
        public bool Them_Sach(Sach s)
        {
            return sach_DAL.Them_Sach(s);
        }
        public bool Sua_Sach(Sach s)
        {
            return sach_DAL.Sua_Sach(s);
        }
        public bool Xoa_Sach(string ma)
        {
            return sach_DAL.Xoa_Sach(ma);
        }
        public DataTable TimKiem_Sach(string ma)
        {
            return sach_DAL.TimKiem_Sach(ma);
        }
    }
}
