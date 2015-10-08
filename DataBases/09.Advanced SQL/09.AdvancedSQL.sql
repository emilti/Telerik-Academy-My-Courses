SELECT *
FROM [TelerikAcademy].[dbo].[Employees]
order by DepartmentID

/* 1. Write a SQL query to find the names and salaries of the employees that take the minimal salary 
in the company.
Use a nested SELECT statement.*/
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary = 
  (SELECT MIN(Salary) FROM Employees)

/* 2. Write a SQL query to find the names and salaries of the employees that have a salary 
that is up to 10% higher than the minimal salary for the company.*/
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary <= 
  (SELECT (MIN(Salary) + MIN(Salary) * 0.1) FROM Employees)

/* 3. Write a SQL query to find the full name, salary and department of the employees
 that take the minimal salary in their department.
    Use a nested SELECT statement.*/

/*SELECT c.FirstName + ' ' + c.LastName as FullName, c.DepartmentID, c.Salary, g.Name
FROM Employees c
INNER JOIN Departments g 
    ON c.DepartmentID = g.DepartmentID
WHERE Salary = 
  (SELECT MIN(Salary) FROM Employees f  
   WHERE c.DepartmentID = DepartmentID)
ORDER BY DepartmentID*/


SELECT FirstName + ' ' + LastName as FullName, DepartmentID, Salary
FROM Employees e
WHERE Salary = 
  (SELECT MIN(Salary) FROM Employees  
   WHERE e.DepartmentID = DepartmentID)
ORDER BY DepartmentID

/* 4. Write a SQL query to find the average salary in the department #1.*/
SELECT AVG(Salary)
FROM Employees e
WHERE DepartmentID = 1 
  
/* 5. Write a SQL query to find the average salary in the "Sales" department.*/
SELECT AVG(Salary)
FROM Employees c
INNER JOIN Departments g 
    ON c.DepartmentID = g.DepartmentID 
	WHERE g.Name = 'Sales'

/* 6. Write a SQL query to find the number of employees in the "Sales" department.*/
SELECT Count(EmployeeID)
FROM Employees c
INNER JOIN Departments g 
    ON c.DepartmentID = g.DepartmentID 
	WHERE g.Name = 'Sales'

/* 7. Write a SQL query to find the number of all employees that have manager.*/
SELECT Count(EmployeeID)
FROM Employees
    WHERE ManagerID IS NOT NULL

/*8 Write a SQL query to find the number of all employees that have no manager.*/
SELECT Count(EmployeeID)
FROM Employees
    WHERE ManagerID IS NULL

/* 9 Write a SQL query to find all departments and the average salary for each of them.*/
SELECT DepartmentID, 
  AVG(Salary) as AverageSalary
FROM Employees
GROUP BY DepartmentID

/* 10 Write a SQL query to find the count of all employees in each department and for each town.*/
SELECT Count(m.EmployeeID) as CountOfEmployees,m.DepartmentID, h.Name
/* m.FirstName, m.LastName, m.DepartmentID, m.AddressID AddressFromEmployers, g.AddressID AddresFromAdress, g.AddressText, g.TownID, h.Name TownName
*/
FROM Employees m
INNER JOIN Addresses g 
    ON m.AddressID = g.AddressID
INNER JOIN Towns h 
    ON g.TownID = h.TownID
GROUP BY m.DepartmentID, h.Name

/* 11. Write a SQL query to find all managers that have exactly 5 employees. 
Display their first name and last name.*/
SELECT c.FirstName, c.LastName, c.EmployeeID
FROM Employees d 
JOIN Employees c
on d.ManagerID = c.EmployeeID
GROUP BY c.FirstName, c.LastName, c.EmployeeID
HAVING COUNT(d.EmployeeID) = 5

