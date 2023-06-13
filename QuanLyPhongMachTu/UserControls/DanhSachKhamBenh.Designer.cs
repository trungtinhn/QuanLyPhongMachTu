﻿namespace QuanLyPhongMachTu.UserControls
{
    partial class DanhSachKhamBenh
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
            this.components = new System.ComponentModel.Container();
            this.dgvThongTinBN = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtMaBNDK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoBNtiepnhan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiachiBN = new System.Windows.Forms.TextBox();
            this.txtHotenBN = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbl_Thongtinbenhnhan = new System.Windows.Forms.Label();
            this.dgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.MaKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.gbx_Thongtinbenhnhan = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.dtimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtimeNgayDK = new System.Windows.Forms.DateTimePicker();
            this.lbl_Thongtindangky = new System.Windows.Forms.Label();
            this.gxb_Dangky = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).BeginInit();
            this.gbx_Thongtinbenhnhan.SuspendLayout();
            this.gxb_Dangky.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinBN
            // 
            this.dgvThongTinBN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinBN.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThongTinBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinBN.Location = new System.Drawing.Point(130, 475);
            this.dgvThongTinBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThongTinBN.Name = "dgvThongTinBN";
            this.dgvThongTinBN.ReadOnly = true;
            this.dgvThongTinBN.RowHeadersVisible = false;
            this.dgvThongTinBN.RowHeadersWidth = 49;
            this.dgvThongTinBN.RowTemplate.Height = 24;
            this.dgvThongTinBN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinBN.Size = new System.Drawing.Size(1101, 432);
            this.dgvThongTinBN.TabIndex = 67;
            this.dgvThongTinBN.SelectionChanged += new System.EventHandler(this.dgvThongTinBN_SelectionChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Silver;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(456, 95);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(79, 46);
            this.btnCapNhat.TabIndex = 66;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.LightGray;
            this.btnDangKy.Location = new System.Drawing.Point(1012, 296);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(85, 47);
            this.btnDangKy.TabIndex = 63;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtMaBNDK
            // 
            this.txtMaBNDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBNDK.Location = new System.Drawing.Point(187, 33);
            this.txtMaBNDK.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBNDK.Name = "txtMaBNDK";
            this.txtMaBNDK.Size = new System.Drawing.Size(162, 22);
            this.txtMaBNDK.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(32, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "Mã bệnh nhân:";
            // 
            // txtSoBNtiepnhan
            // 
            this.txtSoBNtiepnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSoBNtiepnhan.CausesValidation = false;
            this.txtSoBNtiepnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSoBNtiepnhan.Location = new System.Drawing.Point(979, 128);
            this.txtSoBNtiepnhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoBNtiepnhan.Name = "txtSoBNtiepnhan";
            this.txtSoBNtiepnhan.ReadOnly = true;
            this.txtSoBNtiepnhan.Size = new System.Drawing.Size(131, 30);
            this.txtSoBNtiepnhan.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(893, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 57);
            this.label11.TabIndex = 59;
            this.label11.Text = "SỐ BỆNH NHÂN SẼ ĐƯỢC TIẾP NHẬN TRONG NGÀY";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBN.Location = new System.Drawing.Point(200, 50);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(201, 22);
            this.txtMaBN.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 57;
            this.label10.Text = "Mã bệnh nhân:";
            // 
            // btnThemBN
            // 
            this.btnThemBN.BackColor = System.Drawing.Color.Silver;
            this.btnThemBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBN.Location = new System.Drawing.Point(456, 44);
            this.btnThemBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(79, 46);
            this.btnThemBN.TabIndex = 54;
            this.btnThemBN.Text = "Thêm";
            this.btnThemBN.UseVisualStyleBackColor = false;
            this.btnThemBN.Click += new System.EventHandler(this.btnThemBN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ngày khám bệnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngày/Tháng/Năm sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Họ và tên:";
            // 
            // txtDiachiBN
            // 
            this.txtDiachiBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachiBN.Location = new System.Drawing.Point(200, 191);
            this.txtDiachiBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtDiachiBN.Name = "txtDiachiBN";
            this.txtDiachiBN.Size = new System.Drawing.Size(201, 22);
            this.txtDiachiBN.TabIndex = 39;
            // 
            // txtHotenBN
            // 
            this.txtHotenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotenBN.Location = new System.Drawing.Point(200, 84);
            this.txtHotenBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtHotenBN.Name = "txtHotenBN";
            this.txtHotenBN.Size = new System.Drawing.Size(201, 22);
            this.txtHotenBN.TabIndex = 37;
            // 
            // lbl_Thongtinbenhnhan
            // 
            this.lbl_Thongtinbenhnhan.AutoSize = true;
            this.lbl_Thongtinbenhnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thongtinbenhnhan.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_Thongtinbenhnhan.Location = new System.Drawing.Point(307, 23);
            this.lbl_Thongtinbenhnhan.Name = "lbl_Thongtinbenhnhan";
            this.lbl_Thongtinbenhnhan.Size = new System.Drawing.Size(286, 26);
            this.lbl_Thongtinbenhnhan.TabIndex = 36;
            this.lbl_Thongtinbenhnhan.Text = "THÔNG TIN BỆNH NHÂN";
            this.lbl_Thongtinbenhnhan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDanhSachHoaDon
            // 
            this.dgvDanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKB,
            this.HoTen,
            this.TongTien});
            this.dgvDanhSachHoaDon.Location = new System.Drawing.Point(1315, 139);
            this.dgvDanhSachHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            this.dgvDanhSachHoaDon.RowHeadersVisible = false;
            this.dgvDanhSachHoaDon.RowHeadersWidth = 49;
            this.dgvDanhSachHoaDon.RowTemplate.Height = 24;
            this.dgvDanhSachHoaDon.Size = new System.Drawing.Size(309, 768);
            this.dgvDanhSachHoaDon.TabIndex = 100;
            // 
            // MaKB
            // 
            this.MaKB.HeaderText = "Mã Khám bệnh";
            this.MaKB.MinimumWidth = 6;
            this.MaKB.Name = "MaKB";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(1372, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 24);
            this.label6.TabIndex = 101;
            this.label6.Text = "Danh sách hóa đơn";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(456, 149);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 46);
            this.btnXoa.TabIndex = 102;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.BackColor = System.Drawing.Color.Silver;
            this.btnKhongLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.Location = new System.Drawing.Point(456, 201);
            this.btnKhongLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(79, 48);
            this.btnKhongLuu.TabIndex = 103;
            this.btnKhongLuu.Text = "Không Lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = false;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // gbx_Thongtinbenhnhan
            // 
            this.gbx_Thongtinbenhnhan.Controls.Add(this.radNu);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.radNam);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.dtimeNgaySinh);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.txtHotenBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.btnKhongLuu);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.txtDiachiBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.btnXoa);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label1);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label2);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label3);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label4);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.btnCapNhat);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.btnThemBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.txtMaBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label10);
            this.gbx_Thongtinbenhnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Thongtinbenhnhan.ForeColor = System.Drawing.Color.Black;
            this.gbx_Thongtinbenhnhan.Location = new System.Drawing.Point(130, 73);
            this.gbx_Thongtinbenhnhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_Thongtinbenhnhan.Name = "gbx_Thongtinbenhnhan";
            this.gbx_Thongtinbenhnhan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbx_Thongtinbenhnhan.Size = new System.Drawing.Size(614, 285);
            this.gbx_Thongtinbenhnhan.TabIndex = 104;
            this.gbx_Thongtinbenhnhan.TabStop = false;
            this.gbx_Thongtinbenhnhan.Text = "Thông Tin Bệnh Nhân";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(284, 156);
            this.radNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(42, 20);
            this.radNu.TabIndex = 106;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(200, 156);
            this.radNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(54, 20);
            this.radNam.TabIndex = 106;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // dtimeNgaySinh
            // 
            this.dtimeNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeNgaySinh.Location = new System.Drawing.Point(200, 121);
            this.dtimeNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtimeNgaySinh.Name = "dtimeNgaySinh";
            this.dtimeNgaySinh.Size = new System.Drawing.Size(201, 22);
            this.dtimeNgaySinh.TabIndex = 105;
            // 
            // dtimeNgayDK
            // 
            this.dtimeNgayDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeNgayDK.Location = new System.Drawing.Point(187, 69);
            this.dtimeNgayDK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtimeNgayDK.Name = "dtimeNgayDK";
            this.dtimeNgayDK.Size = new System.Drawing.Size(162, 22);
            this.dtimeNgayDK.TabIndex = 104;
            this.dtimeNgayDK.Value = new System.DateTime(2023, 6, 1, 21, 30, 16, 0);
            // 
            // lbl_Thongtindangky
            // 
            this.lbl_Thongtindangky.AutoSize = true;
            this.lbl_Thongtindangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thongtindangky.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_Thongtindangky.Location = new System.Drawing.Point(993, 23);
            this.lbl_Thongtindangky.Name = "lbl_Thongtindangky";
            this.lbl_Thongtindangky.Size = new System.Drawing.Size(402, 26);
            this.lbl_Thongtindangky.TabIndex = 105;
            this.lbl_Thongtindangky.Text = "THÔNG TIN ĐĂNG KÝ KHÁM BỆNH";
            this.lbl_Thongtindangky.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gxb_Dangky
            // 
            this.gxb_Dangky.Controls.Add(this.label12);
            this.gxb_Dangky.Controls.Add(this.txtMaBNDK);
            this.gxb_Dangky.Controls.Add(this.dtimeNgayDK);
            this.gxb_Dangky.Controls.Add(this.label5);
            this.gxb_Dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxb_Dangky.ForeColor = System.Drawing.Color.Salmon;
            this.gxb_Dangky.Location = new System.Drawing.Point(856, 182);
            this.gxb_Dangky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gxb_Dangky.Name = "gxb_Dangky";
            this.gxb_Dangky.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gxb_Dangky.Size = new System.Drawing.Size(375, 100);
            this.gxb_Dangky.TabIndex = 106;
            this.gxb_Dangky.TabStop = false;
            this.gxb_Dangky.Text = "Đăng Ký";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(509, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 26);
            this.label7.TabIndex = 36;
            this.label7.Text = "DANH SÁCH BỆNH NHÂN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(391, 422);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(140, 36);
            this.guna2ComboBox1.TabIndex = 108;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(165, 422);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 109;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.LightGray;
            this.btnTraCuu.Location = new System.Drawing.Point(580, 422);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(98, 36);
            this.btnTraCuu.TabIndex = 63;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // DanhSachKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.gxb_Dangky);
            this.Controls.Add(this.lbl_Thongtindangky);
            this.Controls.Add(this.gbx_Thongtinbenhnhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDanhSachHoaDon);
            this.Controls.Add(this.dgvThongTinBN);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtSoBNtiepnhan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_Thongtinbenhnhan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DanhSachKhamBenh";
            this.Size = new System.Drawing.Size(1855, 940);
            this.Load += new System.EventHandler(this.DanhSachKhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).EndInit();
            this.gbx_Thongtinbenhnhan.ResumeLayout(false);
            this.gbx_Thongtinbenhnhan.PerformLayout();
            this.gxb_Dangky.ResumeLayout(false);
            this.gxb_Dangky.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinBN;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtMaBNDK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoBNtiepnhan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiachiBN;
        private System.Windows.Forms.TextBox txtHotenBN;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbl_Thongtinbenhnhan;
        private System.Windows.Forms.DataGridView dgvDanhSachHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.GroupBox gbx_Thongtinbenhnhan;
        private System.Windows.Forms.Label lbl_Thongtindangky;
        private System.Windows.Forms.GroupBox gxb_Dangky;
        private System.Windows.Forms.DateTimePicker dtimeNgayDK;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.DateTimePicker dtimeNgaySinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Button btnTraCuu;
    }
}
