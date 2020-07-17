using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
  public  class QueConfiguration:IEntityTypeConfiguration<QueQuan>
    {
        public void Configure(EntityTypeBuilder<QueQuan> builder)
        {
            builder.ToTable("QueQuan");
            builder.HasKey(x => x.MaQue);
        }
    }
}
