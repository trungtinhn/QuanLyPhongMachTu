using System;
using System.Windows.Forms;
using BLL_LOGIN;
using DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyPhongMachTu
{
    public partial class fLogin : Form
    {

        User_BLL_LOGIN bll_login = new User_BLL_LOGIN();

        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            string username = txt_UserName.Text;
            string password = txt_Password.Text;

            if (bll_login.CheckUser(username, password))
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
                txt_UserName.Clear();
                txt_Password.Clear();
                txt_UserName.Select();
            }
        }
    }
}
