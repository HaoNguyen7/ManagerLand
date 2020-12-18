
----Phantom read------
/*Session 1*/
BEGIN TRANSACTION
SELECT * FROM dbo.NHANVIEN WHERE GIOITINHNV='Nam'

WAITFOR DELAY '00:00:05.000';

SELECT * FROM dbo.NHANVIEN WHERE GIOITINHNV='Nam'
COMMIT TRANSACTION

------Phantom Read----
/*Session 2*/
INSERT INTO dbo.NHANVIEN
(
    IDNV,IDCNHANH,TENNV,DIENTHOAINV,GIOITINHNV,NGAYSINHNV,LUONGNV,DIACHINV
)
VALUES
(   '4',        -- IDNV - varchar(10)
    '2',        -- IDCNHANH - varchar(10)
    'Nguyen Cung',        -- TENNV - varchar(50)
    '0808333345',        -- DIENTHOAINV - char(10)
    'Nam',        -- GIOITINHNV - varchar(3)
    '02/01/2000', -- NGAYSINHNV - datetime
    500,      -- LUONGNV - money
    'Nha Be'         -- DIACHINV - varchar(100)
    )