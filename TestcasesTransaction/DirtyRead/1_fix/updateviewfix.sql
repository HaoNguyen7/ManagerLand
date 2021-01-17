USE [QLNHADAT]
GO

--T1
create proc [dbo].[sp_updateView_2_T1_FIX] @houseID varchar(10) = NULL, @views int = NULL
as
begin tran
	begin TRY
		SET TRAN ISOLATION LEVEL READ COMMITTED
		declare @currentViews int
		set @currentViews = (select LUOTXEM from NHA where IDNHA = @houseID)
		update NHA
		set LUOTXEM = @currentViews + @views
		where IDCNHA = @houseID
	SELECT RESOURCE_TYPE,DB_NAME(RESOURCE_DATABASE_ID)
	NAME,REQUEST_SESSION_ID,REQUEST_MODE,REQUEST_STATUS
	FROM SYS.DM_TRAN_LOCKS
		waitfor delay '00:00:10'
		if(@currentViews > @currentViews + @views)
		begin
			print N'Cập nhật lượt xem bị lỗi!'
			rollback tran
		end
	end try
	
	begin catch
		print N'Lỗi hệ thống!'
		rollback tran
	end CATCH
    
	
commit transaction
GO

--cai nay chay truoc
select * from NHA
go
exec sp_updateView_2_T1_FIX '3', -1
go
select * from NHA
go