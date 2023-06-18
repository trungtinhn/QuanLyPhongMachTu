﻿using Guna.UI2.WinForms;
using QuanLyPhongMachTu.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyPhongMachTu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(1890, 1060);
            this.MaximumSize = new System.Drawing.Size(1890, 1060);

        }
        Boolean check = true;

        private void btn_Benhnhan_Click(object sender, EventArgs e)
        {
            u_danhSachKhamBenh.BringToFront();

            //DoiMau
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Phieukhambenh_Click(object sender, EventArgs e)
        {
            u_lapPhieuKhamBenh.BringToFront();

            //DoiMau
            ChangeNormalColorOnPanelLeft(sender);

        }

        private void btn_Benh_LoaiBenh_Click(object sender, EventArgs e)
        {

            u_BenhLoaiBenh.BringToFront();

            //DoiMau
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Thuoc_LoaiThuoc_Click(object sender, EventArgs e)
        {
            u_loaiThuocThuoc.BringToFront();

            //DoiMau
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Donvi_Cachdung_Click(object sender, EventArgs e)
        {
            u_donViCachDung.BringToFront();

            //DoiMau
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Nhapthuoc_Click(object sender, EventArgs e)
        {
            u_nhapThuoc.BringToFront();

            //DoiMau
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            uBaoCao.BringToFront();

            //DoiMau
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Quidinh_Click(object sender, EventArgs e)
        {
            u_thayDoiQuiDinh.BringToFront();

            //DoiMau
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Taikhoan_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                uTaiKhoancs.BringToFront();
            }
            else
            {
                uTaiKhoanQLy1.BringToFront();
            }

            //DoiMau
            ChangeNormalColorOnPanelLeft(sender);
        }
        public void ChangeNormalColorOnPanelLeft(object sender)
        {
            Guna2TileButton btn = sender as Guna2TileButton;
            btn.ForeColor = Color.IndianRed;
            foreach (Guna2TileButton item in panel_click.Controls)
            {
                if (item.Name != btn.Name && item.ForeColor != Color.SaddleBrown)
                {
                    Guna2TileButton btn1 = item as Guna2TileButton;
                    btn1.ForeColor = Color.SaddleBrown;
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                if (this.Width > 1890)
                    this.Width = 1890;
                if (this.Height > 1030)
                    this.Height = 1030;

                if (this.Width < 400)
                    this.Width = 400;
                if (this.Height < 300)
                    this.Height = 300;
            }

        }
    }
}