using CustomButton;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongMachTu.UserControls
{
    public partial class uBaoCao : UserControl
    {
        public uBaoCao()
        {
            InitializeComponent();
        }

        private void btn_baocaodoanhthu_Click(object sender, EventArgs e)
        {
            uBaoCaoTheoThang.BringToFront();

            ChangeNormalColorOnPanelLeft(sender);
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            uBaoCaoSDThuoc.BringToFront();

            ChangeNormalColorOnPanelLeft(sender);
        }
        public void ChangeNormalColorOnPanelLeft(object sender)
        {
            VBButton btn = sender as VBButton;
            btn.BackColor = Color.Firebrick;
            foreach (VBButton item in panel_tool.Controls)
            {
                if (item.Name != btn.Name && item.BackColor != Color.DarkRed)
                {
                    VBButton btn1 = item as VBButton;
                    btn1.BackColor = Color.DarkRed;
                }
            }
        }
    }
}