/* 12. Write a SQL query to find all employees along with their managers. 
For employees that do not have manager display the value "(no manager)".*/
SELECT *, ISNULL(c.FirstName + ' ' + c.LastName, '(no manager)') AS [Manager]
FROM Employees d
LEFT JOIN Employees c
on d.ManagerID = c.EmployeeID

/* 13. Write a SQL query to find the names of all employees whose last name is
 exactly 5 characters long. Use the built-in LEN(str) function.*/
 SELECT *
 FROM Employees
 WHERE LEN(LastName) = 5;

/* 14. Write a SQL query to display the current date and time in the following format
 "day.month.year hour:minutes:seconds:milliseconds".
    Search in Google to find how to format dates in SQL Server.*/
SELECT GETDATE() 'Today', 
       CONVERT(VARCHAR(20), GETDATE(), 113) 'hh:mi:ss:ms' 


/* 15 Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.

    Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
    Define the primary key column as identity to facilitate inserting records.
    Define unique constraint to avoid repeating usernames.
    Define a check constraint to ensure the password is at least 5 characters long.*/

CREATE TABLE Users (
  id int IDENTITY,	
  Username nvarchar(50)  NOT NULL,
  Password nvarchar(50),
  FullName nvarchar(100) NOT NULL,
  LastLoginTime DATETIME DEFAULT CURRENT_TIMESTAMP,
  CONSTRAINT PK_USER PRIMARY KEY(id),
  CONSTRAINT Unique_Username UNIQUE(Username) ,
  CONSTRAINT PasswordLength CHECK(LEN(Password) >= 5)
)
GO
 /* 16 Write a SQL statement to create a view that displays the users from
 the Users table that have been in the system today.
 Test if the view works correctly.*/

CREATE VIEW [Users Logged-in Today] AS
SELECT Username FROM Users
WHERE DAY(LastLoginTime) = DAY(GETDATE()) AND
MONTH(LastLoginTime) = MONTH(GETDATE()) AND
YEAR(LastLoginTime) = YEAR(GETDATE()) 
GO

/* 17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
Define primary key and identity column.*/
CREATE TABLE Groups (
  GroupId int IDENTITY,	
  Name nvarchar(50)  NOT NULL,  
  CONSTRAINT PK_Group PRIMARY KEY(GroupId),
  CONSTRAINT Unique_Group_Name UNIQUE(Name)   
)
GO

/* 18 Write a SQL statement to add a column GroupID to the table Users.
    Fill some data in this new column and as well in the `Groups table.
    Write a SQL statement to add a foreign key constraint between tables Users and Groups tables. */
ALTER TABLE Users ADD GroupId int 
GO

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY (GroupId)
REFERENCES Groups(GroupId)
GO

/* 19. Write SQL statements to insert several records in the Users and Groups tables.*/
INSERT INTO Groups VALUES ('aaa' )
INSERT INTO Groups VALUES ('bbb' )
INSERT INTO Groups VALUES ('ccc')
INSERT INTO Groups VALUES ('dddForRemoving')

INSERT INTO Users VALUES ('gggggggg', 'aaaaaaaaaa','aaaaaaa',  GETDATE(), 1)
INSERT INTO Users VALUES ('zzzzzzzzz', 'aaaaaaaaaa','aaaaaaa',  GETDATE(), 2)
INSERT INTO Users VALUES ('yyyyyy', 'aaaaaaaaaa','aaaaaaa',  GETDATE(), 2)
INSERT INTO Users VALUES ('xxxxxx', 'aaaaaaaaaa','aaaaaaa', GETDATE(), 3)
INSERT INTO Users VALUES ('wwwwww', 'aaaaaaaaaa','aaaaaaa', GETDATE(), 3)
INSERT INTO Users VALUES ('Removing', 'aaaaaaaaa','aaaaaaa', GETDATE(), 3)
/* 20.Write SQL statements to update some of the records in the Users and Groups tables.*/

UPDATE Groups
SET Name = 'changed'
FROM Groups
WHERE GroupId = 2

