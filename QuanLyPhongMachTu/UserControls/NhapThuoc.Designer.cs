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
            this.btn_Sua = new Guna.UI2.WinForms.Guna2Button();
            this.SoPhieuNhapThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ThanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.nup_DonGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.nup_SoLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.txt_TenThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SoPhieuNhapThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_SoLuongNhap = new System.Windows.Forms.Label();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.lbl_TenThuoc = new System.Windows.Forms.Label();
            this.dGV_NhapThuoc = new System.Windows.Forms.DataGridView();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_DonGiaNhap = new System.Windows.Forms.Label();
            this.lbl_NgayLap = new System.Windows.Forms.Label();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_SoPhieuNhapThuoc = new System.Windows.Forms.Label();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.gbx_PhieNnhapThuoc = new System.Windows.Forms.GroupBox();
            this.lbl_Phieunhapthuoc = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nup_DonGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_SoLuongNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_NhapThuoc)).BeginInit();
            this.gbx_PhieNnhapThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.BorderThickness = 1;
            this.btn_Sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua.FillColor = System.Drawing.Color.LightGray;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua.ForeColor = System.Drawing.Color.Black;
            this.btn_Sua.Location = new System.Drawing.Point(1128, 251);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 45);
            this.btn_Sua.TabIndex = 17;
            this.btn_Sua.Text = "Xong";
            // 
            // SoPhieuNhapThuoc
            // 
            this.SoPhieuNhapThuoc.HeaderText = "Số Phiếu Nhập Thuốc";
            this.SoPhieuNhapThuoc.MinimumWidth = 7;
            this.SoPhieuNhapThuoc.Name = "SoPhieuNhapThuoc";
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThanhTien.DefaultText = "";
            this.txt_ThanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ThanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ThanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ThanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThanhTien.Location = new System.Drawing.Point(659, 146);
            this.txt_ThanhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.PasswordChar = '\0';
            this.txt_ThanhTien.PlaceholderText = "";
            this.txt_ThanhTien.SelectedText = "";
            this.txt_ThanhTien.Size = new System.Drawing.Size(200, 36);
            this.txt_ThanhTien.TabIndex = 13;
            // 
            // nup_DonGiaNhap
            // 
            this.nup_DonGiaNhap.Location = new System.Drawing.Point(659, 95);
            this.nup_DonGiaNhap.Name = "nup_DonGiaNhap";
            this.nup_DonGiaNhap.Size = new System.Drawing.Size(200, 27);
            this.nup_DonGiaNhap.TabIndex = 12;
            // 
            // nup_SoLuongNhap
            // 
            this.nup_SoLuongNhap.Location = new System.Drawing.Point(659, 39);
            this.nup_SoLuongNhap.Name = "nup_SoLuongNhap";
            this.nup_SoLuongNhap.Size = new System.Drawing.Size(200, 27);
            this.nup_SoLuongNhap.TabIndex = 10;
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Location = new System.Drawing.Point(226, 99);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(214, 27);
            this.dtp_NgayLap.TabIndex = 9;
            // 
            // txt_TenThuoc
            // 
            this.txt_TenThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenThuoc.DefaultText = "";
            this.txt_TenThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenThuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenThuoc.Location = new System.Drawing.Point(226, 146);
            this.txt_TenThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenThuoc.Name = "txt_TenThuoc";
            this.txt_TenThuoc.PasswordChar = '\0';
            this.txt_TenThuoc.PlaceholderText = "";
            this.txt_TenThuoc.SelectedText = "";
            this.txt_TenThuoc.Size = new System.Drawing.Size(214, 36);
            this.txt_TenThuoc.TabIndex = 8;
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
            this.txt_SoPhieuNhapThuoc.Location = new System.Drawing.Point(226, 39);
            this.txt_SoPhieuNhapThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SoPhieuNhapThuoc.Name = "txt_SoPhieuNhapThuoc";
            this.txt_SoPhieuNhapThuoc.PasswordChar = '\0';
            this.txt_SoPhieuNhapThuoc.PlaceholderText = "";
            this.txt_SoPhieuNhapThuoc.SelectedText = "";
            this.txt_SoPhieuNhapThuoc.Size = new System.Drawing.Size(214, 33);
            this.txt_SoPhieuNhapThuoc.TabIndex = 6;
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 7;
            this.NgayLap.Name = "NgayLap";
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.MinimumWidth = 7;
            this.TenThuoc.Name = "TenThuoc";
            // 
            // lbl_SoLuongNhap
            // 
            this.lbl_SoLuongNhap.AutoSize = true;
            this.lbl_SoLuongNhap.Location = new System.Drawing.Point(484, 43);
            this.lbl_SoLuongNhap.Name = "lbl_SoLuongNhap";
            this.lbl_SoLuongNhap.Size = new System.Drawing.Size(120, 20);
            this.lbl_SoLuongNhap.TabIndex = 5;
            this.lbl_SoLuongNhap.Text = "Số lượng nhập:";
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Location = new System.Drawing.Point(484, 148);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(92, 20);
            this.lbl_ThanhTien.TabIndex = 4;
            this.lbl_ThanhTien.Text = "Thành tiền:";
            // 
            // lbl_TenThuoc
            // 
            this.lbl_TenThuoc.AutoSize = true;
            this.lbl_TenThuoc.Location = new System.Drawing.Point(58, 155);
            this.lbl_TenThuoc.Name = "lbl_TenThuoc";
            this.lbl_TenThuoc.Size = new System.Drawing.Size(93, 20);
            this.lbl_TenThuoc.TabIndex = 2;
            this.lbl_TenThuoc.Text = "Tên Thuốc:";
            // 
            // dGV_NhapThuoc
            // 
            this.dGV_NhapThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_NhapThuoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGV_NhapThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_NhapThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuNhapThuoc,
            this.NgayLap,
            this.TenThuoc,
            this.SoLuongNhap,
            this.DonGiaNhap,
            this.ThanhTien});
            this.dGV_NhapThuoc.Location = new System.Drawing.Point(191, 400);
            this.dGV_NhapThuoc.Name = "dGV_NhapThuoc";
            this.dGV_NhapThuoc.RowHeadersVisible = false;
            this.dGV_NhapThuoc.RowHeadersWidth = 57;
            this.dGV_NhapThuoc.RowTemplate.Height = 24;
            this.dGV_NhapThuoc.Size = new System.Drawing.Size(900, 162);
            this.dGV_NhapThuoc.TabIndex = 18;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.HeaderText = "Số Lượng Nhập";
            this.SoLuongNhap.MinimumWidth = 7;
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.HeaderText = "Đơn Giá Nhập";
            this.DonGiaNhap.MinimumWidth = 7;
            this.DonGiaNhap.Name = "DonGiaNhap";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 7;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // lbl_DonGiaNhap
            // 
            this.lbl_DonGiaNhap.AutoSize = true;
            this.lbl_DonGiaNhap.Location = new System.Drawing.Point(484, 97);
            this.lbl_DonGiaNhap.Name = "lbl_DonGiaNhap";
            this.lbl_DonGiaNhap.Size = new System.Drawing.Size(112, 20);
            this.lbl_DonGiaNhap.TabIndex = 3;
            this.lbl_DonGiaNhap.Text = "Đơn giá nhập:";
            // 
            // lbl_NgayLap
            // 
            this.lbl_NgayLap.AutoSize = true;
            this.lbl_NgayLap.Location = new System.Drawing.Point(58, 99);
            this.lbl_NgayLap.Name = "lbl_NgayLap";
            this.lbl_NgayLap.Size = new System.Drawing.Size(79, 20);
            this.lbl_NgayLap.TabIndex = 1;
            this.lbl_NgayLap.Text = "Ngày lập:";
            // 
            // btn_Them
            // 
            this.btn_Them.BorderThickness = 1;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.LightGray;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them.ForeColor = System.Drawing.Color.Black;
            this.btn_Them.Location = new System.Drawing.Point(1004, 160);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 45);
            this.btn_Them.TabIndex = 15;
            this.btn_Them.Text = "Thêm";
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
            this.btn_Luu.Location = new System.Drawing.Point(1128, 160);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(98, 45);
            this.btn_Luu.TabIndex = 14;
            this.btn_Luu.Text = "Lưu";
            // 
            // lbl_SoPhieuNhapThuoc
            // 
            this.lbl_SoPhieuNhapThuoc.AutoSize = true;
            this.lbl_SoPhieuNhapThuoc.Location = new System.Drawing.Point(58, 41);
            this.lbl_SoPhieuNhapThuoc.Name = "lbl_SoPhieuNhapThuoc";
            this.lbl_SoPhieuNhapThuoc.Size = new System.Drawing.Size(166, 20);
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
            this.btn_Xoa.Location = new System.Drawing.Point(1004, 251);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 45);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xóa";
            // 
            // gbx_PhieNnhapThuoc
            // 
            this.gbx_PhieNnhapThuoc.Controls.Add(this.txt_ThanhTien);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.nup_DonGiaNhap);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.nup_SoLuongNhap);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.dtp_NgayLap);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.txt_TenThuoc);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.txt_SoPhieuNhapThuoc);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbl_SoLuongNhap);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbl_ThanhTien);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbl_DonGiaNhap);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbl_TenThuoc);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbl_NgayLap);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbl_SoPhieuNhapThuoc);
            this.gbx_PhieNnhapThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_PhieNnhapThuoc.Location = new System.Drawing.Point(91, 125);
            this.gbx_PhieNnhapThuoc.Name = "gbx_PhieNnhapThuoc";
            this.gbx_PhieNnhapThuoc.Size = new System.Drawing.Size(892, 216);
            this.gbx_PhieNnhapThuoc.TabIndex = 13;
            this.gbx_PhieNnhapThuoc.TabStop = false;
            this.gbx_PhieNnhapThuoc.Text = "Phiếu Nhập Thuốc";
            this.gbx_PhieNnhapThuoc.Enter += new System.EventHandler(this.gbx_PhieNnhapThuoc_Enter);
            // 
            // lbb_TONGTIEN
            // 

            // 
            // btn_HT
        
            // label_tongtien
            // 
            
            // 
            // lbl_Phieunhapthuoc
            // 
            this.lbl_Phieunhapthuoc.AutoSize = false;
            this.lbl_Phieunhapthuoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phieunhapthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phieunhapthuoc.ForeColor = System.Drawing.Color.Red;
            this.lbl_Phieunhapthuoc.Location = new System.Drawing.Point(403, 49);
            this.lbl_Phieunhapthuoc.Name = "lbl_Phieunhapthuoc";
            this.lbl_Phieunhapthuoc.Size = new System.Drawing.Size(521, 56);
            this.lbl_Phieunhapthuoc.TabIndex = 12;
            this.lbl_Phieunhapthuoc.Text = "PHIẾU NHẬP THUỐC";
            // 
            // NhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.dGV_NhapThuoc);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.gbx_PhieNnhapThuoc);
            this.Controls.Add(this.lbl_Phieunhapthuoc);
            this.Name = "NhapThuoc";
            this.Size = new System.Drawing.Size(1358, 638);
            ((System.ComponentModel.ISupportInitialize)(this.nup_DonGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_SoLuongNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_NhapThuoc)).EndInit();
            this.gbx_PhieNnhapThuoc.ResumeLayout(false);
            this.gbx_PhieNnhapThuoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuNhapThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txt_ThanhTien;
        private System.Windows.Forms.NumericUpDown nup_DonGiaNhap;
        private System.Windows.Forms.NumericUpDown nup_SoLuongNhap;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoPhieuNhapThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.Label lbl_SoLuongNhap;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Label lbl_TenThuoc;
        private System.Windows.Forms.DataGridView dGV_NhapThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lbl_DonGiaNhap;
        private System.Windows.Forms.Label lbl_NgayLap;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
        private System.Windows.Forms.Label lbl_SoPhieuNhapThuoc;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
        private System.Windows.Forms.GroupBox gbx_PhieNnhapThuoc;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lbl_Phieunhapthuoc;
    }
}
