﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using QuanLyPhongMachTu.UserControls;

namespace QuanLyPhongMachTu
{
    public partial class fLogin : Form
    {
        public static string currentUserName;

        public fLogin()

        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1890, 1030);
            this.MinimumSize = new System.Drawing.Size(1890, 1030);
        }

        private void lbl_QuanLyPhongMachTu_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string password = txt_Password.Text;

            BLL_LOGIN account = new BLL_LOGIN();

            bool isValid = account.Login(username, password);
            if (isValid)
            {
                currentUserName = username;
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }

    }
}
