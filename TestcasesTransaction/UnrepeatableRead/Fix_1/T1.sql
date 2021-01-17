use QLNHADAT
go

alter proc sp_XemThongTinNha
as
begin
	begin tran
	set transaction isolation level repeatable read
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