UPDATE Users
SET FullName = 'Changed Fullname'
FROM Users
WHERE id = 2

/* 21. Write SQL statements to delete some of the records from the Users and Groups tables.*/
DELETE FROM Groups WHERE GroupId = 4
DELETE FROM Users WHERE id = 6

/* 22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
    Combine the first and last names as a full name.
    For username use the first letter of the first name + the last name (in lowercase).
    Use the same for the password, and NULL for last login time.*/
INSERT INTO Users (Username, [Password], FullName, LastLoginTime)
SELECT LOWER(LEFT(FirstName, 3) + LastName),
		LOWER(LEFT(FirstName, 3) + LastName),
		FirstName + ' ' + LastName,
		NULL
FROM [TelerikAcademy].[dbo].[Employees]

/* 23.Write a SQL statement that changes the password to NULL for all users
 that have not been in the system since 10.03.2010.*/

UPDATE Users
SET LastLoginTime = CAST('2009-05-25' AS DATETIME)
FROM Users
WHERE id = 7

UPDATE Users
SET LastLoginTime = CAST('2009-10-25' AS DATETIME)
FROM Users
WHERE id = 8

UPDATE Users
SET [Password] = NULL
FROM Users
WHERE LastLoginTime < '2013-10-03'

/* 24. Write a SQL statement that deletes all users without passwords (NULL password).*/
DELETE FROM Users WHERE Password IS NULL

/* 25. Write a SQL query to display the average employee salary by department and job title.*/
SELECT d.DepartmentId, e.Name, d.JobTitle, AVG(SALARY) AS AverageSalary
FROM [TelerikAcademy].[dbo].[Employees] d, [TelerikAcademy].[dbo].[Departments] e
WHERE d.DepartmentId = e.DepartmentId
GROUP BY e.Name, d.DepartmentId, d.JobTitle 
ORDER By d.DepartmentId

/* 26. Write a SQL query to display the minimal employee salary by department and job title 
along with the name of some of the employees that take it.*/
SELECT d.DepartmentId, e.Name, d.JobTitle, MIN(d.FirstName),
MIN(d.Salary)
FROM [TelerikAcademy].[dbo].[Employees] d
INNER JOIN [TelerikAcademy].[dbo].[Departments] e
	on d.DepartmentId = e.DepartmentId
GROUP BY e.Name, d.DepartmentId, d.JobTitle
ORDER BY d.DepartmentId


/* 27.Write a SQL query to display the town where maximal number of employees work.*/
SELECT TOP 1 h.Name, COUNT(m.EmployeeId) as MaxCount
FROM Employees m
INNER JOIN Addresses g 
    ON m.AddressID = g.AddressID
INNER JOIN Towns h 
    ON g.TownID = h.TownID
GROUP BY h.Name

/* 28.Write a SQL query to display the number of managers from each town.*/
SELECT h.Name, COUNT(m.EmployeeID)
FROM Employees m
INNER JOIN Addresses g 
    ON m.AddressID = g.AddressID
INNER JOIN Towns h 
    ON g.TownID = h.TownID
	WHERE m.EmployeeID IN(SELECT ManagerID FROM Employees)
GROUP BY h.Name

/* 29. Write a SQL to create table WorkHours to store work reports for each employee 
(employee id, date, task, hours, comments).
Don't forget to define identity, primary key and appropriate foreign key.
Issue few SQL statements to insert, update and delete of some data in the table.
Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
For each change keep the old record data, the new record data and the command (insert / update / delete).*/
CREATE TABLE WorkHours (
  EmployeeId int IDENTITY,	
  Date DATETIME DEFAULT CURRENT_TIMESTAMP, 
  Task nchar(50), 
  Hours int, 
  Comments nchar(50),
  CONSTRAINT PK_WorkHours PRIMARY KEY(EmployeeId)  
)
GO

