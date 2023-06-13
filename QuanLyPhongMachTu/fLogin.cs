using System;
using System.Windows.Forms;
using BusinessLogicLayer;
using DTO;
using BLL;
namespace QuanLyPhongMachTu
{
    public partial class fLogin : Form
    {

        private BusinessLogic businessLogic;

        public fLogin()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string password = txt_Password.Text;
            if (businessLogic.Login(username, password))
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
