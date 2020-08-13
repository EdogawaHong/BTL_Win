using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ChiTietHD
    {
        public string mahd { get; set; }
        public string masach { get; set; }
        public int soluong { get; set; }
        public ChiTietHD()
        {

        }
        public ChiTietHD(string mahd, string masach, int soluong)
        {
            this.mahd = mahd;
            this.masach = masach;
            this.soluong = soluong;
        }
    }
}
