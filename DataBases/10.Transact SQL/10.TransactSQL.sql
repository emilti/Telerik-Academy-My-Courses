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

