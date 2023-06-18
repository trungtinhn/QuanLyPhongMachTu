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
    public partial class HoaDonThanhToan : UserControl
    {

        public void SetPermissionsAdmin(bool isAdmin)
        {
            // Thiết lập quyền truy cập tương ứng cho các button, text box, DataGridView,...
            // Nếu isAdmin = true, cho bác sĩ được phép sử dụng các button, còn ngược lại thì ẩn các button
            if (isAdmin)
            {
                this.Enabled = false;
            }

            // ...
        }
        public void SetPermissionBacSi(bool isBacSi)
        {
            if (isBacSi)
            {
                this.Enabled = false;
            }
        }
        public void SetPermissionNhanVien(bool isNhanVien)
        {
            if (isNhanVien)
            {
                this.Enabled = true;
            }
        }

        public HoaDonThanhToan()
        {
            InitializeComponent();
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
