using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Application.Data.Configurations;
using Application.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Application.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("DbContext");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new BanConfiguration());
            modelBuilder.ApplyConfiguration(new CdMaConfiguration());
            modelBuilder.ApplyConfiguration(new CongDungConfiguration());
            modelBuilder.ApplyConfiguration(new HdnDetailConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonNhapConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiBanConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiMonAnConfiguration());
            modelBuilder.ApplyConfiguration(new MonAnConfiguration());
            modelBuilder.ApplyConfiguration(new NLMAConfiguration());
            modelBuilder.ApplyConfiguration(new NguyenLieuConfiguration());
            modelBuilder.ApplyConfiguration(new NhaCungCapConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new PdbDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PhieuDatBanConfiguration());
            modelBuilder.ApplyConfiguration(new QueConfiguration());
        }

        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<MonAn> MonAns { get; set; }
        public DbSet<CongDung> CongDungs { get; set; }
        public DbSet<CongDungMonAn> CongDungMonAns { get; set; }
        public DbSet<QueQuan> QueQuans { get; set; }
        public LoaiMonAn LoaiMonAns { get; set; }
        public DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public DbSet<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
        public DbSet<NguyenLieu> NguyenLieus { get; set; }
        public DbSet<NguyenLieuMonAn> NguyenLieuMonAns { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Ban> Bans { get; set; }
        public DbSet<LoaiBan> LoaiBans { get; set; }
        public DbSet<PhieuDatBan> PhieuDatBans { get; set; }
        public DbSet<ChiTietPDB> ChiTietPdbs { get; set; }
        public DbSet<HoaDonNhap> DonNhaps { get; set; }

    }
}
