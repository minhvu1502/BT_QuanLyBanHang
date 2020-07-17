using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
   public class LoaiMonAnConfiguration:IEntityTypeConfiguration<LoaiMonAn>
    {
        public void Configure(EntityTypeBuilder<LoaiMonAn> builder)
        {
            builder.ToTable("LoaiMonAn");
            builder.HasKey(x => x.MaLoai);
        }
    }
}
