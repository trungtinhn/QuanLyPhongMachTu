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
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            uBaoCaoSDThuoc.BringToFront();
        }
    }
}
