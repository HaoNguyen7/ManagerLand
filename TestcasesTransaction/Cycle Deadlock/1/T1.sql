use master
go

use QLNHADAT
go 

BEGIN TRANSACTION

update dbo.NHA
set TINHTRANG = 'Đã Thuê'
where IDNHA = '@NhaID'

waitfor delay '00:00:05'

select *
from NHANVIEN
where IDNV = @NhanVienID


COMMIT TRANSACTION

