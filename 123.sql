CREATE TABLE account
(
	username VARCHAR(30),
	password VARCHAR(30),
	typeAcc bit
)

ALTER TABLE account
ALTER COLUMN typeAcc INT


INSERT INTO dbo.account
(
    username,
    password,
    typeAcc
)
VALUES
(   'a',  -- username - varchar(30)
    '1',  -- password - varchar(30)
    1 -- typeAcc - bit
    )
	INSERT INTO dbo.account
	(
	    username,
	    password,
	    typeAcc
	)
	VALUES
	(   'b', -- username - varchar(30)
	    '1', -- password - varchar(30)
	    2   -- typeAcc - int
	    )
INSERT INTO dbo.account
(
    username,
    password,
    typeAcc
)
VALUES
(   'c', -- username - varchar(30)
    '1', -- password - varchar(30)
    3   -- typeAcc - int
)
go

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN 
	SELECT * FROM dbo.account WHERE username=@userName AND password=@passWord
END 
go

SELECT * FROM dbo.account

SELECT * FROM dbo.account WHERE username='a'
EXEC USP_Login 'a','1'



