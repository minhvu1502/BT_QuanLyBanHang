USE [master]
GO
/****** Object:  Database [QuanLyNhaHang]    Script Date: 01/08/2020 10:30:06 ******/
CREATE DATABASE [QuanLyNhaHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhaHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyNhaHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyNhaHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyNhaHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyNhaHang] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhaHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhaHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhaHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhaHang] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [QuanLyNhaHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNhaHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhaHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhaHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhaHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhaHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyNhaHang] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyNhaHang] SET QUERY_STORE = OFF
GO
USE [QuanLyNhaHang]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[MaBan] [nvarchar](450) NOT NULL,
	[TenBan] [nvarchar](max) NULL,
	[MaLoaiBan] [nvarchar](450) NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[MaNguyenLieu] [nvarchar](450) NOT NULL,
	[MaHoaDonNhap] [nvarchar](450) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[KhuyenMai] [int] NOT NULL,
	[ThanhTien] [float] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNhap] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPDB]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPDB](
	[MaPhieu] [nvarchar](450) NOT NULL,
	[MaMonAn] [nvarchar](450) NOT NULL,
	[MaLoai] [nvarchar](450) NULL,
	[SoLuong] [int] NOT NULL,
	[GiamGia] [float] NOT NULL,
	[ThanhTien] [float] NOT NULL,
 CONSTRAINT [PK_ChiTietPDB] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC,
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongDung]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongDung](
	[MaCongDung] [nvarchar](450) NOT NULL,
	[TenCongDung] [nvarchar](max) NULL,
 CONSTRAINT [PK_CongDung] PRIMARY KEY CLUSTERED 
(
	[MaCongDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongDungMonAn]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongDungMonAn](
	[MaCongDung] [nvarchar](450) NOT NULL,
	[MaMonAn] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_CongDungMonAn] PRIMARY KEY CLUSTERED 
(
	[MaCongDung] ASC,
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[MaHoaDonNhap] [nvarchar](450) NOT NULL,
	[NgayNhap] [datetime2](7) NOT NULL,
	[TongTien] [float] NOT NULL,
	[MaNhanVien] [nvarchar](450) NULL,
	[MaNhaCungCap] [nvarchar](450) NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nvarchar](450) NOT NULL,
	[TenKhachHang] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[DienThoai] [nvarchar](max) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiBan]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBan](
	[MaLoaiBan] [nvarchar](450) NOT NULL,
	[TenLoaiBan] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiBan] PRIMARY KEY CLUSTERED 
