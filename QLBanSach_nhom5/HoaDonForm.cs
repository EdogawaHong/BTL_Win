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
    public partial class HoaDonForm : Form
    {
        HoaDon_BUL hoaDon_BUL = new HoaDon_BUL();
        ChiTietHD_BUL chiTietHD_BUL = new ChiTietHD_BUL();
        KhachHang_BUL khachHang_BUL = new KhachHang_BUL();
        NhanVien_BUL nhanVien_BUL = new NhanVien_BUL();
        Sach_BUL sach_BUL = new Sach_BUL();

        public string MaHD, TenNV, MaNV;
        public bool check = true;
        public HoaDonForm(string tennv, string manv)
        {
            InitializeComponent();
            this.TenNV = tennv;
            this.MaNV = manv;
            cbNV.Enabled = false;
            btnCapNhatHD.Enabled = false;
            btnThemCT.Enabled = false;
            btnSuaCT.Enabled = false;
            btnXoaCT.Enabled = false;
            dtNgayMua.Enabled = false;
            this.check = true;
        }
        public HoaDonForm(string mahd, string tennv, string manv)
        {
            InitializeComponent();
            this.MaHD = mahd;
            this.TenNV = tennv;
            this.MaNV = manv;
            btnThemHD.Enabled = false;
            txtMaHD.Enabled = false;
            this.check = false;
            
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            ChiTietHD ct = new ChiTietHD(txtMaHD.Text, cbSach.SelectedValue.ToString(), int.Parse(nbSoLuong.Value.ToString()));
            if (chiTietHD_BUL.Them_CT(ct))
            {
                HienThi();
            }
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            ChiTietHD ct = new ChiTietHD(txtMaHD.Text, cbSach.SelectedValue.ToString(), int.Parse(nbSoLuong.Value.ToString()));
            if (chiTietHD_BUL.Sua_CT(ct))
            {
                HienThi();
            }
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (chiTietHD_BUL.Xoa_CT(cbSach.SelectedValue.ToString(), txtMaHD.Text))
            {
                HienThi();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyForm quanLyForm = new QuanLyForm(this.MaNV, this.TenNV);
            quanLyForm.ShowDialog();
            this.Close();
        }

        private void Cell_Click_CT(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvChiTietHD.CurrentRow.Index;
            nbSoLuong.Value = int.Parse(grvChiTietHD.Rows[i].Cells[1].Value.ToString());
            cbSach.Text = grvChiTietHD.Rows[i].Cells[0].Value.ToString();
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            cbNV.DataSource = nhanVien_BUL.GetList_NV();
            cbNV.DisplayMember = "TenNV";
            cbNV.ValueMember = "MaNV";

            cbKH.DataSource = khachHang_BUL.GetTable_KH();
            cbKH.DisplayMember = "TenKH";
            cbKH.ValueMember = "MaKH";

            cbSach.DataSource = sach_BUL.GetTable_Sach();
            cbSach.DisplayMember = "TenSach";
            cbSach.ValueMember = "MaSach";

            if (check)
            {
                cbNV.Text = TenNV;
            }
            else
            {
                HoaDon_TimKiem hd = hoaDon_BUL.TimKiem_MaHD(MaHD);
                txtMaHD.Text = MaHD;
                cbNV.Text = hd.tennv;
                cbKH.Text = hd.tenkh;
                try
                {
                    dtNgayMua.Value = DateTime.Parse(hd.ngaymua.ToString());
                }
                catch { }
                grvChiTietHD.DataSource = chiTietHD_BUL.GetTable_CT(MaHD);
                lbTongTien.Text = Convert.ToString(chiTietHD_BUL.TongTien(MaHD));
            }
        }

        private void btnCapNhatHD_Click(object sender, EventArgs e)
        {
            if (Check_Null())
            {
                string ma = txtMaHD.Text;
                string nv = cbNV.SelectedValue.ToString();
                string kh = cbKH.SelectedValue.ToString();
                DateTime nm = DateTime.Parse(dtNgayMua.Value.ToString());
                HoaDon hd = new HoaDon(ma, nv, kh, nm);
                if (hoaDon_BUL.Sua_HD(hd))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                }
            }
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (Check_Null())
            {
                string ma = txtMaHD.Text;
                string nv = this.MaNV;
                string kh = cbKH.SelectedValue.ToString();
                DateTime nm = DateTime.Parse(dtNgayMua.Value.ToString());
                HoaDon hd = new HoaDon(ma, nv, kh, nm);
                if (hoaDon_BUL.Them_HD(hd))
                {
                    MessageBox.Show("Thêm mới hóa đơn thành công!", "Thông báo");
                    btnCapNhatHD.Enabled = true;
                    btnThemCT.Enabled = true;
                    btnSuaCT.Enabled = true;
                    btnXoaCT.Enabled = true;
                    dtNgayMua.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn này đã tồn tại!", "Thông báo");
                }
            }
            
        }
        private void HienThi()
        {
            grvChiTietHD.DataSource = chiTietHD_BUL.GetTable_CT(txtMaHD.Text);
            lbTongTien.Text = chiTietHD_BUL.TongTien(txtMaHD.Text).ToString();
        }
        private bool Check_Null()
        {
            if (string.IsNullOrEmpty(txtMaHD.Text) || string.IsNullOrEmpty(cbNV.SelectedValue.ToString()) ||
               string.IsNullOrEmpty(cbKH.SelectedValue.ToString()) || string.IsNullOrEmpty(dtNgayMua.Value.ToString()))
            {
                MessageBox.Show("Bạn không được để trống thông tin!", "Thông báo");
                return false;
            }
            else return true;
        }
    }
}