CREATE TABLE WorkHoursLogs(
ChangeId int IDENTITY,
ChangeDate DATETIME, 
ChangeTask nchar(50),
ChangeHours int,
ChangeComments nchar(50),
ActionChange varchar(10),
CONSTRAINT PK_Trigger PRIMARY KEY(ChangeId),  	
)
GO

CREATE TRIGGER Tr_WorkHoursLogsInsert ON WorkHours FOR INSERT
 AS
DECLARE @action char(10)
SET @action = 'INSERT'
INSERT INTO WorkHoursLogs (ChangeDate, ChangeTask, ChangeHours, ChangeComments, ActionChange)
SELECT  Date, Task, Hours, Comments, @action
  FROM INSERTED
GO

CREATE TRIGGER Tr_WorkHoursLogsUpdate ON WorkHours FOR UPDATE
 AS
DECLARE @action char(10)
SET @action = 'UPDATE'
INSERT INTO WorkHoursLogs (ChangeDate, ChangeTask, ChangeHours, ChangeComments, ActionChange)
SELECT  Date, Task, Hours, Comments, @action
  FROM inserted
GO

CREATE TRIGGER Tr_WorkHoursLogsDelete ON WorkHours FOR DELETE
 AS
DECLARE @action char(10)
SET @action = 'DELETE'
INSERT INTO WorkHoursLogs (ChangeDate, ChangeTask, ChangeHours, ChangeComments, ActionChange)
SELECT  Date, Task, Hours, Comments, @action
  FROM DELETED
GO

INSERT WorkHours VALUES ('10/10/2010','aaaaaaa',  12, 'comment')
INSERT WorkHours VALUES ('10/12/2010','bbbbb',  2, 'bez comment')
INSERT WorkHours VALUES ('10/12/2010','ccccc',  2, 'comment')

UPDATE WorkHours
SET Comments = 'update comment'
FROM WorkHours
WHERE EmployeeId = 2

DELETE FROM WorkHours WHERE EmployeeId = 3

/* 30 Start a database transaction, delete all employees from the 'Sales' department along 
with all dependent records from the pother tables.
    At the end rollback the transaction.*/
begin transaction
ALTER TABLE Departments
	DROP CONSTRAINT FK_Departments_Employees
DELETE FROM Employees WHERE EmployeeId in (SELECT m.EmployeeID
FROM	Employees m
INNER JOIN Departments n 
    ON m.DepartmentID = n.DepartmentID 
	Where n.Name = 'Sales')
rollback transaction
select * from Employees

/* 31. Start a database transaction and drop the table EmployeesProjects.
    Now how you could restore back the lost table data?*/
begin transaction
DROP TABLE [TelerikAcademy].[dbo].[EmployeesProjects]
ROLLBACK transaction

/* 32. Find how to use temporary tables in SQL Server.
Using temporary tables backup all records from EmployeesProjects 
and restore them back after dropping and re-creating the table.*/
CREATE TABLE #TempEmployesProject(
UserID int,
ProjectID int)
Go

INSERT INTO #TempEmployesProject (UserID, ProjectID)
SELECT EmployeeID, ProjectID
FROM EmployeesProjects
Go

SELECT *
FROM EmployeesProjects

SELECT *
FROM #TempEmployesProject


DROP TABLE [TelerikAcademy].[dbo].[EmployeesProjects]


CREATE TABLE EmployeesProjects (
	EmployeeId INT,
	ProjectId INT,
	CONSTRAINT PK_EmployeesProjects PRIMARY KEY(EmployeeID, ProjectID),
	CONSTRAINT FK_EmployeesProjects_Employees FOREIGN KEY(EmployeeID) 
	REFERENCES Employees(EmployeeID),
	CONSTRAINT FK_EmployeesProjects_Projects FOREIGN KEY(ProjectID) 
	REFERENCES Projects(ProjectID)
)

INSERT INTO EmployeesProjects
SELECT UserID, ProjectId
FROM #TempEmployesProject



