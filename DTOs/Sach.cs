using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Sach
    {
        public string masach { get; set; }
        public string tensach { get; set; }
        public string tacgia { get; set; }
        public int dongia { get; set; }
        public string matl { get; set; }
        public string manxb { get; set; }
        public Sach()
        {

        }
        public Sach(string masach, string tensach, string tacgia, int dongia, string matl, string manxb)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.tacgia = tacgia;
            this.dongia = dongia;
            this.matl = matl;
            this.manxb = manxb;
        }
    }
}
