using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
   public class PdbDetailConfiguration:IEntityTypeConfiguration<ChiTietPDB>
    {
        public void Configure(EntityTypeBuilder<ChiTietPDB> builder)
        {
            builder.ToTable("ChiTietPDB");
            builder.HasKey(x => new {x.MaMonAn, x.MaPhieu});
            builder.HasOne(x => x.MonAn).WithMany(x => x.ChiTietPdbs).HasForeignKey(x => x.MaPhieu);
            builder.HasOne(x => x.PhieuDatBan).WithMany(x => x.ChiTietPdbs).HasForeignKey(x => x.MaPhieu);
            builder.HasOne(x => x.LoaiMonAn).WithMany(x => x.ChiTietPdbs).HasForeignKey(x => x.MaLoai);
        }
    }
}
