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

--Insert values into Categories Table
--Insert into Categories(Id,CategoryName) values(1,'Racing') not allowed
Insert into Categories(CategoryName) values('Racing')
Insert into Categories values('Mountain')
select * from Categories
--Insert Data into Bikes 
Insert into Bikes values(1,'Duke',100000,1,10),
(2,'Abc',200000,2,5),
(3,'XYZ',80000,1,20)

select * from Categories
select * from Bikes

--difference between Varchar,nvarchar,char
declare @value char(10)='vani'
print @value
print datalength(@value)
print len(@value)


declare @value2 varchar(10)='vani'
print @value2
print datalength(@value2)
print len(@value2)

--Return Inserted values
Insert into Categories(CategoryName)
output inserted.Id
values('ElectricBike')

--Delete a record
--delete from Bikes --delete all the entries
delete from Bikes where BikeId=3
select * from Bikes

Truncate table Bikes
truncate table Categories

delete from Categories
alter table BikeInfo
add constraint PK_BikeInfo_Id
 primary key(Id)

 drop table BikeInfo
 create table BikeInfo(
 Id int identity primary key,
 BName varchar(50))

 Truncate table BikeInfo
 Insert into BikeInfo values ('abc')
 select * from BikeInfo
delete from BikeInfo
select * from Bikes
--Update a record in table
update Bikes 
set price=90000
where CategoryId=5
Truncate table Categories
drop table Categories
Delete from Categories
where Id=9
select * from Bikes
--drop constraint
alter table Bikes
drop constraint FK_Bikes_CategoryId
--specific column of a table
select BikeName,Price
from Bikes

--select only bikes whose price is greater than 80000
select* from Bikes
where price>80000
--select all bikes whose quantity is not equal to 5
select * from Bikes
where Quantity!=5

select * from Bikes
where Quantity<>5
--column aliasing
select BikeName,Price ,Price*Quantity as TotalStockValue
from Bikes
select b.bikeName,b.Price
from Bikes b
select * from Bikes
--get all bikes whose quantity is null
select * from Bikes 
where Quantity is null

--Get all bikes whose names start with D
select *from Bikes
where BikeName like 'D%'

--check pattern in range of values
select * from Bikes
where BikeName like '[^a-d]%'

select * from Bikes
where BikeName like 'Duke'
-- fetch only two records from Bikes
select top 2 *  from bikes
select top 50 percent *  from bikes
--offset fetch
--get all Bikes which Belong to categoryId 1 and Price is greater than 80000
select * from Bikes
where CategoryId=1 and Price>80000
select * from Bikes
where CategoryId=1 Or Price>80000

--get all bikes whose price is in range 80000-100000
select * from Bikes 
where price between 80000 and 100000

select * from Bikes 
where price In(80000,100000)

--Find Average Price of Bikes
select Avg(Price) as [Average Bike Price]
from Bikes

--Find CategoryWise Total Number of Bikes
select CategoryId ,Count(BikeId) as TotatlCount
from bikes
Group by CategoryId
select * from Categories
--Get BikeName ,Bike Price ,categoryName
select b.BikeName,b.Price,c.CategoryName
from Bikes b
join
Categories c
on b.CategoryId=c.Id
select * from Bikes
select * from Categories
select b.BikeName,b.Price,c.CategoryName
from Bikes b
 left join
Categories c
on b.CategoryId=c.Id

select b.BikeName,b.Price,c.CategoryName
from Bikes b
 Right join
Categories c
on b.CategoryId=c.Id

select b.BikeName,b.Price,c.CategoryName
from Bikes b
 full outer join
Categories c
on b.CategoryId=c.Id

--cross join
select * from Bikes
cross join
categories

--Create Users Table
create Table Users(
userId int identity primary key,
userName varchar(30) not null,
Email varchar(20) unique,
City varchar(20),
)
insert into  Users values('shyam','shyam@gmail.com','Delhi')
insert into  Users values('veena','veena@gmail.com','Mumbai')
insert into  Users values('vani','vani@gmail.com','Bangalore')
insert into  Users values('vicky','vicky@gmail.com','Chennai')
--create stores Table
create Table Stores(
storeId int identity(100,2) primary Key,
storeName varchar(50) not null,
phone varchar(50) not null,
City varchar(20) not null)
Insert into Stores values('RelianceRetail','123456','Chennai'),
						 ('D-Mart','987650','Bangalore')
Insert into Stores(storeName,phone,City) values('MyBikes','6789','Pune')
--Create Orders Table
create  table Orders(
orderId int identity primary key,
userId int not null,
orderDate DateTime not null,
storeId int
foreign key(userId)references Users(userId),
foreign key (storeId) references Stores(storeId))
Insert into Orders values(1,'2024-11-06',100),
						 (2,'2023-10-05',102)

create table OrderDetails(
OrderDetailId int  identity primary key,
orderId int,
BikeId int,
quantity int,
foreign key(orderId) references Orders(orderId),
foreign key(BikeId) references Bikes(BikeId))



--insert values to orderdetails table
Insert into OrderDetails values(1,1,1)
Insert into OrderDetails values(1,2,1)

--self join
--create a employee Table
create table Employee(
EmpId int identity primary key,
EmpName varchar(40),
ManagerId int)

--Insert data
Insert into Employee values ('Ram',2),
							('Shyam',null),
							('Veena',1),
							('vicky',1)
