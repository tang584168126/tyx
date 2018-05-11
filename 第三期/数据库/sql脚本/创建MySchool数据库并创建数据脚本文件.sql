-- 使用说明：
-- 通过本脚本会在D盘创建一个Project文件夹，并在文件夹中
-- 创建两个数据文件，如果没有D盘，请修改创建数据库时的物理名称
-- 注意：通过本脚本可以建库建表建约束，并插入部分数据

use master
go
--创建文件夹
exec sp_configure 'show advanced options',1
go
reconfigure
go
exec sp_configure 'xp_cmdshell',1
go
reconfigure
go
exec xp_cmdshell 'mkdir D:\project'
go

--创建数据库
if exists(select * from sysdatabases where name = 'MySchool')
	drop database MySchool
create database MySchool
on primary
(
	name='MySchool'  --数据库的逻辑名称
   ,filename='D:\Project\MySchool.mdf'  --物理名称
   ,size=5MB         --文件的初始大小
   ,maxsize=100MB    --文件的最大值大小
   ,filegrowth=15%   --文件的增量
)
log on
(
	name='MySchool_log'  --数据库的逻辑名称
   ,filename='D:\Project\MySchool_log.ldf'  --物理名称
   ,size=5MB         --文件的初始大小
   ,maxsize=10MB    --文件的最大值大小
   ,filegrowth=15%   --文件的增量	
)
go

------------------------
use MySchool
--创建Student表
if exists(select * from sysobjects where name='Student')
   drop table Student
create table Student
(
	 StudentNo int not null
	,LoginPwd nvarchar(20) not null
	,StudentName nvarchar(20) not null
	,Sex char(1) not null
	,GradeId int not null
	,Phone nvarchar(15) null
	,[Address] nvarchar(255) null
	,BornDate datetime not null
	,Email nvarchar(50) null
	,IdentityCard varchar(18) not null
)
go
--创建Subject表
if exists(select * from sysobjects where name='Subject')
   drop table Subject
create table Subject
(
	 SubjectNo int identity(1,1) not null
	,SubjectName nvarchar(50) not null
	,ClassHour int not null
	,GradeID int not null
)
go
--创建Result表
if exists(select * from sysobjects where name='Result')
   drop table Result
create table Result
(
	 StudentNo int not null
	,SubjectNo int not null
	,StudentResult int not null
	,ExamDate datetime not null
)
go
--创建Grade表
if exists(select * from sysobjects where name='Grade')
   drop table Grade
create table Grade
(
	 GradeID int identity(1,1) primary key not null
	,GradeName nvarchar(50) not null
)
go
--对Student创建约束
--主键约束
alter table Student
   add constraint PK_StudentNo primary key(StudentNo)
--唯一约束
alter table Student
   add constraint UQ_IdentityCard unique(IdentityCard)
--默认约束
alter table Student
   add constraint DF_Address default('地址不详') for [Address]
--检查约束 
alter table Student
   add constraint CK_BorenDate check(BornDate > '1980-01-01')
--外键约束
alter table Student
   add constraint FK_Grade_Student foreign key(GradeID)
	   references Grade(GradeID)

GO
--对Subject表创建约束
ALTER TABLE Subject   --主键约束（课程编号）
   ADD CONSTRAINT PK_Subject PRIMARY KEY (SubjectNo)

ALTER TABLE Subject  --非空约束（课程名称）
   ADD CONSTRAINT CK_SubjectName CHECK (SubjectName is not null)

ALTER TABLE Subject WITH NOCHECK  --检查约束（学时必须大于等于0）
   ADD CONSTRAINT CK_ClassHour CHECK (ClassHour>=0)

ALTER TABLE Subject   --外键约束（主表Grade和从表Subject建立引用关系）
   ADD CONSTRAINT FK_GradeId          
      FOREIGN KEY (GradeId) REFERENCES Grade (GradeId)
GO

--对Result创建约束  
ALTER TABLE Result   --主键约束（学号、科目号、日期）
   ADD CONSTRAINT PK_Result PRIMARY KEY
      (StudentNo, SubjectNo, ExamDate)

ALTER TABLE Result   --默认约束（日期为系统当前日期）
   ADD CONSTRAINT CK_ExamDate DEFAULT (getdate()) FOR ExamDate

ALTER TABLE Result   --检查约束（分数不能大于100，小于0）
   ADD CONSTRAINT CK_StudentResult CHECK
      (StudentResult BETWEEN 0 AND 100)

ALTER TABLE Result   --外键约束（主表Student和从表Result建立关系）
   ADD CONSTRAINT FK_StudentNo          
      FOREIGN KEY (StudentNo) REFERENCES Student (StudentNo)

