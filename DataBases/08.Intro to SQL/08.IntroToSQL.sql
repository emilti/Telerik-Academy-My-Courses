/****** Script for SelectTopNRows command from SSMS  ******/
/* 4. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).*/
SELECT *
  FROM [TelerikAcademy].[dbo].[Departments]

/* 5. Write a SQL query to find all department names.*/
SELECT Name
	FROM [TelerikAcademy].[dbo].[Departments]

/* 6. Write a SQL query to find the salary of each employee.*/
SELECT Salary
	FROM [TelerikAcademy].[dbo].[Employees]

/* 7. Write a SQL to find the full name of each employee.*/
SELECT  FirstName + ' ' + LastName AS [Full Name]
	FROM [TelerikAcademy].[dbo].[Employees]

/* 8. Write a SQL query to find the email addresses of each employee (by his first and last name).
 Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". 
 The produced column should be named "Full Email Addresses".*/
 SELECT  FirstName + '.' + LastName + '.@telerik.com' AS [Full Email Addresses]
	FROM [TelerikAcademy].[dbo].[Employees]

/* 9. Write a SQL query to find all different employee salaries.*/
SElECT DISTINCT Salary
	FROM [TelerikAcademy].[dbo].[Employees]

/* 10. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.*/
SELECT *
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE [JobTitle] = 'Sales Representative'

/* 11. Write a SQL query to find the names of all employees whose first name starts with "SA".*/
SELECT FirstName, LastName
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE FirstName LIKE 'SA%'

/* 12. Write a SQL query to find the names of all employees whose last name contains "ei".*/
SELECT FirstName, LastName
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE LastName LIKE '%ei%'

/* 13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].*/
SELECT Salary
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE 20000 < Salary AND Salary < 30000

/* 14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.*/
SELECT FirstName, LastName, Salary
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE Salary IN (25000, 14000, 12500, 23600)

/* 15. Write a SQL query to find all employees that do not have manager.*/
SELECT *
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE  ManagerID IS NULL

/* 16. Write a SQL query to find all employees that have salary more than 50000. 
Order them in decreasing order by salary.*/
SELECT *
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE  Salary > 50000 
	ORDER BY Salary Desc

/* 17 Write a SQL query to find the top 5 best paid employees.*/
SELECT TOP 5 *
	FROM [TelerikAcademy].[dbo].[Employees]	
	ORDER BY Salary

/* 18. Write a SQL query to find all employees along with their address. Use inner join with ON clause.*/
SELECT  e.EmployeeID, e.FirstName, e.MiddleName, e.LastName, e.DepartmentID, e.AddressID, e.HireDate,
		e.JobTitle, e.ManagerID, e.Salary,
        d.AddressID, d.AddressText
FROM [TelerikAcademy].[dbo].[Employees] e 
  INNER JOIN [TelerikAcademy].[dbo].Addresses d 
    ON e.AddressID = d.AddressID

/* 19. Write a SQL query to find all employees and their address. 
Use equijoins (conditions in the WHERE clause). */

SELECT  e.EmployeeID, e.FirstName, e.MiddleName, e.LastName, e.DepartmentID, e.AddressID, e.HireDate,
		e.JobTitle, e.ManagerID, e.Salary,
        d.AddressID, d.AddressText
FROM [TelerikAcademy].[dbo].[Employees] e, [TelerikAcademy].[dbo].Addresses d 
    WHERE e.AddressID = d.AddressID

/* 20. Write a SQL query to find all employees along with their manager.*/
SELECT f.EmployeeID, f.FirstName, f.LastName, f.ManagerID ManagerID, f.AddressID, f.DepartmentID, f.HireDate,
		f.Salary, 		    	    	      
		e.FirstName ManagerFirstName, e.MiddleName ManagerMiddleName, e.LastName ManagerLastName 
FROM [TelerikAcademy].[dbo].[Employees] e, [TelerikAcademy].[dbo].Employees f 
    WHERE  f.ManagerID = e.EmployeeID 

/* 21 Write a SQL query to find all employees, along with their manager and their address. 
Join the 3 tables: Employees e, Employees m and Addresses a.*/
SELECT e.EmployeeID, e.FirstName, e.LastName, e.ManagerID, e.AddressID, e.DepartmentID, e.HireDate,
		e.Salary, e.HireDate, e.JobTitle, 		    	    	      
		m.FirstName, m.LastName, m.ManagerID, a.AddressID, a.AddressText
FROM Employees e
JOIN Employees m
ON e.ManagerID = m.EmployeeID
JOIN Addresses a
ON e.AddressID = a.AddressID
ORDER BY e.ManagerID

/* 22.  Write a SQL query to find all departments and all town names as a single list. Use UNION.*/
SELECT Name
FROM [TelerikAcademy].[dbo].Departments
UNION
SELECT Name
FROM [TelerikAcademy].[dbo].Towns
	
/* 23. Write a SQL query to find all the employees and the manager for each of them along with 
the employees that do not have manager. Use right outer join. 
Rewrite the query to use left outer join.*/
SELECT e.EmployeeID, e.FirstName, e.LastName, e.ManagerID, e.AddressID, e.DepartmentID, e.HireDate,
		e.Salary, e.HireDate, e.JobTitle, 		    	    	      
		m.FirstName, m.LastName, m.ManagerID
FROM Employees e
RIGHT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

SELECT e.EmployeeID, e.FirstName, e.LastName, e.ManagerID, e.AddressID, e.DepartmentID, e.HireDate,
		e.Salary, e.HireDate, e.JobTitle, 		    	    	      
		m.FirstName, m.LastName, m.ManagerID
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

/* 24. Write a SQL query to find the names of all employees from the departments 
"Sales" and "Finance" whose hire year is between 1995 and 2005*/

SELECT FirstName, LastName
FROM Employees
WHERE DepartmentID IN (3, 10) 
AND HireDate > '1/1/1995' AND HireDate < '31/12/2005'
ORDER BY FirstName ASC, LastName ASC
