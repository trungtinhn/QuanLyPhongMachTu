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
            this.Title = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemPKB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHotenBN = new System.Windows.Forms.TextBox();
            this.txtTrieuchungBenh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDudoanBenh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDsThuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonviThuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCachdungThuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYearKB = new System.Windows.Forms.TextBox();
            this.txtMonthKB = new System.Windows.Forms.TextBox();
            this.txtDayKB = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lbxThongtinKB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Salmon;
            this.Title.Location = new System.Drawing.Point(252, 15);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(351, 39);
            this.Title.TabIndex = 2;
            this.Title.Text = "PHIẾU KHÁM BỆNH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(143, 100);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(141, 22);
            this.txtMaBN.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "Mã bệnh nhân:";
            // 
            // btnThemPKB
            // 
            this.btnThemPKB.Location = new System.Drawing.Point(573, 103);
            this.btnThemPKB.Name = "btnThemPKB";
            this.btnThemPKB.Size = new System.Drawing.Size(75, 23);
            this.btnThemPKB.TabIndex = 44;
            this.btnThemPKB.Text = "Thêm";
            this.btnThemPKB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Họ và tên:";
            // 
            // txtHotenBN
            // 
            this.txtHotenBN.Location = new System.Drawing.Point(143, 134);
            this.txtHotenBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtHotenBN.Name = "txtHotenBN";
            this.txtHotenBN.Size = new System.Drawing.Size(141, 22);
            this.txtHotenBN.TabIndex = 27;
            // 
            // txtTrieuchungBenh
            // 
            this.txtTrieuchungBenh.Location = new System.Drawing.Point(143, 208);
            this.txtTrieuchungBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTrieuchungBenh.Multiline = true;
            this.txtTrieuchungBenh.Name = "txtTrieuchungBenh";
            this.txtTrieuchungBenh.Size = new System.Drawing.Size(141, 41);
            this.txtTrieuchungBenh.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Triệu chứng bệnh:";
            // 
            // txtDudoanBenh
            // 
            this.txtDudoanBenh.Location = new System.Drawing.Point(143, 265);
            this.txtDudoanBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtDudoanBenh.Name = "txtDudoanBenh";
            this.txtDudoanBenh.Size = new System.Drawing.Size(141, 22);
            this.txtDudoanBenh.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Dự đoán bệnh:";
            // 
            // txtDsThuoc
            // 
            this.txtDsThuoc.Location = new System.Drawing.Point(415, 103);
            this.txtDsThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtDsThuoc.Multiline = true;
            this.txtDsThuoc.Name = "txtDsThuoc";
            this.txtDsThuoc.Size = new System.Drawing.Size(135, 53);
            this.txtDsThuoc.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Danh sách thuốc:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDonviThuoc
            // 
            this.txtDonviThuoc.Location = new System.Drawing.Point(415, 169);
            this.txtDonviThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtDonviThuoc.Name = "txtDonviThuoc";
            this.txtDonviThuoc.Size = new System.Drawing.Size(135, 22);
            this.txtDonviThuoc.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Đơn vị:";
            // 
            // txtCachdungThuoc
            // 
            this.txtCachdungThuoc.Location = new System.Drawing.Point(415, 208);
            this.txtCachdungThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtCachdungThuoc.Multiline = true;
            this.txtCachdungThuoc.Name = "txtCachdungThuoc";
            this.txtCachdungThuoc.Size = new System.Drawing.Size(135, 22);
            this.txtCachdungThuoc.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Cách dùng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ngày khám bệnh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(225, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 25);
            this.label8.TabIndex = 63;
            this.label8.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(173, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 25);
            this.label9.TabIndex = 62;
            this.label9.Text = "/";
            // 
            // txtYearKB
            // 
            this.txtYearKB.Location = new System.Drawing.Point(247, 172);
            this.txtYearKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtYearKB.Name = "txtYearKB";
            this.txtYearKB.Size = new System.Drawing.Size(37, 22);
            this.txtYearKB.TabIndex = 61;
            // 
            // txtMonthKB
            // 
            this.txtMonthKB.Location = new System.Drawing.Point(195, 172);
            this.txtMonthKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtMonthKB.Name = "txtMonthKB";
            this.txtMonthKB.Size = new System.Drawing.Size(26, 22);
            this.txtMonthKB.TabIndex = 60;
            // 
            // txtDayKB
            // 
            this.txtDayKB.Location = new System.Drawing.Point(143, 172);
            this.txtDayKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtDayKB.Name = "txtDayKB";
            this.txtDayKB.Size = new System.Drawing.Size(26, 22);
            this.txtDayKB.TabIndex = 59;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(696, 330);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 162);
            this.vScrollBar1.TabIndex = 65;
            // 
            // lbxThongtinKB
            // 
            this.lbxThongtinKB.FormattingEnabled = true;
            this.lbxThongtinKB.ItemHeight = 16;
            this.lbxThongtinKB.Location = new System.Drawing.Point(27, 328);
            this.lbxThongtinKB.Name = "lbxThongtinKB";
            this.lbxThongtinKB.Size = new System.Drawing.Size(689, 164);
            this.lbxThongtinKB.TabIndex = 64;
            // 
            // LapPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.lbxThongtinKB);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnThemPKB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHotenBN);
            this.Controls.Add(this.Title);
            this.Name = "LapPhieuKhamBenh";
            this.Size = new System.Drawing.Size(818, 495);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThemPKB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotenBN;
        private System.Windows.Forms.TextBox txtTrieuchungBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDudoanBenh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDsThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonviThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCachdungThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYearKB;
        private System.Windows.Forms.TextBox txtMonthKB;
        private System.Windows.Forms.TextBox txtDayKB;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListBox lbxThongtinKB;
    }
}
