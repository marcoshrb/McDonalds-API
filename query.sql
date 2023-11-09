use master
go

if (exists(select * from sys.databases where name = 'McDataBase'))
	drop database McDataBase
go

create database McDataBase
go

use McDataBase
go

create table Product(
	ID int identity primary key,
	ProductName varchar(80) not null,
	Photo varbinary(MAX) null,
	DescriptionText varchar(400) not null
);
go

create table Store(
	ID int identity primary key,
	Localization varchar(200) not null
);
go

create table MenuItem(
	ID int identity primary key,
	ProductID int references Product(ID) not null,
	StoreID int references Store(ID) not null,
	Price decimal(5, 2) not null
);
go

create table ClientOrder(
	ID int identity primary key,
	OrderCode varchar(12) not null,
	StoreID int references Store(ID) not null,
	FinishMoment datetime null,
	DeliveryMoment datetime null
);
go

create table ClientOrderItem(
	ID int identity primary key,
	ClientOrderID int references ClientOrder(ID) not null,
	ProductID int references Product(ID) not null
);
go

insert Store values 
	('Mc do Portão pai'),
	('Mc do Dom'),	
	('Mc do Dom, pamgão')
go

insert Product values 
	('Mac Mc', null, 'É o Mac Mc'),
	('Big Mc', null, 'É o Big Mc'),
	('Small Mc', null, 'É o Small Mc')
go

insert MenuItem values
	(1, 1, 20.00),
	(2, 2, 30.00),
	(3, 3, 40.00)
go

select * from Product
select * from Store
select * from MenuItem