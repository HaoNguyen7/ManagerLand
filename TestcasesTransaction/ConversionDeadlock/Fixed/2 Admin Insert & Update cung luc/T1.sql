USE QLNHADAT
--------------converson deadlock-----------
-----------trans 1----------
go
ALTER	proc sp_InsertNV_Fixed	@idNV varchar(10),@idChiNhanh varchar(10),@tenNV varchar(100),@dienthoaiNV varchar(10),@gioitinhNV varchar(3),@ngaysinhNV datetime,@luong money,@diachiNV varchar(256)
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