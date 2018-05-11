--创建数据库
use master

if exists(select * from sysdatabases where name = 'House')
	drop database House
	
create database House
on primary
(
	name = 'House',
	filename = 'E:\代码\c#语言和数据库技术基础\数据库\House\House.mdf',
	size = 5,
	maxsize = 100,
	filegrowth = 1
)
log on
(
	name = 'House_log',
	filename = 'E:\代码\c#语言和数据库技术基础\数据库\House\House_log.ldf',
	size = 3,
	maxsize = 100,
	filegrowth = 1
)	

--创建表
use House

if exists(select * from sysobjects where name = 'sys_user')
	drop table sys_user
	
if exists(select * from sysobjects where name = 'hos_district')
	drop table hos_district
	
if exists(select * from sysobjects where name = 'hos_street')
	drop table hos_street
	
if exists(select * from sysobjects where name = 'hos_type')
	drop table hos_type
	
if exists(select * from sysobjects where name = 'hos_house')
	drop table hos_house	
	
create table sys_user
(
	UID int identity(1,1) not null,
	UName varchar(20) not null,
	UPASSWORD varchar(20) not null
)	

create table hos_district
(
	DID int identity(1,1) not null,
	DName varchar(50) not null
)	

create table hos_street
(
	SID int identity(1,1) not null,
	SName varchar(50) not null,
	SDID int not null
)		

create table hos_type
(
	HTID  int identity(1,1) not null,
	HTName  varchar(20) not null
) 

create table hos_house
(
	HMID int identity(1,1) not null,
	UID int not null,
	SID int not null,
	HTID int not null,
	PRICE decimal not null,
	TOPIC varchar(30) not null,
	CONTENTS varchar(200) not null,
	HTIME datetime not null,
	COPY varchar(255)
)

--创建约束
alter table sys_user add
constraint PK_UID primary key(UID)

alter table sys_user add
constraint CK_UPASSWORD check(UPASSWORD >= 6 and UPASSWORD <= 18)

alter table hos_district add
constraint PK_DID primary key(DID)

alter table hos_street add
constraint PK_SID primary key(SID)

alter table hos_street add
constraint FK_hos_street_hos_district_DID foreign key(SDID) references hos_district(DID)

alter table hos_type add
constraint PK_HTID primary key(HTID)

alter table hos_house add
constraint PK_HMID primary key(HMID)

alter table hos_house add
constraint FK_hos_house_sys_user_UID foreign key(UID) references sys_user(UID)

alter table hos_house add
constraint FK_hos_house_hos_street_SID foreign key(SID) references hos_street(SID)

alter table hos_house add
constraint FK_hos_house_hos_type_SID foreign key(HTID) references hos_type(HTID)

alter table hos_house add
constraint CK_PRICE check(PRICE >= 0)

alter table hos_house add
constraint DF_PRICE default(0) for PRICE

alter table hos_house add
constraint CK_HTIME check(HTIME <= 'GETDATE')

alter table hos_house add
constraint DF_HTIME default('GETDATE') for HTIME