ALTER TABLE Result   --外键约束（主表Subject和从表Result建立关系）
   ADD CONSTRAINT FK_SubjectNo          
      FOREIGN KEY (SubjectNo) REFERENCES Subject (SubjectNo)
GO

--向Grade表插入数据
INSERT INTO Grade VALUES('S1')
INSERT INTO Grade VALUES('S2')
INSERT INTO Grade VALUES('Y2')

--向Subject表插入数据
INSERT INTO Subject VALUES('Winforms',20,1)
INSERT INTO Subject VALUES('Java Logic',16,1)
INSERT INTO Subject VALUES('SQL Base',18,1)
INSERT INTO Subject VALUES('HTML',32,1)
INSERT INTO Subject VALUES('Proc',38,1)
INSERT INTO Subject VALUES('Project',36,1)
INSERT INTO Subject VALUES('C# OOP',24,2)
INSERT INTO Subject VALUES('Three Tier',28,2)
INSERT INTO Subject VALUES('Java OOP',12,2)
INSERT INTO Subject VALUES('JSP',26,2)
INSERT INTO Subject VALUES('JavaScript',24,2)
INSERT INTO Subject VALUES('T-SQL',22,2)
INSERT INTO Subject VALUES('Project',42,2)
INSERT INTO Subject VALUES('ASP.NET',38,3)
INSERT INTO Subject VALUES('Control+Ajax',12,3)

--向Student表插入数据
INSERT INTO Student VALUES('10000','GuoJing','郭靖',1,1,02088762106,'天津市河西区','1987-09-08 00:00:00','GuoJing@sohu.com',111111)
INSERT INTO Student VALUES('10001','LiWenCai','李文才',1,1,01062768866,'地址不详','1993-03-04 00:00:00','LiWenCai@sohu.com',111112)
INSERT INTO Student VALUES('10002','LiSiWen','李斯文',1,1,02183410615,'河南洛阳','1992-08-08 00:00:00','LiSiWen@sohu.com',111113)
INSERT INTO Student VALUES('10011','WuSong','武松',0,1,01062768888,'地址不详','1984-12-31 00:00:00','WuSong@sohu.com',111114)
INSERT INTO Student VALUES('10012','HeQiang','何强',0,1,02183567890,'地址不详','1991-08-30 00:00:00','HeQiang@sohu.com',111120)
INSERT INTO Student VALUES('20011','ZhangSan','张三',1,1,15290234178,'北京市海淀区','1994-01-01 00:00:00','ZhangSan@sohu.com',111115)
INSERT INTO Student VALUES('20012','ZhangQiuYu','张秋丽',0,2,01062751414,'北京市东城区','1990-06-05 00:00:00','ZhangQiuYu@sohu.com',111116)
INSERT INTO Student VALUES('20015','XiaoMei','肖梅',0,2,031466557171,'河北省石家庄市','1996-10-01 00:00:00','XiaoMei@sohu.com',111117)
INSERT INTO Student VALUES('30021','OuYangJunXiong','欧阳俊雄',1,2,02277585000,'上海市卢湾区','1995-09-29 00:00:00','OuYangJunXiong@sohu.com',111118)
INSERT INTO Student VALUES('30023','MeiChaoFeng','梅超风',0,2,031466557172,'广州市天河区','1997-08-30 00:00:00','MeiChaoFeng@sohu.com',111119)

--向Result表插入数据
INSERT INTO Result VALUES('10001',2,70.6,'2013-02-15 00:00:00')
INSERT INTO Result VALUES('10000',2,60,'2013-02-17 00:00:00')
INSERT INTO Result VALUES('10001',2,46,'2013-02-17 00:00:00')
INSERT INTO Result VALUES('10002',2,83,'2013-02-17 00:00:00')
INSERT INTO Result VALUES('10011',2,71,'2013-02-16 00:00:00')
INSERT INTO Result VALUES('10011',2,95.5,'2013-02-17 00:00:00')
INSERT INTO Result VALUES('10012',2,76,'2013-02-15 00:00:00')
INSERT INTO Result VALUES('20011',2,60,'2013-02-15 00:00:00')
INSERT INTO Result VALUES('20012',2,91,'2013-02-15 00:00:00')
INSERT INTO Result VALUES('20012',7,61,'2013-02-15 00:00:00')
INSERT INTO Result VALUES('20015',2,60,'2013-02-15 00:00:00')
INSERT INTO Result VALUES('20015',7,65,'2013-02-15 00:00:00')
INSERT INTO Result VALUES('30021',2,23,'2013-02-15 00:00:00')
INSERT INTO Result VALUES('30021',8,74,'2013-02-15 00:00:00')
INSERT INTO Result VALUES('30023',2,23,'2013-02-15 00:00:00')
INSERT INTO Result VALUES('30023',9,39,'2013-02-15 00:00:00')
