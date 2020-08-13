using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class KhachHang
    {
        public string makh { get; set; }
        public string tenkh { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }

        public KhachHang()
        {

        }
        public KhachHang(string makh, string tenkh, string diachi, string sdt)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi = diachi;
            this.sdt = sdt;
        }
    }
}
