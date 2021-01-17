--USE [QLNHADAT]
--GO

--T1 nhân viên 1 cập nhật lại view của nhà
--T2 nhân viên 2 cập nhật lại view của nhà
/****** Object:  StoredProcedure [dbo].[sp_updateView_ERROR]    Script Date: 12/17/2020 4:27:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


alter proc [dbo].[sp_updateView_ERROR] @houseID varchar(10) = NULL, @views int = NULL
as
BEGIN TRAN 
	declare @currentViews int
	set @currentViews = (select LUOTXEM from NHA where IDNHA = @houseID)

	update NHA
	set LUOTXEM = @currentViews + @views
	where IDNHA = @houseID
COMMIT TRAN 
GO