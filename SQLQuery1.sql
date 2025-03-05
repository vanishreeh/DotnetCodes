--Create Database
create database BikeStore
create database SISDb
--Delete a Database
Drop database BikeStore
drop database if Exists PolicyDb
drop database if Exists SISDb
--Modify the database name from SISDb to StudentInfoDb
alter database SISDb Modify Name=StudentInfoDb

--create a table
create table Bikes(
BikeId int primary key,
BikeName varchar(20) not null,
Price decimal)
--delete table Bikes
drop table Bikes
--navigate from one database to another
use BikeStore
--Change Table Name studentTbl to students
exec sp_rename 'StdentTbl','Students'
--alter table StudentTbl Modify Name=Students
--add column to existing table
alter table Bikes
add Stock int

--creating a table with database Name
create Table BikeStore.dbo.Categories(
Id int identity primary key,
CategoryName varchar(30) not null)
--structure of Table
Exec sp_help Categories
--Add CategoryId  in Bikes Table
alter table Bikes
add CategoryId int 

--add foreign key constarint
alter table Bikes
add constraint FK_Bikes_CategoryId
foreign key (CategoryId) references Categories(Id)
--delete column from table
alter table Bikes
drop column Stock
--change datatype of existing column
alter table Bikes
alter column Stock int

--Rename existing Column
exec sp_rename 'Bikes.Stock','Quantity', 'Column'