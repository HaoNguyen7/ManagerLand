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
create proc sp_ThemNha @idnha VARCHAR(10),
	@idChuNha varchar(10),@idChiNhanh varchar(10),@idNhanVien varchar(10),@idLoaiNha varchar(10),
	@SoLuongNha int,@NgayDang date,@NgayHetHan date,
	@TinhTrang bit,@luotxem BIGINT,@DuongNha varchar (50),@QuanNha varchar(50),@TPNha varchar (50),@KhuVucNha varchar(50)
as
begin
	begin tran
	set tran isolation level repeatable read
		begin TRY
		INSERT INTO dbo.NHA
		(
		    IDNHA,
		    IDCNHA,
		    IDCNHANH,
		    IDNV,
		    IDLOAINHA,
		    SOLUONGNHA,
		    NGAYDANG,
		    NGAYHETHANG,
		    TINHTRANG,
		    LUOTXEM,
		    DUONGNHA,
		    QUANNHA,
		    TPNHA,
		    KHUVUCNHA
		)
		VALUES
		(   @idnha,        -- IDNHA - varchar(10)
		    @idChuNha,        -- IDCNHA - varchar(10)
		    @idChiNhanh,        -- IDCNHANH - varchar(10)
		    @idNhanVien,        -- IDNV - varchar(10)
		    @idLoaiNha,        -- IDLOAINHA - varchar(10)
		    @SoLuongNha,         -- SOLUONGNHA - int
		    @NgayDang, -- NGAYDANG - datetime
		    @NgayHetHan, -- NGAYHETHANG - datetime
		    @TinhTrang,        -- TINHTRANG - varchar(10)
		    @luotxem,         -- LUOTXEM - bigint
		    @DuongNha,        -- DUONGNHA - varchar(50)
		    @QuanNha,        -- QUANNHA - varchar(50)
		    @TPNha,        -- TPNHA - varchar(50)
		    @KhuVucNha         -- KHUVUCNHA - varchar(50)
		    )
       
		end try
		begin catch
			rollback tran
		end catch
	commit
end