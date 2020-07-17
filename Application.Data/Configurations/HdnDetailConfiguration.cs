using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
    public class HdnDetailConfiguration:IEntityTypeConfiguration<ChiTietHoaDonNhap>
    {
        public void Configure(EntityTypeBuilder<ChiTietHoaDonNhap> builder)
        {
            builder.ToTable("ChiTietHoaDonNhap");
            builder.HasKey(x => new {x.MaHoaDonNhap, x.MaNguyenLieu });
            builder.HasOne(x => x.HoaDonNhap).WithMany(x => x.ChiTietHoaDonNhaps).HasForeignKey(x => x.MaHoaDonNhap);
            builder.HasOne(x => x.NguyenLieu).WithMany(x => x.ChiTietHoaDonNhaps).HasForeignKey(x => x.MaNguyenLieu);
        }
    }
}
