using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
   public class PhieuDatBanConfiguration:IEntityTypeConfiguration<PhieuDatBan>
    {
        public void Configure(EntityTypeBuilder<PhieuDatBan> builder)
        {
            builder.ToTable("PhieuDatBan");
            builder.HasKey(x => x.MaPhieu);
            builder.HasOne(x => x.NhanVien).WithMany(x => x.PhieuDatBans).HasForeignKey(x => x.MaNhanVien);
            builder.HasOne(x => x.Ban).WithMany(x => x.PhieuDatBans).HasForeignKey(x => x.MaBan);
            builder.HasOne(x => x.KhachHang).WithMany(x => x.PhieuDatBans).HasForeignKey(x => x.MaKhach);
        }
    }
}
