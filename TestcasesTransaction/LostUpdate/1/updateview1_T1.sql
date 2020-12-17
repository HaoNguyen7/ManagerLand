USE [QLNHADAT]
GO

--T1
create proc [dbo].[sp_updateView_T1] @houseID varchar(10) = NULL, @views int = NULL
as
begin
	declare @currentViews int
	set @currentViews = (select LUOTXEM from NHA where IDNHA = @houseID)
	waitfor delay '00:00:05'
	update NHA
	set LUOTXEM = @currentViews + @views
	where IDCNHA = @houseID
end
GO

select * from NHA
go
exec sp_updateView_T1
go
select * from NHA
go