USE [QLNHADAT]
GO

-- Vì nếu sử dụng serialazable hoặc repeatable read thì sẽ gây conversion deadlock nên chon giải pháp UPDLOCK, ROWLOCK
--T1
alter proc [dbo].[sp_updateView_FIX_T1] @houseID varchar(10) = NULL, @views int = NULL
as
BEGIN TRAN 
	declare @currentViews int
	set @currentViews = (select LUOTXEM from NHA n WITH(UPDLOCK, ROWLOCK) WHERE n.IDNHA = @houseID)
	waitfor delay '00:00:05'
	update NHA
	set LUOTXEM = @currentViews + @views
	where IDNHA = @houseID

	--SELECT RESOURCE_TYPE,DB_NAME(RESOURCE_DATABASE_ID)
	--NAME,REQUEST_SESSION_ID,REQUEST_MODE,REQUEST_STATUS
	--FROM SYS.DM_TRAN_LOCKS
COMMIT TRAN 
GO

select * from NHA
go
exec sp_updateView_FIX_T1 '1', 2
go
select * from NHA
go