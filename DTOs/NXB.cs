using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class NXB
    {
        public string manxb { get; set; }
        public string tennxb { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }

        public NXB()
        {

        }
        public NXB(string manxb, string tennxb, string diachi, string sdt)
        {
            this.manxb = manxb;
            this.tennxb = tennxb;
            this.diachi = diachi;
            this.sdt = sdt;
        }
    }
}
