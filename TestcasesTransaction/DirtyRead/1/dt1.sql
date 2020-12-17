use QLNHADAT
go

--Nhân viên cập nhật view và chủ nhà xem view rác

--T1
CREATE proc [dbo].[sp_updateView_2_T1] @houseID varchar(10) = NULL, @views int = NULL
as
begin tran
	begin try
		declare @currentViews int
		set @currentViews = (select LUOTXEM from NHA where IDNHA = @houseID)
		update NHA
		set LUOTXEM = @currentViews + @views
		where IDCNHA = @houseID
		
		if(@currentViews > @currentViews + @views)
		begin
			print N'Cập nhật lượt xem bị lỗi!'
			rollback tran
		end
	end try
	
	begin catch
		print N'Lỗi hệ thống!'
		rollback tran
	end catch
commit transaction
GO

--T2
CREATE proc [dbo].[sp_getView] @houseID  varchar(10) = NULL
as
begin
	SET TRAN ISOLATION LEVEL READ UNCOMMITTED
	select * from NHA where IDNHA = @houseID
end
GO