USE [QLNHADAT]
GO


--T2
create proc [dbo].[sp_updateView_T2] @houseID varchar(10) = NULL, @views int = NULL
as
begin
	declare @currentViews int
	set @currentViews = (select LUOTXEM from NHA where IDNHA = @houseID)

	update NHA
	set LUOTXEM = @currentViews + @views
	where IDCNHA = @houseID
end
GO

select * from NHA
go
exec sp_updateView_T2
go
select * from NHA
go