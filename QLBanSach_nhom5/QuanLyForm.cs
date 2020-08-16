using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using BULs;

namespace QLBanSach_nhom5
{
    public partial class QuanLyForm : Form
    {
        NXB_BUL nxb_BUL = new NXB_BUL();
        TheLoai_BUL theLoai_BUL = new TheLoai_BUL();
        KhachHang_BUL khachHang_BUL = new KhachHang_BUL();
        Sach_BUL sach_BUL = new Sach_BUL();
        HoaDon_BUL hoaDon_BUL = new HoaDon_BUL();
        ChiTietHD_BUL chiTietHD_BUL = new ChiTietHD_BUL();
        BaoCao_BUL baoCao_BUL = new BaoCao_BUL();

        private string TenNV, MaNV;
        public QuanLyForm(string manv, string tennv)
        {
            InitializeComponent();
            Load_Data();
            this.MaNV = manv;
            this.TenNV = tennv;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbMaNV.Text = TenNV;
        }
        public void Load_Data()
        {
            grvDanhSachNXB.DataSource = nxb_BUL.GetTable_NXB();
            grvDanhSachTL.DataSource = theLoai_BUL.GetTable_TL();
            grvDanhSachKH.DataSource = khachHang_BUL.GetTable_KH();
            grvDanhSachS.DataSource = sach_BUL.GetTable_Sach();
            grvDanhSachHD.DataSource = hoaDon_BUL.GetTable_HD();
            grvDT_Ngay.DataSource = baoCao_BUL.BaoCao_Ngay();
            grvDT_Thang.DataSource = baoCao_BUL.BaoCao_Thang();
            grvDT_Nam.DataSource = baoCao_BUL.BaoCao_Nam();

            cbNXB.DataSource = nxb_BUL.GetTable_NXB();
            cbNXB.DisplayMember = "TenNXB";
            cbNXB.ValueMember = "MaNXB";

            cbTheLoai.DataSource = theLoai_BUL.GetTable_TL();
            cbTheLoai.DisplayMember = "TenTL";
            cbTheLoai.ValueMember = "MaTL";

            cbTK_HD.SelectedIndex = 0;

            lbTongDT.Text = baoCao_BUL.BaoCao_TongDT().ToString();
        }

        private void btnHienThiNXB_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            if (Check_null_NXB())
            {
                string ma = txtMaNXB.Text;
                string ten = txtTenNXB.Text;
                string dc = txtDiaChiNXB.Text;
                string sdt = txtSdtNXB.Text;
                if (Check_SDT(sdt))
                {
                    NXB nxb = new NXB(ma, ten, dc, sdt);
                    if (nxb_BUL.Them_NXB(nxb))
                    {
                        Load_Data();
                        Reset_NXB();
                        MessageBox.Show("Thêm mới thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm mới nhà xuất bản này!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không đúng", "Thông báo");
                }
            }
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            if (Check_null_NXB())
            {
                string ma = txtMaNXB.Text;
                string ten = txtTenNXB.Text;
                string dc = txtDiaChiNXB.Text;
                string sdt = txtSdtNXB.Text;
                if (Check_SDT(sdt))
                {
                    NXB nxb = new NXB(ma, ten, dc, sdt);
                    if (nxb_BUL.Sua_NXB(nxb))
                    {
                        Load_Data();
                        Reset_NXB();
                        MessageBox.Show("Sửa thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không sửa được nhà xuất bản này", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không đúng", "Thông báo");
                }
            }
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNXB.Text))
            {
                MessageBox.Show("Bạn chưa chọn nhà xuất bản cần xóa", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà xuất bản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (nxb_BUL.Xoa_NXB(txtMaNXB.Text))
                    {
                        Load_Data();
                        Reset_NXB();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhà xuất bản này", "Thông báo");
                    }
                }
            }
        }

