USE [QLNHADAT]
GO

--T1
alter proc [dbo].[sp_updateView_T1] @houseID varchar(10) = NULL, @views int = NULL
as
BEGIN TRAN 
	declare @currentViews int
	set @currentViews = (select LUOTXEM from NHA where IDNHA = @houseID)
	waitfor delay '00:00:05'
	update NHA
	set LUOTXEM = @currentViews + @views
	where IDNHA = @houseID
COMMIT TRAN 
GO

select * from NHA
go
exec sp_updateView_T1
go
select * from NHA
go