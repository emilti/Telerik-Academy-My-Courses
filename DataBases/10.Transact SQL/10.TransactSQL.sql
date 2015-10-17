/* 01. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).

    Insert few records for testing.
    Write a stored procedure that selects the full names of all persons.*/

USE AccountDatabase
CREATE TABLE Persons (
  id int IDENTITY,	
  FirstName nvarchar(50)  NOT NULL,
  LastName nvarchar(50) NOT NULL,
  SSN int NOT NULL, 
  CONSTRAINT PK_USER PRIMARY KEY(id),
 )
GO

CREATE TABLE Accounts (
  id int IDENTITY,	
  person_id int  NOT NULL, 
  balance int  NOT NULL, 
  CONSTRAINT ACCOUNT_ID PRIMARY KEY(id),
  FOREIGN KEY (person_id) REFERENCES Persons(id)
) 
GO

INSERT Persons VALUES ('aaaa','aaaa',  12345)
INSERT Persons VALUES ('bbbb','bbbb',  12345)
INSERT Persons VALUES ('cccc','cccc',  12345)

INSERT Accounts VALUES (1, 1000)
INSERT Accounts VALUES (2, -1000)
INSERT Accounts VALUES (3, 2000)

USE AccountDatabase;
GO
CREATE PROCEDURE FULLNAMES    
AS     
    SELECT FirstName +' ' + LastName as FullName
    FROM Persons   
GO

EXECUTE FULLNAMES;
GO

DROP PROCEDURE FULLNAMES

/* 02. Create a stored procedure that accepts a number as a parameter and returns all persons
 who have more money in their accounts than the supplied number.*/

USE AccountDatabase
GO
CREATE PROCEDURE CHECKMONEY @moneyToBeEvaluated int AS     
SELECT p.id, p.FirstName, p.LastName, p.SSN, a.balance
FROM Accounts a	
INNER JOIN Persons p 
ON a.person_id = p.id 
WHERE @moneyToBeEvaluated < a.balance 
GO

EXECUTE CHECKMONEY @moneyToBeEvaluated=200;
GO

DROP PROCEDURE CHECKMONEY

/* 03. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
    It should calculate and return the new sum.
    Write a SELECT to test whether the function works as expected.*/
USE AccountDatabase
GO
CREATE PROCEDURE CALCULATEINTEREST @sum decimal(9,2), @yearlyInterestRate decimal(9,2), @numberOfMonths decimal(9,2), @calculatedSum decimal(9,2) OUTPUT AS     
SET @calculatedSum = (@sum *  @yearlyInterestRate *  @numberOfMonths)/  (12.00 *  100.00) + @sum
GO
DECLARE @result decimal(9,2);
DECLARE @calculatedSum smallint
EXECUTE CALCULATEINTEREST 100, 3, 6, @result OUTPUT;
SELECT CONVERT(Decimal(9,2), @result)
GO

DROP PROCEDURE CALCULATEINTEREST;


/* 04. Create a stored procedure that uses the function from the previous example to give an 
interest to a person's account for one month.
It should take the AccountId and the interest rate as parameters.*/

USE AccountDatabase
GO
CREATE PROCEDURE CALCULATEACCOUNTINTEREST @account_id int, @yearlyInterestRate decimal(9,2),  @calculatedSum decimal(9,2) OUTPUT AS     
DECLARE @balance AS INT;
SET @balance = (SELECT SUM(balance)
FROM Accounts 
WHERE id = @account_id);

SET @calculatedSum = (@balance *@yearlyInterestRate)/  (12.00 *  100.00) + @balance
GO
DECLARE @result decimal(9,2);
DECLARE @calculatedSum smallint
EXECUTE CALCULATEACCOUNTINTEREST 1, 3, @result OUTPUT;
SELECT CONVERT(Decimal(9,2), @result)
GO

DROP PROCEDURE CALCULATEACCOUNTINTEREST;

/* 05. Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, money)
 that operate in transactions.*/
/*WITHDRAW MONEY*/
USE AccountDatabase
GO

CREATE PROCEDURE WithdrawMoney @account_id int, @moneyToWithdraw decimal(9,2),  @calculatedSum decimal(9,2) OUTPUT AS     
DECLARE @balance AS INT;
SET @balance = (SELECT SUM(balance)
FROM Accounts 
WHERE id = @account_id);
SET @calculatedSum = @balance - @moneyToWithdraw 
UPDATE Accounts
SET balance = @calculatedSum
FROM Accounts
WHERE id = @account_id;
GO

DECLARE @result decimal(9,2);
DECLARE @calculatedSum smallint
EXECUTE WithdrawMoney 1, 300, @result OUTPUT;
SELECT CONVERT(Decimal(9,2), @result)
GO

DROP PROCEDURE WithdrawMoney;

/*DEPOSIT MONEY*/
USE AccountDatabase
GO

CREATE PROCEDURE DepositMoney @account_id int, @moneyToDeposit decimal(9,2),  @calculatedSum decimal(9,2) OUTPUT AS     
DECLARE @balance AS INT;
SET @balance = (SELECT SUM(balance)
FROM Accounts 
WHERE id = @account_id);
SET @calculatedSum = @balance + @moneyToDeposit
UPDATE Accounts
SET balance = @calculatedSum
FROM Accounts
WHERE id = @account_id;
GO

DECLARE @result decimal(9,2);
DECLARE @calculatedSum smallint
EXECUTE DepositMoney 1, 300, @result OUTPUT;
SELECT CONVERT(Decimal(9,2), @result)
GO

DROP PROCEDURE DepositMoney;

/* 06. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
Add a trigger to the Accounts table that enters a new entry into the Logs 
table every time the sum on an account changes.*/

CREATE TABLE Logs (
  LogID int IDENTITY,	
  AccountID int, 
  oldSum decimal, 
  newSum decimal,   
  CONSTRAINT PK_WorkHours PRIMARY KEY(LogID)  
)
GO

CREATE TRIGGER Tr_AccountsUpdateLogs ON Accounts FOR UPDATE
 AS
DECLARE @action char(10)
SET @action = 'UPDATE'
INSERT INTO Logs (AccountID, newSum, oldSum)
SELECT  a.id, a.balance, b.balance
FROM inserted a,
deleted b
GO


DROP trigger Tr_AccountsUpdateLogs
DROP Table Logs

/* 07. Define a function in the database TelerikAcademy that returns all Employee's names 
(first or middle or last name) and all town's names that are comprised of given set of letters.
Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.*/
USE TelerikAcademy
GO

CREATE PROCEDURE CheckLetters @letter1 varchar(1), @letter2 varchar(1),  @letter3 varchar(1) AS     
SELECT a.FirstName, a.MiddleName, a.LastName, c.Name
FROM Employees a
JOIN Addresses b
ON a.AddressID = b.AddressID
JOIN  TOWNS c
ON b.TownID = c.TownID
WHERE a.FirstName = '%' + @letter1 + '%' 
/*AND a.FirstName = '%' + @letter2 + '%' AND a.FirstName = '%' + @letter3 + '%'*/
GO

EXECUTE CheckLetters 'c', 'b', 'c'

DROP PROCEDURE CheckLetters