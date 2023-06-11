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
    public partial class TraCuuBenh : UserControl
    {
        BLL_LOAIBENH dLoaiBenhBLL;
        BLL_BENH dBenhBLL;
        BLL_LOAITHUOC dLoaiThuocBLL;
        BLL_THUOC dThuocBLL;
        public TraCuuBenh()
        {
            InitializeComponent();
            dLoaiBenhBLL = new BLL_LOAIBENH();
            dBenhBLL = new BLL_BENH();
            dThuocBLL = new BLL_THUOC();
            dLoaiThuocBLL = new BLL_LOAITHUOC();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuuBenh_Click(object sender, EventArgs e)
        {

        }

        private void TraCuuBenh_Load(object sender, EventArgs e)
        {
            HienThiThongTinLoaiBenh();
            HienThiThongTinBenh();
            HienThiComboBoxLoaiBenh();
            HienThiComboBoxLoaiThuoc();
        }

        public void HienThiThongTinLoaiBenh()
        {
            dgvLoaiBenh.DataSource = dLoaiBenhBLL.LayThongTinLoaiBenh();
          
            dgvLoaiBenh.Columns[0].HeaderText = "Mã loại bệnh";
            dgvLoaiBenh.Columns[1].HeaderText = "Tên loại bệnh";
            dgvLoaiBenh.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiBenh.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiBenh.Columns[0].Width =(int) (dgvLoaiBenh.Width * 0.3);
            dgvLoaiBenh.Columns[1].Width =(int)(dgvLoaiBenh.Width * 0.7);
        }

        public void HienThiThongTinBenh()
        {
            dgvBenh.DataSource =null;
            var dt = new DataTable();
            dt.Columns.Add("Mã bệnh");
            dt.Columns.Add("Tên bệnh");
            dt.Columns.Add("Triệu chứng");
            dt.Columns.Add("Thuốc đặc trị");
            dt.Columns.Add("Tên loại bệnh");

            List<BENH> benhs = dBenhBLL.LayThongTinBenh();

            foreach(BENH benh in benhs)
            {
                string tenLoaiBenh = dLoaiBenhBLL.LayTenLoaiBenh(benh.idMaLoaiBenh);
                string tenThuoc = dThuocBLL.LayTenThuoc(benh.idMaThuocDacTri);
                dt.Rows.Add(benh.MaBenh, benh.TenBenh, benh.TrieuChung, tenThuoc, tenLoaiBenh);
            }

            dgvBenh.DataSource = dt;

            dgvBenh.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenh.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenh.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenh.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBenh.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvBenh.Columns[0].Width =(int)(dgvLoaiBenh.Width * 0.1);
            dgvBenh.Columns[1].Width =(int)(dgvLoaiBenh.Width * 0.2);
            dgvBenh.Columns[2].Width =(int)(dgvLoaiBenh.Width * 0.3);
            dgvBenh.Columns[3].Width =(int)(dgvLoaiBenh.Width * 0.1);
            dgvBenh.Columns[4].Width =(int)(dgvLoaiBenh.Width * 0.3);


        }

        private bool KiemTraNhapLieuLoaiBenh()
        {
            if (string.IsNullOrEmpty(txtTenLoaiBenh.Text))
            {
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieuLoaiBenh())
            {
                MessageBox.Show("Vui lòng cùng cấp tên loại bệnh!");
                return;
            }

            LOAIBENH loaiBenh = new LOAIBENH();
            loaiBenh.TenLoaiBenh = txtTenLoaiBenh.Text;

            if (dLoaiBenhBLL.ThemLoaiBenh(loaiBenh))
            {
                MessageBox.Show("Thêm loại bệnh thành công!");
                HienThiThongTinLoaiBenh();
            }
            else
            {
                MessageBox.Show("Thêm loại bệnh thất bại!");
            }
        }

        private void btnCapNhatLoaiBenh_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieuLoaiBenh())
            {
                MessageBox.Show("Vui lòng cùng cấp tên loại bệnh!");
                return;
            }

            LOAIBENH loaiBenh = new LOAIBENH();
            loaiBenh.MaLoaiBenh = txtMaLoaiBenh.Text;
            loaiBenh.TenLoaiBenh = txtTenLoaiBenh.Text;

            if (dLoaiBenhBLL.CapNhatLoaiBenh(loaiBenh))
            {
                MessageBox.Show("Cập nhật loại bệnh thành công!");
                HienThiThongTinLoaiBenh();
            }
            else
            {
                MessageBox.Show("Cập nhật loại bệnh thất bại!");
            }
        }

        private void dgvLoaiBenh_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvLoaiBenh.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvLoaiBenh.SelectedRows[0];

                txtMaLoaiBenh.Text = row.Cells[0].Value.ToString();
                txtTenLoaiBenh.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            txtMaLoaiBenh.Text = "";
            txtTenLoaiBenh.Text  = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LOAIBENH loaiBenh = new LOAIBENH();
            loaiBenh.MaLoaiBenh = txtMaLoaiBenh.Text;
            loaiBenh.TenLoaiBenh = txtTenLoaiBenh.Text;

            if (dLoaiBenhBLL.XoaLoaiBenh(loaiBenh))
            {
                MessageBox.Show("Xóa loại bệnh thành công!");
                HienThiThongTinLoaiBenh();
                HienThiThongTinBenh();
            }else
            {
                MessageBox.Show("Xóa loại bệnh thất bại!");
            }
        }

        private void HienThiComboBoxLoaiBenh()
        {
            cboTenLoaiBenh.DataSource = dLoaiBenhBLL.LayThongTinLoaiBenh();
            cboTenLoaiBenh.DisplayMember = "TenLoaiBenh";
            cboTenLoaiBenh.ValueMember ="MaLoaiBenh";
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
                  
                }

                cboTenTHuoc.DisplayMember = "TenThuoc";
                cboTenTHuoc.ValueMember = "MaThuoc";
            }


        }

        private void cboTenLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiComboBoxThuoc();
        }

        private void dgvBenh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBenh.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBenh.SelectedRows[0];

                txtMaBenh.Text = row.Cells[0].Value.ToString();
                txtTenBenh.Text = row.Cells[1].Value.ToString();
                txtTrieuChungBenh.Text = row.Cells[2].Value.ToString();
                cboTenTHuoc.Text = row.Cells[3].Value.ToString();
                cboTenLoaiBenh.Text = row.Cells[4].Value.ToString();

                int idLoaiThuoc = dThuocBLL.LayIdLoaiThuoc(row.Cells[3].Value.ToString());
                cboTenLoaiThuoc.Text = dLoaiThuocBLL.LayTenLoaiThuoc(idLoaiThuoc);
            }
        }
    }
}
