using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;


namespace QuanLyPhongMachTu.UserControls
{
    public partial class NhapThuoc : UserControl
    {
        BLL_PHIEUNHAPTHUOC dPhieuNhapThuocBLL;
        BLL_CT_PHIEUNHAP dCTPNBLL;
        BLL_LOAITHUOC dLoaiThuocBLL;
        BLL_THUOC dThuocBLL;
        public NhapThuoc()
        {
            InitializeComponent();
            dPhieuNhapThuocBLL = new BLL_PHIEUNHAPTHUOC();
            dCTPNBLL = new BLL_CT_PHIEUNHAP();
            dLoaiThuocBLL= new BLL_LOAITHUOC();
            dThuocBLL = new BLL_THUOC();
            LoadForm();
        }

        private void LoadForm()
        {
            LoadLoaiThuoc();
            LoadThuoc();
            LoadPhieuNhap();
            HienThiSoPhieuNhap();
            btnThem.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void LoadLoaiThuoc()
        {
            cboLoaiThuoc.DataSource = dLoaiThuocBLL.GetData();
            cboLoaiThuoc.DisplayMember = "TenLoaiThuoc";
        }

        private void LoadThuoc()
        {
            int maLoai = (cboLoaiThuoc.SelectedItem as LOAITHUOC).id;
            cboTenThuocBox.DataSource = dThuocBLL.GetDataByMaLoai(maLoai);
            cboTenThuocBox.DisplayMember = "TenThuoc";
        }

        private void LoadPhieuNhap()
        {
            cbbPhieuNhap.DataSource = dPhieuNhapThuocBLL.GetData();
            cbbPhieuNhap.DisplayMember = "SoPhieuNhapThuoc";
        }

        private PHIEUNHAPTHUOC GetDataPhieu()
        {
            PHIEUNHAPTHUOC phieu = new PHIEUNHAPTHUOC();
            if (!string.IsNullOrEmpty(txt_SoPhieuNhapThuoc.Text))
                phieu.SoPhieuNhapThuoc = int.Parse(txt_SoPhieuNhapThuoc.Text);
            phieu.NgayNhap = DateTime.Parse(dtp_NgayLap.Value.ToString());

            return phieu;
        }

        private CT_PHIEUNHAP GetDataChiTietPhieu()
        {
            if (!string.IsNullOrEmpty(txt_SoPhieuNhapThuoc.Text) || !string.IsNullOrEmpty(txt_DonGia.Text))
            {
                CT_PHIEUNHAP ct = new CT_PHIEUNHAP();
                ct.SoPhieuNhapThuoc = int.Parse(txt_SoPhieuNhapThuoc.Text);
                ct.idMaThuoc = (cboTenThuocBox.SelectedItem as THUOC).id;
                ct.SoLuongNhap = int.Parse(nup_SoLuongNhap.Value.ToString());
                ct.DonGiaNhap = int.Parse(txt_DonGia.Text);
                return ct;
            }
            else
            {
                Console.WriteLine("LỖI!!!Nhập thiếu thông tin!!!!");
                return null;
            }

        }

        private int GetMaMax()
        {
            return dPhieuNhapThuocBLL.GetMaMax();
        }

        private void LoadDataGridViewThuoc()
        {
            int maPhieuNhap = GetDataPhieu().SoPhieuNhapThuoc;
            dgvThuoc.DataSource = dCTPNBLL.GetDataCTPhieuByMaPhieu(maPhieuNhap);
            HienThiSoPhieuNhap();
        }



        private void gbx_PhieNnhapThuoc_Enter(object sender, EventArgs e)
        {

        }

        private void cboLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThuoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PHIEUNHAPTHUOC phieu = GetDataPhieu();
            dPhieuNhapThuocBLL.ThemPhieu(phieu);

            txt_SoPhieuNhapThuoc.Text = GetMaMax().ToString();
            btnThem.Enabled = false;
            btn_Luu.Enabled = true;
            LoadPhieuNhap();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            CT_PHIEUNHAP ct = GetDataChiTietPhieu();
            dCTPNBLL.ThemChiTietPhieu(ct);
            LoadDataGridViewThuoc();
        }

