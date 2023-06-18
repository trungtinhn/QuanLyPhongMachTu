﻿using BLL;
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
    public partial class uBaoCao : UserControl
    {

        BLL_HOADON dHoaDonBLL;
        BLL_THUOC dThuocBLL;
        BLL_CT_PHIEUKHAMBENH dCT_PHIEUKHAMB;
        BLL_PHIEUKHAMBENH dPhieuKhamBenh;
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
        public uBaoCao()
        {
            dHoaDonBLL = new BLL_HOADON();
            dThuocBLL = new BLL_THUOC();
            dCT_PHIEUKHAMB = new BLL_CT_PHIEUKHAMBENH();
            dPhieuKhamBenh = new BLL_PHIEUKHAMBENH();
            InitializeComponent();

        }

        private void btnBaoCaoDT_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNamDoanhThu.Text))
            {
                MessageBox.Show("Vui lòng nhập số năm!");
                return;
            }
            int thang = Int32.Parse(cboThangDT.Text);
            int nam = Int32.Parse(txtNamDoanhThu.Text);

            int soNgay = DateTime.DaysInMonth(nam, thang);

            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Ngày");
            dt.Columns.Add("Doanh thu");
            dt.Columns.Add("Tỷ lệ");

            int tongDoanhThu = 0;
            for (int i = 1; i <= soNgay; i++)
            {
                tongDoanhThu += dHoaDonBLL.TongDoanhThuNgay(i, thang, nam);

                
            }

            if (tongDoanhThu == 0)
            {
                for (int i = 1; i <= soNgay; i++)
                {
                   

                    DateTime date = new DateTime(nam, thang, i);

                    dt.Rows.Add(i, date.ToString("dd/MM/yyyy"), 0, 0);
                }
            }
            else
            {
                for (int i = 1; i <= soNgay; i++)
                {
                    int doanhThu = dHoaDonBLL.TongDoanhThuNgay(i, thang, nam);

                    DateTime date = new DateTime(nam, thang, i);

                    dt.Rows.Add(i, date.ToString("dd/MM/yyyy"), doanhThu, doanhThu/tongDoanhThu);
                }
            }

            txtTongDoanhThu.Text = tongDoanhThu.ToString();

            dgvDoanhThu.DataSource = dt;

            dgvDoanhThu.Columns[0].Width = (int)(dgvDoanhThu.Width * 0.2);
            dgvDoanhThu.Columns[1].Width = (int)(dgvDoanhThu.Width * 0.2);
            dgvDoanhThu.Columns[2].Width = (int)(dgvDoanhThu.Width * 0.3);
            dgvDoanhThu.Columns[3].Width = (int)(dgvDoanhThu.Width * 0.3);
        }

        private void btnBaoCaoThuoc_Click(object sender, EventArgs e)
        {
            List<THUOC> thuocs = dThuocBLL.DanhSachThuoc();

            int thang = Int32.Parse(cboThangThuoc.Text);
            int nam = Int32.Parse(txtNamThuoc.Text);

            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã thuốc");
            dt.Columns.Add("Tên thuốc");
            dt.Columns.Add("Số lượng dùng");
            dt.Columns.Add("Số lần dùng");

            int i = 0;

            foreach ( THUOC thuoc in thuocs)
            {
                i++;
                List<CT_PHIEUKHAMBENH> phieus = dCT_PHIEUKHAMB.LayTheoThuoc(thuoc.id);

                int SoLuong = 0;
                int SoLanDung = 0;

                foreach(CT_PHIEUKHAMBENH cT_PHIEUKHAMBENH in phieus)
                {
                    PHIEUKHAMBENH pkb = dPhieuKhamBenh.LayPhieuKhamBenh(cT_PHIEUKHAMBENH.SoPhieuKhamBenh);

                    if (pkb.NgayKham.Month == thang && pkb.NgayKham.Year == nam)
                    {
                        SoLuong += cT_PHIEUKHAMBENH.SoLuong;
                        SoLanDung++;
                    }

                }

                dt.Rows.Add(i, thuoc.MaThuoc, thuoc.TenThuoc, SoLuong, SoLanDung);


            }


            dgvBaoCaoThuoc.DataSource = dt;

            dgvBaoCaoThuoc.Columns[0].Width = (int)(dgvBaoCaoThuoc.Width * 0.1);
            dgvBaoCaoThuoc.Columns[1].Width = (int)(dgvBaoCaoThuoc.Width * 0.2);
            dgvBaoCaoThuoc.Columns[2].Width = (int)(dgvBaoCaoThuoc.Width * 0.2);
            dgvBaoCaoThuoc.Columns[3].Width = (int)(dgvBaoCaoThuoc.Width * 0.2);
            dgvBaoCaoThuoc.Columns[4].Width = (int)(dgvBaoCaoThuoc.Width * 0.3);

        }
    }
}
