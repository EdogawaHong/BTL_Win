namespace QLBanSach_nhom5
{
    partial class HoaDonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCapNhatHD = new System.Windows.Forms.Button();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.grvChiTietHD = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.dtNgayMua = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nbSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSach = new System.Windows.Forms.ComboBox();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhatHD
            // 
            this.btnCapNhatHD.Location = new System.Drawing.Point(563, 415);
            this.btnCapNhatHD.Name = "btnCapNhatHD";
            this.btnCapNhatHD.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatHD.TabIndex = 30;
            this.btnCapNhatHD.Text = "Cập nhập";
            this.btnCapNhatHD.UseVisualStyleBackColor = true;
            this.btnCapNhatHD.Click += new System.EventHandler(this.btnCapNhatHD_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(618, 297);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(13, 13);
            this.lbTongTien.TabIndex = 27;
            this.lbTongTien.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tổng tiền:";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(673, 415);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 25;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // grvChiTietHD
            // 
            this.grvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSach,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.grvChiTietHD.Location = new System.Drawing.Point(10, 128);
            this.grvChiTietHD.Name = "grvChiTietHD";
            this.grvChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvChiTietHD.Size = new System.Drawing.Size(656, 150);
            this.grvChiTietHD.TabIndex = 24;
            this.grvChiTietHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Click_CT);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Danh sách sản phẩm";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(123, 15);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày mua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // cbKH
            // 
            this.cbKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Location = new System.Drawing.Point(123, 52);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(190, 21);
            this.cbKH.TabIndex = 31;
            // 
            // dtNgayMua
            // 
            this.dtNgayMua.CustomFormat = "dd.MM.yyyy";
            this.dtNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayMua.Location = new System.Drawing.Point(401, 53);
            this.dtNgayMua.Name = "dtNgayMua";
            this.dtNgayMua.Size = new System.Drawing.Size(173, 20);
            this.dtNgayMua.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Số lượng:";
            // 
            // nbSoLuong
            // 
            this.nbSoLuong.Location = new System.Drawing.Point(70, 313);
            this.nbSoLuong.Name = "nbSoLuong";
            this.nbSoLuong.Size = new System.Drawing.Size(45, 20);
            this.nbSoLuong.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tên sách:";
            // 
            // cbSach
            // 
            this.cbSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSach.FormattingEnabled = true;
            this.cbSach.Location = new System.Drawing.Point(70, 352);
            this.cbSach.Name = "cbSach";
            this.cbSach.Size = new System.Drawing.Size(201, 21);
            this.cbSach.TabIndex = 36;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(636, 50);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(75, 23);
            this.btnThemHD.TabIndex = 37;
            this.btnThemHD.Text = "Thêm mới";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Location = new System.Drawing.Point(307, 350);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(97, 23);
            this.btnThemCT.TabIndex = 38;
            this.btnThemCT.Text = "Thêm sản phẩm";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Location = new System.Drawing.Point(435, 350);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(110, 23);
            this.btnSuaCT.TabIndex = 39;
            this.btnSuaCT.Text = "Cập nhật số lượng";
            this.btnSuaCT.UseVisualStyleBackColor = true;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(576, 350);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(118, 23);
            this.btnXoaCT.TabIndex = 40;
            this.btnXoaCT.Text = "Xóa sản phẩm";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // cbNV
            // 
            this.cbNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(401, 15);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(173, 21);
            this.cbNV.TabIndex = 41;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.btnXoaCT);
            this.Controls.Add(this.btnSuaCT);
            this.Controls.Add(this.btnThemCT);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.cbSach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nbSoLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtNgayMua);
            this.Controls.Add(this.cbKH);
            this.Controls.Add(this.btnCapNhatHD);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.grvChiTietHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HoaDonForm";
            this.Text = "HoaDonForm";
            this.Load += new System.EventHandler(this.HoaDonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhatHD;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView grvChiTietHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKH;
        private System.Windows.Forms.DateTimePicker dtNgayMua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nbSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSach;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}