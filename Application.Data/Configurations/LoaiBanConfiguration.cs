using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
    public class LoaiBanConfiguration:IEntityTypeConfiguration<LoaiBan>
    {
        public void Configure(EntityTypeBuilder<LoaiBan> builder)
        {
            builder.ToTable("LoaiBan");
            builder.HasKey(x => x.MaLoaiBan);
        }
    }
}
