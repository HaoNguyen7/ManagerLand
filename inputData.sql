--use QLNHADAT
--exec sp_XemYeuCauKhachHang NULL, NULL, HCM
--go
--Nhap liệu
--Chi nhánh -> CHủ nhà, loại nhà, -> Nhân viên -> Nhà -> Nhà thuê, Nhà bán, khách hàng, Thông tin đánh giá
--[CHINHANH](
--	[IDCNHANH] [varchar](10) NOT NULL,
--	[DTCNHANH] [varchar](10) NULL,
--	[FAXCNHANH] [varchar](10) NULL,
--	[DUONGCNHANH] [varchar](50) NULL,
--	[QUANCNHANH] [varchar](50) NULL,
--	[TPCNHANH] [varchar](50) NULL,
--	[KHUVUCCNHANH] [varchar](50) NULL)

insert CHINHANH
values('1', '0123456789', '0123456789', '56 Nguyen Dinh Chieu', 'Quan 7', 'Ho Chi Minh', 'Dong Nam Bo'),
('2', '0123456788', '0123456788', '56 Xa Lo Ha Noi', 'Quan Nam Tu Liem', 'Ha Noi', 'Dong Bac Bo')
go



--[CHUNHA](
--	[IDCNHA] [varchar](10) NOT NULL,
--	[TENCNHA] [varchar](50) NULL,
--	[DIACHICNHA] [varchar](100) NULL,
--	[_DTCNHA_] [varchar](10) NULL,

insert CHUNHA
values('1', 'Nguyen Van A', '12 Ngo Quyen, Quan 6, Tp HCM', '0987654321'),
('2', 'Nguyen Van B', '22 Vo Thi Sau, Quan 12, Tp HCM', '0987654322'),
('3', 'Nguyen Van C', '19 Hung vuong, Quan Cau Giay, Tp Ha Noi', '0987654323'),
('4', 'Nguyen Van D', '45 An Duong Vuong, Quan Dong Da, Tp Ha Noi', '0987654324')

--[LOAINHA](
--	[IDLOAINHA] [varchar](10) NOT NULL,
--	[TENLOAINHA] [varchar](50) NOT NULL,
insert LOAINHA
values('0', 'Nha Ban'),
('1', 'Nha Thue')
go
--[NHANVIEN](
--	[IDNV] [varchar](10) NOT NULL,
--	[IDCNHANH] [varchar](10) NOT NULL,
--	[TENNV] [varchar](50) NOT NULL,
--	[DIENTHOAINV] [char](10) NOT NULL,
--	[GIOITINHNV] [varchar](3) NOT NULL,
--	[NGAYSINHNV] [datetime] NOT NULL,
--	[LUONGNV] [money] NULL,
--	[DIACHINV] [varchar](100) NOT NULL,

insert NHANVIEN
values('1', '1', 'Pham Thi A', '1234567890', 'Nu', '1999-02-23', 500, 'thon Xuan An, xa Tinh Hoa, Tp Quang Ngai, tinh Quang Ngai'),
('2', '1', 'Luong Cong Tu', '1234567891', 'Nam', '1996-06-15', 400, '90 Ton That Thuyet, Quan 4, Tp Ho Chi Minh'),
('3', '2', 'Pham Thi C', '1234567892', 'Nu', '1994-10-23', 550, '78 Tan Ki, Nam Tu Liem, Tp Ha Noi')
go
--[NHA](
--	[IDNHA] [varchar](10) NOT NULL,
--	[IDCNHA] [varchar](10) NOT NULL,
--	[IDCNHANH] [varchar](10) NOT NULL,
--	[IDNV] [varchar](10) NOT NULL,
--	[IDLOAINHA] [varchar](10) NOT NULL, 0 la ban, 1 la cho thue
--	[SOLUONGNHA] [int] NULL,
--	[NGAYDANG] [date] NULL,
--	[NGAYHETHANG] [date] NULL,
--	[TINHTRANG] [varchar](10) NULL, 0 la chua thue ban, 1 la da thue ban
--	[LUOTXEM] [int] NULL,
--	[DUONGNHA] [varchar](50) NULL,
--	[QUANNHA] [varchar](50) NULL,
--	[TPNHA] [varchar](50) NULL,
--	[KHUVUCNHA] [varchar](50) NULL,
insert NHA
--Nha o Tp HCM 1
values('1', '1', '1', '1', '0', '4', '2019-01-01', NULL, '1', '10', '34 Nguyen Hue', 'Quan 4', 'Tp Ho Chi Minh', 'Dong Nam Bo'),
	  ('2', '1', '1', '1', '0', '3', '2019-01-01', NULL, '1', '2', '200 Nguyen Luong Bang', 'Quan 7', 'Tp Ho Chi Minh', 'Dong Nam Bo'),
	  ('3', '1', '1', '1', '1', '2', '2019-02-28', '2021-02-01', '0', '10', '58 Nguyen Van Linh', 'Quan 7', 'Tp Ho Chi Minh', 'Dong Nam Bo'),
	  ('4', '2', '1', '2', '1', '1', '2019-03-01', NULL, '0', '100', '34 Pham Van Dong', 'Quan Thu Duc', 'Tp Ho Chi Minh', 'Dong Nam Bo'),
--Nha o Ha Noi 2
	  ('5', '3', '2', '3', '0', '5', '2019-02-05', NULL, '0', '30', '34 Hung Vuong', 'Quan Nam Tu Liem', 'Tp Ha Noi', 'Dong Bac Bo'),
	  ('6', '3', '2', '3', '1', '2', '2019-04-01', NULL, '1', '5', '35 Nguyen Hue', 'Quan Nam Tu Liem', 'Tp Ha Noi', 'Dong Bac Bo'),
	  ('7', '4', '2', '3', '0', '4', '2019-01-17', NULL, '0', '50', ' 299 Nguyen Trung Truc', 'Quan Bac Tu Liem', 'Tp Ha Noi', 'Dong Bac Bo')
go
--[NHATHUE](
--	[IDNHA] [varchar](10) NOT NULL,
--	[TIENTHUE] [money] NULL,

insert NHATHUE
values('3', 100),
('4', 50),
('6', 90)
go
--[NHABAN](
--	[IDNHA] [varchar](10) NOT NULL,
--	[GIABAN] [money] NULL,
--	[DIEUKIENCNHA] [varchar](1000) NULL,

insert NHABAN
values('1', 100000, ''),
('2', 500000, ''),
('5', 120000, 'Nguoi mua uu tien phu nu'),
('7', 700000, '')
go
--[KHACHHANG](
--	[IDKH] [varchar](10) NOT NULL,
--	[IDCNHANH] [varchar](10) NOT NULL,
--	[TENKH] [varchar](50) NULL,
--	[DIACHIKH] [varchar](100) NULL,
--	[DIENTHOAIKH] [varchar](10) NULL,
--	[LOAINHA] [varchar](100) NULL,
--	[TIEUCHINHA] [varchar](100) NULL,
go
insert KHACHHANG
values('1', '1', 'Vo Duc An', 'Tp Ho Chi Minh', '0012345678', 'nha ban', 'Nha tren 3 phong'),
('2', '1', 'Ho Hoai Nam', 'Tp Ho Chi Minh', '0012345679', 'nha thue', 'Nha tren 2 phong'),
('3', '1', 'Ly Khang', 'Tp Ha Noi', '0012345670', 'nha ban', '')
go
--[TTDANHGIANHA](
--	[STT] [bigint] NOT NULL,
--	[IDNHANX] [varchar](10) NULL,
--	[NGAYNX] [datetime] NULL,
--	[NHANXET] [varchar](1000) NULL,
insert TTDANHGIANHA
values(1, '5', '2019-05-20', 'Nha qua dat'),
(2, '4', '2019-09-28', 'Nha nho, chat, chi co 1 phong')
go