use master

if exists(select * from sysdatabases where name = 'Wine')
	drop database Wine

create database Wine
on primary
(
	name = 'Wine.mdf',
	filename = 'E:\代码\c#语言和数据库技术基础\数据库\Wine\Wine.mdf',
	size = 5,
	maxsize = 100,
	filegrowth = 1
)
log on
(
	name = 'Wine_log.ldf',
	filename = 'E:\代码\c#语言和数据库技术基础\数据库\Wine\Wine_log.ldf',
	size = 3,
	maxsize = 100,
	filegrowth = 10%
)
GO

use Wine

if exists(select * from sysobjects where name = 'WineInfo')	
	drop table WineInfo
	
if exists(select * from sysobjects where name = 'WineType')	
	drop table WineType
	
if exists(select * from sysobjects where name = 'Company')	
	drop table Company
	
if exists(select * from sysobjects where name = 'SaleRecord')	
	drop table SaleRecord			