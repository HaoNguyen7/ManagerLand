USE [QLNHADAT]
GO

--T2
alter proc [dbo].[sp_getView_FIX] @houseID  varchar(10) = NULL
as
begin
	SET TRAN ISOLATION LEVEL READ COMMITTED
	select * from NHA where IDNHA = @houseID

	SELECT RESOURCE_TYPE,DB_NAME(RESOURCE_DATABASE_ID)
	NAME,REQUEST_SESSION_ID,REQUEST_MODE,REQUEST_STATUS
	FROM SYS.DM_TRAN_LOCKS
end
GO

--Cai nay chay sau cai T1
exec sp_getView_FIX '3'
go