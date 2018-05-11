/*
 *Example1
 *创建数据库
 */
 
--1.确定使用的数据库
use master

--2.判断此数据库是否存在；若存在，删除此数据库
IF EXISTS(select * from sysdatabases where name = 'MySchool182')
	DROP DATABASE MySchool182

--3.创建数据库
CREATE DATABASE MySchool182
ON PRIMARY
(
	--数据库主数据文件
	NAME = 'MySchool182',
	FILENAME = 'F:\Program\DataBase\MyDataBase\DB\MySchool182.mdf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 1MB
)
LOG ON
(
	--数据库日志数据文件
	NAME = 'MySchool182_log',
	FILENAME = 'F:\Program\DataBase\MyDataBase\DB\MySchool182_log.ldf',
	SIZE = 3MB,
	MAXSIZE = 20MB,
	FILEGROWTH = 1MB
)