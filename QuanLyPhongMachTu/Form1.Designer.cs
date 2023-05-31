using System.Drawing;

namespace QuanLyPhongMachTu
{
    partial class Form1
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_QuanLyPhongMachTu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Quidinh = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Baocao = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Nhapthuoc = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Donvi_Cachdung = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Thuoc_LoaiThuoc = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Benh_LoaiBenh = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Phieukhambenh = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Benhnhan = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Taikhoan = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.PeachPuff;
            this.panel_top.Controls.Add(this.lbl_QuanLyPhongMachTu);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1474, 74);
            this.panel_top.TabIndex = 0;
            // 
            // lbl_QuanLyPhongMachTu
            // 
            this.lbl_QuanLyPhongMachTu.AutoSize = true;
            this.lbl_QuanLyPhongMachTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.02985F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuanLyPhongMachTu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_QuanLyPhongMachTu.Location = new System.Drawing.Point(732, 9);
            this.lbl_QuanLyPhongMachTu.Name = "lbl_QuanLyPhongMachTu";
            this.lbl_QuanLyPhongMachTu.Size = new System.Drawing.Size(560, 47);
            this.lbl_QuanLyPhongMachTu.TabIndex = 0;
            this.lbl_QuanLyPhongMachTu.Text = "QUẢN LÝ PHÒNG MẠCH TƯ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btn_Taikhoan);
            this.panel1.Controls.Add(this.btn_Quidinh);
            this.panel1.Controls.Add(this.btn_Baocao);
            this.panel1.Controls.Add(this.btn_Nhapthuoc);
            this.panel1.Controls.Add(this.btn_Donvi_Cachdung);
            this.panel1.Controls.Add(this.btn_Thuoc_LoaiThuoc);
            this.panel1.Controls.Add(this.btn_Benh_LoaiBenh);
            this.panel1.Controls.Add(this.btn_Phieukhambenh);
            this.panel1.Controls.Add(this.btn_Benhnhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 978);
            this.panel1.TabIndex = 1;
            // 
            // btn_Quidinh
            // 
            this.btn_Quidinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Quidinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Quidinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Quidinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Quidinh.FillColor = System.Drawing.Color.PeachPuff;
            this.btn_Quidinh.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quidinh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Quidinh.Image = global::QuanLyPhongMachTu.Properties.Resources.regulation;
            this.btn_Quidinh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Quidinh.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Quidinh.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Quidinh.Location = new System.Drawing.Point(8, 594);
            this.btn_Quidinh.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_Quidinh.Name = "btn_Quidinh";
            this.btn_Quidinh.Padding = new System.Windows.Forms.Padding(60, 0, 20, 40);
            this.btn_Quidinh.Size = new System.Drawing.Size(247, 73);
            this.btn_Quidinh.TabIndex = 18;
            this.btn_Quidinh.Text = "Qui Định";
            this.btn_Quidinh.Click += new System.EventHandler(this.btn_Quidinh_Click);
            // 
            // btn_Baocao
            // 
            this.btn_Baocao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Baocao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Baocao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Baocao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Baocao.FillColor = System.Drawing.Color.PeachPuff;
            this.btn_Baocao.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baocao.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Baocao.Image = global::QuanLyPhongMachTu.Properties.Resources.report;
            this.btn_Baocao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Baocao.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Baocao.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Baocao.Location = new System.Drawing.Point(12, 517);
            this.btn_Baocao.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_Baocao.Name = "btn_Baocao";
            this.btn_Baocao.Padding = new System.Windows.Forms.Padding(60, 0, 20, 40);
            this.btn_Baocao.Size = new System.Drawing.Size(247, 73);
            this.btn_Baocao.TabIndex = 17;
            this.btn_Baocao.Text = "Báo Cáo";
            this.btn_Baocao.Click += new System.EventHandler(this.btn_Baocao_Click);
            // 
            // btn_Nhapthuoc
            // 
            this.btn_Nhapthuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Nhapthuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Nhapthuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Nhapthuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Nhapthuoc.FillColor = System.Drawing.Color.PeachPuff;
            this.btn_Nhapthuoc.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhapthuoc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Nhapthuoc.Image = global::QuanLyPhongMachTu.Properties.Resources.packaging;
            this.btn_Nhapthuoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Nhapthuoc.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Nhapthuoc.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Nhapthuoc.Location = new System.Drawing.Point(8, 440);
            this.btn_Nhapthuoc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_Nhapthuoc.Name = "btn_Nhapthuoc";
            this.btn_Nhapthuoc.Padding = new System.Windows.Forms.Padding(60, 0, 20, 40);
            this.btn_Nhapthuoc.Size = new System.Drawing.Size(247, 73);
            this.btn_Nhapthuoc.TabIndex = 16;
            this.btn_Nhapthuoc.Text = "Nhập Thuốc";
            this.btn_Nhapthuoc.Click += new System.EventHandler(this.btn_Nhapthuoc_Click);
            // 
            // btn_Donvi_Cachdung
            // 
            this.btn_Donvi_Cachdung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Donvi_Cachdung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Donvi_Cachdung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Donvi_Cachdung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Donvi_Cachdung.FillColor = System.Drawing.Color.PeachPuff;
            this.btn_Donvi_Cachdung.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Donvi_Cachdung.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Donvi_Cachdung.Image = global::QuanLyPhongMachTu.Properties.Resources.settings;
            this.btn_Donvi_Cachdung.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Donvi_Cachdung.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Donvi_Cachdung.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Donvi_Cachdung.Location = new System.Drawing.Point(8, 342);
            this.btn_Donvi_Cachdung.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_Donvi_Cachdung.Name = "btn_Donvi_Cachdung";
            this.btn_Donvi_Cachdung.Padding = new System.Windows.Forms.Padding(60, 0, 20, 20);
            this.btn_Donvi_Cachdung.Size = new System.Drawing.Size(247, 94);
            this.btn_Donvi_Cachdung.TabIndex = 15;
            this.btn_Donvi_Cachdung.Text = "Đơn vị - Cách dùng";
            this.btn_Donvi_Cachdung.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Donvi_Cachdung.Click += new System.EventHandler(this.btn_Donvi_Cachdung_Click);
            // 
            // btn_Thuoc_LoaiThuoc
            // 
            this.btn_Thuoc_LoaiThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thuoc_LoaiThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thuoc_LoaiThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thuoc_LoaiThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Thuoc_LoaiThuoc.FillColor = System.Drawing.Color.PeachPuff;
            this.btn_Thuoc_LoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold);
            this.btn_Thuoc_LoaiThuoc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Thuoc_LoaiThuoc.Image = global::QuanLyPhongMachTu.Properties.Resources.medicine;
            this.btn_Thuoc_LoaiThuoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Thuoc_LoaiThuoc.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Thuoc_LoaiThuoc.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Thuoc_LoaiThuoc.Location = new System.Drawing.Point(8, 253);
            this.btn_Thuoc_LoaiThuoc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_Thuoc_LoaiThuoc.Name = "btn_Thuoc_LoaiThuoc";
            this.btn_Thuoc_LoaiThuoc.Padding = new System.Windows.Forms.Padding(60, 0, 20, 20);
            this.btn_Thuoc_LoaiThuoc.Size = new System.Drawing.Size(247, 94);
            this.btn_Thuoc_LoaiThuoc.TabIndex = 14;
            this.btn_Thuoc_LoaiThuoc.Text = "Thuốc - Loại Thuốc";
            this.btn_Thuoc_LoaiThuoc.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Thuoc_LoaiThuoc.Click += new System.EventHandler(this.btn_Thuoc_LoaiThuoc_Click);
            // 
            // btn_Benh_LoaiBenh
            // 
            this.btn_Benh_LoaiBenh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benh_LoaiBenh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benh_LoaiBenh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Benh_LoaiBenh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Benh_LoaiBenh.FillColor = System.Drawing.Color.PeachPuff;
            this.btn_Benh_LoaiBenh.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Benh_LoaiBenh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Benh_LoaiBenh.Image = global::QuanLyPhongMachTu.Properties.Resources.antibody;
            this.btn_Benh_LoaiBenh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Benh_LoaiBenh.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Benh_LoaiBenh.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Benh_LoaiBenh.Location = new System.Drawing.Point(12, 164);
            this.btn_Benh_LoaiBenh.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_Benh_LoaiBenh.Name = "btn_Benh_LoaiBenh";
            this.btn_Benh_LoaiBenh.Padding = new System.Windows.Forms.Padding(60, 0, 20, 20);
            this.btn_Benh_LoaiBenh.Size = new System.Drawing.Size(247, 96);
            this.btn_Benh_LoaiBenh.TabIndex = 13;
            this.btn_Benh_LoaiBenh.Text = "Bệnh - Loại Bệnh";
            this.btn_Benh_LoaiBenh.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Benh_LoaiBenh.Click += new System.EventHandler(this.btn_Benh_LoaiBenh_Click);
            // 
            // btn_Phieukhambenh
            // 
            this.btn_Phieukhambenh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Phieukhambenh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Phieukhambenh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Phieukhambenh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Phieukhambenh.FillColor = System.Drawing.Color.PeachPuff;
            this.btn_Phieukhambenh.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phieukhambenh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Phieukhambenh.Image = global::QuanLyPhongMachTu.Properties.Resources.phieukhambenh;
            this.btn_Phieukhambenh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Phieukhambenh.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Phieukhambenh.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Phieukhambenh.Location = new System.Drawing.Point(8, 74);
            this.btn_Phieukhambenh.Margin = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.btn_Phieukhambenh.Name = "btn_Phieukhambenh";
            this.btn_Phieukhambenh.Padding = new System.Windows.Forms.Padding(70, 0, 20, 20);
            this.btn_Phieukhambenh.Size = new System.Drawing.Size(247, 86);
            this.btn_Phieukhambenh.TabIndex = 12;
            this.btn_Phieukhambenh.Text = "Phiếu Khám Bệnh";
            this.btn_Phieukhambenh.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Phieukhambenh.Click += new System.EventHandler(this.btn_Phieukhambenh_Click);
            // 
            // btn_Benhnhan
            // 
            this.btn_Benhnhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benhnhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benhnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Benhnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Benhnhan.FillColor = System.Drawing.Color.PeachPuff;
            this.btn_Benhnhan.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Benhnhan.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Benhnhan.Image = global::QuanLyPhongMachTu.Properties.Resources.male_nurse;
            this.btn_Benhnhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Benhnhan.ImageOffset = new System.Drawing.Point(0, 25);
            this.btn_Benhnhan.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Benhnhan.Location = new System.Drawing.Point(8, 0);
            this.btn_Benhnhan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_Benhnhan.Name = "btn_Benhnhan";
            this.btn_Benhnhan.Padding = new System.Windows.Forms.Padding(60, 0, 20, 40);
            this.btn_Benhnhan.Size = new System.Drawing.Size(247, 72);
            this.btn_Benhnhan.TabIndex = 2;
            this.btn_Benhnhan.Text = "Bệnh Nhân";
            this.btn_Benhnhan.Click += new System.EventHandler(this.btn_Benhnhan_Click);
            // 
            // btn_Taikhoan
            // 
            this.btn_Taikhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Taikhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Taikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Taikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Taikhoan.FillColor = System.Drawing.Color.PeachPuff;
            this.btn_Taikhoan.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Taikhoan.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Taikhoan.Image = global::QuanLyPhongMachTu.Properties.Resources.regulation;
            this.btn_Taikhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Taikhoan.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Taikhoan.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Taikhoan.Location = new System.Drawing.Point(12, 671);
            this.btn_Taikhoan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_Taikhoan.Name = "btn_Taikhoan";
            this.btn_Taikhoan.Padding = new System.Windows.Forms.Padding(60, 0, 20, 40);
            this.btn_Taikhoan.Size = new System.Drawing.Size(247, 73);
            this.btn_Taikhoan.TabIndex = 19;
            this.btn_Taikhoan.Text = "Tài Khoản";
            this.btn_Taikhoan.Click += new System.EventHandler(this.btn_Taikhoan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 1052);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Quản Lý Phòng Mạch ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TileButton btn_Benhnhan;
        private System.Windows.Forms.Label lbl_QuanLyPhongMachTu;
        private Guna.UI2.WinForms.Guna2TileButton btn_Thuoc_LoaiThuoc;
        private Guna.UI2.WinForms.Guna2TileButton btn_Benh_LoaiBenh;
        private Guna.UI2.WinForms.Guna2TileButton btn_Phieukhambenh;
        private Guna.UI2.WinForms.Guna2TileButton btn_Donvi_Cachdung;
        private Guna.UI2.WinForms.Guna2TileButton btn_Nhapthuoc;
        private Guna.UI2.WinForms.Guna2TileButton btn_Baocao;
        private Guna.UI2.WinForms.Guna2TileButton btn_Quidinh;
        private Guna.UI2.WinForms.Guna2TileButton btn_Taikhoan;
    }
}

