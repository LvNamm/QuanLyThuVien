USE master
DROP database Quanlythuvien
USE Quanlythuvien

create database Quanlythuvien
use Quanlythuvien
create table Bandoc(
	MaBD int primary key identity(1,1),
	tenBD nvarchar(50),
	gioitinh nvarchar(7),
	diachi nvarchar(50),
	ngaysinh date,
)
SELECT * FROM dbo.Bandoc
create table  sach(
	MaSach int primary key identity(1,1),
	TenSach nvarchar(50),
	Tentacgia nvarchar(50),
	Trangthai int,)


create table MuonTra(
	Mamuontra int primary key identity(1,1),
	MaBD int,
	MaSach int,
	Ngaymuon date,
	Ngayhentra date,
	Trangthai int,
	foreign key (MaBD) references Bandoc(MaBD),
	foreign key (MaSach) references Sach(MaSach)
)
SELECT * FROM dbo.sach
select MaSach AS N'Mã sách', MaBD AS N'Mã bạn đọc', Ngaymuon AS N'Ngày mượn', Ngayhentra AS N'Ngày hẹn trả', TTmuontra.Trangthai AS N'Trạng thái'  FROM TTmuontra, dbo.MuonTra WHERE MaTTmuontra = MuonTra.Trangthai AND MaBD = 1
INSERT INTO dbo.MuonTra
(
    MaBD,
    MaSach,
    Ngaymuon,
    Ngayhentra,
    Trangthai
)
VALUES
(   1,         -- MaBD - int
    1,         -- MaSach - int
    GETDATE(), -- Ngaymuon - date
    GETDATE(), -- Ngayhentra - date
    0          -- Trangthai - int
    )
CREATE table TTmuontra(
MaTTmuontra int,
Trangthai nvarchar(15))

DROP TABLE NhanVien
CREATE TABLE NhanVien(
	Username VARCHAR(15)primary key,
	Tennv NVARCHAR(30),
	MK VARCHAR(20),
	Vaitro NVARCHAR(15),

)
INSERT INTO dbo.NhanVien
(
    Username,
    Tennv,
    MK,
    Vaitro
)
VALUES
(   'NV0011',  -- Username - varchar(15)
    N'Nguyễn Văn C', -- Tennv - nvarchar(30)
    'NV004', -- MK - nvarchar(20)
    N'Quản lý'  -- Vaitro - nvarchar(15)
    )

SELECT  Username AS N'Tài khoản', Tennv AS N'Tên nhân viên', MK AS N'Mật khẩu', Vaitro AS N'Vai trò' FROM dbo.NhanVien	

SELECT Username FROM dbo.NhanVien WHERE Username = 'NV001'

INSERT INTO TTmuontra VALUES(0,N'Chưa trả'),(1,N'Đã trả'),(2,N'Đã trả muộn')


-- DROP TABLE dbo.Nhanvien
-- 1 là vẫn còn trong thư viện
-- 0 là đang cho mượn
insert into sach values (N'Toán cao cấp',N'Nguyễn Đức Phong',1),
						(N'Triết học',N'Lương Văn Nam',1),
						(N'Nghìn lẻ một đêm',N'Nguyễn Đức Phong',1)

insert into Bandoc values(N'Lương Văn Nam',N'Nam',N'Hà Nội',GETDATE())
insert into Bandoc values(N'Nguyễn Đức Phong',N'Nam',N'Hải Dương',GETDATE())
insert into Bandoc values(N'Vũ Thị Trà My',N'Nữ',N'Hà Nội',GETDATE())
insert into Bandoc values(N'Nguyễn Thị Tố Uyên',N'Nữ',N'Hà Nội',GETDATE())
--2 Đã trả muộn
--1 Đã trả
--0 Chưa trả

SELECT * FROM dbo.Bandoc
