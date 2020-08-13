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
    public partial class DangNhapForm : Form
    {
        NhanVien_BUL nhanVien_BUL = new NhanVien_BUL();
        public List<NhanVien> listNV = new List<NhanVien>();
        public string Ma, MK;
        public DangNhapForm()
        {
            InitializeComponent();
        }
        public DangNhapForm(string ma,string mk)
        {
            InitializeComponent();
            this.Ma = ma;
            this.MK = mk;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (Check_Null_DN())
            {
                foreach (NhanVien nv in listNV)
                {
                    if (nv.manv.Equals(txtMaNV.Text) && nv.matkhau.Equals(txtMatKhau.Text))
                    {
                        this.Hide();
                        QuanLyForm form1 = new QuanLyForm(nv.manv,nv.tennv);
                        form1.ShowDialog();
                        this.Close();
                    }
                }
                MessageBox.Show("Vui lòng kiểm tra lại tài khoản!", "Thông báo");
            }
        }
        private bool Check_Null_DN()
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin để đăng nhập!", "Thông báo");
                return false;
            }
            else return true;
        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = Ma;
            txtMatKhau.Text = MK;

            listNV = nhanVien_BUL.GetList_NV();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKyForm dangKy = new DangKyForm();
            dangKy.ShowDialog();
            this.Close();
        }
    }
}
