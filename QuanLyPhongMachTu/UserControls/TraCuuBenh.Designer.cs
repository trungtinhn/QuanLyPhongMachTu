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
            this.dgvLoaiBenh = new System.Windows.Forms.DataGridView();
            this.btnTraCuuLoaiBenh = new System.Windows.Forms.Button();
            this.txtMaLoaiBenh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoaiBenh = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.btnLuuLoaiBenh = new System.Windows.Forms.Button();
            this.btnCapNhatLoaiBenh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBenh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrieuChungBenh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenLB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenLoaiThuoc = new System.Windows.Forms.TextBox();
            this.dgvBenh = new System.Windows.Forms.DataGridView();
            this.MaLoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrieuChungBenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraCuuBenh = new System.Windows.Forms.Button();
            this.btnCapNhatBenh = new System.Windows.Forms.Button();
            this.btnLuuBenh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiBenh
            // 
            this.dgvLoaiBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiBenh,
            this.TenLoaiBenh});
            this.dgvLoaiBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvLoaiBenh.Location = new System.Drawing.Point(518, 66);
            this.dgvLoaiBenh.Name = "dgvLoaiBenh";
            this.dgvLoaiBenh.RowHeadersVisible = false;
            this.dgvLoaiBenh.RowHeadersWidth = 49;
            this.dgvLoaiBenh.RowTemplate.Height = 24;
            this.dgvLoaiBenh.Size = new System.Drawing.Size(346, 139);
            this.dgvLoaiBenh.TabIndex = 68;
            // 
            // btnTraCuuLoaiBenh
            // 
            this.btnTraCuuLoaiBenh.Location = new System.Drawing.Point(96, 165);
            this.btnTraCuuLoaiBenh.Name = "btnTraCuuLoaiBenh";
            this.btnTraCuuLoaiBenh.Size = new System.Drawing.Size(82, 30);
            this.btnTraCuuLoaiBenh.TabIndex = 67;
            this.btnTraCuuLoaiBenh.Text = "Tra cứu";
            this.btnTraCuuLoaiBenh.UseVisualStyleBackColor = true;
            // 
            // txtMaLoaiBenh
            // 
            this.txtMaLoaiBenh.Location = new System.Drawing.Point(207, 94);
            this.txtMaLoaiBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaLoaiBenh.Name = "txtMaLoaiBenh";
            this.txtMaLoaiBenh.Size = new System.Drawing.Size(164, 22);
            this.txtMaLoaiBenh.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(102, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 65;
            this.label10.Text = "Mã loại bệnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tên loại bệnh:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTenLoaiBenh
            // 
            this.txtTenLoaiBenh.Location = new System.Drawing.Point(207, 128);
            this.txtTenLoaiBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenLoaiBenh.Name = "txtTenLoaiBenh";
            this.txtTenLoaiBenh.Size = new System.Drawing.Size(164, 22);
            this.txtTenLoaiBenh.TabIndex = 63;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Salmon;
            this.Title.Location = new System.Drawing.Point(298, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(416, 39);
            this.Title.TabIndex = 62;
            this.Title.Text = "THÔNG TIN LOẠI BỆNH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // btnLuuLoaiBenh
            // 
            this.btnLuuLoaiBenh.Location = new System.Drawing.Point(347, 165);
            this.btnLuuLoaiBenh.Name = "btnLuuLoaiBenh";
            this.btnLuuLoaiBenh.Size = new System.Drawing.Size(88, 30);
            this.btnLuuLoaiBenh.TabIndex = 69;
            this.btnLuuLoaiBenh.Text = "Lưu";
            this.btnLuuLoaiBenh.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatLoaiBenh
            // 
            this.btnCapNhatLoaiBenh.Location = new System.Drawing.Point(225, 165);
            this.btnCapNhatLoaiBenh.Name = "btnCapNhatLoaiBenh";
            this.btnCapNhatLoaiBenh.Size = new System.Drawing.Size(82, 30);
            this.btnCapNhatLoaiBenh.TabIndex = 70;
            this.btnCapNhatLoaiBenh.Text = "Cập nhật";
            this.btnCapNhatLoaiBenh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(331, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 39);
            this.label2.TabIndex = 71;
            this.label2.Text = "THÔNG TIN BỆNH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMaBenh
            // 
            this.txtMaBenh.Location = new System.Drawing.Point(207, 287);
            this.txtMaBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBenh.Name = "txtMaBenh";
            this.txtMaBenh.Size = new System.Drawing.Size(164, 22);
            this.txtMaBenh.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Mã bệnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Tên bệnh:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 321);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 77;
            this.label5.Text = "Triệu chứng:";
            // 
            // txtTrieuChungBenh
            // 
            this.txtTrieuChungBenh.Location = new System.Drawing.Point(207, 360);
            this.txtTrieuChungBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTrieuChungBenh.Name = "txtTrieuChungBenh";
            this.txtTrieuChungBenh.Size = new System.Drawing.Size(164, 22);
            this.txtTrieuChungBenh.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Tên loại bệnh:";
            // 
            // txtTenLB
            // 
            this.txtTenLB.Location = new System.Drawing.Point(514, 363);
            this.txtTenLB.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenLB.Name = "txtTenLB";
            this.txtTenLB.Size = new System.Drawing.Size(164, 22);
            this.txtTenLB.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tên thuốc:";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(514, 327);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(164, 22);
            this.txtTenThuoc.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(404, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 83;
            this.label8.Text = "Tên loại thuốc:";
            // 
            // txtTenLoaiThuoc
            // 
            this.txtTenLoaiThuoc.Location = new System.Drawing.Point(514, 293);
            this.txtTenLoaiThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenLoaiThuoc.Name = "txtTenLoaiThuoc";
            this.txtTenLoaiThuoc.Size = new System.Drawing.Size(164, 22);
            this.txtTenLoaiThuoc.TabIndex = 82;
            // 
            // dgvBenh
            // 
            this.dgvBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBenh,
            this.TenBenh,
            this.TrieuChungBenh,
            this.Thuoc,
            this.TenLB});
            this.dgvBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvBenh.Location = new System.Drawing.Point(144, 411);
            this.dgvBenh.Name = "dgvBenh";
            this.dgvBenh.RowHeadersVisible = false;
            this.dgvBenh.RowHeadersWidth = 49;
            this.dgvBenh.RowTemplate.Height = 24;
            this.dgvBenh.Size = new System.Drawing.Size(734, 139);
            this.dgvBenh.TabIndex = 84;
            // 
            // MaLoaiBenh
            // 
            this.MaLoaiBenh.HeaderText = "Mã loại bênh";
            this.MaLoaiBenh.MinimumWidth = 6;
            this.MaLoaiBenh.Name = "MaLoaiBenh";
            this.MaLoaiBenh.Width = 90;
            // 
            // TenLoaiBenh
            // 
            this.TenLoaiBenh.HeaderText = "Tên loại bệnh";
            this.TenLoaiBenh.MinimumWidth = 50;
            this.TenLoaiBenh.Name = "TenLoaiBenh";
            this.TenLoaiBenh.Width = 250;
            // 
            // MaBenh
            // 
            this.MaBenh.HeaderText = "Mã bệnh";
            this.MaBenh.MinimumWidth = 6;
            this.MaBenh.Name = "MaBenh";
            this.MaBenh.Width = 80;
            // 
            // TenBenh
            // 
            this.TenBenh.HeaderText = "Tên bệnh";
            this.TenBenh.MinimumWidth = 50;
            this.TenBenh.Name = "TenBenh";
            this.TenBenh.Width = 250;
            // 
            // TrieuChungBenh
            // 
            this.TrieuChungBenh.HeaderText = "Triệu chứng bệnh";
            this.TrieuChungBenh.MinimumWidth = 6;
            this.TrieuChungBenh.Name = "TrieuChungBenh";
            this.TrieuChungBenh.Width = 150;
            // 
            // Thuoc
            // 
            this.Thuoc.HeaderText = "Thuốc đặc trị";
            this.Thuoc.MinimumWidth = 6;
            this.Thuoc.Name = "Thuoc";
            this.Thuoc.Width = 150;
            // 
            // TenLB
            // 
            this.TenLB.HeaderText = "Tên loại bệnh";
            this.TenLB.MinimumWidth = 6;
            this.TenLB.Name = "TenLB";
            // 
            // btnTraCuuBenh
            // 
            this.btnTraCuuBenh.Location = new System.Drawing.Point(710, 289);
            this.btnTraCuuBenh.Name = "btnTraCuuBenh";
            this.btnTraCuuBenh.Size = new System.Drawing.Size(82, 30);
            this.btnTraCuuBenh.TabIndex = 85;
            this.btnTraCuuBenh.Text = "Tra cứu";
            this.btnTraCuuBenh.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatBenh
            // 
            this.btnCapNhatBenh.Location = new System.Drawing.Point(710, 327);
            this.btnCapNhatBenh.Name = "btnCapNhatBenh";
            this.btnCapNhatBenh.Size = new System.Drawing.Size(82, 30);
            this.btnCapNhatBenh.TabIndex = 86;
            this.btnCapNhatBenh.Text = "Cập nhật";
            this.btnCapNhatBenh.UseVisualStyleBackColor = true;
            // 
            // btnLuuBenh
            // 
            this.btnLuuBenh.Location = new System.Drawing.Point(710, 363);
            this.btnLuuBenh.Name = "btnLuuBenh";
            this.btnLuuBenh.Size = new System.Drawing.Size(82, 30);
            this.btnLuuBenh.TabIndex = 87;
            this.btnLuuBenh.Text = "Lưu";
            this.btnLuuBenh.UseVisualStyleBackColor = true;
            // 
            // TraCuuBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnLuuBenh);
            this.Controls.Add(this.btnCapNhatBenh);
            this.Controls.Add(this.btnTraCuuBenh);
            this.Controls.Add(this.dgvBenh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTenLoaiThuoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenThuoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTenLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTrieuChungBenh);
            this.Controls.Add(this.txtMaBenh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCapNhatLoaiBenh);
            this.Controls.Add(this.dgvLoaiBenh);
            this.Controls.Add(this.btnTraCuuLoaiBenh);
            this.Controls.Add(this.txtMaLoaiBenh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLoaiBenh);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnLuuLoaiBenh);
            this.Name = "TraCuuBenh";
            this.Size = new System.Drawing.Size(1000, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiBenh;
        private System.Windows.Forms.Button btnTraCuuLoaiBenh;
        private System.Windows.Forms.TextBox txtMaLoaiBenh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoaiBenh;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnLuuLoaiBenh;
        private System.Windows.Forms.Button btnCapNhatLoaiBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBenh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrieuChungBenh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenLB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenLoaiThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiBenh;
        private System.Windows.Forms.DataGridView dgvBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrieuChungBenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLB;
        private System.Windows.Forms.Button btnTraCuuBenh;
        private System.Windows.Forms.Button btnCapNhatBenh;
        private System.Windows.Forms.Button btnLuuBenh;
    }
}
