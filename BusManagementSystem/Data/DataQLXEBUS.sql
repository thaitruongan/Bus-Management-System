USE [master]
GO
/****** Object:  Database [QLXEBUS]    Script Date: 7/11/2020 10:14:34 AM ******/
CREATE DATABASE [QLXEBUS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLXEBUS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLXEBUS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLXEBUS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLXEBUS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLXEBUS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLXEBUS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLXEBUS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLXEBUS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLXEBUS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLXEBUS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLXEBUS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLXEBUS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLXEBUS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLXEBUS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLXEBUS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLXEBUS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLXEBUS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLXEBUS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLXEBUS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLXEBUS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLXEBUS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLXEBUS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLXEBUS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLXEBUS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLXEBUS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLXEBUS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLXEBUS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLXEBUS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLXEBUS] SET RECOVERY FULL 
GO
ALTER DATABASE [QLXEBUS] SET  MULTI_USER 
GO
ALTER DATABASE [QLXEBUS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLXEBUS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLXEBUS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLXEBUS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLXEBUS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLXEBUS', N'ON'
GO
ALTER DATABASE [QLXEBUS] SET QUERY_STORE = OFF
GO
USE [QLXEBUS]
GO
/****** Object:  Table [dbo].[CaTruc]    Script Date: 7/11/2020 10:14:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaTruc](
	[matuyenduong] [varchar](10) NOT NULL,
	ngaytruc date,
	[ca] [int] NOT NULL,
	[maxe] [varchar](10) NOT NULL,
	[matuyenxe] [varchar](10) NOT NULL,
	[matx] [varchar](10) NOT NULL,
	[mapx] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[matuyenduong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoanhThuNgay]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThuNgay](
	[madtngay] [varchar](10) NOT NULL,
	[mapx] [varchar](10) NOT NULL,
	[tenvengay] [varchar](50) NOT NULL,
	[ngay] [date] NOT NULL,
	[soluongveloai1] [int] NOT NULL,
	[soluongveloai2] [int] NOT NULL,
	[soluongveloai3] [int] NOT NULL,
	[dtngay] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[madtngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoanhThuThang]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON

drop table DoanhThuThang
GO
CREATE TABLE [dbo].[DoanhThuThang](
	[madtthang] [varchar](10) NOT NULL,
	dtthang1 float,
	dtthang2 float,
	dtthang3 float,
	dtthang4 float,
	dtthang5 float,
	dtthang6 float,
	dtthang7 float,
	dtthang8 float,
	dtthang9 float,
	dtthang10 float,
	dtthang11 float,
	dtthang12 float
PRIMARY KEY CLUSTERED 
(
	[madtthang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaVeNgay]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaVeNgay](
	[magiavengay] [varchar](10) NOT NULL,
	[giaveloai1] [float] NOT NULL,
	[giaveloai2] [float] NOT NULL,
	[giaveloai3] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[magiavengay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HanhKhachThang]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HanhKhachThang](
	[mahk] [varchar](10) NOT NULL,
	[tenhk] [nvarchar](100) NOT NULL,
	[gioitinh] [nvarchar](10) NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
	[cmnd] [varchar](9) NOT NULL,
	[doituonguutien] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mahk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[manv] [varchar](10) NOT NULL,
	[anh] [varchar](100) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[diachi] [nvarchar](500) NOT NULL,
	[gioitinh] [nvarchar](10) NOT NULL,
	[dienthoai] [varchar](10) NOT NULL,
	[cmnd] [varchar](9) NOT NULL,
	[bangcap] [nvarchar](20) NOT NULL,
	[phongban] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhuXe]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhuXe](
	[mapx] [varchar](10) NOT NULL,	
	[anh] [varchar](100) NOT NULL,
	hoten nvarchar(50),
	[ngaysinh] [date] NOT NULL,
	diachi nvarchar(100),
	[gioitinh] [nvarchar](10) NOT NULL,	
	[dienthoai] [varchar](10) NOT NULL,
	[cmnd] [varchar](9) NOT NULL,

PRIMARY KEY CLUSTERED 
(
	[mapx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[manv] [varchar](10) NOT NULL,
	[tendangnhap] [varchar](100) NOT NULL,
	[matkhau] [varchar](100) NOT NULL,
	[quyen] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiXe]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiXe](
	[matx] [varchar](10) NOT NULL,
	[anh] [varchar](100) NOT NULL,
	[hotentx] [nvarchar](50) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[gioitinh] [nvarchar](10) NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
	[dienthoai] [varchar](10) NOT NULL,
	[cmnd] [varchar](9) NOT NULL,
	[loaibang] [varchar](2) NOT NULL
PRIMARY KEY CLUSTERED 
(
	[matx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE NhanVienBackup
(
	[manv] [varchar](10) NOT NULL PRIMARY KEY,
	[anh] [varchar](100) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[diachi] [nvarchar](500) NOT NULL,
	[gioitinh] [nvarchar](10) NOT NULL,
	[dienthoai] [varchar](10) NOT NULL,
	[cmnd] [varchar](9) NOT NULL,
	[bangcap] [nvarchar](20) NOT NULL,
	[phongban] [nvarchar](50) NOT NULL,
)

GO

CREATE TABLE TaiXeBackup
(
	[matx] [varchar](10) NOT NULL PRIMARY KEY,
	[anh] [varchar](100) NOT NULL,
	[hotentx] [nvarchar](50) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[gioitinh] [nvarchar](10) NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
	[dienthoai] [varchar](10) NOT NULL,
	[cmnd] [varchar](9) NOT NULL,
	[loaibang] [varchar](2) NOT NULL
)

CREATE TABLE PhuXeBackup
(
	[mapx] [varchar](10) NOT NULL PRIMARY KEY,	
	[anh] [varchar](100) NOT NULL,
	hoten nvarchar(50),
	[ngaysinh] [date] NOT NULL,
	diachi nvarchar(100),
	[gioitinh] [nvarchar](10) NOT NULL,	
	[dienthoai] [varchar](10) NOT NULL,
	[cmnd] [varchar](9) NOT NULL,
)

CREATE TABLE XeBackup(
	[maxe] [varchar](10) NOT NULL PRIMARY KEY,
	[bienkiemsoat] [varchar](20) NOT NULL,
	[hangsanxuat] [varchar](50) NOT NULL,
	[namsanxuat] [int] NOT NULL,
	[soghe] [int] NOT NULL
)

CREATE TABLE TuyenXeBackup
(
	[matuyenxe] [varchar](10) NOT NULL PRIMARY KEY,
	[tentuyenxe] [nvarchar](100) NOT NULL,
	[giobatdau] varchar(5) NOT NULL,
	[gioketthuc] varchar(5) NOT NULL,
	[diemdau] [nvarchar](50) NOT NULL,
	[diemcuoi] [nvarchar](50) NOT NULL,
	[chitiettram] [nvarchar](1000) NOT NULL,
	[tansuat] [int] NOT NULL,
	[soluongxe] [int] NOT NULL,
)

CREATE TABLE HanhKhachThangBackup
(
	[mahk] [varchar](10) NOT NULL PRIMARY KEY,
	[tenhk] [nvarchar](100) NOT NULL,
	[gioitinh] [nvarchar](10) NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
	[cmnd] [varchar](9) NOT NULL,
	[doituonguutien] [int] NOT NULL,
)

CREATE TABLE VeThang1TuyenBackup
(
	[mavethang] [varchar](10) NOT NULL PRIMARY KEY,
	[matuyenxe] [varchar](10) NULL,
	[mahk] [varchar](10) NOT NULL,
	[manv] [varchar](10) NOT NULL,
	ngaydangky date,
	ngayhethan date,
	[giave] [float] NOT NULL,
)

CREATE TABLE VeThangLienTuyenBackup
(
	[mavethang] [varchar](10) NOT NULL PRIMARY KEY,
	[mahk] [varchar](10) NOT NULL,
	[manv] [varchar](10) NOT NULL,
	ngaydangky date,
	ngayhethan date,
	[giave] [float] NOT NULL,
)

CREATE TABLE CaTrucBackup
(
	[matuyenduong] [varchar](10) NOT NULL PRIMARY KEY,
	ngaytruc date,
	[ca] [int] NOT NULL,
	[maxe] [varchar](10) NOT NULL,
	[matuyenxe] [varchar](10) NOT NULL,
	[matx] [varchar](10) NOT NULL,
	[mapx] [varchar](10) NOT NULL,
)

CREATE TABLE DoanhThuNgayBackup
(
	[madtngay] [varchar](10) NOT NULL PRIMARY KEY,
	[mapx] [varchar](10) NOT NULL,
	[tenvengay] [varchar](50) NOT NULL,
	[ngay] [date] NOT NULL,
	[soluongveloai1] [int] NOT NULL,
	[soluongveloai2] [int] NOT NULL,
	[soluongveloai3] [int] NOT NULL,
	[dtngay] [float] NOT NULL,
)

/****** Object:  Table [dbo].[TuyenXe]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuyenXe](
	[matuyenxe] [varchar](10) NOT NULL,
	[tentuyenxe] [nvarchar](100) NOT NULL,
	[giobatdau] varchar(5) NOT NULL,
	[gioketthuc] varchar(5) NOT NULL,
	[diemdau] [nvarchar](50) NOT NULL,
	[diemcuoi] [nvarchar](50) NOT NULL,
	[chitiettram] [nvarchar](1000) NOT NULL,
	[tansuat] [int] NOT NULL,
	[soluongxe] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[matuyenxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeThang1Tuyen]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeThang1Tuyen](
	[mavethang] [varchar](10) NOT NULL,
	[matuyenxe] [varchar](10) NULL,
	[mahk] [varchar](10) NOT NULL,
	[manv] [varchar](10) NOT NULL,
	ngaydangky date,
	ngayhethan date,
	[giave] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mavethang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeThangLienTuyen]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeThangLienTuyen](
	[mavethang] [varchar](10) NOT NULL,
	[mahk] [varchar](10) NOT NULL,
	[manv] [varchar](10) NOT NULL,
	ngaydangky date,
	ngayhethan date,
	[giave] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mavethang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[maxe] [varchar](10) NOT NULL,
	[bienkiemsoat] [varchar](20) NOT NULL,
	[hangsanxuat] [varchar](50) NOT NULL,
	[namsanxuat] [int] NOT NULL,
	[soghe] [int] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[maxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CaTruc]  WITH CHECK ADD  CONSTRAINT [fk_CaTruc_TuyenXe] FOREIGN KEY([matuyenxe])
REFERENCES [dbo].[TuyenXe] ([matuyenxe])
GO
ALTER TABLE [dbo].[CaTruc] CHECK CONSTRAINT [fk_CaTruc_TuyenXe]
GO
ALTER TABLE [dbo].[CaTruc]  WITH CHECK ADD  CONSTRAINT [fk_PhuXe_TuyenXe] FOREIGN KEY([mapx])
REFERENCES [dbo].[PhuXe] ([mapx])
GO
ALTER TABLE [dbo].[CaTruc] CHECK CONSTRAINT [fk_PhuXe_TuyenXe]
GO
ALTER TABLE [dbo].[CaTruc]  WITH CHECK ADD  CONSTRAINT [fk_TaiXe_CaTruc] FOREIGN KEY([matx])
REFERENCES [dbo].[TaiXe] ([matx])
GO
ALTER TABLE [dbo].[CaTruc] CHECK CONSTRAINT [fk_TaiXe_CaTruc]
GO
ALTER TABLE [dbo].[CaTruc]  WITH CHECK ADD  CONSTRAINT [fk_Xe_CaTruc] FOREIGN KEY([maxe])
REFERENCES [dbo].[Xe] ([maxe])
GO
ALTER TABLE [dbo].[CaTruc] CHECK CONSTRAINT [fk_Xe_CaTruc]
GO
ALTER TABLE [dbo].[DoanhThuNgay]  WITH CHECK ADD  CONSTRAINT [fk_DoanhThuNgay_PhuXe] FOREIGN KEY([mapx])
REFERENCES [dbo].[PhuXe] ([mapx])
GO
ALTER TABLE [dbo].[DoanhThuNgay] CHECK CONSTRAINT [fk_DoanhThuNgay_PhuXe]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [fk_TaiKhoan_NhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[NhanVien] ([manv])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [fk_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[VeThang1Tuyen]  WITH CHECK ADD  CONSTRAINT [fk_HanhKhachThang_VeThang] FOREIGN KEY([mahk])
REFERENCES [dbo].[HanhKhachThang] ([mahk])
GO
ALTER TABLE [dbo].[VeThang1Tuyen] CHECK CONSTRAINT [fk_HanhKhachThang_VeThang]
GO
ALTER TABLE [dbo].[VeThang1Tuyen]  WITH CHECK ADD  CONSTRAINT [fk_NhanVien_VeThang1Tuyen] FOREIGN KEY([manv])
REFERENCES [dbo].[NhanVien] ([manv])
GO
ALTER TABLE [dbo].[VeThang1Tuyen] CHECK CONSTRAINT [fk_NhanVien_VeThang1Tuyen]
GO
ALTER TABLE [dbo].[VeThang1Tuyen]  WITH CHECK ADD  CONSTRAINT [fk_TuyenXe_VeThang1Tuyen] FOREIGN KEY([matuyenxe])
REFERENCES [dbo].[TuyenXe] ([matuyenxe])
GO
ALTER TABLE [dbo].[VeThang1Tuyen] CHECK CONSTRAINT [fk_TuyenXe_VeThang1Tuyen]
GO
ALTER TABLE [dbo].[VeThangLienTuyen]  WITH CHECK ADD  CONSTRAINT [fk_HanhKhachThang_VeThangLienTuyen] FOREIGN KEY([mahk])
REFERENCES [dbo].[HanhKhachThang] ([mahk])
GO
ALTER TABLE [dbo].[VeThangLienTuyen] CHECK CONSTRAINT [fk_HanhKhachThang_VeThangLienTuyen]
GO
ALTER TABLE [dbo].[VeThangLienTuyen]  WITH CHECK ADD  CONSTRAINT [fk_NhanVien_VeThangLienTuyen] FOREIGN KEY([manv])
REFERENCES [dbo].[NhanVien] ([manv])
GO
ALTER TABLE [dbo].[VeThangLienTuyen] CHECK CONSTRAINT [fk_NhanVien_VeThangLienTuyen]
GO
/****** Object:  StoredProcedure [dbo].[Delete_NhanVien]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Delete_NhanVien]
	@manv varchar(10)
AS
	BEGIN
		DELETE NhanVien
		WHERE manv = @manv
	END
GO
/****** Object:  StoredProcedure [dbo].[Insert_NhanVien]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_NhanVien]	
	@anh varchar(100),
	@hoten nvarchar(50),
	@ngaysinh date,
	@diachi nvarchar(500),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@cmnd varchar(9),
	@bangcap nvarchar(20),
	@phongban nvarchar(50)
AS
	DECLARE @count int,
	@manv varchar(10)
	SET @count = (SELECT COUNT (*) FROM NhanVienBackup)
	IF (@count < 10)
	BEGIN
		SET @manv = 'NV00' + CONVERT(varchar, @count + 1)
	END
	ELSE IF(@count < 100)
	BEGIN
		SET @manv = 'NV0' + CONVERT(varchar, @count + 1)
	END
	ELSE
	BEGIN
		SET @manv = 'NV' + CONVERT(varchar, @count + 1)
	END
	INSERT INTO NhanVien VALUES (@manv, @anh, @hoten, @ngaysinh,@diachi,@gioitinh, @dienthoai, @cmnd,@bangcap,@phongban)
	INSERT INTO NhanVienBackup VALUES (@manv, @anh, @hoten, @ngaysinh,@diachi,@gioitinh, @dienthoai, @cmnd,@bangcap,@phongban)
GO

Insert_NhanVien 'D:\1.Hoc\Bus Management System\GUI\image\avatar\tta.jpg', N'Thái Trường An', '12-31-1999',N'Long Xuyên',N'Nam', '0914518169','352448973',N'Đại Học',N'Giám Đốc'

select * from TaiXe

DROP PROC Insert_TaiXe
/****** Object:  StoredProcedure [dbo].[Update_NhanVien]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_NhanVien]
	@manv varchar(10),
	@anh varchar(100),
	@hoten nvarchar(50),
	@ngaysinh date,
	@diachi nvarchar(500),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@cmnd varchar(9),
	@bangcap nvarchar(20),
	@phongban nvarchar(50)
AS
	BEGIN
		UPDATE NhanVien
		SET
			anh = @anh,
			hoten = @hoten,
			ngaysinh = @ngaysinh,
			diachi = @diachi,
			gioitinh = @gioitinh,
			dienthoai = @dienthoai,
			cmnd = @cmnd,
			bangcap = @bangcap,
			phongban = @phongban
		WHERE
			manv = @manv
	END
GO

CREATE PROC Update_NhanVienNoImg
	@manv varchar(10),
	@hoten nvarchar(50),
	@ngaysinh date,
	@diachi nvarchar(500),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@cmnd varchar(9),
	@bangcap nvarchar(20),
	@phongban nvarchar(50)
AS
	BEGIN
		UPDATE NhanVien
		SET
			hoten = @hoten,
			ngaysinh = @ngaysinh,
			diachi = @diachi,
			gioitinh = @gioitinh,
			dienthoai = @dienthoai,
			cmnd = @cmnd,
			bangcap = @bangcap,
			phongban = @phongban
		WHERE
			manv = @manv
	END
GO

CREATE PROC Search_NhanVien
	@search nvarchar(100)
AS	
	BEGIN
		SELECT * from NhanVien where (hoten LIKE N'%'+@search+'%' OR manv LIKE '%'+@search+'%' OR gioitinh like N'%'+@search+'%'OR diachi like N'%'+@search+'%' OR dienthoai like '%'+@search+'%' OR cmnd like '%'+@search+'%')
	END

 
SELECT * FROM TaiXe

ALTER TABLE DoanhThuNgay
DROP CONSTRAINT fk_DoanhThuNgay_PhuXe

DROP TABLE PhuXe
--Tai xe

CREATE PROCEDURE Xem_TaiXe
AS
BEGIN
    SELECT
        *
    FROM
        TaiXe
END;
GO

CREATE PROCEDURE Insert_TaiXe
	@anh varchar(100),
	@hoten nvarchar(50),
	@ngaysinh date,
	@diachi nvarchar(500),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@cmnd varchar(9),
	@loaibang nvarchar(2)
AS
	DECLARE @count int,
	@matx varchar(10)
	SET @count = (SELECT COUNT (*) FROM TaiXeBackup)
	IF (@count < 10)
	BEGIN
		SET @matx = 'TX00' + CONVERT(varchar, @count + 1)
	END
	ELSE IF(@count < 100)
	BEGIN
		SET @matx = 'TX0' + CONVERT(varchar, @count + 1)
	END
	ELSE
	BEGIN
		SET @matx = 'TX' + CONVERT(varchar, @count + 1)
	END
	INSERT INTO TaiXe VALUES (@matx, @anh, @hoten, @ngaysinh,@diachi,@gioitinh, @dienthoai, @cmnd,@loaibang)
	INSERT INTO TaiXeBackup VALUES (@matx, @anh, @hoten, @ngaysinh,@diachi,@gioitinh, @dienthoai, @cmnd,@loaibang)
GO

delete TaiXeBackup where matx = 'TX002'

select * from PhuXe

select * from TaiXeBackup

Insert_TaiXe 'tta.jpg', N'Thái Trường An', '12-31-1999',N'Nam',N'Long Xuyên', '0914518169','352448973','D'

drop proc Insert_TaiXe

CREATE PROC Delete_TaiXe
	@matx varchar(10)
AS
	BEGIN
		DELETE TaiXe
		WHERE matx = @matx
	END
GO

Delete_TaiXe 'TX002'

select * from TaiXe

DELETE TaiXeBackup WHERE matx = 'TX002'

DROP PROC Search_TaiXe

CREATE PROC Update_TaiXe
	@matx varchar(10),
	@anh varchar(100),
	@hoten nvarchar(50),
	@ngaysinh date,
	@diachi nvarchar(500),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@cmnd varchar(9),
	@loaibang nvarchar(2)
AS
	BEGIN
		UPDATE TaiXe
		SET
			anh = @anh,
			hotentx = @hoten,
			ngaysinh = @ngaysinh,
			diachi = @diachi,
			gioitinh = @gioitinh,
			dienthoai = @dienthoai,
			cmnd = @cmnd,
			loaibang = @loaibang
		WHERE
			matx = @matx
	END
GO

CREATE PROC Update_TaiXe_No_IMG
	@matx varchar(10),
	@hoten nvarchar(50),
	@ngaysinh date,
	@diachi nvarchar(500),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@cmnd varchar(9),
	@loaibang nvarchar(2)
AS
	BEGIN
		UPDATE TaiXe
		SET
			hotentx = @hoten,
			ngaysinh = @ngaysinh,
			diachi = @diachi,
			gioitinh = @gioitinh,
			dienthoai = @dienthoai,
			cmnd = @cmnd,
			loaibang = @loaibang
		WHERE
			matx = @matx
	END
GO

CREATE PROC Search_TaiXe
	@search nvarchar(100)
AS	
	BEGIN
		SELECT * from TaiXe where (hotentx LIKE N'%'+@search+'%' OR matx LIKE '%'+@search+'%' OR gioitinh like N'%'+@search+'%'OR diachi like N'%'+@search+'%' OR dienthoai like '%'+@search+'%' OR cmnd like '%'+@search+'%')
	END

--PhuXe

CREATE PROCEDURE Get_PhuXe
AS
BEGIN
    SELECT
        *
    FROM
        PhuXe
END;
GO

CREATE PROCEDURE Insert_PhuXe
	@anh varchar(100),
	@hoten nvarchar(50),
	@ngaysinh date,
	@diachi nvarchar(500),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@cmnd varchar(9)
AS
	DECLARE @count int,
	@mapx varchar(10)
	SET @count = (SELECT COUNT (*) FROM PhuXeBackup)
	IF (@count < 10)
	BEGIN
		SET @mapx = 'PX00' + CONVERT(varchar, @count + 1)
	END
	ELSE IF(@count < 100)
	BEGIN
		SET @mapx = 'PX0' + CONVERT(varchar, @count + 1)
	END
	ELSE
	BEGIN
		SET @mapx = 'PX' + CONVERT(varchar, @count + 1)
	END
	INSERT INTO PhuXe VALUES (@mapx, @anh, @hoten, @ngaysinh,@diachi,@gioitinh, @dienthoai, @cmnd)
	INSERT INTO PhuXeBackup VALUES (@mapx, @anh, @hoten, @ngaysinh,@diachi,@gioitinh, @dienthoai, @cmnd)
GO

Insert_PhuXe 'tta.jpg', N'Thái Trường An', '12-31-1999',N'Long Xuyên',N'Nam', '0914518169', '352448973'

CREATE PROC Update_PhuXe
	@mapx varchar(10),
	@anh varchar(100),
	@hoten nvarchar(50),
	@ngaysinh date,
	@diachi nvarchar(500),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@cmnd varchar(9)
AS
	BEGIN
		UPDATE PhuXe
		SET
			anh = @anh,
			hoten = @hoten,
			ngaysinh = @ngaysinh,
			diachi = @diachi,
			gioitinh = @gioitinh,
			dienthoai = @dienthoai,
			cmnd = @cmnd
		WHERE
			mapx = @mapx
	END
GO

CREATE PROC Update_PhuXe_No_IMG
	@mapx varchar(10),
	@hoten nvarchar(50),
	@ngaysinh date,
	@diachi nvarchar(500),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@cmnd varchar(9)
AS
	BEGIN
		UPDATE PhuXe
		SET
			hoten = @hoten,
			ngaysinh = @ngaysinh,
			diachi = @diachi,
			gioitinh = @gioitinh,
			dienthoai = @dienthoai,
			cmnd = @cmnd
		WHERE
			mapx = @mapx
	END
GO

CREATE PROC Delete_PhuXe
	@mapx varchar(10)
AS
	BEGIN
		DELETE PhuXe
		WHERE mapx = @mapx
	END
GO

CREATE PROC Search_PhuXe
	@search nvarchar(100)
AS	
	BEGIN
		SELECT * from PhuXe where (hoten LIKE N'%'+@search+'%' OR mapx LIKE '%'+@search+'%' OR gioitinh like N'%'+@search+'%'OR diachi like N'%'+@search+'%' OR dienthoai like '%'+@search+'%' OR cmnd like '%'+@search+'%')
	END

/****** Object:  StoredProcedure XE   Script Date: 7/11/2020 10:14:35 AM ******/

CREATE PROCEDURE Get_Xe
AS
BEGIN
    SELECT
        *
    FROM
        Xe
END;
GO

CREATE PROCEDURE Insert_Xe
	@bienkiemsoat varchar(20),
	@hangsanxuat varchar(50),
	@namsanxuat int,
	@soghe int
AS
	DECLARE @count int,
	@maxe varchar(10)
	SET @count = (SELECT COUNT (*) FROM XeBackup)
	IF (@count < 10)
	BEGIN
		SET @maxe = 'XE00' + CONVERT(varchar, @count + 1)
	END
	ELSE IF(@count < 100)
	BEGIN
		SET @maxe = 'XE0' + CONVERT(varchar, @count + 1)
	END
	ELSE
	BEGIN
		SET @maxe = 'XE' + CONVERT(varchar, @count + 1)
	END
	INSERT INTO Xe VALUES (@maxe,@bienkiemsoat,@hangsanxuat,@namsanxuat,@soghe)
	INSERT INTO XeBackup VALUES (@maxe,@bienkiemsoat,@hangsanxuat,@namsanxuat,@soghe)
GO

Insert_Xe '67-B2 526.45','Thaco',2010,47

CREATE PROC Update_Xe
	@maxe varchar(10),
	@bienkiemsoat varchar(20),
	@hangsanxuat varchar(50),
	@namsanxuat int,
	@soghe int
AS
	BEGIN
		UPDATE Xe
		SET
			bienkiemsoat = @bienkiemsoat,
			hangsanxuat = @hangsanxuat,
			namsanxuat = @namsanxuat,
			soghe = @soghe
		WHERE
			maxe = @maxe
	END
GO

CREATE PROC Delete_Xe
	@maxe varchar(10)
AS
	BEGIN
		DELETE Xe
		WHERE maxe = @maxe
	END
GO

CREATE PROC Search_Xe
	@search nvarchar(100)
AS	
	BEGIN
		SELECT * from Xe where (bienkiemsoat LIKE N'%'+@search+'%' OR maxe LIKE '%'+@search+'%' OR namsanxuat like N'%'+@search+'%'OR hangsanxuat like N'%'+@search+'%' OR soghe like '%'+@search+'%')
	END

/****** Object:  StoredProcedure TuyenXe   Script Date: 7/11/2020 10:14:35 AM ******/
DROP TABLE TuyenXeBackup


ALTER TABLE CaTruc DROP CONSTRAINT fk_CaTruc_TuyenXe

CREATE PROCEDURE Get_TuyenXe
AS
BEGIN
    SELECT
        *
    FROM
        TuyenXe
END;
GO

DROP PROC Insert_TuyenXe

CREATE PROCEDURE Insert_TuyenXe
	@tentuyenxe nvarchar(100),
	@giobatdau varchar(5),
	@gioketthuc varchar(5),
	@diemdau nvarchar(50),
	@diemketthuc nvarchar(50),
	@chitiettram nvarchar(1000),
	@tansuat int,
	@soluongxe int
AS
	DECLARE @count int,
	@matuyenxe varchar(10)
	SET @count = (SELECT COUNT (*) FROM TuyenXeBackup)
	IF (@count < 10)
	BEGIN
		SET @matuyenxe = 'TUXE00' + CONVERT(varchar, @count + 1)
	END
	ELSE IF(@count < 100)
	BEGIN
		SET @matuyenxe = 'TUXE0' + CONVERT(varchar, @count + 1)
	END
	ELSE
	BEGIN
		SET @matuyenxe = 'TUXE' + CONVERT(varchar, @count + 1)
	END
	INSERT INTO TuyenXe VALUES (@matuyenxe, @tentuyenxe, @giobatdau, @gioketthuc, @diemdau, @diemketthuc, @chitiettram, @tansuat, @soluongxe)
	INSERT INTO TuyenXeBackup VALUES (@matuyenxe, @tentuyenxe, @giobatdau, @gioketthuc, @diemdau, @diemketthuc, @chitiettram, @tansuat, @soluongxe)
GO

Insert_TuyenXe N'BX Long Xuyên - Châu Đốc', '6h', '18h', N'BX Long Xuyên', N'Châu Đốc',N'BX Long Xuyên - Châu Thành - Châu Phú - Châu Đốc', 30, 2

CREATE PROC Update_TuyenXe
	@matuyenxe varchar(10),
	@tentuyenxe nvarchar(100),
	@giobatdau varchar(5),
	@gioketthuc varchar(5),
	@diemdau nvarchar(50),
	@diemketthuc nvarchar(50),
	@chitiettram nvarchar(1000),
	@tansuat int,
	@soluongxe int
AS
	BEGIN
		UPDATE TuyenXe
		SET
			tentuyenxe = @tentuyenxe,
			giobatdau = @giobatdau,
			gioketthuc = @gioketthuc,
			diemdau = @diemdau,
			diemcuoi = @diemketthuc,
			chitiettram = @chitiettram,
			tansuat = @tansuat,
			soluongxe = @soluongxe
		WHERE
			matuyenxe = @matuyenxe
	END
GO

CREATE PROC Delete_TuyenXe
	@matuyenxe varchar(10)
AS
	BEGIN
		DELETE TuyenXe
		WHERE matuyenxe = @matuyenxe
	END
GO

CREATE PROC Search_TuyenXe
	@search nvarchar(100)
AS	
	BEGIN
		SELECT * from TuyenXe where (tentuyenxe LIKE N'%'+@search+'%' OR matuyenxe LIKE '%'+@search+'%' OR diemdau like N'%'+@search+'%'OR diemcuoi like N'%'+@search+'%' OR chitiettram like '%'+@search+'%' OR giobatdau like '%'+@search+'%')
	END

/****** Object:  StoredProcedure HanhKhachThang   Script Date: 7/11/2020 10:14:35 AM ******/

CREATE PROCEDURE Get_HanhKhachThang
AS
BEGIN
    SELECT
        *
    FROM
        HanhKhachThang
END;
GO

CREATE PROCEDURE Insert_HanhKhachThang
	@tenhk nvarchar(100),
	@gioitinh nvarchar(10),
	@diachi nvarchar(100),
	@cmnd varchar(9),
	@doituonguutien int
AS
	DECLARE @count int,
	@mahk varchar(10)
	SET @count = (SELECT COUNT (*) FROM HanhKhachThangBackup)
	IF (@count < 10)
	BEGIN
		SET @mahk = 'HK00' + CONVERT(varchar, @count + 1)
	END
	ELSE IF(@count < 100)
	BEGIN
		SET @mahk = 'HK0' + CONVERT(varchar, @count + 1)
	END
	ELSE
	BEGIN
		SET @mahk = 'HK' + CONVERT(varchar, @count + 1)
	END
	INSERT INTO HanhKhachThang VALUES (@mahk, @tenhk, @gioitinh, @diachi, @cmnd, @doituonguutien)
	INSERT INTO HanhKhachThangBackup VALUES (@mahk, @tenhk, @gioitinh, @diachi, @cmnd, @doituonguutien)
GO

Insert_HanhKhachThang N'Nam Béo' , N'Nam' , N'Long Xuyên', '352458973', 1

CREATE PROC Update_HanhKhachThang
	@mahk varchar(10),
	@tenhk nvarchar(100),
	@gioitinh nvarchar(10),
	@diachi nvarchar(100),
	@cmnd varchar(9),
	@doituonguutien int
AS
	BEGIN
		UPDATE HanhKhachThang
		SET
			tenhk = @tenhk,
			gioitinh = @gioitinh,
			diachi = @diachi,
			cmnd = @cmnd,
			doituonguutien = @doituonguutien
		WHERE
			mahk = @mahk
	END
GO

CREATE PROC Delete_HanhKhachThang
	@mahk varchar(10)
AS
	BEGIN
		DELETE HanhKhachThang
		WHERE mahk = @mahk
	END
GO

drop proc Delete_HanhKhachThang

CREATE PROC Search_HanhKhachThang
	@search nvarchar(100)
AS	
	BEGIN
		SELECT * from HanhKhachThang where (tenhk LIKE N'%'+@search+'%' OR mahk LIKE '%'+@search+'%' OR diachi like N'%'+@search+'%'OR gioitinh like N'%'+@search+'%' OR cmnd like '%'+@search+'%')
	END

/****** Object:  StoredProcedure VeThang1Tuyen   Script Date: 7/11/2020 10:14:35 AM ******/

select * from VeThang1Tuyen
CREATE PROCEDURE Get_VeThang1Tuyen
AS
BEGIN
    SELECT
        v1t.*,hk.mahk,hk.tenhk, tx.matuyenxe, tx.tentuyenxe, nv.manv, nv.hoten
    FROM
        HanhKhachThang hk,TuyenXe tx, NhanVien nv, VeThang1Tuyen v1t
	WHERE
		v1t.mahk = hk.mahk AND v1t.manv = nv.manv AND v1t.matuyenxe = tx.matuyenxe
END;
GO

drop proc Insert_VeThang1Tuyen

CREATE PROCEDURE Insert_VeThang1Tuyen
	@matuyenxe varchar(10),
	@mahk varchar(10),
	@manv varchar(10),
	@ngaydangky date,
	@ngayhethan date,
	@giave float
AS
	DECLARE @count int,
	@mavethang varchar(10)
	SET @count = (SELECT COUNT (*) FROM VeThang1TuyenBackup)
	IF (@count < 10)
	BEGIN
		SET @mavethang = 'V1T00' + CONVERT(varchar, @count + 1)
	END
	ELSE IF(@count < 100)
	BEGIN
		SET @mavethang = 'V1T0' + CONVERT(varchar, @count + 1)
	END
	ELSE
	BEGIN
		SET @mavethang = 'V1T' + CONVERT(varchar, @count + 1)
	END
	INSERT INTO VeThang1Tuyen VALUES (@mavethang, @matuyenxe,@mahk,@manv,@ngaydangky,@ngayhethan,@giave)
	INSERT INTO VeThang1TuyenBackup VALUES (@mavethang, @matuyenxe,@mahk,@manv,@ngaydangky,@ngayhethan,@giave)
GO

Insert_VeThang1Tuyen 'TUXE001','HK001','NV001', '7-12-2020' , '8-12-2020' , 55000 

select * from VeThang1TuyenBackup

delete VeThang1Tuyen where mavethang = 'V1T001'

CREATE PROC Update_VeThang1Tuyen
	@mavethang varchar(10),
	@matuyenxe varchar(10),
	@mahk varchar(10),
	@manv varchar(10),
	@ngaydangky date,
	@ngayhethan date,
	@giave float
AS
	BEGIN
		UPDATE VeThang1Tuyen
		SET
			matuyenxe = @matuyenxe,
			mahk = @mahk,
			manv = @manv,
			ngaydangky = @ngaydangky,
			ngayhethan = @ngayhethan,
			giave = @giave
		WHERE
			mavethang = @mavethang
	END
GO

CREATE PROC Delete_VeThang1Tuyen
	@mavethang varchar(10)
AS
	BEGIN
		DELETE VeThang1Tuyen
		WHERE mavethang = @mavethang
	END
GO

CREATE PROCEDURE Search_VeThang1Tuyen
@input varchar(50)
AS
BEGIN
    SELECT
        v1t.*,hk.mahk,hk.tenhk, tx.matuyenxe, tx.tentuyenxe, nv.manv, nv.hoten
    FROM
        HanhKhachThang hk,TuyenXe tx, NhanVien nv, VeThang1Tuyen v1t
	WHERE
		v1t.mahk = hk.mahk AND v1t.manv = nv.manv AND v1t.matuyenxe = tx.matuyenxe
		and (v1t.mavethang like '%'+ @input +'%' OR v1t.matuyenxe like '%'+ @input +'%' OR v1t.mahk like '%'+ @input +'%' OR v1t.manv  like '%'+ @input +'%' OR v1t.giave like '%'+ @input +'%' OR hk.tenhk like '%'+ @input +'%' OR  tx.tentuyenxe like '%'+ @input +'%' OR  nv.hoten like '%'+ @input +'%')
END;
GO
Search_VeThang1Tuyen 'Th'

select * from VeThang1Tuyen

Search_VeThang1Tuyen N'Thái Trường An' 

/****** Object:  StoredProcedure VeThangLienTuyen    Script Date: 7/11/2020 10:14:35 AM ******/

select * from VeThangLienTuyen
CREATE PROCEDURE Get_VeThangLienTuyen
AS
BEGIN
    SELECT
        vlt.*,hk.mahk,hk.tenhk, nv.manv, nv.hoten
    FROM
        HanhKhachThang hk, NhanVien nv, VeThangLienTuyen vlt
	WHERE
		vlt.mahk = hk.mahk AND vlt.manv = nv.manv
END;
GO

drop proc Insert_VeThangLienTuyen

CREATE PROCEDURE Insert_VeThangLienTuyen
	@mahk varchar(10),
	@manv varchar(10),
	@ngaydangky date,
	@ngayhethan date,
	@giave float
AS
	DECLARE @count int,
	@mavethang varchar(10)
	SET @count = (SELECT COUNT (*) FROM VeThangLienTuyenBackup)
	IF (@count < 10)
	BEGIN
		SET @mavethang = 'VLT00' + CONVERT(varchar, @count + 1)
	END
	ELSE IF(@count < 100)
	BEGIN
		SET @mavethang = 'VLT0' + CONVERT(varchar, @count + 1)
	END
	ELSE
	BEGIN
		SET @mavethang = 'VLT' + CONVERT(varchar, @count + 1)
	END
	INSERT INTO VeThangLienTuyen VALUES (@mavethang,@mahk,@manv,@ngaydangky,@ngayhethan,@giave)
	INSERT INTO VeThangLienTuyenBackup VALUES (@mavethang,@mahk,@manv,@ngaydangky,@ngayhethan,@giave)
GO

DElete VeThangLienTuyenBackup where mavethang = 'VLT001'

select * from VeThangLienTuyenBackup

Insert_VeThangLienTuyen 'HK002', 'NV001','7-12-2020','8-12-2020',100000

CREATE PROC Update_VeThangLienTuyen
	@mavethang varchar(10),
	@mahk varchar(10),
	@manv varchar(10),
	@ngaydangky date,
	@ngayhethan date,
	@giave float
AS
	BEGIN
		UPDATE VeThangLienTuyen
		SET
			mahk = @mahk,
			manv = @manv,
			ngaydangky = @ngaydangky,
			ngayhethan = @ngayhethan,
			giave = @giave
		WHERE
			mavethang = @mavethang
	END
GO

CREATE PROC Delete_VeThangLienTuyen
	@mavethang varchar(10)
AS
	BEGIN
		DELETE VeThangLienTuyen
		WHERE mavethang = @mavethang
	END
GO
drop PROCEDURE Search_VeThang1Tuyen

CREATE PROCEDURE Search_VeThangLienTuyen
@input varchar(50)
AS
BEGIN
    SELECT
        vlt.*,hk.mahk,hk.tenhk, nv.manv, nv.hoten
    FROM
        HanhKhachThang hk, NhanVien nv, VeThangLienTuyen vlt
	WHERE
		vlt.mahk = hk.mahk AND vlt.manv = nv.manv
		and (vlt.mavethang like '%'+ @input +'%' OR vlt.mahk like '%'+ @input +'%' OR vlt.manv  like '%'+ @input +'%' OR vlt.giave like '%'+ @input +'%' OR hk.tenhk like '%'+ @input +'%' OR  nv.hoten like '%'+ @input +'%')
END;
GO

select * from VeThang1TuyenBackup

/****** Object:  StoredProcedure CaTruc   Script Date: 7/11/2020 10:14:35 AM ******/

select * from PhuXe

DROP TABLE TaiXeBackup

ALTER TABLE CaTruc DROP CONSTRAINT fk_TaiXe_CaTruc

DROP PROC Get_CaTruc

CREATE PROCEDURE Get_CaTruc
AS
BEGIN
    SELECT
        ct.*,xe.bienkiemsoat, tuxe.tentuyenxe , tx.hotentx, px.hoten
    FROM
        CaTruc ct , Xe xe, TuyenXe tuxe, TaiXe tx, PhuXe px
	WHERE
		ct.maxe = xe.maxe AND ct.matuyenxe = tuxe.matuyenxe AND ct.matx = tx.matx AND ct.mapx = px.mapx
END;
GO

select * from TaiXe

CREATE PROCEDURE Insert_CaTruc
	@ngaytruc date,
	@ca int,
	@maxe varchar(10),
	@matuyenxe varchar(10),
	@matx varchar(10),
	@mapx varchar(10)
AS
	DECLARE @count int,
	@matuyenduong varchar(10)
	SET @count = (SELECT COUNT (*) FROM CaTrucBackup)
	IF (@count < 10)
	BEGIN
		SET @matuyenduong = 'CT00' + CONVERT(varchar, @count + 1)
	END
	ELSE IF(@count < 100)
	BEGIN
		SET @matuyenduong = 'CT0' + CONVERT(varchar, @count + 1)
	END
	ELSE
	BEGIN
		SET @matuyenduong = 'CT' + CONVERT(varchar, @count + 1)
	END
	INSERT INTO CaTruc VALUES (@matuyenduong,@ngaytruc,@ca,@maxe,@matuyenxe,@matx,@mapx)
	INSERT INTO CaTrucBackup VALUES (@matuyenduong,@ngaytruc,@ca,@maxe,@matuyenxe,@matx,@mapx)
GO

CREATE PROC Update_CaTruc
	@matuyenduong varchar(10),
	@ngaytruc date,
	@ca int,
	@maxe varchar(10),
	@matuyenxe varchar(10),
	@matx varchar(10),
	@mapx varchar(10)
AS
	BEGIN
		UPDATE CaTruc
		SET
			ngaytruc = @ngaytruc,
			ca = @ca,
			maxe = @maxe,
			matuyenxe = @matuyenxe,
			matx = @matx,
			mapx =@mapx
		WHERE
			matuyenduong = @matuyenduong
	END
GO

CREATE PROC Delete_CaTruc
	@matuyenduong varchar(10)
AS
	BEGIN
		DELETE CaTruc
		WHERE matuyenduong = @matuyenduong
	END
GO

Insert_CaTruc '7-13-2020', '1', 'XE001','TUXE001','TX001','PX002'

drop table TaiXe
delete CaTrucBackup where matuyenduong = 'CT001'

/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_Login]
@Username nvarchar(100), @Password nvarchar(100)
AS
BEGIN
	SELECT t.*, n.* FROM dbo.TaiKhoan t, nhanvien n WHERE tendangnhap = @Username AND matkhau = @Password and t.manv = n.manv
