----Phantom read------
--Nhân viên đang xem nhà
/*Session 1*/
create proc sp_XemNha
as
begin
	begin tran
	SET TRANSACTION ISOLATION LEVEL REPEATABLE READ

	Select * from NHA 
	commit
END
go
BEGIN TRANSACTION
EXEC sp_XemNha
WAITFOR DELAY '00:00:05'
EXEC sp_XemNha
COMMIT TRANSACTION

--Chủ nhà đăng thêm 1 nhà mới 
/*Session 2*/
go
create proc sp_ThemNha
	@idChuNha varchar(10),@idChiNhanh varchar(10),@idLoaiNha varchar(10),@idNhanVien varchar(10),
	@KhuVucNha varchar(50),@NgayDang date,@NgayHetHan date,@QuanNha varchar(50),@SoLuongNha int,@TinhTrang bit,@DuongNha varchar (50),@TPNha varchar (50)
as
begin
	begin tran
	set tran isolation level repeatable read
		begin TRY
        Insert into NHA
		Values(	@idChuNha,
				@idChiNhanh,
				@idLoaiNha,
				@idNhanVien,
				@KhuVucNha,
				@NgayDang,
				@NgayHetHan,
				@QuanNha,
				@SoLuongNha,
				@TinhTrang,
				@DuongNha,
				@TPNha)

		end try
		begin catch
			rollback tran
		end catch
	commit
end