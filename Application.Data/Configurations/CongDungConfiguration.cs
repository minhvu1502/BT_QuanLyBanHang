using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
   public class CongDungConfiguration:IEntityTypeConfiguration<CongDung>
    {
        public void Configure(EntityTypeBuilder<CongDung> builder)
        {
            builder.ToTable("CongDung");
            builder.HasKey(x => x.MaCongDung);
        }
    }
}
