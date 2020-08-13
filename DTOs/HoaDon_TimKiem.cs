using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class HoaDon_TimKiem
    {
        public string mahd { get; set; }
        public string tennv { get; set; }
        public string tenkh { get; set; }
        public DateTime ngaymua { get; set; }
        public HoaDon_TimKiem()
        {

        }
        public HoaDon_TimKiem(string mahd, string tennv, string tenkh, DateTime ngaymua)
        {
            this.mahd = mahd;
            this.tennv = tennv;
            this.tenkh = tenkh;
            this.ngaymua = ngaymua;
        }
    }
}
