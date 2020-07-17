using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
   public class NhanVienConfiguration:IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.MaNhanVien);
            builder.HasOne(x => x.QueQuan).WithMany(x => x.NhanVien).HasForeignKey(x => x.MaQue);
        }
    }
}
