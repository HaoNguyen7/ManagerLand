--------------converson deadlock-----------
-----------trans 1----------
BEGIN TRANSACTION
set tran isolation level SERIALIZABLE
Select * from NHANVIEN 
WAITFOR DELAY '00:00:5';
INSERT INTO dbo.NHANVIEN
(
    @idnv,
    @idcnhanh,
    @tennv,
    @dienthoainv,
    @gioitinhnv,
    @ngaysinhnv,
    @luongnv,
    @diachinv
)
VALUES
(   
     '9','2','Que A','1111','Nam','12/12/2000',1000,'VietNam')
COMMIT TRANSACTION

-----------trans 2----------
BEGIN TRANSACTION
set tran isolation level SERIALIZABLE
Select * from NHANVIEN 
WAITFOR DELAY '00:00:5';
UPDATE NHANVIEN
SET 
    IDNV='5'
    IDCHINHANH='2'
    TENNV='Que C'
    DIENTHOAINV='1111'
    GIOITINHNV='Nam'
    NGAYSINHNV='12/12/2000'
    LUONG=1000
    DIACHINV='VietNam'
Where  IDNV='5'

COMMIT TRANSACTION