using QuanLyPhongMachTu.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Guna.UI2.WinForms;
namespace QuanLyPhongMachTu
{
    public partial class Form1 : Form
    {
        QLPMTEntities db;
        public string UserName = fLogin.currentUserName;
        public Form1()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(1890, 1060);
            this.MaximumSize = new System.Drawing.Size(1890, 1060);
            db= new QLPMTEntities();
            uTaiKhoancs.BringToFront();

        }
        Boolean check = true;
        
                
        private void btn_Benhnhan_Click(object sender, EventArgs e)
        {
            u_danhSachKhamBenh.BringToFront();
            var user = db.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
            if (user.ChucVu == "Admin")
            {
                u_danhSachKhamBenh.SetPermissionsAdmin(true);
            }
            else if (user.ChucVu == "Bác sĩ")
            {
                
                u_danhSachKhamBenh.SetPermissionBacSi(true);
            }
            else
            { 
                u_danhSachKhamBenh.SetPermissionNhanVien(true);
            }
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uTaiKhoancs.BringToFront();
        }

        private void btn_Phieukhambenh_Click(object sender, EventArgs e)
        {
            u_lapPhieuKhamBenh.BringToFront();
            var user = db.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
            if (user.ChucVu == "Admin")
            {
                u_lapPhieuKhamBenh.SetPermissionsAdmin(true);
            }
            else if (user.ChucVu == "Bác sĩ")
            {

                u_lapPhieuKhamBenh.SetPermissionBacSi(true);
            }
            else
            {
                u_lapPhieuKhamBenh.SetPermissionNhanVien(true);
            }
            ChangeNormalColorOnPanelLeft(sender);

        }

        private void btn_Benh_LoaiBenh_Click(object sender, EventArgs e)
        {
            
            u_BenhLoaiBenh.BringToFront();
            var user = db.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
            if (user.ChucVu == "Admin")
            {
                u_BenhLoaiBenh.SetPermissionsAdmin(true);
            }
            else if (user.ChucVu == "Bác sĩ")
            {

                u_BenhLoaiBenh.SetPermissionBacSi(true);
            }
            else
            {
                u_BenhLoaiBenh.SetPermissionNhanVien(true);
            }
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Thuoc_LoaiThuoc_Click(object sender, EventArgs e)
        {
            u_loaiThuocThuoc.BringToFront();
            var user = db.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
            if (user.ChucVu == "Admin")
            {
                u_loaiThuocThuoc.SetPermissionsAdmin(true);
            }
            else if (user.ChucVu == "Bác sĩ")
            {

                u_loaiThuocThuoc.SetPermissionBacSi(true);
            }
            else
            {
                u_loaiThuocThuoc.SetPermissionNhanVien(true);
            }
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Donvi_Cachdung_Click(object sender, EventArgs e)
        {
            u_donViCachDung.BringToFront();
            var user = db.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
            if (user.ChucVu == "Admin")
            {
                u_donViCachDung.SetPermissionsAdmin(true);
            }
            else if (user.ChucVu == "Bác sĩ")
            {

                u_donViCachDung.SetPermissionBacSi(true);
            }
            else
            {
                u_donViCachDung.SetPermissionNhanVien(true);
            }
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Nhapthuoc_Click(object sender, EventArgs e)
        {
            u_nhapThuoc.BringToFront();
            var user = db.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
            if (user.ChucVu == "Admin")
            {
                u_nhapThuoc.SetPermissionsAdmin(true);
            }
            else if (user.ChucVu == "Bác sĩ")
            {

                u_nhapThuoc.SetPermissionBacSi(true);
            }
            else
            {
                u_nhapThuoc.SetPermissionNhanVien(true);
            }
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            uBaoCao.BringToFront();
            var user = db.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
            if (user.ChucVu == "Admin")
            {
                uBaoCao.SetPermissionsAdmin(true);
            }
            else if (user.ChucVu == "Bác sĩ")
            {

                uBaoCao.SetPermissionBacSi(true);
            }
            else
            {
                uBaoCao.SetPermissionNhanVien(true);
            }
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Quidinh_Click(object sender, EventArgs e)
        {
            u_thayDoiQuiDinh.BringToFront();
            var user = db.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
            if (user.ChucVu == "Admin")
            {
                u_thayDoiQuiDinh.SetPermissionsAdmin(true);
            }
            else if (user.ChucVu == "Bác sĩ")
            {

                u_thayDoiQuiDinh.SetPermissionBacSi(true);
            }
            else
            {
                u_thayDoiQuiDinh.SetPermissionNhanVien(true);
            }
            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Taikhoan_Click(object sender, EventArgs e)
        {
                uTaiKhoancs.BringToFront();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                if (this.Width > 1890)
                    this.Width = 1890;
                if (this.Height > 1030)
                    this.Height =1030;

                if (this.Width < 400)
                    this.Width = 400;
                if (this.Height < 300)
                    this.Height = 300;
            }

        }

        public void ChangeNormalColorOnPanelLeft(object sender)
        {
            Guna2TileButton btn = sender as Guna2TileButton;
            btn.ForeColor = Color.IndianRed;
            foreach (Guna2TileButton item in siticonePanel2.Controls)
            {
                if (item.Name != btn.Name && item.ForeColor != Color.SaddleBrown)
                {
                    Guna2TileButton btn1 = item as Guna2TileButton;
                    btn1.ForeColor = Color.SaddleBrown;
                }
            }
        }
    }
}
