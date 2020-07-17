using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
    public class CdMaConfiguration:IEntityTypeConfiguration<CongDungMonAn>
    {
        public void Configure(EntityTypeBuilder<CongDungMonAn> builder)
        {
            builder.ToTable("CongDungMonAn");
            builder.HasKey(x => new {x.MaCongDung, x.MaMonAn});
            builder.HasOne(x => x.MonAn).WithMany(x => x.CongDungMonAns).HasForeignKey(x => x.MaMonAn);
            builder.HasOne(x => x.CongDung).WithMany(x => x.CongDungMonAns).HasForeignKey(x => x.MaCongDung);
        }
    }
}
