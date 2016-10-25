namespace TTN_QuanLyKhachSan
{
    partial class frmThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbThuephong = new System.Windows.Forms.GroupBox();
            this.ckcAll = new System.Windows.Forms.CheckBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.cmbKhachhang = new System.Windows.Forms.ComboBox();
            this.cmbMahd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThongtin = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbThuephong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.grbThuephong);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvThongtin);
            this.splitContainer1.Size = new System.Drawing.Size(769, 426);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbThuephong
            // 
            this.grbThuephong.Controls.Add(this.ckcAll);
            this.grbThuephong.Controls.Add(this.txtMaHD);
            this.grbThuephong.Controls.Add(this.txtMaKH);
            this.grbThuephong.Controls.Add(this.button2);
            this.grbThuephong.Controls.Add(this.btnThanhtoan);
            this.grbThuephong.Controls.Add(this.cmbKhachhang);
            this.grbThuephong.Controls.Add(this.cmbMahd);
            this.grbThuephong.Controls.Add(this.label5);
            this.grbThuephong.Controls.Add(this.label4);
            this.grbThuephong.Controls.Add(this.dtpNgayra);
            this.grbThuephong.Controls.Add(this.label1);
            this.grbThuephong.Location = new System.Drawing.Point(3, 0);
            this.grbThuephong.Name = "grbThuephong";
            this.grbThuephong.Size = new System.Drawing.Size(360, 211);
            this.grbThuephong.TabIndex = 1;
            this.grbThuephong.TabStop = false;
            this.grbThuephong.Text = "Thông tin thuê phòng";
            // 
            // ckcAll
            // 
            this.ckcAll.AutoSize = true;
            this.ckcAll.Location = new System.Drawing.Point(135, 145);
            this.ckcAll.Name = "ckcAll";
            this.ckcAll.Size = new System.Drawing.Size(111, 17);
            this.ckcAll.TabIndex = 18;
            this.ckcAll.Text = "Thanh toán tất cả";
            this.ckcAll.UseVisualStyleBackColor = true;
            this.ckcAll.CheckedChanged += new System.EventHandler(this.ckcAll_CheckedChanged);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(278, 71);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(10, 20);
            this.txtMaHD.TabIndex = 17;
            this.txtMaHD.Visible = false;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(278, 33);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(10, 20);
            this.txtMaKH.TabIndex = 16;
            this.txtMaKH.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(91, 173);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhtoan.TabIndex = 3;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // cmbKhachhang
            // 
            this.cmbKhachhang.FormattingEnabled = true;
            this.cmbKhachhang.Location = new System.Drawing.Point(135, 33);
            this.cmbKhachhang.Name = "cmbKhachhang";
            this.cmbKhachhang.Size = new System.Drawing.Size(137, 21);
            this.cmbKhachhang.TabIndex = 0;
            this.cmbKhachhang.SelectedIndexChanged += new System.EventHandler(this.cmbKhachhang_SelectedIndexChanged);
            // 
            // cmbMahd
            // 
            this.cmbMahd.FormattingEnabled = true;
            this.cmbMahd.Location = new System.Drawing.Point(135, 71);
            this.cmbMahd.Name = "cmbMahd";
            this.cmbMahd.Size = new System.Drawing.Size(137, 21);
            this.cmbMahd.TabIndex = 1;
            this.cmbMahd.TextChanged += new System.EventHandler(this.cmbMahd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày trả";
            // 
            // dtpNgayra
            // 
            this.dtpNgayra.Location = new System.Drawing.Point(135, 109);
            this.dtpNgayra.Name = "dtpNgayra";
            this.dtpNgayra.Size = new System.Drawing.Size(137, 20);
            this.dtpNgayra.TabIndex = 2;
            this.dtpNgayra.Value = new System.DateTime(2016, 10, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // dgvThongtin
            // 
            this.dgvThongtin.AllowUserToAddRows = false;
            this.dgvThongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoPhong,
            this.TenPT,
            this.NgayVao,
            this.NgayRa,
            this.TenDV,
            this.ThoiGian,
            this.Gia,
            this.ThanhTien,
            this.TenKH,
            this.MaPhieu,
            this.MaKH,
            this.MaPH,
            this.MaHD,
            this.MaDV,
            this.DonGia});
            this.dgvThongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongtin.Location = new System.Drawing.Point(0, 0);
            this.dgvThongtin.Name = "dgvThongtin";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongtin.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvThongtin.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongtin.Size = new System.Drawing.Size(769, 208);
            this.dgvThongtin.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.STT.Width = 30;
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SoPhong.Width = 80;
            // 
            // TenPT
            // 
            this.TenPT.DataPropertyName = "TenPT";
            this.TenPT.HeaderText = "Phương Thức";
            this.TenPT.Name = "TenPT";
            this.TenPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgayVao
            // 
            this.NgayVao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayVao.DataPropertyName = "NgayVao";
            this.NgayVao.HeaderText = "Ngày thuê";
            this.NgayVao.Name = "NgayVao";
            this.NgayVao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NgayVao.Width = 85;
            // 
            // NgayRa
            // 
            this.NgayRa.DataPropertyName = "NgayRa";
            this.NgayRa.HeaderText = "Ngày Trả";
            this.NgayRa.Name = "NgayRa";
            this.NgayRa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NgayRa.Width = 85;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Dịch vụ";
            this.TenDV.Name = "TenDV";
            this.TenDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian DV";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThoiGian.Width = 85;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá DV";
            this.Gia.Name = "Gia";
            this.Gia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Gia.Width = 80;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenKH.Visible = false;
            this.TenKH.Width = 150;
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "MaPhieu";
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaPhieu.Visible = false;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "MaKH";
            this.MaKH.Name = "MaKH";
            this.MaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaKH.Visible = false;
            // 
            // MaPH
            // 
            this.MaPH.DataPropertyName = "MaPh";
            this.MaPH.HeaderText = "MaPh";
            this.MaPH.Name = "MaPH";
            this.MaPH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaPH.Visible = false;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "MaHD";
            this.MaHD.Name = "MaHD";
            this.MaHD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaHD.Visible = false;
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "MaDV";
            this.MaDV.Name = "MaDV";
            this.MaDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaDV.Visible = false;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DonGia.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TTN_QuanLyKhachSan.Properties.Resources.pic_New_i_636033147493026282;
            this.pictureBox1.Location = new System.Drawing.Point(369, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 426);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThanhToan";
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbThuephong.ResumeLayout(false);
            this.grbThuephong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbThuephong;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.ComboBox cmbKhachhang;
        private System.Windows.Forms.ComboBox cmbMahd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThongtin;
        private System.Windows.Forms.CheckBox ckcAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}