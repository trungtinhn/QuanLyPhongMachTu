using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyPhongMachTu.UserControls
{
    public partial class ThayDoiQuiDinh : UserControl
    {
        QLPMTEntities db;
        BLL_THAMSO dThamSoBLL;
        BLL_THUOC dThuocBLL;
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
        public ThayDoiQuiDinh()
        {
            InitializeComponent();
            db = new QLPMTEntities();
            dThamSoBLL = new BLL_THAMSO();
        }

        private void btn_Dongy_Click(object sender, EventArgs e)
        {
            
            dThamSoBLL.ThayDoiQuyDinh(Int32.Parse(txt_Tienkham.Text),Int32.Parse(txt_Sobenhnhantoida.Text));
            
            THAMSO thamSo = dThamSoBLL.LayThamSo(1);
            txt_Tienkham.Text = thamSo.TienKham.ToString();
            txt_Sobenhnhantoida.Text = thamSo.SoBenhNhanToiDa.ToString();
            int limited;
            if (Int32.TryParse(txt_thuocsaphet.Text, out limited))
            {
                // Thiết lập giá trị cho thuộc tính Limited của UserControl
                LoaiThuocThuoc loaiThuocThuoc = new LoaiThuocThuoc();
                loaiThuocThuoc.Limited = limited;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vào một số nguyên hợp lệ");
            }
            MessageBox.Show("Đã thay đổi quy định thành công!");
        }

        private void ThayDoiQuiDinh_Load(object sender, EventArgs e)
        {
            THAMSO thamSo = dThamSoBLL.LayThamSo(1);
            txt_Tienkham.Text = thamSo.TienKham.ToString();
            txt_Sobenhnhantoida.Text = thamSo.SoBenhNhanToiDa.ToString();
        }

    }
}
