USE QLNHADAT
--------------converson deadlock-----------
-----------trans 1----------
go
CREATE	proc sp_InsertNV	@idNV varchar(10),@idChiNhanh varchar(10),@tenNV varchar(100),@dienthoaiNV varchar(10),@gioitinhNV varchar(3),@ngaysinhNV datetime,@luong money,@diachiNV varchar(256)
as
BEGIN TRAN
	BEGIN TRY
		SET	TRAN ISOLATION	LEVEL SERIALIZABLE
		IF(EXISTS(SELECT * FROM dbo.NHANVIEN WHERE IDNV=@idNV))
		BEGIN
		    PRINT N'Tồn tại nhân viên!'
		END
		Select * from NHANVIEN 
		WAITFOR DELAY '00:00:10';
        INSERT INTO dbo.NHANVIEN
        VALUES
		   (@idNV,       
            @idChiNhanh,   
            @tenNV,       
            @dienthoaiNV,    
            @gioitinhNV,    
            @ngaysinhNV,
            @luong,      
            @diachiNV)
	END	TRY
	BEGIN CATCH
			PRINT N'Lỗi hệ thống!'
		ROLLBACK TRAN
	END	CATCH
COMMIT
go
EXEC dbo.sp_InsertNV_Fix '26','2','Que A','1111','Nam','12/12/2000',1000,'VietNam'
GO
SELECT * FROM dbo.NHANVIEN
GO
-----------trans 2----------
go
CREATE PROC sp_updateNV @idnv varchar(10), @idcnhanh varchar(10), @tennv varchar(50), @dienthoainv char(10), @gioitinhnv varchar(3), @ngaysinhnv datetime, @luongnv money, @diachinv varchar(100)

as
BEGIN TRAN 
	BEGIN TRY
		SET tran isolation level SERIALIZABLE
		SELECT * from NHANVIEN WITH(UPDLOCK)
		
		UPDATE NHANVIEN
		SET 
	   IDNV=@idNV,
	   IDCNHANH=@idcnhanh,
	   TENNV=@tenNV,
	   DIENTHOAINV=@dienthoaiNV,
	   GIOITINHNV=@gioitinhNV,
	   NGAYSINHNV=@ngaysinhNV,
	   LUONGNV=@luongnv,
	   DIACHINV=@diachiNV
		WHERE  IDNV=@idNV	
	end try

	begin catch
		print N'Lỗi hệ thống!'
		rollback tran
	end CATCH
COMMIT TRAN 
GO


EXEC dbo.sp_updateNV_Fixed '9','2','Que C','1111','Nam','12/12/2000',1000,'VietNam'
go
SELECT * FROM dbo.NHANVIEN