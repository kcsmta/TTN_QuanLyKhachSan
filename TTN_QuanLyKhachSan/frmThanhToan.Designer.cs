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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongtin = new System.Windows.Forms.DataGridView();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThuephong = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.dtpNgayVao = new System.Windows.Forms.DateTimePicker();
            this.cmbKhachhang = new System.Windows.Forms.ComboBox();
            this.cmbMahd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).BeginInit();
            this.grbThuephong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThongtin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ sử dụng";
            // 
            // dgvThongtin
            // 
            this.dgvThongtin.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvThongtin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.TenDV,
            this.ThoiGian,
            this.Gia});
            this.dgvThongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongtin.Location = new System.Drawing.Point(3, 16);
            this.dgvThongtin.Name = "dgvThongtin";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongtin.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvThongtin.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThongtin.Size = new System.Drawing.Size(771, 150);
            this.dgvThongtin.TabIndex = 1;
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SoPhong.Width = 80;
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Dịch vụ";
            this.TenDV.Name = "TenDV";
            this.TenDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenDV.Width = 150;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian DV";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ThoiGian.Width = 150;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá DV";
            this.Gia.Name = "Gia";
            this.Gia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Gia.Width = 80;
            // 
            // grbThuephong
            // 
            this.grbThuephong.Controls.Add(this.label2);
            this.grbThuephong.Controls.Add(this.btnThanhtoan);
            this.grbThuephong.Controls.Add(this.dtpNgayVao);
            this.grbThuephong.Controls.Add(this.cmbKhachhang);
            this.grbThuephong.Controls.Add(this.cmbMahd);
            this.grbThuephong.Controls.Add(this.label5);
            this.grbThuephong.Controls.Add(this.label4);
            this.grbThuephong.Controls.Add(this.dtpNgayra);
            this.grbThuephong.Controls.Add(this.label1);
            this.grbThuephong.Location = new System.Drawing.Point(12, 12);
            this.grbThuephong.Name = "grbThuephong";
            this.grbThuephong.Size = new System.Drawing.Size(245, 155);
            this.grbThuephong.TabIndex = 1;
            this.grbThuephong.TabStop = false;
            this.grbThuephong.Text = "Thông tin thuê phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày vào";
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(90, 123);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(137, 26);
            this.btnThanhtoan.TabIndex = 3;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // dtpNgayVao
            // 
            this.dtpNgayVao.Enabled = false;
            this.dtpNgayVao.Location = new System.Drawing.Point(90, 73);
            this.dtpNgayVao.Name = "dtpNgayVao";
            this.dtpNgayVao.Size = new System.Drawing.Size(137, 20);
            this.dtpNgayVao.TabIndex = 18;
            this.dtpNgayVao.Value = new System.DateTime(2016, 10, 12, 0, 0, 0, 0);
            // 
            // cmbKhachhang
            // 
            this.cmbKhachhang.FormattingEnabled = true;
            this.cmbKhachhang.Location = new System.Drawing.Point(90, 19);
            this.cmbKhachhang.Name = "cmbKhachhang";
            this.cmbKhachhang.Size = new System.Drawing.Size(137, 21);
            this.cmbKhachhang.TabIndex = 0;
            this.cmbKhachhang.SelectedIndexChanged += new System.EventHandler(this.cmbKhachhang_SelectedIndexChanged);
            // 
            // cmbMahd
            // 
            this.cmbMahd.FormattingEnabled = true;
            this.cmbMahd.Location = new System.Drawing.Point(90, 46);
            this.cmbMahd.Name = "cmbMahd";
            this.cmbMahd.Size = new System.Drawing.Size(137, 21);
            this.cmbMahd.TabIndex = 1;
            this.cmbMahd.SelectedIndexChanged += new System.EventHandler(this.cmbMahd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày trả";
            // 
            // dtpNgayra
            // 
            this.dtpNgayra.Location = new System.Drawing.Point(90, 99);
            this.dtpNgayra.Name = "dtpNgayra";
            this.dtpNgayra.Size = new System.Drawing.Size(137, 20);
            this.dtpNgayra.TabIndex = 2;
            this.dtpNgayra.Value = new System.DateTime(2016, 10, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(777, 346);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TTN_QuanLyKhachSan.Properties.Resources.pic_New_i_636033147493026282;
            this.pictureBox1.Location = new System.Drawing.Point(263, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 346);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThanhToan";
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).EndInit();
            this.grbThuephong.ResumeLayout(false);
            this.grbThuephong.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongtin;
        private System.Windows.Forms.GroupBox grbThuephong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayVao;
        private System.Windows.Forms.ComboBox cmbKhachhang;
        private System.Windows.Forms.ComboBox cmbMahd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}