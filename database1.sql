create database database1
go

use database1
go

create table Users
(
	Username varchar(255) primary key,
	Password varchar(max),
	UserRole varchar(255)
)

insert into Users(Username, Password, UserRole)
	values('Zainalds','123456','Admin')

	insert into Users(Username, Password, UserRole)
	values('Andrew','654321','User')

