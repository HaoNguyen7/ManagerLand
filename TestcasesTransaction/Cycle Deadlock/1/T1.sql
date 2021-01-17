USE [QLNHADAT]
GO

create proc [dbo].[sp_update] @houseID  varchar(10), @NhanVienID varchar(10)
as
begin tran
	begin try

		update NHA
		set TINHTRANG = 1
		where IDNHA = @houseID

		waitfor delay '00:00:05'

		update NHANVIEN
		set LUONGNV = 500
		where IDNV = @NhanVienID
		print 'Cap nhat 1 nha ban duoc, tang luong thanh cong'

		SELECT RESOURCE_TYPE,DB_NAME(RESOURCE_DATABASE_ID)
		NAME,REQUEST_SESSION_ID,REQUEST_MODE,REQUEST_STATUS
		FROM SYS.DM_TRAN_LOCKS
	end try

	begin catch	
		print 'Loi he thong'
		rollback tran
	end catch

commit tran

exec sp_update '1', '1'
go


drop proc sp_update

select * from NHA
select * from NHANVIEN
