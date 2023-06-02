namespace QuanLyPhongMachTu.UserControls
{
    partial class LapPhieuKhamBenh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.dgvKB = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.MaThuocKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuocKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThuocKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDanhSachThuoc = new System.Windows.Forms.Label();
            this.txtCachdungThuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonviThuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDsThuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDudoanBenh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrieuchungBenh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.btnThemPKB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHotenBN = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.dtbNgayKB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDonGiaThuoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSoBNcho = new System.Windows.Forms.TextBox();
            this.btnXongPKB = new System.Windows.Forms.Button();
            this.btnLuuPKB = new System.Windows.Forms.Button();
            this.btnHuyPKB = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.gxb_Phieukhambenh = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gxb_Phieukhambenh.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(422, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 96;
            this.label11.Text = "Thành tiền:";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(532, 154);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(1);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(117, 27);
            this.txtThanhtien.TabIndex = 97;
            // 
            // dgvKB
            // 
            this.dgvKB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKB.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NgayKB,
            this.MaBN,
            this.MaBenh,
            this.MaThuoc,
            this.SoLuong});
            this.dgvKB.Location = new System.Drawing.Point(239, 492);
            this.dgvKB.Name = "dgvKB";
            this.dgvKB.RowHeadersVisible = false;
            this.dgvKB.RowHeadersWidth = 49;
            this.dgvKB.RowTemplate.Height = 24;
            this.dgvKB.Size = new System.Drawing.Size(864, 158);
            this.dgvKB.TabIndex = 95;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // NgayKB
            // 
            this.NgayKB.HeaderText = "Ngày khám bệnh";
            this.NgayKB.MinimumWidth = 6;
            this.NgayKB.Name = "NgayKB";
            // 
            // MaBN
            // 
            this.MaBN.HeaderText = "Mã bệnh nhân";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            // 
            // MaBenh
            // 
            this.MaBenh.HeaderText = "Mã Bệnh";
            this.MaBenh.MinimumWidth = 6;
            this.MaBenh.Name = "MaBenh";
            // 
            // MaThuoc
            // 
            this.MaThuoc.HeaderText = "Thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuocKho,
            this.TenThuocKho,
            this.SoLuongThuocKho});
            this.dgvThuoc.Location = new System.Drawing.Point(929, 272);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.RowHeadersWidth = 49;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.Size = new System.Drawing.Size(231, 155);
            this.dgvThuoc.TabIndex = 94;
            // 
            // MaThuocKho
            // 
            this.MaThuocKho.HeaderText = "Mã Thuốc";
            this.MaThuocKho.MinimumWidth = 6;
            this.MaThuocKho.Name = "MaThuocKho";
            // 
            // TenThuocKho
            // 
            this.TenThuocKho.HeaderText = "Tên thuốc";
            this.TenThuocKho.MinimumWidth = 6;
            this.TenThuocKho.Name = "TenThuocKho";
            // 
            // SoLuongThuocKho
            // 
            this.SoLuongThuocKho.HeaderText = "Số Lượng";
            this.SoLuongThuocKho.MinimumWidth = 6;
            this.SoLuongThuocKho.Name = "SoLuongThuocKho";
            // 
            // lbDanhSachThuoc
            // 
            this.lbDanhSachThuoc.AutoSize = true;
            this.lbDanhSachThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachThuoc.Location = new System.Drawing.Point(973, 249);
            this.lbDanhSachThuoc.Name = "lbDanhSachThuoc";
            this.lbDanhSachThuoc.Size = new System.Drawing.Size(130, 20);
            this.lbDanhSachThuoc.TabIndex = 93;
            this.lbDanhSachThuoc.Text = "Danh sách thuốc";
            // 
            // txtCachdungThuoc
            // 
            this.txtCachdungThuoc.Location = new System.Drawing.Point(532, 190);
            this.txtCachdungThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtCachdungThuoc.Multiline = true;
            this.txtCachdungThuoc.Name = "txtCachdungThuoc";
            this.txtCachdungThuoc.Size = new System.Drawing.Size(117, 22);
            this.txtCachdungThuoc.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Cách dùng:";
            // 
            // txtDonviThuoc
            // 
            this.txtDonviThuoc.Location = new System.Drawing.Point(532, 78);
            this.txtDonviThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtDonviThuoc.Name = "txtDonviThuoc";
            this.txtDonviThuoc.Size = new System.Drawing.Size(118, 27);
            this.txtDonviThuoc.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Số Lượng:";
            // 
            // txtDsThuoc
            // 
            this.txtDsThuoc.Location = new System.Drawing.Point(532, 43);
            this.txtDsThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtDsThuoc.Multiline = true;
            this.txtDsThuoc.Name = "txtDsThuoc";
            this.txtDsThuoc.Size = new System.Drawing.Size(121, 23);
            this.txtDsThuoc.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Tên loại thuốc:";
            // 
            // txtDudoanBenh
            // 
            this.txtDudoanBenh.Location = new System.Drawing.Point(216, 193);
            this.txtDudoanBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtDudoanBenh.Name = "txtDudoanBenh";
            this.txtDudoanBenh.Size = new System.Drawing.Size(170, 27);
            this.txtDudoanBenh.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Dự đoán bệnh:";
            // 
            // txtTrieuchungBenh
            // 
            this.txtTrieuchungBenh.Location = new System.Drawing.Point(216, 157);
            this.txtTrieuchungBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTrieuchungBenh.Multiline = true;
            this.txtTrieuchungBenh.Name = "txtTrieuchungBenh";
            this.txtTrieuchungBenh.Size = new System.Drawing.Size(170, 26);
            this.txtTrieuchungBenh.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Triệu chứng bệnh:";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(216, 49);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(170, 27);
            this.txtMaBN.TabIndex = 77;
            // 
            // btnThemPKB
            // 
            this.btnThemPKB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThemPKB.Location = new System.Drawing.Point(794, 203);
            this.btnThemPKB.Name = "btnThemPKB";
            this.btnThemPKB.Size = new System.Drawing.Size(90, 40);
            this.btnThemPKB.TabIndex = 75;
            this.btnThemPKB.Text = "Thêm";
            this.btnThemPKB.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 76;
            this.label10.Text = "Mã bệnh nhân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ngày khám bệnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Họ và tên:";
            // 
            // txtHotenBN
            // 
            this.txtHotenBN.Location = new System.Drawing.Point(216, 83);
            this.txtHotenBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtHotenBN.Name = "txtHotenBN";
            this.txtHotenBN.Size = new System.Drawing.Size(170, 27);
            this.txtHotenBN.TabIndex = 72;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Salmon;
            this.Title.Location = new System.Drawing.Point(499, 93);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(406, 46);
            this.Title.TabIndex = 71;
            this.Title.Text = "PHIẾU KHÁM BỆNH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtbNgayKB
            // 
            this.dtbNgayKB.Font = new System.Drawing.Font("Microsoft New Tai Lue", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgayKB.Location = new System.Drawing.Point(216, 121);
            this.dtbNgayKB.Name = "dtbNgayKB";
            this.dtbNgayKB.Size = new System.Drawing.Size(170, 25);
            this.dtbNgayKB.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(528, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 20);
            this.label8.TabIndex = 99;
            this.label8.Text = "Danh sách phiếu khám bệnh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSo,
            this.HoTenBN});
            this.dataGridView1.Location = new System.Drawing.Point(1193, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(197, 409);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaSo
            // 
            this.MaSo.HeaderText = "Mã số";
            this.MaSo.MinimumWidth = 6;
            this.MaSo.Name = "MaSo";
            // 
            // HoTenBN
            // 
            this.HoTenBN.HeaderText = "Họ tên";
            this.HoTenBN.MinimumWidth = 6;
            this.HoTenBN.Name = "HoTenBN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1205, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 101;
            this.label9.Text = "Danh sách đăng ký";
            // 
            // txtDonGiaThuoc
            // 
            this.txtDonGiaThuoc.Location = new System.Drawing.Point(532, 116);
            this.txtDonGiaThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtDonGiaThuoc.Name = "txtDonGiaThuoc";
            this.txtDonGiaThuoc.Size = new System.Drawing.Size(119, 27);
            this.txtDonGiaThuoc.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(444, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 102;
            this.label12.Text = "Đơn giá:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(925, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 41);
            this.label13.TabIndex = 104;
            this.label13.Text = "Số bệnh nhân đang chờ";
            // 
            // txtSoBNcho
            // 
            this.txtSoBNcho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSoBNcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSoBNcho.Location = new System.Drawing.Point(1045, 160);
            this.txtSoBNcho.Margin = new System.Windows.Forms.Padding(1);
            this.txtSoBNcho.Multiline = true;
            this.txtSoBNcho.Name = "txtSoBNcho";
            this.txtSoBNcho.Size = new System.Drawing.Size(106, 41);
            this.txtSoBNcho.TabIndex = 105;
            // 
            // btnXongPKB
            // 
            this.btnXongPKB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXongPKB.Location = new System.Drawing.Point(794, 301);
            this.btnXongPKB.Name = "btnXongPKB";
            this.btnXongPKB.Size = new System.Drawing.Size(90, 40);
            this.btnXongPKB.TabIndex = 106;
            this.btnXongPKB.Text = "Xong";
            this.btnXongPKB.UseVisualStyleBackColor = false;
            // 
            // btnLuuPKB
            // 
            this.btnLuuPKB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLuuPKB.Location = new System.Drawing.Point(794, 255);
            this.btnLuuPKB.Name = "btnLuuPKB";
            this.btnLuuPKB.Size = new System.Drawing.Size(90, 40);
            this.btnLuuPKB.TabIndex = 107;
            this.btnLuuPKB.Text = "Lưu";
            this.btnLuuPKB.UseVisualStyleBackColor = false;
            // 
            // btnHuyPKB
            // 
            this.btnHuyPKB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHuyPKB.Location = new System.Drawing.Point(794, 348);
            this.btnHuyPKB.Name = "btnHuyPKB";
            this.btnHuyPKB.Size = new System.Drawing.Size(90, 40);
            this.btnHuyPKB.TabIndex = 108;
            this.btnHuyPKB.Text = "Hủy";
            this.btnHuyPKB.UseVisualStyleBackColor = false;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXem.Location = new System.Drawing.Point(794, 404);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(90, 40);
            this.btnXem.TabIndex = 109;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // gxb_Phieukhambenh
            // 
            this.gxb_Phieukhambenh.Controls.Add(this.txtDonGiaThuoc);
            this.gxb_Phieukhambenh.Controls.Add(this.txtHotenBN);
            this.gxb_Phieukhambenh.Controls.Add(this.label1);
            this.gxb_Phieukhambenh.Controls.Add(this.label5);
            this.gxb_Phieukhambenh.Controls.Add(this.label10);
            this.gxb_Phieukhambenh.Controls.Add(this.txtMaBN);
            this.gxb_Phieukhambenh.Controls.Add(this.label2);
            this.gxb_Phieukhambenh.Controls.Add(this.txtTrieuchungBenh);
            this.gxb_Phieukhambenh.Controls.Add(this.label12);
            this.gxb_Phieukhambenh.Controls.Add(this.label3);
            this.gxb_Phieukhambenh.Controls.Add(this.txtDudoanBenh);
            this.gxb_Phieukhambenh.Controls.Add(this.label4);
            this.gxb_Phieukhambenh.Controls.Add(this.txtDsThuoc);
            this.gxb_Phieukhambenh.Controls.Add(this.dtbNgayKB);
            this.gxb_Phieukhambenh.Controls.Add(this.label6);
            this.gxb_Phieukhambenh.Controls.Add(this.label11);
            this.gxb_Phieukhambenh.Controls.Add(this.txtDonviThuoc);
            this.gxb_Phieukhambenh.Controls.Add(this.txtThanhtien);
            this.gxb_Phieukhambenh.Controls.Add(this.label7);
            this.gxb_Phieukhambenh.Controls.Add(this.txtCachdungThuoc);
            this.gxb_Phieukhambenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gxb_Phieukhambenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxb_Phieukhambenh.Location = new System.Drawing.Point(104, 160);
            this.gxb_Phieukhambenh.Name = "gxb_Phieukhambenh";
            this.gxb_Phieukhambenh.Size = new System.Drawing.Size(664, 283);
            this.gxb_Phieukhambenh.TabIndex = 110;
            this.gxb_Phieukhambenh.TabStop = false;
            this.gxb_Phieukhambenh.Text = "Phiếu Khám Bệnh";
            // 
            // LapPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.gxb_Phieukhambenh);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnHuyPKB);
            this.Controls.Add(this.btnLuuPKB);
            this.Controls.Add(this.btnXongPKB);
            this.Controls.Add(this.txtSoBNcho);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvKB);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.lbDanhSachThuoc);
            this.Controls.Add(this.btnThemPKB);
            this.Controls.Add(this.Title);
            this.Name = "LapPhieuKhamBenh";
            this.Size = new System.Drawing.Size(1441, 776);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gxb_Phieukhambenh.ResumeLayout(false);
            this.gxb_Phieukhambenh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.DataGridView dgvKB;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Label lbDanhSachThuoc;
        private System.Windows.Forms.TextBox txtCachdungThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonviThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDsThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDudoanBenh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrieuchungBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Button btnThemPKB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotenBN;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DateTimePicker dtbNgayKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuocKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuocKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThuocKho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenBN;
        private System.Windows.Forms.TextBox txtDonGiaThuoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSoBNcho;
        private System.Windows.Forms.Button btnXongPKB;
        private System.Windows.Forms.Button btnLuuPKB;
        private System.Windows.Forms.Button btnHuyPKB;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox gxb_Phieukhambenh;
    }
}
