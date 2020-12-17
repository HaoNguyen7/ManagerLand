USE [QLNHADAT]
GO

--T2
CREATE proc [dbo].[sp_getView] @houseID  varchar(10) = NULL
as
begin
	SET TRAN ISOLATION LEVEL READ UNCOMMITTED
	select * from NHA where IDNHA = @houseID
end
GO

--Cai nay chay sau cai T1
exec sp_getView '1'
go