        private void btnTimKiemNXB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNXB.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo");
            }
            else
            {
                if (nxb_BUL.TimKiem_NXB(txtMaNXB.Text).Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhà xuất bản có mã là " + txtMaNXB.Text, "Thông báo");
                }
                else
                {
                    grvDanhSachNXB.DataSource = nxb_BUL.TimKiem_NXB(txtMaNXB.Text);
                }
            }
        }

        private void Cell_Click_NXB(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachNXB.CurrentRow.Index;
            txtMaNXB.Text = grvDanhSachNXB.Rows[i].Cells[0].Value.ToString();
            txtTenNXB.Text = grvDanhSachNXB.Rows[i].Cells[1].Value.ToString();
            txtDiaChiNXB.Text = grvDanhSachNXB.Rows[i].Cells[2].Value.ToString();
            txtSdtNXB.Text = grvDanhSachNXB.Rows[i].Cells[3].Value.ToString();
        }
        private bool Check_null_NXB()
        {
            if (string.IsNullOrEmpty(txtMaNXB.Text) || string.IsNullOrEmpty(txtTenNXB.Text) ||
                string.IsNullOrEmpty(txtDiaChiNXB.Text) || string.IsNullOrEmpty(txtSdtNXB.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return false;
            }
            else return true;
        }
        private bool Check_SDT(string sdt)
        {
            if (sdt.Length != 10) return false;
            else
            {
                try
                {
                    int s = int.Parse(sdt);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        private void Reset_NXB()
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtDiaChiNXB.Clear();
            txtSdtNXB.Clear();
        }

        private void btnHienThiTL_Click(object sender, EventArgs e)
        {
            grvDanhSachTL.DataSource = theLoai_BUL.GetTable_TL();
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            if (Check_Null_TL())
            {
                string ma = txtMaTL.Text;
                string ten = txtTenTL.Text;
                TheLoai tl = new TheLoai(ma, ten);
                if (theLoai_BUL.Them_TL(tl))
                {
                    Load_Data();
                    Reset_TL();
                    MessageBox.Show("Thêm mới thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không thể thêm mới thể loại này!", "Thông báo");
                }
            }
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            if (Check_Null_TL())
            {
                string ma = txtMaTL.Text;
                string ten = txtTenTL.Text;
                TheLoai tl = new TheLoai(ma, ten);
                if (theLoai_BUL.Sua_TL(tl))
                {
                    Load_Data();
                    Reset_TL();
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không sửa được thể loại này!", "Thông báo");
                }
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTL.Text))
            {
                MessageBox.Show("Bạn chưa chọn thể loại cần xóa", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thể loại này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (theLoai_BUL.Xoa_TL(txtMaTL.Text))
                    {
                        Load_Data();
                        Reset_TL();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thể loại này", "Thông báo");
                    }
                }
            }
        }

        private void btnTimKiemTL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTL.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo");
            }
            else
            {
                if (theLoai_BUL.TimKiem_TL(txtMaTL.Text).Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thể loại có mã là " + txtMaTL.Text, "Thông báo");
                }
                else
                {
                    grvDanhSachTL.DataSource = theLoai_BUL.TimKiem_TL(txtMaTL.Text);
                }
            }
        }

        private void Cell_Click_TL(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachTL.CurrentRow.Index;
            txtMaTL.Text = grvDanhSachTL.Rows[i].Cells[0].Value.ToString();
            txtTenTL.Text = grvDanhSachTL.Rows[i].Cells[1].Value.ToString();
        }
        private void Reset_TL()
        {
            txtMaTL.Clear();
            txtTenTL.Clear();
        }
        private bool Check_Null_TL()
        {
            if (string.IsNullOrEmpty(txtMaTL.Text) || string.IsNullOrEmpty(txtTenTL.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return false;
            }
            else return true;
        }

        private void btnHienThiKH_Click(object sender, EventArgs e)
        {
            grvDanhSachKH.DataSource = khachHang_BUL.GetTable_KH();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (Check_null_KH())
            {
                string ma = txtMaKH.Text;
                string ten = txtTenKH.Text;
                string dc = txtDiaChiKH.Text;
                string sdt = txtSdtKH.Text;
                if (Check_SDT(sdt))
                {
                    KhachHang kh = new KhachHang(ma, ten, dc, sdt);
                    if (khachHang_BUL.Them_KH(kh))
                    {
                        Load_Data();
                        Reset_KH();
                        MessageBox.Show("Thêm mới thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm mới khách hàng này!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không đúng", "Thông báo");
                }
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (Check_null_KH())
            {
                string ma = txtMaKH.Text;
                string ten = txtTenKH.Text;
                string dc = txtDiaChiKH.Text;
                string sdt = txtSdtKH.Text;
                if (Check_SDT(sdt))
                {
                    KhachHang kh = new KhachHang(ma, ten, dc, sdt);
                    if (khachHang_BUL.Sua_KH(kh))
                    {
                        Load_Data();
                        Reset_KH();
                        MessageBox.Show("Sửa thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không sửa được khách hàng này", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không đúng", "Thông báo");
                }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Bạn chưa chọn khách hàng cần xóa", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa khách này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (khachHang_BUL.Xoa_KH(txtMaKH.Text))
                    {
                        Load_Data();
                        Reset_KH();
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhà xuất bản này!", "Thông báo");
                    }
                }
            }
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo");
            }
            else
            {
                if (khachHang_BUL.TimKiem_KH(txtMaKH.Text).Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy khách hàng có mã là " + txtMaKH.Text, "Thông báo");
                }
                else
                {
                    grvDanhSachKH.DataSource = khachHang_BUL.TimKiem_KH(txtMaKH.Text);
                }
            }
        }

        private void Cell_Click_KH(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachKH.CurrentRow.Index;
            txtMaKH.Text = grvDanhSachKH.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = grvDanhSachKH.Rows[i].Cells[1].Value.ToString();
            txtDiaChiKH.Text = grvDanhSachKH.Rows[i].Cells[2].Value.ToString();
            txtSdtKH.Text = grvDanhSachKH.Rows[i].Cells[3].Value.ToString();
        }
        private bool Check_null_KH()
        {
            if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtTenKH.Text) ||
                string.IsNullOrEmpty(txtDiaChiKH.Text) || string.IsNullOrEmpty(txtSdtKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return false;
            }
            else return true;
        }
        private void Reset_KH()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChiKH.Clear();
            txtSdtKH.Clear();
        }

        private void btnHienThiS_Click(object sender, EventArgs e)
        {
            grvDanhSachS.DataSource = sach_BUL.GetTable_Sach();
        }

        private void btnThemS_Click(object sender, EventArgs e)
        {
            if (Check_Null_Sach())
            {
                string ma = txtMaS.Text;
                string ten = txtTenS.Text;
                string tg = txtTacGiaS.Text;
                string matl = cbTheLoai.SelectedValue.ToString();
                string manxb = cbNXB.SelectedValue.ToString();
                try
                {
                    int dg = int.Parse(txtDonGiaS.Text);
                    Sach s = new Sach(ma, ten, tg, dg, matl, manxb);
                    if (sach_BUL.Them_Sach(s))
                    {
                        Load_Data();
                        Reset_Sach();
                        MessageBox.Show("Thêm mới thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm mới sách này!", "Thông báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đơn giá có dữ liệu kiểu số nguyên!", "Thông báo");
                }
            }
        }

        private void btnSuaS_Click(object sender, EventArgs e)
        {
            if (Check_Null_Sach())
            {
                string ma = txtMaS.Text;
                string ten = txtTenS.Text;
                string tg = txtTacGiaS.Text;
                string matl = cbTheLoai.SelectedValue.ToString();
                string manxb = cbNXB.SelectedValue.ToString();
                try
                {
                    int dg = int.Parse(txtDonGiaS.Text);
                    Sach s = new Sach(ma, ten, tg, dg, matl, manxb);

                    if (sach_BUL.Sua_Sach(s))
                    {
                        Load_Data();
                        Reset_Sach();
                        MessageBox.Show("Sửa thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa thông tin sách này!", "Thông báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Đơn giá có dữ liệu kiểu số nguyên!", "Thông báo");
                }
            }
        }

        private void btnXoaS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaS.Text))
            {
                MessageBox.Show("Bạn chưa chọn sách cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sách này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (sach_BUL.Xoa_Sach(txtMaS.Text))
                    {
                        Load_Data();
                        Reset_Sach();
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sách này!", "Thông báo");
                    }
                }
            }
        }

        private void btnTimKiemS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaS.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm", "Thông báo");
            }
            else
            {
                if (sach_BUL.TimKiem_Sach(txtMaS.Text).Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách có mã là " + txtMaS.Text, "Thông báo");
                }
                else
                {
                    grvDanhSachS.DataSource = sach_BUL.TimKiem_Sach(txtMaS.Text);
                }
            }
        }

        private void Reset_Sach()
        {
            txtMaS.Clear();
            txtTenS.Clear();
            txtTacGiaS.Clear();
            txtDonGiaS.Clear();
            cbTheLoai.SelectedIndex = 0;
            cbNXB.SelectedIndex = 0;
        }
        private void Cell_Click_Sach(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachS.CurrentRow.Index;
            txtMaS.Text = grvDanhSachS.Rows[i].Cells[0].Value.ToString();
            txtTenS.Text = grvDanhSachS.Rows[i].Cells[1].Value.ToString();
            txtTacGiaS.Text = grvDanhSachS.Rows[i].Cells[2].Value.ToString();
            txtDonGiaS.Text = grvDanhSachS.Rows[i].Cells[3].Value.ToString();
            cbTheLoai.Text = grvDanhSachS.Rows[i].Cells[4].Value.ToString();
            cbNXB.Text = grvDanhSachS.Rows[i].Cells[5].Value.ToString();
        }
        private bool Check_Null_Sach()
        {
            if (string.IsNullOrEmpty(txtMaS.Text) || string.IsNullOrEmpty(txtTenS.Text) ||
                string.IsNullOrEmpty(txtTacGiaS.Text) || string.IsNullOrEmpty(txtDonGiaS.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return false;
            }
            else return true;
        }

        private void btnHienThiHD_Click(object sender, EventArgs e)
        {
            grvDanhSachHD.DataSource = hoaDon_BUL.GetTable_HD();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDonForm hoaDonForm = new HoaDonForm(this.TenNV, this.MaNV);
            hoaDonForm.ShowDialog();
            this.Close();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (chiTietHD_BUL.Xoa_CT_MaHD(txtMaHD.Text))
                    {
                        if (hoaDon_BUL.Xoa_HD(txtMaHD.Text))
                        {
                            Load_Data();
                            Reset_Sach();
                            MessageBox.Show("Xóa thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa hóa đơn này!", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa hóa đơn này!", "Thông báo");
                    }
                }
            }
        }

        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemHD.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo");
            }
            else
            {
                int i = cbTK_HD.SelectedIndex;
                List<HoaDon_TimKiem> listHD = hoaDon_BUL.TimKiem_HD(txtTimKiemHD.Text, i);
                if (listHD.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn phù hợp!", "Thông báo");
                }
                else
                {
                    grvDanhSachHD.DataSource = listHD;
                }
            }
        }

        private void Cell_Click_HD(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachHD.CurrentRow.Index;
            txtMaHD.Text = grvDanhSachHD.Rows[i].Cells[0].Value.ToString();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không!", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                DangNhapForm dangNhap = new DangNhapForm();
                dangNhap.ShowDialog();
                this.Close();
            }
        }

        private void btnXemChiTietHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn để xem!", "Thông báo");
            }
            else
            {
                this.Hide();
                ChiTietHoaDonForm hoaDonForm = new ChiTietHoaDonForm(txtMaHD.Text, this.TenNV, this.MaNV);
                hoaDonForm.ShowDialog();
                this.Close();

            }
        }

    }
}
