﻿namespace QuanLyPhongMachTu
{
    partial class fDoiThongTin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbb_chucvu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_ngaysinh = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.Email = new System.Windows.Forms.Label();
            this.txt_email = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_diachi = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lbl_Diachi = new System.Windows.Forms.Label();
            this.lbl_ChucVu = new System.Windows.Forms.Label();
            this.lbl_Ngaysinh = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_Hoten = new MetroSet_UI.Controls.MetroSetTextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lb_Doithongtin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.BackColor = System.Drawing.Color.Transparent;
            this.cbb_chucvu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_chucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_chucvu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_chucvu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_chucvu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_chucvu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_chucvu.ItemHeight = 30;
            this.cbb_chucvu.Location = new System.Drawing.Point(284, 235);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(187, 36);
            this.cbb_chucvu.TabIndex = 93;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Checked = true;
            this.dtp_ngaysinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dtp_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(63, 235);
            this.dtp_ngaysinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaysinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 36);
            this.dtp_ngaysinh.TabIndex = 92;
            this.dtp_ngaysinh.Value = new System.DateTime(2023, 6, 12, 1, 24, 52, 962);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(60, 373);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(50, 18);
            this.Email.TabIndex = 85;
            this.Email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.AutoCompleteCustomSource = null;
            this.txt_email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_email.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_email.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_email.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_email.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_email.Image = null;
            this.txt_email.IsDerivedStyle = true;
            this.txt_email.Lines = null;
            this.txt_email.Location = new System.Drawing.Point(63, 413);
            this.txt_email.MaxLength = 32767;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = false;
            this.txt_email.Size = new System.Drawing.Size(408, 43);
            this.txt_email.Style = MetroSet_UI.Enums.Style.Light;
            this.txt_email.StyleManager = null;
            this.txt_email.TabIndex = 84;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_email.ThemeAuthor = "Narwin";
            this.txt_email.ThemeName = "MetroLite";
            this.txt_email.UseSystemPasswordChar = false;
            this.txt_email.WatermarkText = "";
            // 
            // txt_diachi
            // 
            this.txt_diachi.AutoCompleteCustomSource = null;
            this.txt_diachi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_diachi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_diachi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_diachi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_diachi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_diachi.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_diachi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_diachi.Image = null;
            this.txt_diachi.IsDerivedStyle = true;
            this.txt_diachi.Lines = null;
            this.txt_diachi.Location = new System.Drawing.Point(63, 311);
            this.txt_diachi.MaxLength = 32767;
            this.txt_diachi.Multiline = false;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.ReadOnly = false;
            this.txt_diachi.Size = new System.Drawing.Size(408, 43);
            this.txt_diachi.Style = MetroSet_UI.Enums.Style.Light;
            this.txt_diachi.StyleManager = null;
            this.txt_diachi.TabIndex = 83;
            this.txt_diachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_diachi.ThemeAuthor = "Narwin";
            this.txt_diachi.ThemeName = "MetroLite";
            this.txt_diachi.UseSystemPasswordChar = false;
            this.txt_diachi.WatermarkText = "";
            // 
            // lbl_Diachi
            // 
            this.lbl_Diachi.AutoSize = true;
            this.lbl_Diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Diachi.Location = new System.Drawing.Point(60, 281);
            this.lbl_Diachi.Name = "lbl_Diachi";
            this.lbl_Diachi.Size = new System.Drawing.Size(63, 18);
            this.lbl_Diachi.TabIndex = 82;
            this.lbl_Diachi.Text = "Địa Chỉ";
            // 
            // lbl_ChucVu
            // 
            this.lbl_ChucVu.AutoSize = true;
            this.lbl_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChucVu.Location = new System.Drawing.Point(281, 202);
            this.lbl_ChucVu.Name = "lbl_ChucVu";
            this.lbl_ChucVu.Size = new System.Drawing.Size(78, 18);
            this.lbl_ChucVu.TabIndex = 80;
            this.lbl_ChucVu.Text = "Chức Vụ*";
            // 
            // lbl_Ngaysinh
            // 
            this.lbl_Ngaysinh.AutoSize = true;
            this.lbl_Ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ngaysinh.Location = new System.Drawing.Point(60, 202);
            this.lbl_Ngaysinh.Name = "lbl_Ngaysinh";
            this.lbl_Ngaysinh.Size = new System.Drawing.Size(91, 18);
            this.lbl_Ngaysinh.TabIndex = 78;
            this.lbl_Ngaysinh.Text = "Ngày Sinh*";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Huy.Location = new System.Drawing.Point(284, 509);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(118, 45);
            this.btn_Huy.TabIndex = 77;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Luu.Location = new System.Drawing.Point(131, 509);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(109, 45);
            this.btn_Luu.TabIndex = 76;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.AutoCompleteCustomSource = null;
            this.txt_Hoten.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Hoten.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Hoten.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_Hoten.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_Hoten.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_Hoten.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_Hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_Hoten.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_Hoten.Image = null;
            this.txt_Hoten.IsDerivedStyle = true;
            this.txt_Hoten.Lines = null;
            this.txt_Hoten.Location = new System.Drawing.Point(63, 142);
            this.txt_Hoten.MaxLength = 32767;
            this.txt_Hoten.Multiline = false;
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.ReadOnly = false;
            this.txt_Hoten.Size = new System.Drawing.Size(408, 43);
            this.txt_Hoten.Style = MetroSet_UI.Enums.Style.Light;
            this.txt_Hoten.StyleManager = null;
            this.txt_Hoten.TabIndex = 3;
            this.txt_Hoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Hoten.ThemeAuthor = "Narwin";
            this.txt_Hoten.ThemeName = "MetroLite";
            this.txt_Hoten.UseSystemPasswordChar = false;
            this.txt_Hoten.WatermarkText = "";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(60, 111);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(70, 18);
            this.lbl_HoTen.TabIndex = 1;
            this.lbl_HoTen.Text = "Họ Tên*";
            // 
            // lb_Doithongtin
            // 
            this.lb_Doithongtin.AutoSize = true;
            this.lb_Doithongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Doithongtin.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_Doithongtin.Location = new System.Drawing.Point(181, 42);
            this.lb_Doithongtin.Name = "lb_Doithongtin";
            this.lb_Doithongtin.Size = new System.Drawing.Size(234, 31);
            this.lb_Doithongtin.TabIndex = 0;
            this.lb_Doithongtin.Text = "ĐỔI THÔNG TIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.cbb_chucvu);
            this.panel1.Controls.Add(this.dtp_ngaysinh);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_diachi);
            this.panel1.Controls.Add(this.lbl_Diachi);
            this.panel1.Controls.Add(this.lbl_ChucVu);
            this.panel1.Controls.Add(this.lbl_Ngaysinh);
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.txt_Hoten);
            this.panel1.Controls.Add(this.lbl_HoTen);
            this.panel1.Controls.Add(this.lb_Doithongtin);
            this.panel1.Location = new System.Drawing.Point(285, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 635);
            this.panel1.TabIndex = 2;
            // 
            // fDoiThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1122, 807);
            this.Controls.Add(this.panel1);
            this.Name = "fDoiThongTin";
            this.Text = "Đổi Thông Tin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbb_chucvu;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label Email;
        private MetroSet_UI.Controls.MetroSetTextBox txt_email;
        private MetroSet_UI.Controls.MetroSetTextBox txt_diachi;
        private System.Windows.Forms.Label lbl_Diachi;
        private System.Windows.Forms.Label lbl_ChucVu;
        private System.Windows.Forms.Label lbl_Ngaysinh;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private MetroSet_UI.Controls.MetroSetTextBox txt_Hoten;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label lb_Doithongtin;
        private System.Windows.Forms.Panel panel1;
    }
}