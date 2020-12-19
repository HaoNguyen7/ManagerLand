USE [QLNHADAT]
GO

CREATE proc [dbo].[sp_update] @houseID  varchar(10), @NhanVienID varchar(10)
as
begin
	update NHA
	set TINHTRANG = 1
	where IDNHA = @houseID

	waitfor delay '00:00:05'

	select *
	from NHANVIEN
	where IDNV = @NhanVienID
end
GO