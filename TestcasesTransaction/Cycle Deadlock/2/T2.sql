

USE [QLNHADAT]
GO

CREATE proc [dbo].[sp_updatechunha2] @houseID  varchar(10), @NhanVienID varchar(10), @DiaChi varchar(20)
as
begin tran
	begin try
		update NHA
		set IDNV = @NhanVienID
		where IDNHA = @houseID

	
		declare @IDChuNha int
		set @IDChuNha = (select IDCNHA from   NHA     where IDNHA = @houseID)

		update CHUNHA
		set DIACHICNHA = @DiaChi
		where IDCNHA = @IDChuNha

		SELECT RESOURCE_TYPE,DB_NAME(RESOURCE_DATABASE_ID)
		NAME,REQUEST_SESSION_ID,REQUEST_MODE,REQUEST_STATUS
		FROM SYS.DM_TRAN_LOCKS
	end try

	begin catch	
		print 'Loi he thong'
		rollback tran
	end catch

commit tran