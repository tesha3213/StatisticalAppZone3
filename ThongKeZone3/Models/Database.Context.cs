﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThongKeZone3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BKDS2019Entities : DbContext
    {
        public BKDS2019Entities()
            : base("name=BKDS2019Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BK_DiaBan> BK_DiaBan { get; set; }
        public DbSet<BK_Ho> BK_Ho { get; set; }
        public DbSet<BK_Thon> BK_Thon { get; set; }
        public DbSet<DM_Huyen> DM_Huyen { get; set; }
        public DbSet<DM_Tinh> DM_Tinh { get; set; }
        public DbSet<DM_Xa> DM_Xa { get; set; }
        public DbSet<QL_ThongTinDiaBan> QL_ThongTinDiaBan { get; set; }
        public DbSet<QT_NguoiDung> QT_NguoiDung { get; set; }
        public DbSet<QT_PhanQuyen> QT_PhanQuyen { get; set; }
        public DbSet<QT_SystemLog> QT_SystemLog { get; set; }
        public DbSet<QT_DanhSachChucNang> QT_DanhSachChucNang { get; set; }
        public DbSet<QT_NhomNguoiDung> QT_NhomNguoiDung { get; set; }
        public DbSet<TMP_BangKeHo> TMP_BangKeHo { get; set; }
    }
}
