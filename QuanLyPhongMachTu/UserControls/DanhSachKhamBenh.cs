using BLL;
using DTO;
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
    public partial class DanhSachKhamBenh : UserControl
    {
        BLL_BENHNHAN dBenhNhanBLL;
        BLL_DANGKY dDangKyBLL;
      
        public DanhSachKhamBenh()
        {
            InitializeComponent();
            dBenhNhanBLL = new BLL_BENHNHAN();
            dDangKyBLL = new BLL_DANGKY();
           
        }

        private void DanhSachKhamBenh_Load(object sender, EventArgs e)
        {

            HienThiLenDGVBenhNhan();
        }

        private void HienThiLenDGVBenhNhan()
        {
            dgvThongTinBN.DataSource = null;
            dBenhNhanBLL.LayDanhSachBenhNhan(dgvThongTinBN);
            dgvThongTinBN.Columns[0].HeaderText = "Mã bệnh nhân";
            dgvThongTinBN.Columns[1].HeaderText = "Họ tên";
            dgvThongTinBN.Columns[2].HeaderText = "Giới tính";
            dgvThongTinBN.Columns[3].HeaderText = "Ngày sinh";
            dgvThongTinBN.Columns[4].HeaderText = "Địa chỉ";
        }

        private bool KiemTraNhapLieu()
        {
            if (string.IsNullOrEmpty(txtHotenBN.Text) || string.IsNullOrEmpty(txtDiachiBN.Text))
            {
                return false;
            }else if (!radNam.Checked && !radNu.Checked)
            {
                return false;
            }
            return true;
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {

            if(!KiemTraNhapLieu())
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
                return;
            }

            BENHNHAN benhNhan = new BENHNHAN();
            benhNhan.HoTenBenhNhan = txtHotenBN.Text;
            if (radNam.Checked)
            {
                benhNhan.GioiTinh = "Nam";
            }else
            {
                benhNhan.GioiTinh = "Nữ";
            }
            benhNhan.NgaySinh = dtimeNgaySinh.Value;
            benhNhan.DiaChi = txtDiachiBN.Text;

            if (dBenhNhanBLL.ThemBenhNhan(benhNhan))
            {
                MessageBox.Show("Thêm bệnh nhân thành công!");
                HienThiLenDGVBenhNhan();
            }
            else
            {
                MessageBox.Show("Thêm bệnh nhân thất bại!");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (!KiemTraNhapLieu())
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
                return;
            }

            BENHNHAN benhNhan = new BENHNHAN();
            benhNhan.HoTenBenhNhan = txtHotenBN.Text;
            if (radNam.Checked)
            {
                benhNhan.GioiTinh = "Nam";
            }
            else
            {
                benhNhan.GioiTinh = "Nữ";
            }
            benhNhan.NgaySinh = dtimeNgaySinh.Value;
            benhNhan.DiaChi = txtDiachiBN.Text;
            benhNhan.MaBenhNhan = txtMaBN.Text;


            if (dBenhNhanBLL.CapNhatBenhNhan(benhNhan))
            {
                MessageBox.Show("Cập nhật bệnh nhân thành công!");
                HienThiLenDGVBenhNhan();
            }
            else
            {
                MessageBox.Show("Cập nhật bệnh nhân thất bại!");
            }
        }

        private void dgvThongTinBN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongTinBN.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvThongTinBN.SelectedRows[0];
              
               
                txtMaBN.Text = row.Cells[0].Value.ToString();
                txtHotenBN.Text = row.Cells[1].Value.ToString();

                if(row.Cells[2].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }

                dtimeNgaySinh.Value = (DateTime) row.Cells[3].Value;
                txtDiachiBN.Text = row.Cells[4].Value.ToString();
          


            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BENHNHAN benhNhan = new BENHNHAN();
            benhNhan.HoTenBenhNhan = txtHotenBN.Text;
            if (radNam.Checked)
            {
                benhNhan.GioiTinh = "Nam";
            }
            else
            {
                benhNhan.GioiTinh = "Nữ";
            }
            benhNhan.NgaySinh = dtimeNgaySinh.Value;
            benhNhan.DiaChi = txtDiachiBN.Text;
            benhNhan.MaBenhNhan = txtMaBN.Text;

            if (dBenhNhanBLL.XoaBenhNhan(benhNhan))
            {
                MessageBox.Show("Xóa bệnh nhân thành công!");
                HienThiLenDGVBenhNhan();
            }
            else
            {
                MessageBox.Show("Xóa bệnh nhân thất bại!");
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            txtMaBN.Text = "";
            txtHotenBN.Text = "";
            radNam.Checked = false;
            radNam.Checked = false;
            DateTime dateTime = DateTime.Now;
            dtimeNgaySinh.Value = dateTime;
            txtDiachiBN.Text = "";

        }

        private bool KiemTraNhapLieuDK()
        {
            if (string.IsNullOrEmpty(txtMaBNDK.Text))
            {
                return false;
            }
            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieuDK())
            {
                MessageBox.Show("Vui lòng cung cấp đủ thông tin!");
                return;
            }

            DANGKY dangKy = new DANGKY();

            BENHNHAN bn = dBenhNhanBLL.LayThongTinBenhNhan(txtMaBNDK.Text);

            if (bn == null)
            {
                MessageBox.Show("Không tồn tại mã bệnh nhân!");
                return;
            }

            dangKy.NgayDangKy = dtimeNgayDK.Value;
            dangKy.idMaBenhNhan = bn.id;

            if (dDangKyBLL.DangKyKhamBenh(dangKy))
            {
                MessageBox.Show("Đăng ký khám bênh thành công!");
               
            }else
            {
                MessageBox.Show("Đăng ký khám bệnh thất bại!");
            }
        }
    }
}