END
GO
--DoanhThu



SELECT MONTH(ngaydangky) AS THANG, SUM(giave) AS DOANHTHU
FROM VeThang1Tuyen
WHERE YEAR(ngaydangky) = 2020
GROUP BY MONTH(ngaydangky)

SELECT * from GiaVeNgay

INSERT INTO GiaVeNgay(magiavengay,giaveloai1,giaveloai2,giaveloai3) VALUES ('GV001',7000,8000,9000)

DROP PROC Get_DoanhThuNgay

CREATE PROCEDURE Get_DoanhThuNgay
AS
BEGIN
    SELECT
        dtn.*,px.hoten
    FROM
        DoanhThuNgay dtn,PhuXe px
	WHERE
		dtn.mapx = px.mapx
END;
GO

select * from DoanhThuThang

drop table doanh

select * from DoanhThuNgay

CREATE PROCEDURE Insert_DoanhThuNgay
	@mapx varchar(10),
	@tenvengay varchar(50),
	@ngay date,
	@soluongve1 int,
	@soluongve2 int,
	@soluongve3 int,
	@doanhthu float
AS
	DECLARE @count int,
	@madtngay varchar(10)
	SET @count = (SELECT COUNT (*) FROM DoanhThuNgayBackup)
	IF (@count < 10)
	BEGIN
		SET @madtngay = 'DTN00' + CONVERT(varchar, @count + 1)
	END
	ELSE IF(@count < 100)
	BEGIN
		SET @madtngay = 'DTN0' + CONVERT(varchar, @count + 1)
	END
	ELSE
	BEGIN
		SET @madtngay = 'DTN' + CONVERT(varchar, @count + 1)
	END
	INSERT INTO DoanhThuNgay VALUES (@madtngay,@mapx,@tenvengay,@ngay,@soluongve1,@soluongve2,@soluongve3,@doanhthu)
	INSERT INTO DoanhThuNgayBackup VALUES (@madtngay,@mapx,@tenvengay,@ngay,@soluongve1,@soluongve2,@soluongve3,@doanhthu)
