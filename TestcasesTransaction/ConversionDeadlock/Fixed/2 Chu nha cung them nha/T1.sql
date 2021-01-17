USE QLNHADAT
--------------converson deadlock-----------
-----------trans 1----------
go
ALTER	proc sp_ThemNha_Fixed_T1 @idNha varchar(10),@idChuNha varchar(10),@idChiNhanh varchar(10),@idNhanVien varchar(10),
	@idLoaiNha varchar(10),@SoLuongNha int,@NgayDang datetime,@NgayHetHan datetime,@TinhTrang varchar(10),
	@LuotXem bigint,@DuongNha varchar(10),@QuanNha varchar(10),@TPNha varchar(10),@KhuVucNha varchar(10)

as
BEGIN TRAN
	BEGIN TRY
		SET	TRAN ISOLATION	LEVEL SERIALIZABLE
		IF(EXISTS(SELECT * FROM dbo.NHA WHERE IDNHA=@idNha))
		BEGIN
		    PRINT N'Tồn tại nhà!'
		END
		Select * from NHA
		WAITFOR DELAY '00:00:10';
        INSERT INTO dbo.NHA
        VALUES
		   (@idNha,
		    @idChuNha,
			@idChiNhanh,
			@idNhanVien,
			@idLoaiNha,
			@SoLuongNha,
			@NgayDang,
			@NgayHetHan,
			@TinhTrang,
			@LuotXem,
			@DuongNha,
			@QuanNha,
			@TPNha,
			@KhuVucNha)
	END	TRY
	BEGIN CATCH
			PRINT N'Lỗi hệ thống!'
		ROLLBACK TRAN
	END	CATCH
COMMIT
go
EXEC dbo.sp_ThemNha_Fixed_T1 '22', '2', '1', '1', '0', '4', '2019-05-01', NULL, '1', '10', '34 Nguyen Cong Tru', 'Quan 6', 'Tp Ho Chi Minh', 'Dong Nam Bo'
GO
SELECT * FROM dbo.NHA