select * from Employee
--self join
select e.EmpName, m.EmpName as ManagerName
from Employee e
left join Employee m
on e.ManagerId=m.EmpId

--display no manger instead of Null Value
select e.EmpName, ISNULL(m.EmpName,'No Manager') as Manager
from employee e
left join Employee m
on e.ManagerId=m.EmpId

select e.EmpName, coalesce(m.EmpName,'No Manager') as Manager
from employee e
left join Employee m
on e.ManagerId=m.EmpId
--get ordered bike Details(OrderId,QuantityOrder,BikeName)
select od.orderId,od.quantity, b.bikeName
from OrderDetails od
join 
Bikes b
on od.BikeId=b.BikeId
select * from Users
select * from OrderDetails
--get all users who have not palced orders
select u.userName, o.orderId
from users u
left join
Orders o
on u.userId=o.userId
where o.orderId is null or year(o.orderDate)=2024
select * from Bikes
--SubQuery
--Find total quantity ordered for a specific bikeName
select Sum(quantity)
from OrderDetails
where BikeId=
(select bikeId 
from Bikes 
where BikeName='Duke')
--subquery with exists Operator

select * from Users
select * from Orders
--Get The users who have not placed orders
select userName
from users u
where  not exists
(select o.userId 
from Orders o
where o.userId=u.userId)

-- find the highest quantity ordered for each bike
select bikeId,MaximumQuantity from (select BikeId,Max(quantity) as MaximumQuantity
from OrderDetails
group by BikeId)maxResult

--find the names of bike which belong to RoadBike and Mountain Bike category
select * from categories
select * from Bikes
select BikeName
from Bikes
where categoryId in(select Id from 
categories
where CategoryName='Road' or CategoryName='Mountain')

--Store Procedure
--GetAllBikes
Create procedure GetAllBikes
as
Begin
select * from Bikes
end
--execute the store procedure
execute GetAllBikes
exec  GetAllBikes
--GetBikeById
create proc GetBikeById
@BikeId int
as
begin
select * from Bikes where BikeId=@BikeId
end
exec GetBikeById 2
--create procedure for adding Bike
create procedure AddBike
@BikeId int,
@BikeName varchar(40),
@Price decimal,
@categoryId int,
@quantity int
As
begin
Insert into Bikes values(@BikeId,@BikeName,@Price,@categoryId,@quantity)
end

exec AddBike 6,'Royal Enfield',150000,3,10 
select * from Bikes
--bookOrder
Alter Procedure BookOrder
@userId int,
@StoreId int,
@OrderId int OutPut
as 
begin
Insert into Orders values (@userId,Getdate(),@StoreId)
set @OrderId=SCOPE_IDENTITY();
end

select * from Stores
select * from Orders
declare @OrderId int
exec BookOrder  @UserId=4,@storeId=100,@OrderId=@OrderId output
print @orderId
--count users by city
create procedure SpGetUserCountByCity
@city varchar(20),
@userCount int out
as
--begin
select @userCount=count(userId)
from users
where city=@city
--end
declare @customerCount int
execute SpGetUserCountByCity 'Delhi', @userCount=@customerCount out
select * from Users 

-- total number of bikes by Category
create view VWBikesByCategory
as
select c.CategoryName,Count(b.BikeId) as TotalBikes
from Bikes b
join Categories c
on b.CategoryId=c.Id
Group by CategoryName

update VWBikesByCategory--cannot update with aggregate functions
set CategoryName='NewCategory' where CategoryName='Road'




--indexes
create  nonclustered index IX_Bikes_BikeName
on Bikes(BikeName)

--create  nonclustered index IX_Bikes_Price
on Bikes(Price asc)
--drop index PK__Bikes__7DC81721C9A3840F

--views 
create view VWBikeDetails
as
select BikeId,BikeName,Price,CategoryName
from Bikes
join Categories
on CategoryId=Id

--how to execute view
select * from VWBikeDetails

--cannot pass input parameter and cannot use order by clause
create view VWBikeDetailsForCategory
as
select BikeId,BikeName,Price,CategoryName
from Bikes
join Categories
on CategoryId=Id
where categoryName='Road'
--order by BikeName

update VWBikeDetails
set BikeName='newName' where BikeId=5

select * from Bikes

--Triggers DML Triggers
--create a table for logging changes
create table BikesLogTbl(
id int identity primary key,
TrackChanges varchar(50))

--create Trigger
create trigger tr_Bikes_ForInsert
on Bikes
for Insert
as
begin
--select * from Inserted
declare @Id int
select @Id= BikeID from inserted
insert into BikesLogTbl values('new Bike with id='+Cast(@Id as varchar(5)))
end

select * from BikesLogTbl
Insert into Bikes values(7,'Yamah',90000,3,10)
Insert into Bikes values(8,'Yamah1',95000,3,10)
select * from Bikes

--Transactions
begin try
begin transaction
Insert into Bikes values(9,'xyzBike',60000,2,5)
Insert into Bikes values(9,'xyzBike',60000,2,5)
commit transaction
print 'transaction success'
end try
begin catch
rollback transaction
print 'transaction unsuccess'
select ERROR_MESSAGE() as [Error Msg]
end catch
--not commited transactions will be locked by database
begin transaction
update bikes set quantity=100 where BikeId=1