GO

CREATE PROC Update_DoanhThuNgay
	@madtngay varchar(10),
	@mapx varchar(10),
	@tenvengay varchar(50),
	@ngay date,
	@soluongve1 int,
	@soluongve2 int,
	@soluongve3 int,
	@doanhthu float
AS
	BEGIN
		UPDATE DoanhThuNgay
		SET
			madtngay = @madtngay,
			mapx = @mapx,
			tenvengay = @tenvengay,
			soluongveloai1 = @soluongve1,
			soluongveloai2 = @soluongve2,
			soluongveloai3 =@soluongve3,
			dtngay = @doanhthu
		WHERE
			madtngay = @madtngay
	END
GO

CREATE PROC Delete_DoanhThuNgay
	@madtngay varchar(10)
AS
	BEGIN
		DELETE DoanhThuNgay
		WHERE madtngay = @madtngay
	END
GO

drop proc Get_GiaVe

CREATE PROCEDURE Get_GiaVe
AS
BEGIN
    SELECT
        *
    FROM
        GiaVeNgay
END;
GO

INSERT INTO DoanhThuThang(madtthang,dtthang1,dtthang2,dtthang3,dtthang4,dtthang5,dtthang6,dtthang7,dtthang8,dtthang9,dtthang10,dtthang11,dtthang12) VALUES ('DTT001',0,0,0,0,0,0,0,0,0,0,0,0)
 
