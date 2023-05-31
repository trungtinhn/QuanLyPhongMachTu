namespace QuanLyPhongMachTu.UserControls
{
    partial class TraCuuBenh
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
            this.label11 = new System.Windows.Forms.Label();
            this.NgayKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDanhSachThuoc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYearKB = new System.Windows.Forms.TextBox();
            this.txtMonthKB = new System.Windows.Forms.TextBox();
            this.txtDayKB = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(344, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 96;
            this.label11.Text = "Thành tiền:";
            // 
            // NgayKB
            // 
            this.NgayKB.HeaderText = "Ngày khám bệnh";
            this.NgayKB.MinimumWidth = 6;
            this.NgayKB.Name = "NgayKB";
            this.NgayKB.Width = 200;
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(420, 168);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(1);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(106, 22);
            this.txtThanhtien.TabIndex = 97;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 70;
            // 
            // MaBN
            // 
            this.MaBN.HeaderText = "Mã bệnh nhân";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            this.MaBN.Width = 180;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NgayKB,
            this.MaBN,
            this.MaBenh});
            this.dataGridView2.Location = new System.Drawing.Point(82, 337);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 49;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(635, 150);
            this.dataGridView2.TabIndex = 95;
            // 
            // MaBenh
            // 
            this.MaBenh.HeaderText = "Mã Bệnh";
            this.MaBenh.MinimumWidth = 6;
            this.MaBenh.Name = "MaBenh";
            this.MaBenh.Width = 180;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.SoLuongThuoc});
            this.dataGridView1.Location = new System.Drawing.Point(599, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(203, 193);
            this.dataGridView1.TabIndex = 94;
            // 
            // MaThuoc
            // 
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Width = 50;
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Width = 90;
            // 
            // SoLuongThuoc
            // 
            this.SoLuongThuoc.HeaderText = "Số Lượng";
            this.SoLuongThuoc.MinimumWidth = 6;
            this.SoLuongThuoc.Name = "SoLuongThuoc";
            this.SoLuongThuoc.Width = 60;
            // 
            // lbDanhSachThuoc
            // 
            this.lbDanhSachThuoc.AutoSize = true;
            this.lbDanhSachThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachThuoc.Location = new System.Drawing.Point(651, 50);
            this.lbDanhSachThuoc.Name = "lbDanhSachThuoc";
            this.lbDanhSachThuoc.Size = new System.Drawing.Size(106, 16);
            this.lbDanhSachThuoc.TabIndex = 93;
            this.lbDanhSachThuoc.Text = "Danh sách thuốc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(225, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 25);
            this.label8.TabIndex = 92;
            this.label8.Text = "/";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(175, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 25);
            this.label9.TabIndex = 91;
            this.label9.Text = "/";
            // 
            // txtYearKB
            // 
            this.txtYearKB.Location = new System.Drawing.Point(244, 164);
            this.txtYearKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtYearKB.Name = "txtYearKB";
            this.txtYearKB.Size = new System.Drawing.Size(37, 22);
            this.txtYearKB.TabIndex = 90;
            // 
            // txtMonthKB
            // 
            this.txtMonthKB.Location = new System.Drawing.Point(197, 164);
            this.txtMonthKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtMonthKB.Name = "txtMonthKB";
            this.txtMonthKB.Size = new System.Drawing.Size(26, 22);
            this.txtMonthKB.TabIndex = 89;
            // 
            // txtDayKB
            // 
            this.txtDayKB.Location = new System.Drawing.Point(148, 164);
            this.txtDayKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtDayKB.Name = "txtDayKB";
            this.txtDayKB.Size = new System.Drawing.Size(26, 22);
            this.txtDayKB.TabIndex = 88;
            // 
            // txtCachdungThuoc
            // 
            this.txtCachdungThuoc.Location = new System.Drawing.Point(420, 203);
            this.txtCachdungThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtCachdungThuoc.Multiline = true;
            this.txtCachdungThuoc.Name = "txtCachdungThuoc";
            this.txtCachdungThuoc.Size = new System.Drawing.Size(106, 22);
            this.txtCachdungThuoc.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 86;
            this.label7.Text = "Cách dùng:";
            // 
            // txtDonviThuoc
            // 
            this.txtDonviThuoc.Location = new System.Drawing.Point(420, 129);
            this.txtDonviThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtDonviThuoc.Name = "txtDonviThuoc";
            this.txtDonviThuoc.Size = new System.Drawing.Size(106, 22);
            this.txtDonviThuoc.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 84;
            this.label6.Text = "Số Lượng:";
            // 
            // txtDsThuoc
            // 
            this.txtDsThuoc.Location = new System.Drawing.Point(420, 95);
            this.txtDsThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtDsThuoc.Multiline = true;
            this.txtDsThuoc.Name = "txtDsThuoc";
            this.txtDsThuoc.Size = new System.Drawing.Size(106, 23);
            this.txtDsThuoc.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 82;
            this.label4.Text = "Danh sách thuốc:";
            // 
            // txtDudoanBenh
            // 
            this.txtDudoanBenh.Location = new System.Drawing.Point(148, 257);
            this.txtDudoanBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtDudoanBenh.Name = "txtDudoanBenh";
            this.txtDudoanBenh.Size = new System.Drawing.Size(141, 22);
            this.txtDudoanBenh.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "Dự đoán bệnh:";
            // 
            // txtTrieuchungBenh
            // 
            this.txtTrieuchungBenh.Location = new System.Drawing.Point(148, 200);
            this.txtTrieuchungBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTrieuchungBenh.Multiline = true;
            this.txtTrieuchungBenh.Name = "txtTrieuchungBenh";
            this.txtTrieuchungBenh.Size = new System.Drawing.Size(141, 26);
            this.txtTrieuchungBenh.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "Triệu chứng bệnh:";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(148, 92);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(141, 22);
            this.txtMaBN.TabIndex = 77;
            // 
            // btnThemPKB
            // 
            this.btnThemPKB.Location = new System.Drawing.Point(420, 250);
            this.btnThemPKB.Name = "btnThemPKB";
            this.btnThemPKB.Size = new System.Drawing.Size(75, 23);
            this.btnThemPKB.TabIndex = 75;
            this.btnThemPKB.Text = "Thêm";
            this.btnThemPKB.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "Mã bệnh nhân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ngày khám bệnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Họ và tên:";
            // 
            // txtHotenBN
            // 
            this.txtHotenBN.Location = new System.Drawing.Point(148, 126);
            this.txtHotenBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtHotenBN.Name = "txtHotenBN";
            this.txtHotenBN.Size = new System.Drawing.Size(141, 22);
            this.txtHotenBN.TabIndex = 72;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Salmon;
            this.Title.Location = new System.Drawing.Point(257, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(351, 39);
            this.Title.TabIndex = 71;
            this.Title.Text = "PHIẾU KHÁM BỆNH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TraCuuBenh
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtThanhtien);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbDanhSachThuoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYearKB);
            this.Controls.Add(this.txtMonthKB);
            this.Controls.Add(this.txtDayKB);
            this.Controls.Add(this.txtCachdungThuoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDonviThuoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDsThuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDudoanBenh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTrieuchungBenh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.btnThemPKB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHotenBN);
            this.Controls.Add(this.Title);
            this.Name = "TraCuuBenh";
            this.Size = new System.Drawing.Size(818, 495);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKB;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThuoc;
        private System.Windows.Forms.Label lbDanhSachThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYearKB;
        private System.Windows.Forms.TextBox txtMonthKB;
        private System.Windows.Forms.TextBox txtDayKB;
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
    }
}
