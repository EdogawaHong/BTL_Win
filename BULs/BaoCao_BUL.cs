using DALs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class BaoCao_BUL
    {
        BaoCao_DAL baoCao_DAL = new BaoCao_DAL();
        public DataTable BaoCao_Ngay()
        {
            return baoCao_DAL.BaoCao_Ngay();
        }
        public DataTable BaoCao_Thang()
        {
            return baoCao_DAL.BaoCao_Thang();
        }
        public DataTable BaoCao_Nam()
        {
            return baoCao_DAL.BaoCao_Nam();
        }
        public int BaoCao_TongDT()
        {
            return baoCao_DAL.BaoCao_TongDT();
        }
    }
}
