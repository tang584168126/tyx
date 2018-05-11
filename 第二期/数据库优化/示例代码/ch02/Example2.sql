/*
 *Example2
 *创建数据表
 */
 
--1.确定使用的数据库
use MySchool182

--2.判断数据库表是否存在；若存在，删除数据库表
IF EXISTS(select * from sysobjects where name = 'Student')
	DROP TABLE Student
	
IF EXISTS(select * from sysobjects where name = 'Grade')
	DROP TABLE Grade
	
--3.创建表
CREATE TABLE Student
(
	StudentNo int NOT NULL,
	LoginPwd nvarchar(20) NOT NULL,
	StudentName nvarchar(20) NOT NULL,
	Sex bit NOT NULL,
	GradeId int NOT NULL,
	Phone nvarchar(50)	NOT NULL,
	BornDate datetime NOT NULL,
	Address nvarchar(255),
	Email nvarchar(50),
	IDENTITYCard nvarchar(18) NOT NULL
)

CREATE TABLE Grade
(
	GradeId int IDENTITY(1,1) NOT NULL,
	GradeName nvarchar(50) NOT NULL
)