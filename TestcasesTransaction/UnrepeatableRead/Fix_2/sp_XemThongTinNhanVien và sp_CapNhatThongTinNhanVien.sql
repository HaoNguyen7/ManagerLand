
/*SESSION 1*/
create proc sp_XemThongTinNhanVien
as
begin
	begin tran
	select *
	from dbo.NHANVIEN
	commit
END

BEGIN TRANSACTION
EXEC sp_XemThongTinNhanVien
WAITFOR DELAY '00:00:05.000'
EXEC sp_XemThongTinNhanVien
COMMIT TRANSACTION


/*Session 2*/
--T2
create proc sp_CapNhapNhanVien
	@idNV varchar(10),@idChiNhanh varchar(10),@tenNV varchar(100),@dienthoaiNV varchar(10),@gioitinhNV varchar(3),@ngaysinhNV datetime,@luong money,@diachiNV varchar(256)
as
begin
	begin tran
	set tran isolation level repeatable read
		begin TRY
			IF(NOT EXISTS(SELECT * FROM dbo.NHANVIEN WHERE IDNV=@idNV))
			BEGIN
			    PRINT('Khong ton tai nhan vien');
			END
			UPDATE dbo.NHANVIEN
			SET IDCNHANH=@idChiNhanh,TENNV = @tenNV, DIENTHOAINV=@dienthoaiNV,GIOITINHNV=@gioitinhNV,NGAYSINHNV=@ngaysinhNV,LUONGNV=@luong,DIACHINV=@diachiNV
			WHERE IDNV = @idNV
		end try
		begin catch
			rollback tran
		end catch
	commit
END

