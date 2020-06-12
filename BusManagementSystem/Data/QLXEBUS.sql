USE MASTER
DROP DATABASE QLXEBUS
CREATE DATABASE QLXEBUS
GO
USE QLXEBUS

CREATE TABLE TaiKhoan
(
	id int identity(1,1) PRIMARY KEY,
	manv varchar(10),
	tendangnhap varchar(100),
	matkhau varchar(100),
	quyen varchar(10),
)
GO

CREATE TABLE Quyen
(
	maquyen varchar(10) PRIMARY KEY,
	ten nvarchar(50),
)

ALTER TABLE TaiKhoan 
	ADD CONSTRAINT fk_TaiKhoan_Quyen
		FOREIGN KEY(quyen)
		REFERENCES Quyen(maquyen);

ALTER TABLE NhanVien 
	ADD CONSTRAINT fk_NhanVien_Quyen
		FOREIGN KEY(taikhoan)
		REFERENCES Quyen(maquyen);

ALTER TABLE TaiKhoan 
	ADD CONSTRAINT fk_TaiKhoan_NhanVien
		FOREIGN KEY(manv)
		REFERENCES NhanVien(manv);


CREATE TABLE NhanVien
(
	manv varchar(10) PRIMARY KEY,
	anh varchar(100),
	hoten nvarchar(50),
	ngaysinh date,
	diachi nvarchar(500),
	gioitinh nvarchar(10),
	dienthoai varchar(10),
	cmnd varchar(9),
	bangcap nvarchar(20),
	taikhoan varchar(10),
	phongban nvarchar(50),
)
GO

CREATE TABLE TaiXe
(
	matx varchar(10) PRIMARY KEY,
	anh varchar(100),
	hoten nvarchar(50),
	ngaysinh date,
	gioitinh nvarchar(10),
	diachi nvarchar(100),
	dienthoai varchar(10),
	cmnd varchar(9),
	loaibang varchar(2),
	matuyenxe varchar(10)
)
GO

ALTER TABLE TaiXe 
	ADD CONSTRAINT fk_TaiXe_TuyenXe
		FOREIGN KEY(matuyenxe)
		REFERENCES TuyenXe(matuyenxe);

CREATE TABLE PhuXe
(
	mapx varchar(10) PRIMARY KEY,
	anh varchar(100),
	ngaysinh date,
	gioitinh nvarchar(10),
	dienthoai varchar(10),
	cmnd varchar(9),
	matuyenxe varchar(10)
)
GO

ALTER TABLE PhuXe 
	ADD CONSTRAINT fk_PhuXe_TuyenXe
		FOREIGN KEY(matuyenxe)
		REFERENCES TuyenXe(matuyenxe);

CREATE TABLE Xe
(
	maxe varchar(10) PRIMARY KEY,
	bienkiemsoat varchar(20),
	hangsanxuat varchar(50),
	namsanxuat int,
	soghe int,
	matuyenxe varchar(10)
)
GO

ALTER TABLE Xe 
	ADD CONSTRAINT fk_Xe_TuyenXe
		FOREIGN KEY(matuyenxe)
		REFERENCES TuyenXe(matuyenxe);

CREATE TABLE TuyenXe
(
	matuyenxe varchar(10) PRIMARY KEY,
	tentuyenxe nvarchar(100),
	giobatdau time,
	gioketthuc time,
	diemdau nvarchar(50),
	diemcuoi nvarchar(50),
	chitiettram nvarchar(200),
	tansuat int,
	soluongxe int
)
GO

CREATE TABLE TuyenDuong
(
	matuyenduong varchar(10) PRIMARY KEY,
	ca int,
	maxe varchar(10),
	matuyenxe varchar(10),
	matx varchar(10),
	mapx varchar(10)
)
GO

ALTER TABLE TuyenDuong 
	ADD CONSTRAINT fk_TuyenDuong_Xe
		FOREIGN KEY(maxe)
		REFERENCES Xe(maxe);
ALTER TABLE TuyenDuong 
	ADD CONSTRAINT fk_TuyenDuong_TuyenXe
		FOREIGN KEY(matuyenxe)
		REFERENCES TuyenXe(matuyenxe);
ALTER TABLE TuyenDuong 
	ADD CONSTRAINT fk_TuyenDuong_TaiXe
		FOREIGN KEY(matx)
		REFERENCES TaiXe(matx);
ALTER TABLE TuyenDuong 
	ADD CONSTRAINT fk_TuyenDuong_PhuXe
		FOREIGN KEY(mapx)
		REFERENCES PhuXe(mapx);

CREATE TABLE KhachHangThang
(
	makh varchar(10) PRIMARY KEY,
	tenkh nvarchar(100),
	gioitinh nvarchar(10),
	diachi nvarchar(100),
	cmnd varchar(9),
	doituonguutien int,
	loaivethang int, -- 1 tuyến và liên tuyến
	matuyenxe varchar(10) ,
)

ALTER TABLE KhachHangThang 
	ADD CONSTRAINT fk_KhachHangThang_TuyenXe
		FOREIGN KEY(matuyenxe)
		REFERENCES TuyenXe(matuyenxe);



CREATE TABLE NhanVienBanVeThang(
	manv varchar(10) PRIMARY KEY,
	anh varchar(100),
	hoten nvarchar(50),
	ngaysinh date,
	gioitinh nvarchar(10),
	diachi nvarchar(100),
	dienthoai varchar(10),
	cmnd varchar(9),
	diembanve nvarchar(50)	
)

CREATE TABLE DoanhThuNgay
(
	madtngay varchar(10) PRIMARY KEY,
	mapx varchar(10),
	tenvengay varchar(50),
	soveban int,
	dtngay int
)

ALTER TABLE DoanhThuNgay
	ADD CONSTRAINT fk_DoanhThuNgay_PhuXe
		FOREIGN KEY(mapx)
		REFERENCES PhuXe(mapx);

CREATE TABLE DoanhThuThang
(
	madtthang varchar(10) PRIMARY KEY,
	manv varchar(10),
	tenvengay varchar(50),
	soveban int,
	dtthang int
)

ALTER TABLE DoanhThuThang 
	ADD CONSTRAINT fk_DoanhThuThang_NhanVienBanVeThang
		FOREIGN KEY(manv)
		REFERENCES NhanVienBanVeThang(manv);


SELECT * FROM KhachHangThang

CREATE PROC USP_Login
@Username nvarchar(100), @Password nvarchar(100)
AS
BEGIN
	SELECT t.*, n.* FROM dbo.TaiKhoan t, nhanvien n WHERE tendangnhap = @Username AND matkhau = @Password and t.manv = n.manv
END
GO
drop proc USP_Login

CREATE PROCEDURE uspGetStaff
AS
BEGIN
    SELECT
        nv.*,q.*
    FROM
        NhanVien nv,Quyen q
    where
        nv.taikhoan = q.maquyen
END;

uspGetStaff

CREATE PROCEDURE uspGetRole
AS
BEGIN
    SELECT
        *
    FROM
        Quyen
END;