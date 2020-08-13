using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class NhanVien
    {
        public string manv { get; set; }
        public string tennv { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string matkhau { get; set; }

        public NhanVien()
        {

        }
        public NhanVien(string manv, string tennv, string diachi, string sdt, string matkhau)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.diachi = diachi;
            this.sdt = sdt;
            this.matkhau = matkhau;
        }
    }
}
