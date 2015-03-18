USE [master]
GO
/****** Object:  Database [QuanLy]    Script Date: 03/18/2015 19:00:53 ******/
CREATE DATABASE [QuanLy] ON  PRIMARY 
( NAME = N'quanly', FILENAME = N'D:\Study\DCafe\trunk\Data\quanly.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quanly_log', FILENAME = N'D:\Study\DCafe\trunk\Data\quanly_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLy] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLy] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QuanLy] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QuanLy] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QuanLy] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QuanLy] SET ARITHABORT OFF
GO
ALTER DATABASE [QuanLy] SET AUTO_CLOSE ON
GO
ALTER DATABASE [QuanLy] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QuanLy] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QuanLy] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QuanLy] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QuanLy] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QuanLy] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QuanLy] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QuanLy] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QuanLy] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QuanLy] SET  DISABLE_BROKER
GO
ALTER DATABASE [QuanLy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QuanLy] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QuanLy] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QuanLy] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QuanLy] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QuanLy] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QuanLy] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QuanLy] SET  READ_WRITE
GO
ALTER DATABASE [QuanLy] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QuanLy] SET  MULTI_USER
GO
ALTER DATABASE [QuanLy] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QuanLy] SET DB_CHAINING OFF
GO
USE [QuanLy]
GO
/****** Object:  Table [dbo].[T_Thanhpham]    Script Date: 03/18/2015 19:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Thanhpham](
	[ma_thanhpham] [nchar](3) NOT NULL,
	[ten_thanhpham] [nchar](60) NOT NULL,
	[dongia] [int] NOT NULL,
	[giaban] [int] NOT NULL,
	[donvi] [nchar](10) NULL,
	[thoidiem] [datetime] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[T_Thanhpham] ([ma_thanhpham], [ten_thanhpham], [dongia], [giaban], [donvi], [thoidiem]) VALUES (N'CFD', N'Cafe da                                                     ', 10000, 12000, N'Ly        ', CAST(0x0000A56C00000000 AS DateTime))
INSERT [dbo].[T_Thanhpham] ([ma_thanhpham], [ten_thanhpham], [dongia], [giaban], [donvi], [thoidiem]) VALUES (N'CFS', N'Cafe sua                                                    ', 12000, 15000, N'Ly        ', CAST(0x0000A56C00000000 AS DateTime))
/****** Object:  Table [dbo].[T_Nhanvien]    Script Date: 03/18/2015 19:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Nhanvien](
	[ma_nv] [nchar](4) NOT NULL,
	[ten_nhanvien] [nchar](60) NOT NULL,
	[gioitinh] [bit] NOT NULL,
	[ma_kv] [nchar](2) NOT NULL,
	[is_admin] [bit] NOT NULL,
	[password] [nchar](30) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[T_Nhanvien] ([ma_nv], [ten_nhanvien], [gioitinh], [ma_kv], [is_admin], [password]) VALUES (N'AD01', N'Admin                                                       ', 1, N'TT', 1, N'admin123                      ')
INSERT [dbo].[T_Nhanvien] ([ma_nv], [ten_nhanvien], [gioitinh], [ma_kv], [is_admin], [password]) VALUES (N'NV02', N'Miss Nhân viên                                              ', 0, N'TT', 0, N'123456                        ')
INSERT [dbo].[T_Nhanvien] ([ma_nv], [ten_nhanvien], [gioitinh], [ma_kv], [is_admin], [password]) VALUES (N'NV03', N'Lê Minh Quân                                                ', 1, N'TT', 0, N'123456                        ')
/****** Object:  Table [dbo].[T_Nguyenlieu]    Script Date: 03/18/2015 19:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Nguyenlieu](
	[ma_nguyenlieu] [nchar](3) NOT NULL,
	[ten_nguyenlieu] [nchar](60) NOT NULL,
	[dongia] [int] NOT NULL,
	[donvi] [nchar](10) NULL,
	[thoidiem] [datetime] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[T_Nguyenlieu] ([ma_nguyenlieu], [ten_nguyenlieu], [dongia], [donvi], [thoidiem]) VALUES (N'CFE', N'Cafe                                                        ', 50000, N'Kg        ', CAST(0x0000A29200000000 AS DateTime))
INSERT [dbo].[T_Nguyenlieu] ([ma_nguyenlieu], [ten_nguyenlieu], [dongia], [donvi], [thoidiem]) VALUES (N'NDA', N'Nuoc da                                                     ', 10000, N'Bao       ', CAST(0x0000A29200000000 AS DateTime))
INSERT [dbo].[T_Nguyenlieu] ([ma_nguyenlieu], [ten_nguyenlieu], [dongia], [donvi], [thoidiem]) VALUES (N'DNG', N'Duong                                                       ', 19000, N'Kg        ', CAST(0x0000A3FF00000000 AS DateTime))
INSERT [dbo].[T_Nguyenlieu] ([ma_nguyenlieu], [ten_nguyenlieu], [dongia], [donvi], [thoidiem]) VALUES (N'SUA', N'Sua                                                         ', 15000, N'Hop       ', CAST(0x00009FB700000000 AS DateTime))
/****** Object:  Table [dbo].[T_Khuvuc]    Script Date: 03/18/2015 19:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Khuvuc](
	[ma_kv] [nchar](2) NOT NULL,
	[ten_kv] [nchar](30) NOT NULL,
	[soluong_ban] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[T_Khuvuc] ([ma_kv], [ten_kv], [soluong_ban]) VALUES (N'TT', N'Tang tret                     ', 5)
INSERT [dbo].[T_Khuvuc] ([ma_kv], [ten_kv], [soluong_ban]) VALUES (N'TL', N'Tang lau                      ', 10)
/****** Object:  Table [dbo].[T_Hoadon]    Script Date: 03/18/2015 19:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Hoadon](
	[ma_hd] [nchar](10) NOT NULL,
	[ma_nv] [nchar](4) NOT NULL,
	[ma_kv] [nchar](2) NULL,
	[ma_ban] [nchar](2) NULL,
	[thoidiem] [datetime] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[T_Hoadon] ([ma_hd], [ma_nv], [ma_kv], [ma_ban], [thoidiem]) VALUES (N'TT01020001', N'TT01', N'TT', N'02', CAST(0x0000A56C00000000 AS DateTime))
/****** Object:  Table [dbo].[T_CTHoadon]    Script Date: 03/18/2015 19:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_CTHoadon](
	[ma_hd] [nchar](10) NOT NULL,
	[ma_thanhpham] [nchar](3) NOT NULL,
	[soluong] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[T_CTHoadon] ([ma_hd], [ma_thanhpham], [soluong]) VALUES (N'TT01020001', N'CFS', 2)
INSERT [dbo].[T_CTHoadon] ([ma_hd], [ma_thanhpham], [soluong]) VALUES (N'TT01020001', N'CFD', 1)
/****** Object:  Table [dbo].[T_Chebien]    Script Date: 03/18/2015 19:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Chebien](
	[ma_thanhpham] [nchar](3) NOT NULL,
	[ma_nguyenlieu] [nchar](3) NOT NULL,
	[soluong] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[T_Chebien] ([ma_thanhpham], [ma_nguyenlieu], [soluong]) VALUES (N'CFD', N'CFE', 2)
INSERT [dbo].[T_Chebien] ([ma_thanhpham], [ma_nguyenlieu], [soluong]) VALUES (N'CFD', N'NDA', 1)
INSERT [dbo].[T_Chebien] ([ma_thanhpham], [ma_nguyenlieu], [soluong]) VALUES (N'CFD', N'DNG', 1)
INSERT [dbo].[T_Chebien] ([ma_thanhpham], [ma_nguyenlieu], [soluong]) VALUES (N'CFS', N'CFE', 2)
INSERT [dbo].[T_Chebien] ([ma_thanhpham], [ma_nguyenlieu], [soluong]) VALUES (N'CFS', N'NDA', 1)
INSERT [dbo].[T_Chebien] ([ma_thanhpham], [ma_nguyenlieu], [soluong]) VALUES (N'CFS', N'DNG', 1)
INSERT [dbo].[T_Chebien] ([ma_thanhpham], [ma_nguyenlieu], [soluong]) VALUES (N'CFS', N'SUA', 1)
