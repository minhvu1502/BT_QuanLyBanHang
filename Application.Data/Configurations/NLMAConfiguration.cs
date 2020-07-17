using System;
using System.Collections.Generic;
using System.Text;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
    public class NLMAConfiguration:IEntityTypeConfiguration<NguyenLieuMonAn>
    {
        public void Configure(EntityTypeBuilder<NguyenLieuMonAn> builder)
        {
            builder.ToTable("NguyenLieuMonAn");
            builder.HasKey(x => new {x.MaNguyenLieu, x.MaMonAn});
            builder.HasOne(x => x.MonAn).WithMany(x => x.NguyenLieuMonAns).HasForeignKey(x => x.MaMonAn);
            builder.HasOne(x => x.NguyenLieu).WithMany(x => x.NguyenLieuMonAns).HasForeignKey(x => x.MaNguyenLieu);
        }
    }
}
