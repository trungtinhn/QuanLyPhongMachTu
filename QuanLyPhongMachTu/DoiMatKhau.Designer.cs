﻿using System.Security.Cryptography.X509Certificates;

namespace QuanLyPhongMachTu
{
    partial class fDoiMatKhau
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_xacnhanmkmoi = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_mkmoi = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_mk = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Matkhauhientai = new System.Windows.Forms.Label();
            this.lbl_Doimatkhau = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.txt_xacnhanmkmoi);
            this.panel1.Controls.Add(this.txt_mkmoi);
            this.panel1.Controls.Add(this.txt_mk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Matkhauhientai);
            this.panel1.Controls.Add(this.lbl_Doimatkhau);
            this.panel1.Location = new System.Drawing.Point(165, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 391);
            this.panel1.TabIndex = 0;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Huy.Location = new System.Drawing.Point(190, 315);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(88, 37);
            this.btn_Huy.TabIndex = 77;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Luu.Location = new System.Drawing.Point(70, 315);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(82, 37);
            this.btn_Luu.TabIndex = 76;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_xacnhanmkmoi
            // 
            this.txt_xacnhanmkmoi.AutoCompleteCustomSource = null;
            this.txt_xacnhanmkmoi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_xacnhanmkmoi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_xacnhanmkmoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_xacnhanmkmoi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_xacnhanmkmoi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_xacnhanmkmoi.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_xacnhanmkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_xacnhanmkmoi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_xacnhanmkmoi.Image = null;
            this.txt_xacnhanmkmoi.IsDerivedStyle = true;
            this.txt_xacnhanmkmoi.Lines = null;
            this.txt_xacnhanmkmoi.Location = new System.Drawing.Point(47, 253);
            this.txt_xacnhanmkmoi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_xacnhanmkmoi.MaxLength = 32767;
            this.txt_xacnhanmkmoi.Multiline = false;
            this.txt_xacnhanmkmoi.Name = "txt_xacnhanmkmoi";
            this.txt_xacnhanmkmoi.ReadOnly = false;
            this.txt_xacnhanmkmoi.Size = new System.Drawing.Size(244, 38);
            this.txt_xacnhanmkmoi.Style = MetroSet_UI.Enums.Style.Light;
            this.txt_xacnhanmkmoi.StyleManager = null;
            this.txt_xacnhanmkmoi.TabIndex = 5;
            this.txt_xacnhanmkmoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_xacnhanmkmoi.ThemeAuthor = "Narwin";
            this.txt_xacnhanmkmoi.ThemeName = "MetroLite";
            this.txt_xacnhanmkmoi.UseSystemPasswordChar = false;
            this.txt_xacnhanmkmoi.WatermarkText = "";
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.AutoCompleteCustomSource = null;
            this.txt_mkmoi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_mkmoi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_mkmoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_mkmoi.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_mkmoi.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_mkmoi.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_mkmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_mkmoi.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_mkmoi.Image = null;
            this.txt_mkmoi.IsDerivedStyle = true;
            this.txt_mkmoi.Lines = null;
            this.txt_mkmoi.Location = new System.Drawing.Point(47, 201);
            this.txt_mkmoi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mkmoi.MaxLength = 32767;
            this.txt_mkmoi.Multiline = false;
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.ReadOnly = false;
            this.txt_mkmoi.Size = new System.Drawing.Size(244, 38);
            this.txt_mkmoi.Style = MetroSet_UI.Enums.Style.Light;
            this.txt_mkmoi.StyleManager = null;
            this.txt_mkmoi.TabIndex = 4;
            this.txt_mkmoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_mkmoi.ThemeAuthor = "Narwin";
            this.txt_mkmoi.ThemeName = "MetroLite";
            this.txt_mkmoi.UseSystemPasswordChar = false;
            this.txt_mkmoi.WatermarkText = "";
            // 
            // txt_mk
            // 
            this.txt_mk.AutoCompleteCustomSource = null;
            this.txt_mk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_mk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_mk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_mk.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_mk.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_mk.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_mk.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_mk.Image = null;
            this.txt_mk.IsDerivedStyle = true;
            this.txt_mk.Lines = null;
            this.txt_mk.Location = new System.Drawing.Point(47, 115);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mk.MaxLength = 32767;
            this.txt_mk.Multiline = false;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.ReadOnly = false;
            this.txt_mk.Size = new System.Drawing.Size(244, 38);
            this.txt_mk.Style = MetroSet_UI.Enums.Style.Light;
            this.txt_mk.StyleManager = null;
            this.txt_mk.TabIndex = 3;
            this.txt_mk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_mk.ThemeAuthor = "Narwin";
            this.txt_mk.ThemeName = "MetroLite";
            this.txt_mk.UseSystemPasswordChar = false;
            this.txt_mk.WatermarkText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập và xác nhận mật khẩu mới*";
            // 
            // lbl_Matkhauhientai
            // 
            this.lbl_Matkhauhientai.AutoSize = true;
            this.lbl_Matkhauhientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matkhauhientai.Location = new System.Drawing.Point(45, 90);
            this.lbl_Matkhauhientai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Matkhauhientai.Name = "lbl_Matkhauhientai";
            this.lbl_Matkhauhientai.Size = new System.Drawing.Size(111, 13);
            this.lbl_Matkhauhientai.TabIndex = 1;
            this.lbl_Matkhauhientai.Text = "Mật khẩu hiện tại*";
            // 
            // lbl_Doimatkhau
            // 
            this.lbl_Doimatkhau.AutoSize = true;
            this.lbl_Doimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doimatkhau.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_Doimatkhau.Location = new System.Drawing.Point(100, 38);
            this.lbl_Doimatkhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Doimatkhau.Name = "lbl_Doimatkhau";
            this.lbl_Doimatkhau.Size = new System.Drawing.Size(157, 24);
            this.lbl_Doimatkhau.TabIndex = 0;
            this.lbl_Doimatkhau.Text = "ĐỔI MẬT KHẨU";
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(700, 495);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDoiMatKhau";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_Doimatkhau;
        public System.Windows.Forms.Label lbl_Matkhauhientai;
        public MetroSet_UI.Controls.MetroSetTextBox txt_xacnhanmkmoi;
        public MetroSet_UI.Controls.MetroSetTextBox txt_mkmoi;
        public MetroSet_UI.Controls.MetroSetTextBox txt_mk;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_Huy;
        public System.Windows.Forms.Button btn_Luu;
    }
}