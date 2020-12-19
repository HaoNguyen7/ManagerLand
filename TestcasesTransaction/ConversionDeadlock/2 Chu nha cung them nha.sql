--------------converson deadlock-----------
-----------trans 1----------
BEGIN TRANSACTION
set tran isolation level SERIALIZABLE
Select * from NHA
WAITFOR DELAY '00:00:5';
Insert into NHA
([IDNHA],
[IDCNHA],
[IDCNHANH],
[IDNV],
[IDLOAINHA],
[SOLUONGNHA],
[NGAYDANG],
[NGAYHETHANG],
[TINHTRANG],
[LUOTXEM],
[DUONGNHA],
[QUANNHA],
[TPNHA] ,
[KHUVUCNHA])
VALUES
('5', '2', '1', '1', '0', '4', '2019-05-01', NULL, '1', '10', '34 Nguyen Cong Tru', 'Quan 6', 'Tp Ho Chi Minh', 'Dong Nam Bo')
COMMIT TRANSACTION

-----------trans 2----------
BEGIN TRANSACTION
set tran isolation level SERIALIZABLE
Select * from NHA
WAITFOR DELAY '00:00:5';
Insert into NHA
([IDNHA],
[IDCNHA],
[IDCNHANH],
[IDNV],
[IDLOAINHA],
[SOLUONGNHA],
[NGAYDANG],
[NGAYHETHANG],
[TINHTRANG],
[LUOTXEM],
[DUONGNHA],
[QUANNHA],
[TPNHA] ,
[KHUVUCNHA])
VALUES
('6', '1', '1', '1', '0', '4', '2019-03-02', NULL, '1', '10', '34 Nguyen Van Cu', 'Quan 5', 'Tp Ho Chi Minh', 'Dong Nam Bo')
COMMIT TRANSACTION