CREATE PROC Update_DoanhThuNgay
	@madtthang varchar(10)	
AS
	DECLARE @thang int,
	@dtthang1 float,
	@dtthang2 float,
	@dtthang3 float,
	@dtthang4 float,
	@dtthạng5 float,
	@dtthang6 float,
	@dtthang7 float,
	@dtthang8 float,
	@dtthang9 float,
	@dtthang10 float,
	@dtthang11 float,
	@dtthang12 float,
	@dtthangve1tuyen float,
	@dtthangvelientuyen float,
	@dtngay float,
	@tongdoanhthu float
	SET @thang = (SELECT MONTH(ngay) FROM DoanhThuNgay WHERE YEAR(ngay) = 2020 and MONTH(ngay) = 1)
	IF (@thang = 1)
	BEGIN
		SET @dtthangve1tuyen = (SELECT SUM(giave) FROM VeThang1Tuyen WHERE MONTH(ngaydangky) = 1)
		SET @dtthangvelientuyen = (SELECT SUM(giave) FROM VeThangLienTuyen WHERE MONTH(ngaydangky) = 1)
		SET @dtngay = (SELECT SUM(dtngay) FROM DoanhThuNgay WHERE MONTH(ngay) = 1)
		SET @tongdoanhthu = @dtthangve1tuyen + @dtthangvelientuyen + @dtngay
	END
	ELSE IF (@thang = 2)
	BEGIN
		SET @dtthangve1tuyen = (SELECT SUM(giave) FROM VeThang1Tuyen WHERE MONTH(ngaydangky) = 2)
		SET @dtthangvelientuyen = (SELECT SUM(giave) FROM VeThangLienTuyen WHERE MONTH(ngaydangky) = 2)
		SET @dtngay = (SELECT SUM(dtngay) FROM DoanhThuNgay WHERE MONTH(ngay) = 2)
		SET @tongdoanhthu = @dtthangve1tuyen + @dtthangvelientuyen + @dtngay
	END
	ELSE IF (@thang = 3)
	BEGIN
		SET @dtthangve1tuyen = (SELECT SUM(giave) FROM VeThang1Tuyen WHERE MONTH(ngaydangky) = 3)
		SET @dtthangvelientuyen = (SELECT SUM(giave) FROM VeThangLienTuyen WHERE MONTH(ngaydangky) = 3)
		SET @dtngay = (SELECT SUM(dtngay) FROM DoanhThuNgay WHERE MONTH(ngay) = 3)
		SET @tongdoanhthu = @dtthangve1tuyen + @dtthangvelientuyen + @dtngay
	END
	ELSE IF (@thang = 4)
	BEGIN
		SET @dtthangve1tuyen = (SELECT SUM(giave) FROM VeThang1Tuyen WHERE MONTH(ngaydangky) = 4)
		SET @dtthangvelientuyen = (SELECT SUM(giave) FROM VeThangLienTuyen WHERE MONTH(ngaydangky) = 4)
		SET @dtngay = (SELECT SUM(dtngay) FROM DoanhThuNgay WHERE MONTH(ngay) = 4)
		SET @tongdoanhthu = @dtthangve1tuyen + @dtthangvelientuyen + @dtngay
	END
	ELSE IF (@thang = 5)
	BEGIN
		SET @dtthangve1tuyen = (SELECT SUM(giave) FROM VeThang1Tuyen WHERE MONTH(ngaydangky) = 4)
		SET @dtthangvelientuyen = (SELECT SUM(giave) FROM VeThangLienTuyen WHERE MONTH(ngaydangky) = 4)
		SET @dtngay = (SELECT SUM(dtngay) FROM DoanhThuNgay WHERE MONTH(ngay) = 4)
		SET @tongdoanhthu = @dtthangve1tuyen + @dtthangvelientuyen + @dtngay
	END
	BEGIN
		UPDATE DoanhThuThang
		SET
			madtngay = @madtngay,
			mapx = @mapx,
			tenvengay = @tenvengay,
			soluongveloai1 = @soluongve1,
			soluongveloai2 = @soluongve2,
			soluongveloai3 =@soluongve3,
			dtngay = @doanhthu
		WHERE
			madtngay = @madtngay
	END
