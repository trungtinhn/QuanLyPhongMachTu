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
            this.Title = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbxThongtinBN = new System.Windows.Forms.ListBox();
            this.txtHotenBN = new System.Windows.Forms.TextBox();
            this.txtDayBN = new System.Windows.Forms.TextBox();
            this.txtDiachiBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonthBN = new System.Windows.Forms.TextBox();
            this.txtYearBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYearKB = new System.Windows.Forms.TextBox();
            this.txtMonthKB = new System.Windows.Forms.TextBox();
            this.txtDayKB = new System.Windows.Forms.TextBox();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.btnNamBN = new System.Windows.Forms.CheckBox();
            this.btnNuBN = new System.Windows.Forms.CheckBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoBNtiepnhan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Salmon;
            this.Title.Location = new System.Drawing.Point(196, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(452, 39);
            this.Title.TabIndex = 1;
            this.Title.Text = "DANH SÁCH KHÁM BỆNH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbxThongtinBN
            // 
            this.lbxThongtinBN.FormattingEnabled = true;
            this.lbxThongtinBN.ItemHeight = 16;
            this.lbxThongtinBN.Location = new System.Drawing.Point(15, 330);
            this.lbxThongtinBN.Name = "lbxThongtinBN";
            this.lbxThongtinBN.Size = new System.Drawing.Size(689, 164);
            this.lbxThongtinBN.TabIndex = 2;
            this.lbxThongtinBN.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtHotenBN
            // 
            this.txtHotenBN.Location = new System.Drawing.Point(170, 133);
            this.txtHotenBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtHotenBN.Name = "txtHotenBN";
            this.txtHotenBN.Size = new System.Drawing.Size(164, 22);
            this.txtHotenBN.TabIndex = 3;
            // 
            // txtDayBN
            // 
            this.txtDayBN.Location = new System.Drawing.Point(170, 166);
            this.txtDayBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtDayBN.Name = "txtDayBN";
            this.txtDayBN.Size = new System.Drawing.Size(26, 22);
            this.txtDayBN.TabIndex = 4;
            // 
            // txtDiachiBN
            // 
            this.txtDiachiBN.Location = new System.Drawing.Point(170, 239);
            this.txtDiachiBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtDiachiBN.Name = "txtDiachiBN";
            this.txtDiachiBN.Size = new System.Drawing.Size(164, 22);
            this.txtDiachiBN.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ và tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày/Tháng/Năm sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày khám bệnh:";
            // 
            // txtMonthBN
            // 
            this.txtMonthBN.Location = new System.Drawing.Point(222, 166);
            this.txtMonthBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMonthBN.Name = "txtMonthBN";
            this.txtMonthBN.Size = new System.Drawing.Size(26, 22);
            this.txtMonthBN.TabIndex = 12;
            // 
            // txtYearBN
            // 
            this.txtYearBN.Location = new System.Drawing.Point(274, 166);
            this.txtYearBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtYearBN.Name = "txtYearBN";
            this.txtYearBN.Size = new System.Drawing.Size(60, 22);
            this.txtYearBN.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(200, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(252, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(252, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(200, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "/";
            // 
            // txtYearKB
            // 
            this.txtYearKB.Location = new System.Drawing.Point(274, 271);
            this.txtYearKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtYearKB.Name = "txtYearKB";
            this.txtYearKB.Size = new System.Drawing.Size(60, 22);
            this.txtYearKB.TabIndex = 18;
            // 
            // txtMonthKB
            // 
            this.txtMonthKB.Location = new System.Drawing.Point(222, 271);
            this.txtMonthKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtMonthKB.Name = "txtMonthKB";
            this.txtMonthKB.Size = new System.Drawing.Size(26, 22);
            this.txtMonthKB.TabIndex = 17;
            // 
            // txtDayKB
            // 
            this.txtDayKB.Location = new System.Drawing.Point(170, 271);
            this.txtDayKB.Margin = new System.Windows.Forms.Padding(1);
            this.txtDayKB.Name = "txtDayKB";
            this.txtDayKB.Size = new System.Drawing.Size(26, 22);
            this.txtDayKB.TabIndex = 16;
            // 
            // btnThemBN
            // 
            this.btnThemBN.Location = new System.Drawing.Point(381, 99);
            this.btnThemBN.Name = "btnThemBN";
            this.btnThemBN.Size = new System.Drawing.Size(75, 23);
            this.btnThemBN.TabIndex = 21;
            this.btnThemBN.Text = "Thêm";
            this.btnThemBN.UseVisualStyleBackColor = true;
            // 
            // btnNamBN
            // 
            this.btnNamBN.AutoSize = true;
            this.btnNamBN.Location = new System.Drawing.Point(170, 204);
            this.btnNamBN.Name = "btnNamBN";
            this.btnNamBN.Size = new System.Drawing.Size(55, 20);
            this.btnNamBN.TabIndex = 22;
            this.btnNamBN.Text = "Nam";
            this.btnNamBN.UseVisualStyleBackColor = true;
            this.btnNamBN.CheckedChanged += new System.EventHandler(this.btnNamBN_CheckedChanged);
            // 
            // btnNuBN
            // 
            this.btnNuBN.AutoSize = true;
            this.btnNuBN.Location = new System.Drawing.Point(257, 204);
            this.btnNuBN.Name = "btnNuBN";
            this.btnNuBN.Size = new System.Drawing.Size(43, 20);
            this.btnNuBN.TabIndex = 23;
            this.btnNuBN.Text = "Nữ";
            this.btnNuBN.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(684, 331);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 164);
            this.vScrollBar1.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã bệnh nhân:";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(170, 99);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(164, 22);
            this.txtMaBN.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(473, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 57);
            this.label11.TabIndex = 27;
            this.label11.Text = "SỐ BỆNH NHÂN SẼ ĐƯỢC TIẾP NHẬN TRONG NGÀY";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtSoBNtiepnhan
            // 
            this.txtSoBNtiepnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSoBNtiepnhan.CausesValidation = false;
            this.txtSoBNtiepnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSoBNtiepnhan.Location = new System.Drawing.Point(555, 172);
            this.txtSoBNtiepnhan.Name = "txtSoBNtiepnhan";
            this.txtSoBNtiepnhan.ReadOnly = true;
            this.txtSoBNtiepnhan.Size = new System.Drawing.Size(131, 35);
            this.txtSoBNtiepnhan.TabIndex = 28;
            // 
            // DanhSachKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txtSoBNtiepnhan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnNuBN);
            this.Controls.Add(this.btnNamBN);
            this.Controls.Add(this.btnThemBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYearKB);
            this.Controls.Add(this.txtMonthKB);
            this.Controls.Add(this.txtDayKB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYearBN);
            this.Controls.Add(this.txtMonthBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiachiBN);
            this.Controls.Add(this.txtDayBN);
            this.Controls.Add(this.txtHotenBN);
            this.Controls.Add(this.lbxThongtinBN);
            this.Controls.Add(this.Title);
            this.Name = "DanhSachKhamBenh";
            this.Size = new System.Drawing.Size(818, 495);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox lbxThongtinBN;
        private System.Windows.Forms.TextBox txtHotenBN;
        private System.Windows.Forms.TextBox txtDayBN;
        private System.Windows.Forms.TextBox txtDiachiBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonthBN;
        private System.Windows.Forms.TextBox txtYearBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYearKB;
        private System.Windows.Forms.TextBox txtMonthKB;
        private System.Windows.Forms.TextBox txtDayKB;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.CheckBox btnNamBN;
        private System.Windows.Forms.CheckBox btnNuBN;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoBNtiepnhan;
    }
}
