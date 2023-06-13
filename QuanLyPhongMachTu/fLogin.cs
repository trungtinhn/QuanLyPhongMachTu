using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace QuanLyPhongMachTu
{
    public partial class fLogin : Form
    {
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
            // Lấy tên đăng nhập và mật khẩu từ TextBox
            string username = txt_UserName.Text.Trim().ToLower();
            string password = txt_Password.Text.Trim();

            // Kiểm tra thông tin đăng nhập có hợp lệ không
            DAL_LOGIN accountDAL = new DAL_LOGIN();
            bool isValid = accountDAL.CheckAccount(username, password);

            if (isValid)
            {
                // Mở màn hình HomePage
                Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }
    }
}
