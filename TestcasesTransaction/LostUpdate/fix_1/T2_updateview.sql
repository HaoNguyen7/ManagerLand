USE [QLNHADAT]
GO


--T2
alter proc [dbo].[sp_updateView_FIX_T2] @houseID varchar(10) = NULL, @views int = NULL
as
BEGIN TRAN 
	declare @currentViews int
	set @currentViews = (select LUOTXEM from NHA n WITH(UPDLOCK, ROWLOCK)  where n.IDNHA = @houseID)

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
exec sp_updateView_FIX_T2 '1', 1
go
select * from NHA
go