        int vt = -1;
        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
                return;
            DataGridViewRow row = dgvThuoc.Rows[vt];

            int idThuoc = int.Parse(row.Cells[0].Value.ToString());
            THUOC thuoc = dThuocBLL.GetDataByMa(idThuoc);
            foreach (LOAITHUOC loai in cboLoaiThuoc.Items)
            {
                if (loai.id == thuoc.idMaLoaiThuoc)
                    cboLoaiThuoc.SelectedItem = loai;
            }
            foreach (THUOC item in cboTenThuocBox.Items)
                if (item.id == thuoc.id)
                    cboTenThuocBox.SelectedItem = item;
            //cboLoaiThuoc.SelectedItem = thuoc.LOAITHUOC;
            //cboTenThuocBox.SelectedItem = thuoc;
            nup_SoLuongNhap.Value = int.Parse(row.Cells[2].Value.ToString());
            txt_DonGia.Text = row.Cells[3].Value.ToString();
        }

        private void btn_CapNhatThuoc_Click(object sender, EventArgs e)
        {
            if (vt == -1)
                return;
            CT_PHIEUNHAP ct = GetDataChiTietPhieu();
            dCTPNBLL.SuaChiTietPhieu(ct);
            LoadDataGridViewThuoc();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int idPhieu = (cbbPhieuNhap.SelectedItem as PHIEUNHAPTHUOC).SoPhieuNhapThuoc;
            PHIEUNHAPTHUOC phieu = dPhieuNhapThuocBLL.GetDataByMa(idPhieu);
            txt_SoPhieuNhapThuoc.Text = idPhieu.ToString();
            dtp_NgayLap.Text = phieu.NgayNhap.ToString("yyyy/MM/dd");
            dgvThuoc.DataSource = dCTPNBLL.GetDataCTPhieuByMaPhieu(idPhieu);
            btnThem.Enabled = false;
            btn_Luu.Enabled = true;
        }

