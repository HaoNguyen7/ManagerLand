use master
go

use QLNHADAT
go 

BEGIN TRANSACTION

select *
from NHANVIEN
where IDNV = @NhanVienID

select *
from NHA
where IDNV = @NhanVienID and TINHTRANG = 0

COMMIT TRANSACTION