using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
   public class HoaDonNhapConfiguration:IEntityTypeConfiguration<HoaDonNhap>
    {
        public void Configure(EntityTypeBuilder<HoaDonNhap> builder)
        {
            builder.ToTable("HoaDonNhap");
            builder.HasKey(x => x.MaHoaDonNhap);
            builder.HasOne(x => x.NhaCungCap).WithMany(x => x.HoaDonNhaps).HasForeignKey(x => x.MaNhaCungCap);
        }
    }
}