        private void btn_xoaThuoc_Click(object sender, EventArgs e)
        {
            if (vt == -1)
                return;
            if (MessageBox.Show("Bạn có chắc muốn xóa loại mặt hàng này ra khỏi phiếu nhập?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CT_PHIEUNHAP ct = GetDataChiTietPhieu();
                dCTPNBLL.XoaChiTietPhieu(ct);
                LoadDataGridViewThuoc();
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PHIEUNHAPTHUOC phieu = GetDataPhieu();
                dCTPNBLL.XoaAllChiTietPhieu(phieu.SoPhieuNhapThuoc);
                dPhieuNhapThuocBLL.XoaPhieuNhap(phieu.SoPhieuNhapThuoc);
                txt_SoPhieuNhapThuoc.Text = "";
                nup_SoLuongNhap.Value = 0;
                txt_DonGia.Text = "";
                dgvThuoc.DataSource = "";
                btnThem.Enabled = true;
                btn_Luu.Enabled = false;
                LoadPhieuNhap();
            }
            HienThiSoPhieuNhap();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            txt_SoPhieuNhapThuoc.Text = "";
            nup_SoLuongNhap.Value = 0;
            txt_DonGia.Text = "";
            dgvThuoc.DataSource = "";
            btnThem.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void dgv_SoPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void HienThiSoPhieuNhap()
        {

            int selectedRowIndex = 0;
            if (dgv_SoPhieuNhap.DataSource != null)
            {
                if (dgv_SoPhieuNhap.SelectedRows.Count == 0)
                    selectedRowIndex = 0;
                else selectedRowIndex = dgv_SoPhieuNhap.SelectedCells[0].RowIndex;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Số Phiếu Nhập");
            dt.Columns.Add("Tổng tiền");
            dt.Columns.Add("Ngày Nhập");

            List<PHIEUNHAPTHUOC> tHUOCs = dPhieuNhapThuocBLL.GetData();

            foreach (PHIEUNHAPTHUOC t in tHUOCs)
            {
                t.TongTien = (int)dPhieuNhapThuocBLL.TongTien(t.SoPhieuNhapThuoc);
                dt.Rows.Add(t.SoPhieuNhapThuoc, t.TongTien, t.NgayNhap);
            }

            dgv_SoPhieuNhap.DataSource = dt;
            if (dgv_SoPhieuNhap.Rows.Count > 0 && selectedRowIndex != -1 && selectedRowIndex < dgv_SoPhieuNhap.Rows.Count)
            {
                dgv_SoPhieuNhap.Rows[selectedRowIndex].Selected = true;
            }


        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        //private void dgv_SoPhieuNhap_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgv_SoPhieuNhap.SelectedRows.Count > 0 && txt_SoPhieuNhapThuoc.Text != null)
        //    {
        //        DataGridViewRow row = dgv_SoPhieuNhap.SelectedRows[0];
        //        txt_SoPhieuNhapThuoc.Text = row.Cells[0].Value.ToString();
        //        dtp_NgayLap.Value = Convert.ToDateTime(row.Cells[2].Value);
        //        List<CT_PHIEUNHAP> s= PhieuNhapControllers.Instance.Getall(int.Parse(txt_SoPhieuNhapThuoc.Text));

        //        HienThiCTPhieuNhap(s);
        //    }
        //}
        public void HienThiCTPhieuNhap(List<CT_PHIEUNHAP> ct)
        {
            btn_Luu.Enabled = true;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã loại thuốc");
            dt.Columns.Add("Tên Thuốc");
            dt.Columns.Add("Số lượng nhập");
            dt.Columns.Add("Đơn giá nhập");
            dt.Columns.Add("Thành tiền");
            foreach (CT_PHIEUNHAP s in ct)
            {
                THUOC lt = dThuocBLL.GetTenById(s.idMaThuoc);
                dt.Rows.Add(s.idMaThuoc, lt.TenThuoc, s.SoLuongNhap, s.DonGiaNhap, s.ThanhTien);
            }
            dgvThuoc.DataSource = dt;
            //if (dgvThuoc.Rows.Count > 0 && selectedRowIndex != -1 && selectedRowIndex < dgv_SoPhieuNhap.Rows.Count)
            //{
            //    dgv_SoPhieuNhap.Rows[selectedRowIndex].Selected = true;
            //}
        }

        private void dgvThuoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvThuoc.SelectedRows[0];
                int idThuoc = int.Parse(row.Cells[0].Value.ToString());
                THUOC thuoc = dThuocBLL.GetDataByMa(idThuoc);
                foreach (LOAITHUOC loai in cboLoaiThuoc.Items)
                {
                    if (loai.id == thuoc.idMaLoaiThuoc)
                        cboLoaiThuoc.SelectedItem = loai;
                }
                foreach (THUOC item in cboTenThuocBox.Items)
                    if (item.id == thuoc.id)
                        cboTenThuocBox.SelectedItem = item;
                //cboLoaiThuoc.SelectedItem = thuoc.LOAITHUOC;
                //cboTenThuocBox.SelectedItem = thuoc;
                nup_SoLuongNhap.Value = int.Parse(row.Cells[2].Value.ToString());
                txt_DonGia.Text = row.Cells[3].Value.ToString();
            }
        }


        private void NhapThuoc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPhieu = (cbbPhieuNhap.SelectedItem as PHIEUNHAPTHUOC).SoPhieuNhapThuoc;
            PHIEUNHAPTHUOC phieu = dPhieuNhapThuocBLL.GetDataByMa(idPhieu);
            if (phieu != null)
            {
                int t = phieu.TongTien;
                lbb_TONGTIEN.Text = t.ToString() + "VND";
                List<CT_PHIEUNHAP> ct = dCTPNBLL.GetCTByMa(phieu.SoPhieuNhapThuoc);
                foreach (CT_PHIEUNHAP s in ct)
                {
                    THUOC thuoc = dThuocBLL.GetThuocbyMa(s.idMaThuoc);
                    thuoc.SoLuongTon = thuoc.SoLuongTon + s.SoLuongNhap;
                    dThuocBLL.Luu(thuoc);
                }
                MessageBox.Show("Hoàn tất Phiếu Nhập Thuốc. Tổng tiền phải trả là " + t.ToString()+" !!!Dữ Liệu đã được cập nhật!!!");
            }
            else return;

        }
    }
}