GO


SELECT MONTH(ngaydangky) as thang, SUM(giave) as doanhthu
FROM VeThang1Tuyen
WHERE YEAR(ngaydangky) = 2020
GROUP BY MONTH(ngaydangky)

select * from DoanhThuThang

/****** Object:  StoredProcedure TaiKhoan    Script Date: 7/11/2020 10:14:35 AM ******/

CREATE PROCEDURE Get_TaiKhoan
AS
BEGIN
    SELECT
        tk.*,nv.hoten
    FROM
        TaiKhoan tk,NhanVien nv
	WHERE
		tk.manv = nv.manv
END;
GO

CREATE PROCEDURE Insert_TaiKhoan
	@manv nvarchar(10),
	@tendangnhap varchar(100),
	@matkhau varchar(100),
	@quyen varchar(10)
AS
	INSERT INTO TaiKhoan VALUES (@manv,@tendangnhap,@matkhau,@quyen)
GO

CREATE PROC Update_TaiKhoan
	@id int,
	@manv nvarchar(10),
	@tendangnhap varchar(100),
	@matkhau varchar(100),
	@quyen varchar(10)
AS
	BEGIN
		UPDATE TaiKhoan
		SET
			manv = @manv,
			tendangnhap = @tendangnhap,
			matkhau = @matkhau,
			quyen = @quyen
		WHERE
			id = @id
	END
GO

CREATE PROC Delete_TaiKhoan
	@id int
AS
	BEGIN
		DELETE TaiKhoan
		WHERE id = @id
	END
GO

/****** Object:  StoredProcedure [dbo].[uspGetStaff]    Script Date: 7/11/2020 10:14:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetStaff]
AS
BEGIN
    SELECT
        nv.*
    FROM
        NhanVien nv
END;
GO
USE [master]
GO
ALTER DATABASE [QLXEBUS] SET  READ_WRITE 
GO



