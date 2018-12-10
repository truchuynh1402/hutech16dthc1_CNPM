CREATE DATABASE QuanLyCafe
GO

USE QuanLyCafe 
GO

-- tạo dánh sach bàn ---

CREATE TABLE danhsachban
(
	id INT IDENTITY PRIMARY KEY NOT NULL,
	nameTable NVARCHAR(100),
	trangthaiTable NVARCHAR(100) DEFAULT N'Trống' -- Trống || Có Người
	
)
GO 

--Tạo ACCOUNT đăng nhâp --
CREATE TABLE Acc
(
	id INT IDENTITY PRIMARY KEY NOT NULL,
	ShowName NVARCHAR(100) NOT NULL ,
	UserName NVARCHAR(100) NOT NULL,
	PassAcc NVARCHAR(1000) NOT NULL,
	Type INT NOT NULL DEFAULT 0 --- 0 là nhân viên || 1 là ADMIN
)
GO

 -- Tạo Danh Mục Nước ---
 
CREATE TABLE DanhMucCafe
(
	id INT IDENTITY PRIMARY KEY NOT NULL,
	NameDanhMuc NVARCHAR(100) NOT NULL DEFAULT N'Chưa Đặt tên'
)
GO

-- Tạo Nước Uốn -- 
 
CREATE TABLE Nuoc
(
	id INT IDENTITY PRIMARY KEY NOT NULL,
	NameNuoc NVARCHAR(100) NOT NULL DEFAULT N'Chưa Đặt Tên',
	idDanhMuc INT NOT NULL,
	GiaNuoc FLOAT NOT NULL
	
	FOREIGN KEY (idDanhMuc) REFERENCES dbo.DanhMucCafe(id)
)
GO

-- Tạo Bill món --- 

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY NOT NULL,
	NgayCheckIn DATE NOT NULL DEFAULT GETDATE(),
	NgayCheckOut DATE,
	idBan INT NOT NULL,
	TrangThai INT NOT NULL
	FOREIGN KEY (idBan) REFERENCES dbo.DanhSachban(id)
	
)
GO

-- Gọi Bill info --- 

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY NOT NULL,
	idBill INT NOT NULL,
	
	idNuoc INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idNuoc) REFERENCES dbo.Nuoc(id)
)
GO
