use QLNHADAT
go

create proc sp_XemThongTinNha
as
begin
	begin tran
	set tran isolation level read uncommitted
	select *
	from NHA
	commit
end

--T1
begin tran
	exec sp_XemThongTinNha
	waitfor delay '00:00:10'
	exec sp_XemThongTinNha
commit
