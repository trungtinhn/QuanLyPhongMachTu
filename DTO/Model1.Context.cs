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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConnectEntities : DbContext
    {
        public ConnectEntities()
            : base("name=ConnectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BC_DOANHTHU> BC_DOANHTHU { get; set; }
        public virtual DbSet<BC_SUDUNGTHUOC> BC_SUDUNGTHUOC { get; set; }
        public virtual DbSet<BENH> BENH { get; set; }
        public virtual DbSet<BENHNHAN> BENHNHAN { get; set; }
        public virtual DbSet<CACHDUNG> CACHDUNG { get; set; }
        public virtual DbSet<CT_PHIEUKHAMBENH> CT_PHIEUKHAMBENH { get; set; }
        public virtual DbSet<CT_PHIEUNHAP> CT_PHIEUNHAP { get; set; }
        public virtual DbSet<CHITIETBCDOANHTHU> CHITIETBCDOANHTHU { get; set; }
        public virtual DbSet<CHITIETBCSUDUNGTHUOC> CHITIETBCSUDUNGTHUOC { get; set; }
        public virtual DbSet<CHUCNANG> CHUCNANG { get; set; }
        public virtual DbSet<DONVI> DONVI { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<LOAIBENH> LOAIBENH { get; set; }
        public virtual DbSet<LOAITHUOC> LOAITHUOC { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNG { get; set; }
        public virtual DbSet<NHOMNGUOIDUNG> NHOMNGUOIDUNG { get; set; }
        public virtual DbSet<PHIEUKHAMBENH> PHIEUKHAMBENH { get; set; }
        public virtual DbSet<PHIEUNHAPTHUOC> PHIEUNHAPTHUOC { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<THAMSO> THAMSO { get; set; }
        public virtual DbSet<THUOC> THUOC { get; set; }
    }
}
