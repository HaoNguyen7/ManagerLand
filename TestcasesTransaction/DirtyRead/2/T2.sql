use QLNHADAT
go

--T2
--Xem thong tin tat ca cac nha
alter proc sp_XemThongTinNha
as
begin
	begin tran
	set tran isolation level read uncommitted
	select *
	from NHA
	commit tran
end
go

exec sp_XemThongTinNha