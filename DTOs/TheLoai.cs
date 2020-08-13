using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class TheLoai
    {
        public string matl { get; set; }
        public string tentl { get; set; }
        public TheLoai()
        {

        }
        public TheLoai(string matl, string tentl)
        {
            this.matl = matl;
            this.tentl = tentl;
        }
    }
}
