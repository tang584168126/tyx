--确定使用的数据库
use master

--判断数据库是否存在，若存在，删除
if exists( select * from sysdatabases where name = 'Library')
	drop database Library
	
--创建数据库
create database Library
on primary
(
	name = 'Library',
	filename = 'E:\代码\c#语言和数据库技术基础\数据库\Library\Library.mdf',
	size = 5MB,
	maxsize = 100MB,
	filegrowth = 1
)
log on
(
	name = 'Library_log',
	filename = 'E:\代码\c#语言和数据库技术基础\数据库\Library\Library_log.ldf',
	size = 1MB,
	maxsize = 50MB,
	filegrowth = 1
)

--确定使用的数据库
use Library

--判断数据库表是否存在，若存在，删除
if exists( select * from sysobjects where name = 'Book')
	drop table Book
	
--创建数据库表
create table Book
(
	BID nvarchar(100) not null,
	BName nvarchar(100) not null,
	BTotal int not null,
	Author nvarchar(20),
	PubComp nvarchar(100),
	PubDate datetime,
	BCount int not null,
	Price money not null
)

--确定使用的数据库
use Library

--判断数据库表是否存在，若存在，删除
if exists( select * from sysobjects where name = 'Reader')
	drop table Reader
	
--创建数据库表
create table Reader
(
	RID nvarchar(100) not null,
	RName nvarchar(20) not null,
	LendNum int, 
	RAddress nvarchar(255)
)

--确定使用的数据库
use Library

--判断数据库表是否存在，若存在，删除
if exists( select * from sysobjects where name = 'Borrow')
	drop table Borrow
	
--创建数据库表
create table Borrow
(
	RID nvarchar(100) not null,
	BID nvarchar(100) not null,
	LendDate datetime not null,
	WillDate datetime,
	ReturnDate datetime
)

--确定使用的数据库
use Library

--判断数据库表是否存在，若存在，删除
if exists( select * from sysobjects where name = 'Penalty')
	drop table Penalty
	
--创建数据库表
create table Penalty
(
	RID nvarchar(100) not null,
	BID nvarchar(100) not null,
	PDate datetime not null,
	PType int,
	Amount money
)

--确定使用的数据库
use Library

--创建Book表约束
alter table Book with nocheck
add constraint PK_Book Primary key(BID)

alter table Book with nocheck
add constraint CK_PubDate check(PubDate < getdate())

alter table Book with nocheck
add constraint CK_BCount check(BCount >= 1)

alter table Book with nocheck
add constraint CK_Price check(Price > 0)

--创建Reader表约束
alter table Reader with nocheck
add constraint PK_Reader Primary key(RID)

alter table Reader with nocheck
add constraint CK_LendNum check(LendNum >= 0)

--创建Borrow表约束
alter table Borrow with nocheck
add constraint PK_Borrow Primary key(RID,BID,LendDate)

alter table Borrow with nocheck
add constraint FK_RID foreign key(RID)
  references Reader(RID)
  
alter table Borrow with nocheck
add constraint FK_BID foreign key(BID)
  references Book(BID)
  
alter table Borrow with nocheck
add constraint DF_LendDate default(getdate())for LendDate

alter table Borrow with nocheck
add constraint CK_WillDate check(WillDate > LendDate)

alter table Borrow with nocheck
add constraint DF_ReturnDate default(null)for ReturnDate

--创建Penalty表约束
alter table Penalty with nocheck
add constraint PK_Penalty Primary key(RID,BID,PDate)

alter table Penalty with nocheck
add constraint FK_RID1 foreign key(RID)
  references Reader(RID)
  
alter table Penalty with nocheck
add constraint FK_BID1 foreign key(BID)
  references Book(BID)
  
alter table Penalty with nocheck
add constraint DF_PDate default(getdate())for PDate

alter table Penalty with nocheck
add constraint CK_Amount check(Amount > 0)

/*
*添加数据
*/
--确定使用的数据库
use Library

INSERT INTO Book
(BID,BName,BTotal,Author,PubComp,PubDate,BCount,Price)
values
('ISBN001','读者',100,'123','321','2014-5-8',20,15)
INSERT INTO Book
(BID,BName,BTotal,Author,PubComp,PubDate,BCount,Price)
values
('ISBN002','西游记',120,'吴承恩','123','1997-7-7',50,125)
INSERT INTO Book
(BID,BName,BTotal,Author,PubComp,PubDate,BCount,Price)
values
('ISBN003','笑傲江湖',110,'123','321','2005-7-8',30,75)

INSERT INTO Reader
(RID,RName,LendNum,RAddress)
values
('DZ001','何天展',5,'')
INSERT INTO Reader
(RID,RName,LendNum,RAddress)
values
('DZ002','张三',2,'')
INSERT INTO Reader
(RID,RName,LendNum,RAddress)
values
('DZ003','李四',7,'')

insert into Borrow
(RID,BID,LendDate,WillDate,ReturnDate)
values
('DZ001','ISBN002','2014-6-9','2014-7-10',null)
insert into Borrow
(RID,BID,LendDate,WillDate,ReturnDate)
values
('DZ002','ISBN001','2014-8-9','2014-9-10',null)
insert into Borrow
(RID,BID,LendDate,WillDate,ReturnDate)
values
('DZ003','ISBN002','2014-9-9','2014-10-10',null)

INSERT INTO Penalty
(RID,BID,PDate,PType,Amount)
values
('DZ001','ISBN002','2014-7-11',2,1.2)
INSERT INTO Penalty
(RID,BID,PDate,PType,Amount)
values
('DZ002','ISBN001','2014-7-11',1,0.5)
INSERT INTO Penalty
(RID,BID,PDate,PType,Amount)
values
('DZ003','ISBN003','2014-7-11',3,5)