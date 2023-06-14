namespace QuanLyPhongMachTu.UserControls
{
    partial class NhapThuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXong = new Guna.UI2.WinForms.Guna2Button();
            this.txt_DonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.nup_SoLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.txt_SoPhieuNhapThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_SoLuongNhap = new System.Windows.Forms.Label();
            this.lbl_TenThuoc = new System.Windows.Forms.Label();
            this.lbl_DonGiaNhap = new System.Windows.Forms.Label();
            this.lbl_NgayLap = new System.Windows.Forms.Label();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_SoPhieuNhapThuoc = new System.Windows.Forms.Label();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.gbx_PhieNnhapThuoc = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Phieunhapthuoc = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.cboTenThuocBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CapNhatThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoaThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.cbbPhieuNhap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_SoPhieuNhap = new System.Windows.Forms.DataGridView();
            this.label_tongtien = new System.Windows.Forms.Label();
            this.lb_Tongtien = new System.Windows.Forms.Label();
            this.lbb_TONGTIEN = new System.Windows.Forms.Label();
            this.btn_HT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nup_SoLuongNhap)).BeginInit();
            this.gbx_PhieNnhapThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXong
            // 
            this.btnXong.BorderThickness = 1;
            this.btnXong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXong.FillColor = System.Drawing.Color.LightGray;
            this.btnXong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXong.ForeColor = System.Drawing.Color.Black;
            this.btnXong.Location = new System.Drawing.Point(640, 307);
            this.btnXong.Margin = new System.Windows.Forms.Padding(4);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(134, 68);
            this.btnXong.TabIndex = 17;
            this.btnXong.Text = "Xong";
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DonGia.DefaultText = "";
            this.txt_DonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DonGia.Location = new System.Drawing.Point(242, 251);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.PasswordChar = '\0';
            this.txt_DonGia.PlaceholderText = "";
            this.txt_DonGia.SelectedText = "";
            this.txt_DonGia.Size = new System.Drawing.Size(275, 36);
            this.txt_DonGia.TabIndex = 13;
            // 
            // nup_SoLuongNhap
            // 
            this.nup_SoLuongNhap.Location = new System.Drawing.Point(242, 187);
            this.nup_SoLuongNhap.Margin = new System.Windows.Forms.Padding(4);
            this.nup_SoLuongNhap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_SoLuongNhap.Name = "nup_SoLuongNhap";
            this.nup_SoLuongNhap.Size = new System.Drawing.Size(275, 29);
            this.nup_SoLuongNhap.TabIndex = 12;
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLap.Location = new System.Drawing.Point(296, 188);
            this.dtp_NgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(292, 32);
            this.dtp_NgayLap.TabIndex = 9;
            // 
            // txt_SoPhieuNhapThuoc
            // 
            this.txt_SoPhieuNhapThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoPhieuNhapThuoc.DefaultText = "";
            this.txt_SoPhieuNhapThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoPhieuNhapThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoPhieuNhapThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoPhieuNhapThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoPhieuNhapThuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoPhieuNhapThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoPhieuNhapThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoPhieuNhapThuoc.Location = new System.Drawing.Point(295, 89);
            this.txt_SoPhieuNhapThuoc.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_SoPhieuNhapThuoc.Name = "txt_SoPhieuNhapThuoc";
            this.txt_SoPhieuNhapThuoc.PasswordChar = '\0';
            this.txt_SoPhieuNhapThuoc.PlaceholderText = "";
            this.txt_SoPhieuNhapThuoc.ReadOnly = true;
            this.txt_SoPhieuNhapThuoc.SelectedText = "";
            this.txt_SoPhieuNhapThuoc.Size = new System.Drawing.Size(295, 50);
            this.txt_SoPhieuNhapThuoc.TabIndex = 6;
            // 
            // lbl_SoLuongNhap
            // 
            this.lbl_SoLuongNhap.AutoSize = true;
            this.lbl_SoLuongNhap.Location = new System.Drawing.Point(76, 187);
            this.lbl_SoLuongNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoLuongNhap.Name = "lbl_SoLuongNhap";
            this.lbl_SoLuongNhap.Size = new System.Drawing.Size(145, 25);
            this.lbl_SoLuongNhap.TabIndex = 5;
            this.lbl_SoLuongNhap.Text = "Số lượng nhập:";
            // 
            // lbl_TenThuoc
            // 
            this.lbl_TenThuoc.AutoSize = true;
            this.lbl_TenThuoc.Location = new System.Drawing.Point(76, 124);
            this.lbl_TenThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenThuoc.Name = "lbl_TenThuoc";
            this.lbl_TenThuoc.Size = new System.Drawing.Size(114, 25);
            this.lbl_TenThuoc.TabIndex = 2;
            this.lbl_TenThuoc.Text = "Tên Thuốc:";
            // 
            // lbl_DonGiaNhap
            // 
            this.lbl_DonGiaNhap.AutoSize = true;
            this.lbl_DonGiaNhap.Location = new System.Drawing.Point(76, 251);
            this.lbl_DonGiaNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DonGiaNhap.Name = "lbl_DonGiaNhap";
            this.lbl_DonGiaNhap.Size = new System.Drawing.Size(134, 25);
            this.lbl_DonGiaNhap.TabIndex = 3;
            this.lbl_DonGiaNhap.Text = "Đơn giá nhập:";
            // 
            // lbl_NgayLap
            // 
            this.lbl_NgayLap.AutoSize = true;
            this.lbl_NgayLap.Location = new System.Drawing.Point(49, 186);
            this.lbl_NgayLap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgayLap.Name = "lbl_NgayLap";
            this.lbl_NgayLap.Size = new System.Drawing.Size(104, 26);
            this.lbl_NgayLap.TabIndex = 1;
            this.lbl_NgayLap.Text = "Ngày lập:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BorderThickness = 1;
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.FillColor = System.Drawing.Color.LightGray;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Luu.ForeColor = System.Drawing.Color.Black;
            this.btn_Luu.Location = new System.Drawing.Point(620, 60);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(134, 54);
            this.btn_Luu.TabIndex = 15;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderThickness = 1;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.LightGray;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(640, 66);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 68);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbl_SoPhieuNhapThuoc
            // 
            this.lbl_SoPhieuNhapThuoc.AutoSize = true;
            this.lbl_SoPhieuNhapThuoc.Location = new System.Drawing.Point(49, 89);
            this.lbl_SoPhieuNhapThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoPhieuNhapThuoc.Name = "lbl_SoPhieuNhapThuoc";
            this.lbl_SoPhieuNhapThuoc.Size = new System.Drawing.Size(217, 26);
            this.lbl_SoPhieuNhapThuoc.TabIndex = 0;
            this.lbl_SoPhieuNhapThuoc.Text = "Số phiếu nhập thuốc:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BorderThickness = 1;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.FillColor = System.Drawing.Color.LightGray;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_Xoa.Location = new System.Drawing.Point(640, 176);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(134, 68);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // gbx_PhieNnhapThuoc
            // 
            this.gbx_PhieNnhapThuoc.Controls.Add(this.label2);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.dtp_NgayLap);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.btnXong);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.txt_SoPhieuNhapThuoc);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbl_NgayLap);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbl_SoPhieuNhapThuoc);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.btn_Xoa);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.btnThem);
            this.gbx_PhieNnhapThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_PhieNnhapThuoc.Location = new System.Drawing.Point(16, 178);
            this.gbx_PhieNnhapThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_PhieNnhapThuoc.Name = "gbx_PhieNnhapThuoc";
            this.gbx_PhieNnhapThuoc.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_PhieNnhapThuoc.Size = new System.Drawing.Size(807, 383);
            this.gbx_PhieNnhapThuoc.TabIndex = 13;
            this.gbx_PhieNnhapThuoc.TabStop = false;
            this.gbx_PhieNnhapThuoc.Text = "Phiếu Nhập Thuốc";
            this.gbx_PhieNnhapThuoc.Enter += new System.EventHandler(this.gbx_PhieNnhapThuoc_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 350);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số phiếu nhập:";
            // 
            // lbl_Phieunhapthuoc
            // 
            this.lbl_Phieunhapthuoc.AutoSize = false;
            this.lbl_Phieunhapthuoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phieunhapthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phieunhapthuoc.ForeColor = System.Drawing.Color.Red;
            this.lbl_Phieunhapthuoc.Location = new System.Drawing.Point(637, 86);
            this.lbl_Phieunhapthuoc.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_Phieunhapthuoc.Name = "lbl_Phieunhapthuoc";
            this.lbl_Phieunhapthuoc.Size = new System.Drawing.Size(716, 84);
            this.lbl_Phieunhapthuoc.TabIndex = 12;
            this.lbl_Phieunhapthuoc.Text = "PHIẾU NHẬP THUỐC";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(994, 650);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.RowHeadersWidth = 57;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(782, 242);
            this.dgvThuoc.TabIndex = 18;
            this.dgvThuoc.SelectionChanged += new System.EventHandler(this.dgvThuoc_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLoaiThuoc);
            this.groupBox1.Controls.Add(this.cboTenThuocBox);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_TenThuoc);
            this.groupBox1.Controls.Add(this.nup_SoLuongNhap);
            this.groupBox1.Controls.Add(this.lbl_SoLuongNhap);
            this.groupBox1.Controls.Add(this.btn_CapNhatThuoc);
            this.groupBox1.Controls.Add(this.btn_xoaThuoc);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.lbl_DonGiaNhap);
            this.groupBox1.Location = new System.Drawing.Point(913, 198);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(942, 362);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thuốc Cần Nhập";
            // 
            // cboLoaiThuoc
            // 
            this.cboLoaiThuoc.FormattingEnabled = true;
            this.cboLoaiThuoc.Location = new System.Drawing.Point(241, 67);
            this.cboLoaiThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboLoaiThuoc.Name = "cboLoaiThuoc";
            this.cboLoaiThuoc.Size = new System.Drawing.Size(275, 32);
            this.cboLoaiThuoc.TabIndex = 17;
            this.cboLoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cboLoaiThuoc_SelectedIndexChanged);
            // 
            // cboTenThuocBox
            // 
            this.cboTenThuocBox.FormattingEnabled = true;
            this.cboTenThuocBox.Location = new System.Drawing.Point(242, 124);
            this.cboTenThuocBox.Margin = new System.Windows.Forms.Padding(2);
            this.cboTenThuocBox.Name = "cboTenThuocBox";
            this.cboTenThuocBox.Size = new System.Drawing.Size(275, 32);
            this.cboTenThuocBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại Thuốc";
            // 
            // btn_CapNhatThuoc
            // 
            this.btn_CapNhatThuoc.BorderThickness = 1;
            this.btn_CapNhatThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhatThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhatThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CapNhatThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CapNhatThuoc.FillColor = System.Drawing.Color.LightGray;
            this.btn_CapNhatThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_CapNhatThuoc.ForeColor = System.Drawing.Color.Black;
            this.btn_CapNhatThuoc.Location = new System.Drawing.Point(620, 258);
            this.btn_CapNhatThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhatThuoc.Name = "btn_CapNhatThuoc";
            this.btn_CapNhatThuoc.Size = new System.Drawing.Size(134, 54);
            this.btn_CapNhatThuoc.TabIndex = 15;
            this.btn_CapNhatThuoc.Text = "Cập Nhật ";
            this.btn_CapNhatThuoc.Click += new System.EventHandler(this.btn_CapNhatThuoc_Click);
            // 
            // btn_xoaThuoc
            // 
            this.btn_xoaThuoc.BorderThickness = 1;
            this.btn_xoaThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoaThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoaThuoc.FillColor = System.Drawing.Color.LightGray;
            this.btn_xoaThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoaThuoc.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaThuoc.Location = new System.Drawing.Point(620, 156);
            this.btn_xoaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoaThuoc.Name = "btn_xoaThuoc";
            this.btn_xoaThuoc.Size = new System.Drawing.Size(134, 54);
            this.btn_xoaThuoc.TabIndex = 15;
            this.btn_xoaThuoc.Text = "Xóa";
            this.btn_xoaThuoc.Click += new System.EventHandler(this.btn_xoaThuoc_Click);
            // 
            // cbbPhieuNhap
            // 
            this.cbbPhieuNhap.BackColor = System.Drawing.Color.Transparent;
            this.cbbPhieuNhap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPhieuNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhieuNhap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPhieuNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbPhieuNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbPhieuNhap.ItemHeight = 30;
            this.cbbPhieuNhap.Location = new System.Drawing.Point(41, 909);
            this.cbbPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPhieuNhap.Name = "cbbPhieuNhap";
            this.cbbPhieuNhap.Size = new System.Drawing.Size(455, 36);
            this.cbbPhieuNhap.TabIndex = 20;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderThickness = 1;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.LightGray;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(533, 909);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(140, 63);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgv_SoPhieuNhap
            // 
            this.dgv_SoPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SoPhieuNhap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_SoPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SoPhieuNhap.Location = new System.Drawing.Point(41, 650);
            this.dgv_SoPhieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_SoPhieuNhap.Name = "dgv_SoPhieuNhap";
            this.dgv_SoPhieuNhap.ReadOnly = true;
            this.dgv_SoPhieuNhap.RowHeadersVisible = false;
            this.dgv_SoPhieuNhap.RowHeadersWidth = 57;
            this.dgv_SoPhieuNhap.RowTemplate.Height = 24;
            this.dgv_SoPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SoPhieuNhap.Size = new System.Drawing.Size(782, 242);
            this.dgv_SoPhieuNhap.TabIndex = 18;
            this.dgv_SoPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SoPhieuNhap_CellContentClick);
            //   this.dgv_SoPhieuNhap.SelectionChanged += new System.EventHandler(this.dgv_SoPhieuNhap_SelectionChanged);
            // 
            // label_tongtien
            // 
            this.label_tongtien.AutoSize = true;
            this.label_tongtien.BackColor = System.Drawing.Color.LightSalmon;
            this.label_tongtien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_tongtien.Location = new System.Drawing.Point(1280, 916);
            this.label_tongtien.Name = "label_tongtien";
            this.label_tongtien.Size = new System.Drawing.Size(136, 25);
            this.label_tongtien.TabIndex = 21;
            this.label_tongtien.Text = "TỔNG TIỀN : ";
            this.label_tongtien.Click += new System.EventHandler(this.label3_Click);
            // 
            // lb_Tongtien
            // 
            this.lb_Tongtien.AutoSize = true;
            this.lb_Tongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lb_Tongtien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_Tongtien.Location = new System.Drawing.Point(1132, 590);
            this.lb_Tongtien.Name = "lb_Tongtien";
            this.lb_Tongtien.Size = new System.Drawing.Size(0, 25);
            this.lb_Tongtien.TabIndex = 21;
            this.lb_Tongtien.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbb_TONGTIEN
            // 
            this.lbb_TONGTIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb_TONGTIEN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbb_TONGTIEN.Location = new System.Drawing.Point(1471, 909);
            this.lbb_TONGTIEN.Name = "lbb_TONGTIEN";
            this.lbb_TONGTIEN.Size = new System.Drawing.Size(305, 43);
            this.lbb_TONGTIEN.TabIndex = 22;
            // 
            // btn_HT
            // 
            this.btn_HT.BackColor = System.Drawing.Color.Silver;
            this.btn_HT.Location = new System.Drawing.Point(993, 903);
            this.btn_HT.Name = "btn_HT";
            this.btn_HT.Size = new System.Drawing.Size(183, 57);
            this.btn_HT.TabIndex = 23;
            this.btn_HT.Text = "HOÀN THÀNH";
            this.btn_HT.UseVisualStyleBackColor = false;
            this.btn_HT.Click += new System.EventHandler(this.button1_Click);
            // 
            // NhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.btn_HT);
            this.Controls.Add(this.lbb_TONGTIEN);
            this.Controls.Add(this.lb_Tongtien);
            this.Controls.Add(this.label_tongtien);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbbPhieuNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_SoPhieuNhap);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.gbx_PhieNnhapThuoc);
            this.Controls.Add(this.lbl_Phieunhapthuoc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhapThuoc";
            this.Size = new System.Drawing.Size(1882, 1066);
            this.Load += new System.EventHandler(this.NhapThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_SoLuongNhap)).EndInit();
            this.gbx_PhieNnhapThuoc.ResumeLayout(false);
            this.gbx_PhieNnhapThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnXong;
        private Guna.UI2.WinForms.Guna2TextBox txt_DonGia;
        private System.Windows.Forms.NumericUpDown nup_SoLuongNhap;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoPhieuNhapThuoc;
        private System.Windows.Forms.Label lbl_SoLuongNhap;
        private System.Windows.Forms.Label lbl_TenThuoc;
        private System.Windows.Forms.Label lbl_DonGiaNhap;
        private System.Windows.Forms.Label lbl_NgayLap;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label lbl_SoPhieuNhapThuoc;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private System.Windows.Forms.GroupBox gbx_PhieNnhapThuoc;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lbl_Phieunhapthuoc;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLoaiThuoc;
        private System.Windows.Forms.ComboBox cboTenThuocBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_CapNhatThuoc;
        private Guna.UI2.WinForms.Guna2Button btn_xoaThuoc;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPhieuNhap;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_SoPhieuNhap;
        public System.Windows.Forms.Label label_tongtien;
        public System.Windows.Forms.Label lb_Tongtien;
        public System.Windows.Forms.Label lbb_TONGTIEN;
        private System.Windows.Forms.Button btn_HT;
    }
}
