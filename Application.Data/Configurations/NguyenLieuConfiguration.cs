using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
   public class NguyenLieuConfiguration:IEntityTypeConfiguration<NguyenLieu>
    {
        public void Configure(EntityTypeBuilder<NguyenLieu> builder)
        {
            builder.ToTable("NguyenLieu");
            builder.HasKey(x => x.MaNguyenLieu);
        }
    }
}
