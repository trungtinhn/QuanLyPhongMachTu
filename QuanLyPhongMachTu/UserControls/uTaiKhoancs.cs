using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Entity;
using System.Web.UI;
using System.Xml.Linq;
using UserControl = System.Windows.Forms.UserControl;
using System.Web.UI.WebControls;
using static QuanLyPhongMachTu.fLogin;

namespace QuanLyPhongMachTu.UserControls
{
    public partial class uTaiKhoancs : UserControl
    {

        public string UserName = fLogin.currentUserName;

        QLPMTEntities db = new QLPMTEntities();
        public uTaiKhoancs()
        {
            InitializeComponent();
            
        }
        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uTaiKhoancs_Load(object sender, EventArgs e)
        {

            var user = db.NGUOIDUNGs.FirstOrDefault(a => a.TenDangNhap == UserName);
            
            if (user != null)
            {
                MessageBox.Show("OKE");
                label1.Text = user.id.ToString();
                label2.Text = user.MaNguoiDung;
                label3.Text = user.TenNguoiDung.ToString();
                label4.Text = user.NgaySinh.ToString();
                label5.Text = user.TenDangNhap;
                label6.Text = user.idNhomNguoiDung.ToString();
            }    
            else
            {
                MessageBox.Show("NOT OKE");
            }
        }
    }
}
