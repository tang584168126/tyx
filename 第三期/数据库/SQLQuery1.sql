use master

if exists(select * from sysdatabases where name='MyDemo')
	drop database MyDemo
	
create database MyDemo
on primary
(
	name = 'MyDemo',
	filename = 'E:\代码\第三期\数据库\MyDemo.mdf',
	size = 3MB,
	MaxSize = 100MB,
	filegrowth = 15%
)	
log on
(
	name = 'MyDemo_ldf',
	filename = 'E:\代码\第三期\数据库\MyDemo_ldf.ldf',
	size = 1MB,
	MaxSize = 100MB,
	filegrowth = 15%
)