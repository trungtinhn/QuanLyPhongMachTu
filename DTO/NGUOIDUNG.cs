﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;

    public partial class NGUOIDUNG
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