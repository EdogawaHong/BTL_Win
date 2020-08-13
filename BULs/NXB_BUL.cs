using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;
using System.Data;

namespace BULs
{
    public class NXB_BUL
    {
        NXB_DAL nxb_DAL = new NXB_DAL();
        public DataTable GetTable_NXB()
        {
            return nxb_DAL.GetTable_NXB();
        }
        public bool Them_NXB(NXB nxb)
        {
            return nxb_DAL.Them_NXB(nxb);
        }
        public bool Sua_NXB(NXB nxb)
        {
            return nxb_DAL.Sua_NXB(nxb);
        }
        public bool Xoa_NXB(string ma)
        {
            return nxb_DAL.Xoa_NXB(ma);
        }
        public DataTable TimKiem_NXB(string ma)
        {
            return nxb_DAL.TimKiem_NXB(ma);
        }
    }
}
