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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyPhongMachTu.UserControls
{
    public partial class LapPhieuKhamBenh : UserControl
    {
        BLL_DANGKY dDangKyBLL;
        BLL_LOAITHUOC dLoaiThuocBLL;
        BLL_THUOC dThuocBLL;
        public LapPhieuKhamBenh()
        {
            InitializeComponent();
            dDangKyBLL = new BLL_DANGKY(); 
            dLoaiThuocBLL = new BLL_LOAITHUOC();
            dThuocBLL = new BLL_THUOC();
            
        }

        private void LapPhieuKhamBenh_Load(object sender, EventArgs e)
        {

            HienThiDanhSachKhamBenh();
            HienThiComboBoxLoaiThuoc();
        }

        public void HienThiDanhSachKhamBenh()
        {
            var dt = new DataTable();
            dt.Columns.Add("Mã bệnh nhân");
            dt.Columns.Add("Họ tên");

            List<BENHNHAN> danhSachDK = dDangKyBLL.LayDanhSachDangKy();

            foreach (var bn in danhSachDK)
            {
                dt.Rows.Add(bn.MaBenhNhan, bn.HoTenBenhNhan);
            }

            dgvDangKy.DataSource = dt;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HienThiDanhSachKhamBenh();
        }

        private void dgvDangKy_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDangKy.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDangKy.SelectedRows[0];

                txtMaBN.Text = row.Cells[0].Value.ToString();
                txtHotenBN.Text = row.Cells[1].Value.ToString();
            }
        }


        public void HienThiComboBoxLoaiThuoc()
        {
            cboTenLoaiThuoc.DataSource = dLoaiThuocBLL.LayDanhSachLoaiThuoc();
            cboTenLoaiThuoc.DisplayMember = "TenLoaiThuoc";
            cboTenLoaiThuoc.ValueMember = "MaLoaiThuoc";
            HienThiComboBoxThuoc();
        }


        public void HienThiComboBoxThuoc()
        {
            string maLoaiThuoc = cboTenLoaiThuoc.SelectedValue.ToString();
            LOAITHUOC loaiThuoc = dLoaiThuocBLL.LayLoaiThuoc(maLoaiThuoc);

            if (loaiThuoc == null)
            {
              
               
            }
            else
            {
                cboTenTHuoc.DataSource = dThuocBLL.LayDanhSachThuoc(loaiThuoc.id);

                if (cboTenTHuoc.Items.Count == 0)
                {
                    cboTenTHuoc.ResetText();
                    numSoLuong.Value = 0;
                    txtDonGiaThuoc.Text = "";
                }    
                   

                cboTenTHuoc.DisplayMember = "TenThuoc";
                cboTenTHuoc.ValueMember = "MaThuoc";

                HienThiGiaTien();
            }
              
            
        }

        private void cboTenLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiComboBoxThuoc();
           
        }

        private void cboTenTHuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiGiaTien();
        }

        private void HienThiGiaTien()
        {

            if(cboTenTHuoc.Items.Count > 0)
            {
                string maThuoc = cboTenTHuoc.SelectedValue.ToString();

                THUOC thuoc = dThuocBLL.LayThuoc(maThuoc);

                if (thuoc == null) return;

                txtDonGiaThuoc.Text = thuoc.DonGia.ToString();
                numSoLuong.Value = 0;

                txtThanhtien.Text = "0";
            }

            
            
        }

        private void ThayDoiThanhTien()
        {
            int donGia = Int32.Parse(txtDonGiaThuoc.Text);

            txtThanhtien.Text = (donGia * numSoLuong.Value) +"";
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            ThayDoiThanhTien();
        }
    }
}
