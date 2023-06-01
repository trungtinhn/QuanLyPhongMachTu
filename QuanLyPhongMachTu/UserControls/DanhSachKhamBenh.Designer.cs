namespace QuanLyPhongMachTu.UserControls
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
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaysinhBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnNapDanhSach = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtMaBNDK = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoBNtiepnhan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNuBN = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYearKB = new System.Windows.Forms.TextBox();
            this.txtMonthKB = new System.Windows.Forms.TextBox();
            this.btnNamBN = new System.Windows.Forms.CheckBox();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.txtDayKB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiachiBN = new System.Windows.Forms.TextBox();
            this.txtHotenBN = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.dtbNgaySinhBN = new System.Windows.Forms.DateTimePicker();
            this.dgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.MaKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTinBN
            // 
            this.dgvThongTinBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinBN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.HotenBN,
            this.GioiTinhBN,
            this.NgaysinhBN,
            this.DiaChiBN});
            this.dgvThongTinBN.Location = new System.Drawing.Point(108, 352);
            this.dgvThongTinBN.Name = "dgvThongTinBN";
            this.dgvThongTinBN.RowHeadersVisible = false;
            this.dgvThongTinBN.RowHeadersWidth = 49;
            this.dgvThongTinBN.RowTemplate.Height = 24;
            this.dgvThongTinBN.Size = new System.Drawing.Size(670, 147);
            this.dgvThongTinBN.TabIndex = 67;
            // 
            // MaBN
            // 
            this.MaBN.HeaderText = "Mã bệnh nhân";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            this.MaBN.Width = 120;
            // 
            // HotenBN
            // 
            this.HotenBN.HeaderText = "Họ và tên";
            this.HotenBN.MinimumWidth = 6;
            this.HotenBN.Name = "HotenBN";
            this.HotenBN.Width = 120;
            // 
            // GioiTinhBN
            // 
            this.GioiTinhBN.HeaderText = "Giới tính";
            this.GioiTinhBN.MinimumWidth = 6;
            this.GioiTinhBN.Name = "GioiTinhBN";
            this.GioiTinhBN.Width = 60;
            // 
            // NgaysinhBN
            // 
            this.NgaysinhBN.HeaderText = "Ngày sinh";
            this.NgaysinhBN.MinimumWidth = 6;
            this.NgaysinhBN.Name = "NgaysinhBN";
            this.NgaysinhBN.Width = 120;
            // 
            // DiaChiBN
            // 
            this.DiaChiBN.HeaderText = "Địa chỉ";
            this.DiaChiBN.MinimumWidth = 6;
            this.DiaChiBN.Name = "DiaChiBN";
            this.DiaChiBN.Width = 250;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(365, 125);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(79, 31);
            this.btnCapNhat.TabIndex = 66;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnNapDanhSach
            // 
            this.btnNapDanhSach.Location = new System.Drawing.Point(694, 280);
            this.btnNapDanhSach.Name = "btnNapDanhSach";
            this.btnNapDanhSach.Size = new System.Drawing.Size(73, 23);
            this.btnNapDanhSach.TabIndex = 65;
            this.btnNapDanhSach.Text = "Nạp danh sách";
            this.btnNapDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(585, 280);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(73, 23);
            this.btnTraCuu.TabIndex = 64;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(482, 280);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(73, 23);
            this.btnDangKy.TabIndex = 63;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // txtMaBNDK
            // 
            this.txtMaBNDK.Location = new System.Drawing.Point(577, 231);
            this.txtMaBNDK.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBNDK.Name = "txtMaBNDK";
            this.txtMaBNDK.Size = new System.Drawing.Size(137, 22);
            this.txtMaBNDK.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(479, 231);
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
            this.txtSoBNtiepnhan.Location = new System.Drawing.Point(583, 142);
            this.txtSoBNtiepnhan.Name = "txtSoBNtiepnhan";
            this.txtSoBNtiepnhan.ReadOnly = true;
            this.txtSoBNtiepnhan.Size = new System.Drawing.Size(131, 35);
            this.txtSoBNtiepnhan.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(496, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 57);
            this.label11.TabIndex = 59;
            this.label11.Text = "SỐ BỆNH NHÂN SẼ ĐƯỢC TIẾP NHẬN TRONG NGÀY";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(180, 91);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(164, 22);
            this.txtMaBN.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 57;
            this.label10.Text = "Mã bệnh nhân:";
            // 
            // btnNuBN
            // 
            this.btnNuBN.AutoSize = true;
            this.btnNuBN.Location = new System.Drawing.Point(267, 196);
            this.btnNuBN.Name = "btnNuBN";
            this.btnNuBN.Size = new System.Drawing.Size(43, 20);
            this.btnNuBN.TabIndex = 56;
            this.btnNuBN.Text = "Nữ";
            this.btnNuBN.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(262, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(210, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 25);
            this.label9.TabIndex = 52;
            this.label9.Text = "/";
            // 
            // txtYearKB
            // 
            this.txtYearKB.Location = new System.Drawing.Point(284, 263);
            this.txtYearKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtYearKB.Name = "txtYearKB";
            this.txtYearKB.Size = new System.Drawing.Size(60, 22);
            this.txtYearKB.TabIndex = 51;
            // 
            // txtMonthKB
            // 
            this.txtMonthKB.Location = new System.Drawing.Point(232, 263);
            this.txtMonthKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtMonthKB.Name = "txtMonthKB";
            this.txtMonthKB.Size = new System.Drawing.Size(26, 22);
            this.txtMonthKB.TabIndex = 50;
            // 
            // btnNamBN
            // 
            this.btnNamBN.AutoSize = true;
            this.btnNamBN.Location = new System.Drawing.Point(180, 196);
            this.btnNamBN.Name = "btnNamBN";
            this.btnNamBN.Size = new System.Drawing.Size(55, 20);
            this.btnNamBN.TabIndex = 55;
            this.btnNamBN.Text = "Nam";
            this.btnNamBN.UseVisualStyleBackColor = true;
            // 
            // btnThemBN
            // 
            this.btnThemBN.Location = new System.Drawing.Point(365, 91);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(79, 28);
            this.btnThemBN.TabIndex = 54;
            this.btnThemBN.Text = "Thêm";
            this.btnThemBN.UseVisualStyleBackColor = true;
            // 
            // txtDayKB
            // 
            this.txtDayKB.Location = new System.Drawing.Point(180, 263);
            this.txtDayKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtDayKB.Name = "txtDayKB";
            this.txtDayKB.Size = new System.Drawing.Size(26, 22);
            this.txtDayKB.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ngày khám bệnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngày/Tháng/Năm sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Họ và tên:";
            // 
            // txtDiachiBN
            // 
            this.txtDiachiBN.Location = new System.Drawing.Point(180, 231);
            this.txtDiachiBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtDiachiBN.Name = "txtDiachiBN";
            this.txtDiachiBN.Size = new System.Drawing.Size(164, 22);
            this.txtDiachiBN.TabIndex = 39;
            // 
            // txtHotenBN
            // 
            this.txtHotenBN.Location = new System.Drawing.Point(180, 125);
            this.txtHotenBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtHotenBN.Name = "txtHotenBN";
            this.txtHotenBN.Size = new System.Drawing.Size(164, 22);
            this.txtHotenBN.TabIndex = 37;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Salmon;
            this.Title.Location = new System.Drawing.Point(206, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(452, 39);
            this.Title.TabIndex = 36;
            this.Title.Text = "DANH SÁCH KHÁM BỆNH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtbNgaySinhBN
            // 
            this.dtbNgaySinhBN.Location = new System.Drawing.Point(180, 161);
            this.dtbNgaySinhBN.Name = "dtbNgaySinhBN";
            this.dtbNgaySinhBN.Size = new System.Drawing.Size(141, 22);
            this.dtbNgaySinhBN.TabIndex = 99;
            this.dtbNgaySinhBN.Value = new System.DateTime(2023, 6, 1, 21, 30, 16, 0);
            // 
            // dgvDanhSachHoaDon
            // 
            this.dgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKB,
            this.HoTen,
            this.TongTien});
            this.dgvDanhSachHoaDon.Location = new System.Drawing.Point(784, 50);
            this.dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            this.dgvDanhSachHoaDon.RowHeadersVisible = false;
            this.dgvDanhSachHoaDon.RowHeadersWidth = 49;
            this.dgvDanhSachHoaDon.RowTemplate.Height = 24;
            this.dgvDanhSachHoaDon.Size = new System.Drawing.Size(240, 450);
            this.dgvDanhSachHoaDon.TabIndex = 100;
            // 
            // MaKB
            // 
            this.MaKB.HeaderText = "Mã Khám bệnh";
            this.MaKB.MinimumWidth = 6;
            this.MaKB.Name = "MaKB";
            this.MaKB.Width = 60;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 95;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(869, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 101;
            this.label6.Text = "Danh sách hóa đơn";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(365, 162);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 31);
            this.btnLuu.TabIndex = 102;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Location = new System.Drawing.Point(365, 199);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(79, 31);
            this.btnKhongLuu.TabIndex = 103;
            this.btnKhongLuu.Text = "Không Lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            // 
            // DanhSachKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDanhSachHoaDon);
            this.Controls.Add(this.dtbNgaySinhBN);
            this.Controls.Add(this.dgvThongTinBN);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnNapDanhSach);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtMaBNDK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSoBNtiepnhan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnNuBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYearKB);
            this.Controls.Add(this.txtMonthKB);
            this.Controls.Add(this.btnNamBN);
            this.Controls.Add(this.btnThemBN);
            this.Controls.Add(this.txtDayKB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiachiBN);
            this.Controls.Add(this.txtHotenBN);
            this.Controls.Add(this.Title);
            this.Name = "DanhSachKhamBenh";
            this.Size = new System.Drawing.Size(1100, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaysinhBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiBN;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnNapDanhSach;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtMaBNDK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoBNtiepnhan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox btnNuBN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYearKB;
        private System.Windows.Forms.TextBox txtMonthKB;
        private System.Windows.Forms.CheckBox btnNamBN;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.TextBox txtDayKB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiachiBN;
        private System.Windows.Forms.TextBox txtHotenBN;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DateTimePicker dtbNgaySinhBN;
        private System.Windows.Forms.DataGridView dgvDanhSachHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
    }
}