(
	[MaLoaiBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiMonAn]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMonAn](
	[MaLoai] [nvarchar](450) NOT NULL,
	[TenLoai] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiMonAn] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMonAn] [nvarchar](450) NOT NULL,
	[YeuCau] [nvarchar](max) NULL,
	[TenMonAn] [nvarchar](max) NULL,
	[CachLam] [nvarchar](max) NULL,
	[DonGia] [float] NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[EditedBy] [nvarchar](max) NULL,
	[MaLoai] [nvarchar](450) NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNguyenLieu] [nvarchar](450) NOT NULL,
	[TenNguyenLieu] [nvarchar](max) NULL,
	[SoLuong] [int] NOT NULL,
	[DonViTinh] [nvarchar](max) NULL,
	[DonGiaNhap] [float] NOT NULL,
	[DonGiaBan] [float] NOT NULL,
	[YeuCau] [nvarchar](max) NULL,
	[ChongChiDinh] [nvarchar](max) NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieuMonAn]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieuMonAn](
	[MaNguyenLieu] [nvarchar](450) NOT NULL,
	[MaMonAn] [nvarchar](450) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_NguyenLieuMonAn] PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC,
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nvarchar](450) NOT NULL,
	[TenNhaCungCap] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[DienThoai] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](450) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](max) NULL,
	[NgaySinh] [datetime2](7) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SoDienThoai] [nvarchar](max) NULL,
	[Status] [bit] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[EditedBy] [nvarchar](max) NULL,
	[MaQue] [nvarchar](450) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatBan]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatBan](
	[MaPhieu] [nvarchar](450) NOT NULL,
	[NgayDat] [datetime2](7) NOT NULL,
	[NgayDung] [datetime2](7) NOT NULL,
	[TongTien] [float] NOT NULL,
	[MaBan] [nvarchar](450) NULL,
	[MaKhach] [nvarchar](450) NULL,
	[MaNhanVien] [nvarchar](450) NULL,
 CONSTRAINT [PK_PhieuDatBan] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QueQuan]    Script Date: 01/08/2020 10:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QueQuan](
	[MaQue] [nvarchar](450) NOT NULL,
	[TenQue] [nvarchar](max) NULL,
	[TrangThai] [bit] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[EditedBy] [nvarchar](max) NULL,
 CONSTRAINT [PK_QueQuan] PRIMARY KEY CLUSTERED 
(
	[MaQue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200727104657_init', N'5.0.0-preview.6.20312.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200729071505_fix', N'5.0.0-preview.6.20312.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200729074529_update', N'5.0.0-preview.6.20312.4')
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([Id], [Username], [Password], [Name], [Email], [Status]) VALUES (1, N'admin', N'TmGyZtPWQlWi1pBL54/ZZTe5OCSS/nRgpuF4soZ7MXUPBdgsGFCrnfOipmHHzrbodHAjpsMKmA/yKL1PANINEA==', N'Vũ Quang Minh', N'vuquangminhql123@gmail.com', 0)
INSERT [dbo].[Account] ([Id], [Username], [Password], [Name], [Email], [Status]) VALUES (2, N'vuquangminhql123', N'ujJTh2rta8ItSm/1PYQGxq2GQZXtFEq1yHYhtsIztUi66uaVbfNG7IwX9eoQ817jy8UUeX7X3dMUVGTioLq0Ew==', N'Vũ Quang Minh', N'vuquangminhql123@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[Account] OFF
INSERT [dbo].[Ban] ([MaBan], [TenBan], [MaLoaiBan]) VALUES (N'MB1', N'bàn 1', N'MLB1')
INSERT [dbo].[Ban] ([MaBan], [TenBan], [MaLoaiBan]) VALUES (N'MB2', N'bàn 2', N'MLB2')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai]) VALUES (N'MKH01', N'ẻwe', N'ẻwe', N'ửe')
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan]) VALUES (N'MLB1', N'bàn 1')
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan]) VALUES (N'MLB2', N'bàn 2')
INSERT [dbo].[NhanVien] ([MaNhanVien], [Ten], [GioiTinh], [NgaySinh], [DiaChi], [SoDienThoai], [Status], [CreatedBy], [EditedBy], [MaQue]) VALUES (N'MNV01', N'Black Panther', N'Nam', CAST(N'2020-08-17T00:00:00.0000000' AS DateTime2), N'Wankada Forever', N'19008198', 1, NULL, NULL, N'MQ2')
INSERT [dbo].[NhanVien] ([MaNhanVien], [Ten], [GioiTinh], [NgaySinh], [DiaChi], [SoDienThoai], [Status], [CreatedBy], [EditedBy], [MaQue]) VALUES (N'MNV02', N'Black Window', N'Nữ', CAST(N'2020-07-17T00:00:00.0000000' AS DateTime2), N'1231', N'123456', 1, NULL, NULL, N'MQ2')
INSERT [dbo].[NhanVien] ([MaNhanVien], [Ten], [GioiTinh], [NgaySinh], [DiaChi], [SoDienThoai], [Status], [CreatedBy], [EditedBy], [MaQue]) VALUES (N'MNV03', N'Iron Man', N'Nam', CAST(N'2020-07-18T00:00:00.0000000' AS DateTime2), N'Nhật Bản', N'dá', 1, NULL, NULL, N'MQ2')
INSERT [dbo].[NhanVien] ([MaNhanVien], [Ten], [GioiTinh], [NgaySinh], [DiaChi], [SoDienThoai], [Status], [CreatedBy], [EditedBy], [MaQue]) VALUES (N'MNV04', N'Capitan America', N'Nam', CAST(N'2020-07-10T00:00:00.0000000' AS DateTime2), N'Nam fffffffffff', N'211', 0, NULL, NULL, N'MQ1')
INSERT [dbo].[NhanVien] ([MaNhanVien], [Ten], [GioiTinh], [NgaySinh], [DiaChi], [SoDienThoai], [Status], [CreatedBy], [EditedBy], [MaQue]) VALUES (N'MNV05', N'Spider Man', N'Nam', CAST(N'2020-07-17T00:00:00.0000000' AS DateTime2), N'Mỹ', N'0313123123', 1, NULL, NULL, N'MQ3')
INSERT [dbo].[NhanVien] ([MaNhanVien], [Ten], [GioiTinh], [NgaySinh], [DiaChi], [SoDienThoai], [Status], [CreatedBy], [EditedBy], [MaQue]) VALUES (N'MNV07', N'Thanos Tím', N'Nam', CAST(N'2020-08-23T00:00:00.0000000' AS DateTime2), N'Infinity War', N'123123', 0, NULL, NULL, N'MQ3')
INSERT [dbo].[QueQuan] ([MaQue], [TenQue], [TrangThai], [CreatedBy], [EditedBy]) VALUES (N'MQ1', N'Hưng Yên', 1, NULL, NULL)
INSERT [dbo].[QueQuan] ([MaQue], [TenQue], [TrangThai], [CreatedBy], [EditedBy]) VALUES (N'MQ2', N'Hà Nội', 1, NULL, NULL)
INSERT [dbo].[QueQuan] ([MaQue], [TenQue], [TrangThai], [CreatedBy], [EditedBy]) VALUES (N'MQ3', N'Hồ Chí Minh', 1, NULL, NULL)
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Ban_MaLoaiBan]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_Ban_MaLoaiBan] ON [dbo].[Ban]
(
	[MaLoaiBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ChiTietHoaDonNhap_MaNguyenLieu]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_ChiTietHoaDonNhap_MaNguyenLieu] ON [dbo].[ChiTietHoaDonNhap]
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ChiTietPDB_MaLoai]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_ChiTietPDB_MaLoai] ON [dbo].[ChiTietPDB]
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ChiTietPDB_MaPhieu]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_ChiTietPDB_MaPhieu] ON [dbo].[ChiTietPDB]
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CongDungMonAn_MaMonAn]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_CongDungMonAn_MaMonAn] ON [dbo].[CongDungMonAn]
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_HoaDonNhap_MaNhaCungCap]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_HoaDonNhap_MaNhaCungCap] ON [dbo].[HoaDonNhap]
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_HoaDonNhap_MaNhanVien]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_HoaDonNhap_MaNhanVien] ON [dbo].[HoaDonNhap]
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_MonAn_MaLoai]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_MonAn_MaLoai] ON [dbo].[MonAn]
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_NguyenLieuMonAn_MaMonAn]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_NguyenLieuMonAn_MaMonAn] ON [dbo].[NguyenLieuMonAn]
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_NhanVien_MaQue]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_NhanVien_MaQue] ON [dbo].[NhanVien]
(
	[MaQue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PhieuDatBan_MaBan]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_PhieuDatBan_MaBan] ON [dbo].[PhieuDatBan]
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PhieuDatBan_MaKhach]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_PhieuDatBan_MaKhach] ON [dbo].[PhieuDatBan]
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PhieuDatBan_MaNhanVien]    Script Date: 01/08/2020 10:30:09 ******/
CREATE NONCLUSTERED INDEX [IX_PhieuDatBan_MaNhanVien] ON [dbo].[PhieuDatBan]
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD  CONSTRAINT [FK_Ban_LoaiBan_MaLoaiBan] FOREIGN KEY([MaLoaiBan])
REFERENCES [dbo].[LoaiBan] ([MaLoaiBan])
GO
ALTER TABLE [dbo].[Ban] CHECK CONSTRAINT [FK_Ban_LoaiBan_MaLoaiBan]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap_MaHoaDonNhap] FOREIGN KEY([MaHoaDonNhap])
REFERENCES [dbo].[HoaDonNhap] ([MaHoaDonNhap])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap_MaHoaDonNhap]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_NguyenLieu_MaNguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_NguyenLieu_MaNguyenLieu]
GO
ALTER TABLE [dbo].[ChiTietPDB]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPDB_LoaiMonAn_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiMonAn] ([MaLoai])
GO
ALTER TABLE [dbo].[ChiTietPDB] CHECK CONSTRAINT [FK_ChiTietPDB_LoaiMonAn_MaLoai]
GO
ALTER TABLE [dbo].[ChiTietPDB]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPDB_MonAn_MaPhieu] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[MonAn] ([MaMonAn])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPDB] CHECK CONSTRAINT [FK_ChiTietPDB_MonAn_MaPhieu]
GO
ALTER TABLE [dbo].[ChiTietPDB]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPDB_PhieuDatBan_MaPhieu] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDatBan] ([MaPhieu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPDB] CHECK CONSTRAINT [FK_ChiTietPDB_PhieuDatBan_MaPhieu]
GO
ALTER TABLE [dbo].[CongDungMonAn]  WITH CHECK ADD  CONSTRAINT [FK_CongDungMonAn_CongDung_MaCongDung] FOREIGN KEY([MaCongDung])
REFERENCES [dbo].[CongDung] ([MaCongDung])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CongDungMonAn] CHECK CONSTRAINT [FK_CongDungMonAn_CongDung_MaCongDung]
GO
ALTER TABLE [dbo].[CongDungMonAn]  WITH CHECK ADD  CONSTRAINT [FK_CongDungMonAn_MonAn_MaMonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CongDungMonAn] CHECK CONSTRAINT [FK_CongDungMonAn_MonAn_MaMonAn]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhaCungCap_MaNhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhaCungCap_MaNhaCungCap]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhanVien_MaNhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhanVien_MaNhanVien]
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_LoaiMonAn_MaLoai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiMonAn] ([MaLoai])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_LoaiMonAn_MaLoai]
GO
ALTER TABLE [dbo].[NguyenLieuMonAn]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieuMonAn_MonAn_MaMonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MonAn] ([MaMonAn])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NguyenLieuMonAn] CHECK CONSTRAINT [FK_NguyenLieuMonAn_MonAn_MaMonAn]
GO
ALTER TABLE [dbo].[NguyenLieuMonAn]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieuMonAn_NguyenLieu_MaNguyenLieu] FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NguyenLieuMonAn] CHECK CONSTRAINT [FK_NguyenLieuMonAn_NguyenLieu_MaNguyenLieu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_QueQuan_MaQue] FOREIGN KEY([MaQue])
REFERENCES [dbo].[QueQuan] ([MaQue])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_QueQuan_MaQue]
GO
ALTER TABLE [dbo].[PhieuDatBan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatBan_Ban_MaBan] FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[PhieuDatBan] CHECK CONSTRAINT [FK_PhieuDatBan_Ban_MaBan]
GO
ALTER TABLE [dbo].[PhieuDatBan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatBan_KhachHang_MaKhach] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhieuDatBan] CHECK CONSTRAINT [FK_PhieuDatBan_KhachHang_MaKhach]
GO
ALTER TABLE [dbo].[PhieuDatBan]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatBan_NhanVien_MaNhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuDatBan] CHECK CONSTRAINT [FK_PhieuDatBan_NhanVien_MaNhanVien]
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhaHang] SET  READ_WRITE 
GO
