use QLNHADAT
go 

BEGIN TRANSACTION

select * from NHA where TINHTRANG = 0

select * from CHUNHA where IDCNHA = @IDChuNha

COMMIT TRANSACTION