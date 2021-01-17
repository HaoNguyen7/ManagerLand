use QLNHADAT
go

--T2
create proc sp_CapNhapNha
	@idNha varchar(10),@idChuNha varchar(10),@idChiNhanh varchar(10),@idNhanVien varchar(10),@idLoaiNha varchar(10),@SoLuongNha int,@NgayDang datetime,@NgayHetHan datetime,@TinhTrang varchar(10),@LuotXem bigint,@DuongNha varchar(10),@QuanNha varchar(10),@TPNha varchar(10),@KhuVucNha varchar(10)
as
begin
	begin tran
	set tran isolation level repeatable read
		begin try
			update NHA
			set NHA.DUONGNHA = @DuongNha,NHA.IDCNHA = @idChuNha,NHA.IDCNHANH = @idChiNhanh,NHA.IDLOAINHA = @idLoaiNha,NHA.IDNV = @idNhanVien,NHA.KHUVUCNHA = @KhuVucNha,NHA.LUOTXEM = @LuotXem,NHA.NGAYDANG = @NgayDang,NHA.NGAYHETHANG = @NgayHetHan,NHA.QUANNHA = @QuanNha,NHA.SOLUONGNHA = @SoLuongNha,NHA.TINHTRANG = @TinhTrang,NHA.TPNHA = @TPNha
			where NHA.IDNHA = @idNha
		end try
		begin catch
			rollback tran
		end catch
	commit
end

exec sp_CapNhapNha "4","1","1","1","1",1,"2019-01-17 00:00:00.000","2019-01-12 00:00:00.000","8",8,"8","8","8","8"
