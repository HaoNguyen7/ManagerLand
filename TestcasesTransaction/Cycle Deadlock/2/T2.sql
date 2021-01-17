

USE [QLNHADAT]
GO

CREATE proc [dbo].[sp_update] @houseID  varchar(10), @NhanVienID varchar(10)
as
begin

update NHA
	set IDNV = @NhanVienID
	where IDNHA = @houseID

	
	declare @IDChuNha int
	set @IDChuNha = (select IDCNHA from   NhA     where IDNHA = @houseID)

	select *
	from CHUNHA
	where IDCNHA = @IDChuNha

	end
GO