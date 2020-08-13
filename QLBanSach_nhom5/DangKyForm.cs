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
    public partial class DangKyForm : Form
    {
        NhanVien_BUL nhanVien_BUL = new NhanVien_BUL();
        public DangKyForm()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (check_DangKi())
            {
                NhanVien nv = new NhanVien(
                    txtMaNV.Text,
                    txtTenNV.Text,
                    txtDiaChi.Text,
                    txtSdt.Text,
                    txtMatKhau.Text
                    );
                if (nhanVien_BUL.Them_NV(nv))
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo");
                    this.Hide();
                    DangNhapForm dangNhap = new DangNhapForm(nv.manv,nv.matkhau);
                    dangNhap.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Mã nhân viên này đã tồn tại!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhapForm dangNhap = new DangNhapForm();
            dangNhap.ShowDialog();
            this.Close();
        }
        private bool check_DangKi()
        {
            if(string.IsNullOrEmpty(txtMaNV.Text)||
                string.IsNullOrEmpty(txtTenNV.Text)||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtSdt.Text) ||
                string.IsNullOrEmpty(txtMatKhau.Text) ||
                string.IsNullOrEmpty(txtXacNhan.Text))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin!", "Thông báo");
                return false;
            }
            else
            {
                if (txtSdt.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại không đúng!", "Thông báo");
                    return false;
                }
                else
                {
                    try
                    {
                        int s = int.Parse(txtSdt.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Số điện thoại không đúng!", "Thông báo");
                        return false;
                    }
                }
                if (txtMatKhau.Text.Length != 8)
                {
                    MessageBox.Show("Mật khẩu phải có 8 kí tự!", "Thông báo");
                    return false;
                }
           
                if (txtXacNhan.Text.CompareTo(txtMatKhau.Text) != 0)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo");
                    return false;
                }
                return true;
            }
        }
    }
}
