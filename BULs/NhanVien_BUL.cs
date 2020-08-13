using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class NhanVien_BUL
    {
        NhanVien_DAL nhanVien_DAL = new NhanVien_DAL();
        public List<NhanVien> GetList_NV()
        {
            return nhanVien_DAL.GetList_NV();
        }
        public bool Them_NV(NhanVien nv)
        {
            return nhanVien_DAL.Them_NV(nv);
        }
    }
}
