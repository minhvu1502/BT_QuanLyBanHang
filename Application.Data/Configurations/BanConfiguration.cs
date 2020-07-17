using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
   public class BanConfiguration:IEntityTypeConfiguration<Ban>
    {
        public void Configure(EntityTypeBuilder<Ban> builder)
        {
            builder.ToTable("Ban");
            builder.HasKey(x => x.MaBan);
            builder.HasOne(x => x.LoaiBan).WithMany(x => x.Bans).HasForeignKey(x => x.MaLoaiBan);
        }
    }
}
