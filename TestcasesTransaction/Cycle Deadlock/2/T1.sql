USE [QLNHADAT]
GO

CREATE proc [dbo].[sp_updatechunha] @houseID  varchar(10), @ChuNhaID varchar(10), @Ten nvarchar(20)
as
begin tran
	begin try
		update CHUNHA
		set TENCNHA = @Ten
		where IDCNHA = @ChuNhaID

		waitfor delay '00:00:05'

		update NHA
		set TINHTRANG = 1
		where IDNHA = @houseID
		print 'Cập nhật thành công'

		SELECT RESOURCE_TYPE,DB_NAME(RESOURCE_DATABASE_ID)
		NAME,REQUEST_SESSION_ID,REQUEST_MODE,REQUEST_STATUS
		FROM SYS.DM_TRAN_LOCKS
	end try

	begin catch	
		print 'Loi he thong'
		rollback tran
	end catch

commit tran
