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
            this.btnNamBN = new System.Windows.Forms.CheckBox();
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
            this.dtbNgaySinhBN = new System.Windows.Forms.DateTimePicker();
            this.dgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.MaKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.gbx_Thongtinbenhnhan = new System.Windows.Forms.GroupBox();
            this.lbl_Thongtindangky = new System.Windows.Forms.Label();
            this.gxb_Dangky = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDon)).BeginInit();
            this.gbx_Thongtinbenhnhan.SuspendLayout();
            this.gxb_Dangky.SuspendLayout();
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
            this.dgvThongTinBN.Location = new System.Drawing.Point(270, 481);
            this.dgvThongTinBN.Name = "dgvThongTinBN";
            this.dgvThongTinBN.RowHeadersVisible = false;
            this.dgvThongTinBN.RowHeadersWidth = 49;
            this.dgvThongTinBN.RowTemplate.Height = 24;
            this.dgvThongTinBN.Size = new System.Drawing.Size(683, 145);
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
            this.btnCapNhat.BackColor = System.Drawing.Color.Silver;
            this.btnCapNhat.Location = new System.Drawing.Point(456, 95);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(79, 46);
            this.btnCapNhat.TabIndex = 66;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnNapDanhSach
            // 
            this.btnNapDanhSach.BackColor = System.Drawing.Color.LightGray;
            this.btnNapDanhSach.Location = new System.Drawing.Point(929, 376);
            this.btnNapDanhSach.Name = "btnNapDanhSach";
            this.btnNapDanhSach.Size = new System.Drawing.Size(101, 47);
            this.btnNapDanhSach.TabIndex = 65;
            this.btnNapDanhSach.Text = "Nạp danh sách";
            this.btnNapDanhSach.UseVisualStyleBackColor = false;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.LightGray;
            this.btnTraCuu.Location = new System.Drawing.Point(808, 376);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(92, 47);
            this.btnTraCuu.TabIndex = 64;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.LightGray;
            this.btnDangKy.Location = new System.Drawing.Point(704, 376);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(85, 47);
            this.btnDangKy.TabIndex = 63;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            // 
            // txtMaBNDK
            // 
            this.txtMaBNDK.Location = new System.Drawing.Point(168, 31);
            this.txtMaBNDK.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBNDK.Name = "txtMaBNDK";
            this.txtMaBNDK.Size = new System.Drawing.Size(137, 24);
            this.txtMaBNDK.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(32, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 61;
            this.label12.Text = "Mã bệnh nhân:";
            // 
            // txtSoBNtiepnhan
            // 
            this.txtSoBNtiepnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSoBNtiepnhan.CausesValidation = false;
            this.txtSoBNtiepnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSoBNtiepnhan.Location = new System.Drawing.Point(808, 232);
            this.txtSoBNtiepnhan.Name = "txtSoBNtiepnhan";
            this.txtSoBNtiepnhan.ReadOnly = true;
            this.txtSoBNtiepnhan.Size = new System.Drawing.Size(131, 39);
            this.txtSoBNtiepnhan.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(727, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 57);
            this.label11.TabIndex = 59;
            this.label11.Text = "SỐ BỆNH NHÂN SẼ ĐƯỢC TIẾP NHẬN TRONG NGÀY";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(200, 51);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(202, 24);
            this.txtMaBN.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Mã bệnh nhân:";
            // 
            // btnNuBN
            // 
            this.btnNuBN.AutoSize = true;
            this.btnNuBN.Location = new System.Drawing.Point(274, 155);
            this.btnNuBN.Name = "btnNuBN";
            this.btnNuBN.Size = new System.Drawing.Size(49, 22);
            this.btnNuBN.TabIndex = 56;
            this.btnNuBN.Text = "Nữ";
            this.btnNuBN.UseVisualStyleBackColor = true;
            // 
            // btnNamBN
            // 
            this.btnNamBN.AutoSize = true;
            this.btnNamBN.Location = new System.Drawing.Point(200, 156);
            this.btnNamBN.Name = "btnNamBN";
            this.btnNamBN.Size = new System.Drawing.Size(62, 22);
            this.btnNamBN.TabIndex = 55;
            this.btnNamBN.Text = "Nam";
            this.btnNamBN.UseVisualStyleBackColor = true;
            // 
            // btnThemBN
            // 
            this.btnThemBN.BackColor = System.Drawing.Color.Silver;
            this.btnThemBN.Location = new System.Drawing.Point(456, 44);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(79, 45);
            this.btnThemBN.TabIndex = 54;
            this.btnThemBN.Text = "Thêm";
            this.btnThemBN.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ngày khám bệnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ngày/Tháng/Năm sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Họ và tên:";
            // 
            // txtDiachiBN
            // 
            this.txtDiachiBN.Location = new System.Drawing.Point(200, 191);
            this.txtDiachiBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtDiachiBN.Name = "txtDiachiBN";
            this.txtDiachiBN.Size = new System.Drawing.Size(202, 24);
            this.txtDiachiBN.TabIndex = 39;
            // 
            // txtHotenBN
            // 
            this.txtHotenBN.Location = new System.Drawing.Point(200, 84);
            this.txtHotenBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtHotenBN.Name = "txtHotenBN";
            this.txtHotenBN.Size = new System.Drawing.Size(202, 24);
            this.txtHotenBN.TabIndex = 37;
            // 
            // lbl_Thongtinbenhnhan
            // 
            this.lbl_Thongtinbenhnhan.AutoSize = true;
            this.lbl_Thongtinbenhnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thongtinbenhnhan.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_Thongtinbenhnhan.Location = new System.Drawing.Point(188, 119);
            this.lbl_Thongtinbenhnhan.Name = "lbl_Thongtinbenhnhan";
            this.lbl_Thongtinbenhnhan.Size = new System.Drawing.Size(381, 36);
            this.lbl_Thongtinbenhnhan.TabIndex = 36;
            this.lbl_Thongtinbenhnhan.Text = "THÔNG TIN BỆNH NHÂN";
            this.lbl_Thongtinbenhnhan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtbNgaySinhBN
            // 
            this.dtbNgaySinhBN.Location = new System.Drawing.Point(200, 120);
            this.dtbNgaySinhBN.Name = "dtbNgaySinhBN";
            this.dtbNgaySinhBN.Size = new System.Drawing.Size(202, 24);
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
            this.dgvDanhSachHoaDon.Location = new System.Drawing.Point(1131, 158);
            this.dgvDanhSachHoaDon.Name = "dgvDanhSachHoaDon";
            this.dgvDanhSachHoaDon.RowHeadersVisible = false;
            this.dgvDanhSachHoaDon.RowHeadersWidth = 49;
            this.dgvDanhSachHoaDon.RowTemplate.Height = 24;
            this.dgvDanhSachHoaDon.Size = new System.Drawing.Size(277, 450);
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
            this.label6.Location = new System.Drawing.Point(1229, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 101;
            this.label6.Text = "Danh sách hóa đơn";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Silver;
            this.btnLuu.Location = new System.Drawing.Point(456, 149);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 46);
            this.btnLuu.TabIndex = 102;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.BackColor = System.Drawing.Color.Silver;
            this.btnKhongLuu.Location = new System.Drawing.Point(456, 201);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(79, 48);
            this.btnKhongLuu.TabIndex = 103;
            this.btnKhongLuu.Text = "Không Lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = false;
            // 
            // gbx_Thongtinbenhnhan
            // 
            this.gbx_Thongtinbenhnhan.Controls.Add(this.dateTimePicker1);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.txtHotenBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.btnKhongLuu);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.txtDiachiBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.btnLuu);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label1);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label2);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label3);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.dtbNgaySinhBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label4);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label5);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.btnCapNhat);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.btnThemBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.btnNamBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.btnNuBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.txtMaBN);
            this.gbx_Thongtinbenhnhan.Controls.Add(this.label10);
            this.gbx_Thongtinbenhnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Thongtinbenhnhan.ForeColor = System.Drawing.Color.Black;
            this.gbx_Thongtinbenhnhan.Location = new System.Drawing.Point(125, 185);
            this.gbx_Thongtinbenhnhan.Name = "gbx_Thongtinbenhnhan";
            this.gbx_Thongtinbenhnhan.Size = new System.Drawing.Size(561, 260);
            this.gbx_Thongtinbenhnhan.TabIndex = 104;
            this.gbx_Thongtinbenhnhan.TabStop = false;
            this.gbx_Thongtinbenhnhan.Text = "Thông Tin Bệnh Nhân";
            // 
            // lbl_Thongtindangky
            // 
            this.lbl_Thongtindangky.AutoSize = true;
            this.lbl_Thongtindangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thongtindangky.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_Thongtindangky.Location = new System.Drawing.Point(705, 119);
            this.lbl_Thongtindangky.Name = "lbl_Thongtindangky";
            this.lbl_Thongtindangky.Size = new System.Drawing.Size(337, 36);
            this.lbl_Thongtindangky.TabIndex = 105;
            this.lbl_Thongtindangky.Text = "THÔNG TIN ĐĂNG KÝ";
            this.lbl_Thongtindangky.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gxb_Dangky
            // 
            this.gxb_Dangky.Controls.Add(this.label12);
            this.gxb_Dangky.Controls.Add(this.txtMaBNDK);
            this.gxb_Dangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxb_Dangky.ForeColor = System.Drawing.Color.Salmon;
            this.gxb_Dangky.Location = new System.Drawing.Point(704, 286);
            this.gxb_Dangky.Name = "gxb_Dangky";
            this.gxb_Dangky.Size = new System.Drawing.Size(326, 68);
            this.gxb_Dangky.TabIndex = 106;
            this.gxb_Dangky.TabStop = false;
            this.gxb_Dangky.Text = "Đăng Ký";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 24);
            this.dateTimePicker1.TabIndex = 104;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 1, 21, 30, 16, 0);
            // 
            // DanhSachKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.gxb_Dangky);
            this.Controls.Add(this.lbl_Thongtindangky);
            this.Controls.Add(this.gbx_Thongtinbenhnhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDanhSachHoaDon);
            this.Controls.Add(this.dgvThongTinBN);
            this.Controls.Add(this.btnNapDanhSach);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtSoBNtiepnhan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_Thongtinbenhnhan);
            this.Name = "DanhSachKhamBenh";
            this.Size = new System.Drawing.Size(1459, 732);
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
        private System.Windows.Forms.CheckBox btnNamBN;
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
        private System.Windows.Forms.DateTimePicker dtbNgaySinhBN;
        private System.Windows.Forms.DataGridView dgvDanhSachHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.GroupBox gbx_Thongtinbenhnhan;
        private System.Windows.Forms.Label lbl_Thongtindangky;
        private System.Windows.Forms.GroupBox gxb_Dangky;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
