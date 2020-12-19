USE [QLNHADAT]
GO

CREATE proc [dbo].[sp_update2]  @NhanVienID varchar(10), @Ten nvarchar(20)
as
begin
	update NHANVIEN
	set TENNV = @Ten
	where IDNV = @NhanVienID


	select *
	from NHA
	where IDNV = @NhanVienID
end
GO