USE [QLNHADAT]
GO

CREATE proc [dbo].[sp_update] @houseID  varchar(10), @ChuNhaID varchar(10), @Ten nvarchar(20)
as
begin
	update CHUNHA
	set TENCNHA = @Ten
	where IDCNHA = @ChuNhaID

	waitfor delay '00:00:05'

	update NHA
	set TINHTRANG = 1
	where IDNHA = @houseID

end
GO