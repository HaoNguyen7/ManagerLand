USE [QLNHADAT]
GO

alter proc [dbo].[sp_update2] @houseID  varchar(10), @NhanVienID varchar(10)
as
begin tran
	begin try

		update NHANVIEN
		set LUONGNV = 500
		where IDNV = @NhanVienID
		
		update NHA
		set TINHTRANG = 1
		where IDNHA = @houseID

		print 'Cap nhat 1 nha ban duoc, tang luong thanh cong'

	end try

	begin catch	
		print 'Loi he thong'
		rollback tran
	end catch
commit tran

exec sp_update2 '1', '1'

drop proc sp_update2