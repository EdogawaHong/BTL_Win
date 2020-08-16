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
            bool check = false;
            if (Check_Null_DN())
            {
                foreach (NhanVien nv in listNV)
                {
                    /* if (txtMaNV.Text.Equals(nv.sdt) )
                     {
                         MessageBox.Show(nv.sdt);
                     }*/
                    MessageBox.Show(nv.matkhau);

                    if (txtMaNV.Text.Equals(nv.sdt) &&txtMK.Text.Equals(nv.matkhau))
                    {
                        MessageBox.Show("thanh cong");
                    }

                    /*if (nv.sdt.Equals(txtMaNV.Text) && nv.matkhau.Equals(txtMatKhau.Text))*/
                    /*if (txtMaNV.Text == listNV[0].sdt && txtMatKhau.Text == listNV[0].matkhau)
                    {
                        MessageBox.Show("hihi");
                        *//*this.Hide();
                        QuanLyForm form1 = new QuanLyForm(nv.manv, nv.tennv);
                        form1.ShowDialog();
                        this.Close();*//*
                        check = true;
                    }*/

                }
                if(check == false)
                    MessageBox.Show("Vui lòng kiểm tra lại tài khoản!", "Thông báo");
            }
        }
        private bool Check_Null_DN()
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin để đăng nhập!", "Thông báo");
                return false;
            }
            else return true;
        }

        private void DangNhapForm_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = Ma;
            txtMK.Text = MK;

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
