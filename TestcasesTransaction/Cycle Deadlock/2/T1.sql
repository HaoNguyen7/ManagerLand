use master
go

use QLNHADAT
go 

BEGIN TRANSACTION

update CHUNHA
set TENCNHA = @TenMoi
where IDCNHA = @IDChuNha

waitfor delay '00:00:05'

update NHA
set TINHTRANG = 1
where IDNHA = @IDNha

COMMIT TRANSACTION