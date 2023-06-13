using BLL;
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
    public partial class LoaiThuocThuoc : UserControl
    {
        BLL_LOAITHUOC dLoaiThuocBLL;
        public LoaiThuocThuoc()
        {
            InitializeComponent();
            dLoaiThuocBLL = new BLL_LOAITHUOC();
        }

        private void LoaiThuocThuoc_Load(object sender, EventArgs e)
        {
            HienThiLoaiThuoc();
        }

        private void HienThiLoaiThuoc()
        {
            dgv_Loaithuoc.DataSource = dLoaiThuocBLL.LayDanhSachLoaiThuoc();
        }
    }
}
