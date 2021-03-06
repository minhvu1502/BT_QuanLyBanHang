﻿using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
   public class MonAnConfiguration:IEntityTypeConfiguration<MonAn>
    {
        public void Configure(EntityTypeBuilder<MonAn> builder)
        {
            builder.ToTable("MonAn");
            builder.HasKey(x => x.MaMonAn);
            builder.HasOne(x => x.LoaiMonAn).WithMany(x => x.MonAns).HasForeignKey(x => x.MaLoai);
        }
    }
}
