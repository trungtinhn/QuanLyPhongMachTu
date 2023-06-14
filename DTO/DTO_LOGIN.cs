using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DTO
{
    public class DTO_LOGIN
    {
        public class DTO_ACCOUNT
        {
            public int id { get; set; }
            public string MaNguoiDung { get; set; }
            public string TenNguoiDung { get; set; }
            public Nullable<System.DateTime> NgaySinh { get; set; }
            public string ChucVu { get; set; }
            public string TenDangNhap { get; set; }
            public string MatKhau { get; set; }
            public int idNhomNguoiDung { get; set; }
            public string AnhDaiDien { get; set; }
            public string SoDT { get; set; }
            public string DiaChi { get; set; }
            public virtual NHOMNGUOIDUNG NHOMNGUOIDUNG { get; set; }
        }
    }
}
