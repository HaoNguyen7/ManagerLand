USE QLNHADAT
--------------converson deadlock-----------
-----------trans 2----------
go
ALTER PROC sp_updateNV_Fixed @idnv varchar(10), @idcnhanh varchar(10), @tennv varchar(50), @dienthoainv char(10), @gioitinhnv varchar(3), @ngaysinhnv datetime, @luongnv money, @diachinv varchar(100)

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