--create database WebAPICurd
--go
--use WebAPICurd
--go
--create table Users
--(
--UserId int identity,
--Name varchar(30),
--Address varchar(30), 
--ContactNo varchar(10)
-- )
 
 --insert into Users values('Naren','Ghaziabad','9891188387')
 --insert into Users values('Kumar','Ghaziabad','9891188387')
 --insert into Users values('Kavish Gautam','Ghaziabad','9891290987')
 --insert into Users values('Aditya Singh','Vijay Nagar Ghaziabad','9212721783')
 --insert into Users values('Niyati Siddharth','Delhi','9891188387')
 --insert into Users values('Nirbhay Siddharth','Delhi','9891188387')
--go 
--create table Departments
--(
--DepartmentId int identity,
--DepartName varchar(30)
--)
--go
--insert into Departments values('IT')
--insert into Departments values('Account')
--insert into Departments values('HR')
--insert into Departments values('Admin')
--insert into Departments values('Software')
--insert into Departments values('Beauty')


--go
--create table Employees
--(
--EmployeeId int identity,
--EmpName varchar(50),
--Department varchar(50), 
--Mail varchar(50),
--DOJ date null
--)


--insert into Employees values('Lovkesh','Admin','lovekeshgautamgzb@gmail.com',getdate())
--insert into Employees values('Narendra','Software','lovekeshgautamgzb@gmail.com',getdate())
--insert into Employees values('Kiran','Law','kiranbharti@gmail.com',getdate())
--insert into Employees values('Geeta Gauatm','Beauty','geetagautam@gmail.com',getdate())


select * from Users 
select * from Department
select * from Employees
