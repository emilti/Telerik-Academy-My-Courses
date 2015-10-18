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
use TelerikAcademy
GO

CREATE FUNCTION ufn_CheckName(
@nameToCheck NVARCHAR(50), 
@letters NVARCHAR(50))
RETURNS INT
AS
BEGIN
        DECLARE @i INT = 1
		DECLARE @currentChar NVARCHAR(1)
        WHILE (@i <= LEN(@nameToCheck))
			BEGIN
				SET @currentChar = SUBSTRING(@nameToCheck,@i, 1)
					IF (CHARINDEX(LOWER(@currentChar),LOWER(@letters)) <= 0) 
						BEGIN  
							RETURN 0
						END
				SET @i = @i + 1
			END
        RETURN 1
END
GO

CREATE FUNCTION dbo.ufn_AllEmploeeysAndTownByStringCondition(@format nvarchar(50))
RETURNS @table TABLE
	([Name] nvarchar(50) NOT NULL)
AS
BEGIN
	INSERT @table
	SELECT newTbl.LastName FROM
		(SELECT LastName FROM Employees
		UNION
		SELECT Name FROM Towns) as newTbl
		WHERE dbo.ufn_CheckName(newTbl.LastName, @format) > 0
	 RETURN
END
GO

SELECT * FROM ufn_AllEmploeeysAndTownByStringCondition('oiseltmiahf')

/* 08. Using database cursor write a T-SQL script that scans all employees and their addresses
 and prints all pairs of employees that live in the same town.*/

DECLARE empCursor CURSOR READ_ONLY FOR
  SELECT e.FirstName, e.LastName, t.Name FROM Employees e
  JOIN Addresses a
  ON e.AddressID = a.AddressID
  JOIN Towns t
  ON a.TownID = t.TownID

OPEN empCursor
DECLARE @firstName nvarchar(50), @lastName nvarchar(50), @town nvarchar(50)
FETCH NEXT FROM empCursor INTO @firstName, @lastName, @town

WHILE @@FETCH_STATUS = 0
  BEGIN
  			  DECLARE empCursor1 CURSOR READ_ONLY FOR
			  SELECT e.FirstName, e.LastName, t.Name FROM Employees e
			  JOIN Addresses a
			  ON e.AddressID = a.AddressID
			  JOIN Towns t
			  ON a.TownID = t.TownID

			OPEN empCursor1
			DECLARE @firstName1 nvarchar(50), @lastName1 nvarchar(50), @town1 nvarchar(50)
			FETCH NEXT FROM empCursor1 INTO @firstName1, @lastName1, @town1

			WHILE @@FETCH_STATUS = 0
			  BEGIN
			  IF(@town=@town1 AND @firstName != @firstName1 AND @lastName != @lastName1)
				  BEGIN
					PRINT @town+':'+ @firstName + ' ' + @lastName + ':' + @firstName1 + ' ' + @lastName1 
				  END
				FETCH NEXT FROM empCursor1 INTO @firstName1, @lastName1, @town1
			  END

			CLOSE empCursor1
			DEALLOCATE empCursor1

    FETCH NEXT FROM empCursor  INTO @firstName, @lastName, @town
  END

CLOSE empCursor
DEALLOCATE empCursor

/* 10. Define a .NET aggregate function `StrConcat` that takes as input a sequence of 
strings and return a single string that consists of the input strings separated by '`,`'.
*	For example the following SQL statement should return a single string:
```sql
SELECT StrConcat(FirstName + ' ' + LastName)
FROM Employees
```
*/

EXEC sp_configure 'clr enabled', 1
GO
RECONFIGURE
GO

CREATE ASSEMBLY CommaSeparatedValue
AUTHORIZATION dbo
FROM 'D:\TelerikMy\DataBases\10.Transact SQL\CommaSeparatedValue.dll'
WITH PERMISSION_SET = SAFE;
GO

CREATE AGGREGATE dbo.StringConcat (
@value nvarchar(MAX), 
@delimiter nvarchar(50)
) 
RETURNS nvarchar(MAX)
EXTERNAL NAME CommaSeparatedValue.[CommaSeparatedValue.CommaSeparatedValue]
--–EXTERNAL NAME SQLAssemblyName.[C#NameSpace”.C#ClassName].C#MethodName

SELECT dbo.StringConcat(FirstName, ',')
FROM Employees

DROP AGGREGATE dbo.StringConcat
DROP ASSEMBLY CommaSeparatedValue