using BULs;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanSach_nhom5
{
    public partial class ChiTietHoaDonForm : Form
    {
        ChiTietHD_BUL chiTietHD_BUL = new ChiTietHD_BUL();
        HoaDon_BUL hoaDon_BUL = new HoaDon_BUL();

        public string MaHD, TenNV, MaNV;
        public ChiTietHoaDonForm()
        {
            InitializeComponent();
        }
        public ChiTietHoaDonForm(string mahd,string tennv,string manv)
        {
            InitializeComponent();
            this.MaHD = mahd;
            this.TenNV = tennv;
            this.MaNV = manv;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = MaHD;
            ThongTinHoaDon(MaHD);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ThongTinHoaDon(txtMaHD.Text);
        }

        private void ThongTinHoaDon(string mahd)
        {
            if (string.IsNullOrEmpty(mahd))
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn!", "Thông báo");
            }
            else
            {
                HoaDon_TimKiem hd = hoaDon_BUL.TimKiem_MaHD(mahd);
                if (hd != null)
                {
                    lbTenNV.Text = hd.tennv;
                    lbTenKH.Text = hd.tenkh;
                    lbNgayMua.Text = hd.ngaymua.ToString();
                    grvChiTietHD.DataSource = chiTietHD_BUL.GetTable_CT(mahd);
                    lbTongTien.Text = Convert.ToString(chiTietHD_BUL.TongTien(mahd));
                }
                else
                {
                    MessageBox.Show("Không tồn tại hóa đơn có mã là " + mahd, "Thông báo");
                }
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyForm quanLyForm = new QuanLyForm(this.MaNV, this.TenNV);
            quanLyForm.ShowDialog();
            this.Close();
        }
    }
}
