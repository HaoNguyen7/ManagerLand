
----Phantom read------
/*Session 1*/
create proc sp_XemThongTinNhanVien
as
begin
	begin tran
	set tran isolation level read uncommitted
	select *
	from dbo.NHANVIEN
	commit
END

BEGIN TRANSACTION
EXEC sp_XemThongTinNhanVien
WAITFOR DELAY '00:00:05.000'
EXEC sp_XemThongTinNhanVien
COMMIT TRANSACTION
------Phantom Read----
/*Session 2*/

create proc sp_ThemNhanVien
	@idNV varchar(10),@idChiNhanh varchar(10),@tenNV varchar(100),@dienthoaiNV varchar(10),@gioitinhNV varchar(3),@ngaysinhNV datetime,@luong money,@diachiNV varchar(256)
as
begin
	begin tran
	set tran isolation level repeatable read
		begin TRY
        INSERT INTO dbo.NHANVIEN
        VALUES
        (   @idNV,        -- IDNV - varchar(10)
            @idChiNhanh,        -- IDCNHANH - varchar(10)
            @tenNV,        -- TENNV - varchar(50)
            @dienthoaiNV,        -- DIENTHOAINV - char(10)
            @gioitinhNV,        -- GIOITINHNV - varchar(3)
            @ngaysinhNV, -- NGAYSINHNV - datetime
            @luong,      -- LUONGNV - money
            @diachiNV        -- DIACHINV - varchar(100)
            )
		end try
		begin catch
			rollback tran
		end catch
	commit
end