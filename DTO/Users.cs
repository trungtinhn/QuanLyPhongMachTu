using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Users
    {
        public int id { get; set; }
        public string MaNguoiDung { get; set; }
        public string TenNguoiDung { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string ChucVu { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int idNhomNguoiDung { get; set; }

        public virtual NHOMNGUOIDUNG NHOMNGUOIDUNG { get; set; }
    }
}
