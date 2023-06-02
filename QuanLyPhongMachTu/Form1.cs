﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongMachTu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(1900, 1100);
            this.MaximumSize = new System.Drawing.Size(1990, 1190);

        }

        private void btn_Benhnhan_Click(object sender, EventArgs e)
        {
            u_danhSachKhamBenh.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Phieukhambenh_Click(object sender, EventArgs e)
        {
            u_PhieuKhamBenh.BringToFront();
        }

        private void btn_Benh_LoaiBenh_Click(object sender, EventArgs e)
        {
            u_BenhLoaiBenh.BringToFront();
        }

        private void btn_Thuoc_LoaiThuoc_Click(object sender, EventArgs e)
        {
            u_loaiThuocThuoc.BringToFront();
        }

        private void btn_Donvi_Cachdung_Click(object sender, EventArgs e)
        {
            u_donViCachDung.BringToFront();
        }

        private void btn_Nhapthuoc_Click(object sender, EventArgs e)
        {
            u_nhapThuoc.BringToFront();
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {

        }

        private void btn_Quidinh_Click(object sender, EventArgs e)
        {
            u_thayDoiQuiDinh.BringToFront();
        }

        private void btn_Taikhoan_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                if (this.Width > 1890)
                    this.Width = 1890;
                if (this.Height > 1030)
                    this.Height =1030;

                if (this.Width < 400)
                    this.Width = 400;
                if (this.Height < 300)
                    this.Height = 300;
            }

        }
    }
}
