--首先进入系统数据库
use master
go
--判断数据库是否存在，如果存在就删除
if exists(select * from sysdatabases where name = 'IQQ')
drop database IQQ
--创建数据库
create database IQQ
on primary
(
	name = 'IQQ',
	filename = 'E:\代码\c#语言和数据库技术基础\数据库\IQQ\IQQ.mdf',
	size = 3mb,
	maxsize = 100mb,
	filegrowth = 15%
)
log on
(
	name = 'IQQ_log',
	filename = 'E:\代码\c#语言和数据库技术基础\数据库\IQQ\IQQ_log.ldf',
	size = 1mb,
	maxsize = 10,
	filegrowth = 15%
)
go
--使用MyQQ数据库
use IQQ
go
--判断QQ用户表是否存在 存在就删除
if exists (select * from sysobjects where name = 'Customer')
drop table Customer
--创建Customer表
create table Customer
(
	--列名		 数据类型					描述
	CusID		bigint	identity(10000,1),	--QQ号码,主键，标识列
	NickName	varchar(20) 	not null,	--QQ的昵称
	Pass		nvarchar(20)	not null,	--QQ密码,长度不小于6位
	Sex			nvarchar(2)		not null,	--性别，只能是男和女
	BornDate	datetime		not null,	--出生日期
	RegDate		datetime		not null,	--当前日期	注册时间
	Head		nvarchar(255)	not null,	--头像
	Level		int				not null,	--QQ等级
	Idiograph	nvarchar(255),				--个性签名
	Caption		nvarchar(255),				--个人说明
	CName		nvarchar(50),				--中文姓名
	EName		nvarchar(50),				--英文名字
	Language	nvarchar(50),				--语言
	BloodType	nvarchar(4)	,				--血型
	Profession	nvarchar(50),				--职业
	Educational	nvarchar(50),				--学历
	School		nvarchar(50),				--学校
	Phone		nvarchar(20),				--电话
	Mobile		nvarchar(11),				--手机
	Email		nvarchar(50),				--邮箱
	HomePage	nvarchar(100),				--主页
	NativePlace	nvarchar(255),				--籍贯(故乡)
	LocationPlace	nvarchar(255)	not null,	--所在地
	Address		nvarchar(255),				--联系地址
	Postcode	nvarchar(6),				--邮编
	Status		int				not null	--在线状态(7种 1：我在线上,2：Q我吧,3：离开,4：忙碌,5：请勿打扰,6：隐身,7：离线)
)
go
--创建好友分组级别表(确定是系统默认 好友 陌生人 黑名单 用户自定义好友)
if exists (select * from sysobjects where name = 'FriendRank')
drop table FriendRank
--创建QQRelation表
create table FriendRank
(
	--列名		 数据类型					描述
	ID			int	identity(1,1) primary key,--好友分组级别编号
	Name		nvarchar(50)		not null,	--好友分组级别名称
)
go
--创建好友分组表(确定每个用户的联系人分组)
if exists (select * from sysobjects where name = 'FriendGroup')
drop table FriendGroup
--创建FriendGroup表
create table FriendGroup
(
	--列名		 数据类型					描述
	ID			int	identity(1,1) primary key,--分组编号
	CusID		bigint	not null,	--外键，引用Customer表，确定分组时哪个用户的
	Name		nvarchar(50)		not null,	--分组名称
	FRID		int 	not null	--外键，分组级别编号 引用FriendRank表
)
go
--创建联系人表
--判断RelationList是否存在 存在就删除
if exists (select * from sysobjects where name = 'RelationList')
drop table RelationList
--创建RelationList表
create table RelationList
(
	--列名		 数据类型					描述
	ID			int	identity(1,1) primary key,--关系编号
	CusID		 bigint		not null,	--联系人的QQ号码,外键
	Name		nvarchar(255),			--联系人的备注名称
	FGID		 int		not null,	--外键,引用分组的编号，确定是谁的联系人
)
go
--创建群表
--判断Group是否存在 存在就删除
if exists (select * from sysobjects where name = 'GroupInfo')
drop table GroupInfo
--创建Group表
create table GroupInfo
(
	--列名		 数据类型					描述
	ID			bigint	identity(1,1) primary key,--群编号
	Name		nvarchar(255)	not null,	--群名称
	TypeName	nvarchar(255)	not null,	--群类型名称
	Caption		nvarchar(255)	not null,	--群介绍
	CusID	bigint	not null,	--外键，应用用户表，创建者
	CreateTime	datetime	not null,	--创建时间，默认当前时间
)
go
--创建群用户权限表(确定群主管理员和普通群用户)
--判断QQGroupRank是否存在 存在就删除
if exists (select * from sysobjects where name = 'GroupRank')
drop table GroupRank
--创建QQGroupRank表
create table GroupRank
(
	--列名		 数据类型					描述
	ID			int	identity(1,1) primary key,--关系编号
	Name		nvarchar(100)		not null,	--权限名称
)
go
--创建群用户列表
--判断QQGroupList是否存在 存在就删除
if exists (select * from sysobjects where name = 'GroupList')
drop table GroupList
--创建GroupList表
create table GroupList
(
	--列名		 数据类型					描述
	ID			int	identity(1,1) primary key,--关系编号
	GroupID		bigint		not null,	--外键，引用群信息表的编号
	GroupRemarkName	nvarchar(255),	--群备注名称，
	CusID		bigint		not null,	--外键，引用用户表的QQ号码
	RemarkName	nvarchar(255),	--群名片，显示用户在群中使用的名字
	GRID		int		not null	--外键，引用群用户权限表，确定群用户的级别
)
go
--创建消息类型表
if exists (select * from sysobjects where name = 'MessageType')
drop table MessageType
--创建MessageType表
create table MessageType
(
	--列名		 数据类型					描述
	ID			int	identity(1,1) primary key,--消息类型编号
	Name 		nvarchar(20)		not null--消息类型名称
)
go

--创建消息表
--判断MessageInfo是否存在 存在就删除
if exists (select * from sysobjects where name = 'MessageInfo')
drop table MessageInfo
--创建PersonalMessage表
create table MessageInfo
(
	--列名		 数据类型					描述
	ID			int	identity(1,1) primary key,--消息编号
	FromCusID		bigint		not null,	--发信人的QQ号码,外键
	Message		ntext		not null,	--消息类容
	MsgTypeID		int		not null,	--消息类型编号,外键引用消息类型编号
	SendTime	datetime	not null	--消息发送时间
)
go

--创建个人消息表
--判断PersonalMessage是否存在 存在就删除
if exists (select * from sysobjects where name = 'PersonalMessage')
drop table PersonalMessage
--创建PersonalMessage表
create table PersonalMessage
(
	--列名		 数据类型					描述
	ID			int	identity(1,1) primary key,--消息编号
	MsgID		int		not null,		--消息编号,外键
	ToCusID		bigint		not null,	--收信人的QQ号码,外键
	Status		int			not null	--消息是否读取0：已读  1：未读
)
go
--创建群消息表
--判断GroupMessage是否存在 存在就删除
if exists (select * from sysobjects where name = 'GroupMessage')
drop table GroupMessage
--创建GroupMessage表
create table GroupMessage
(
	--列名		 数据类型					描述
	ID			int	identity(1,1) primary key,--消息编号
	MsgID		int		not null,		--消息编号,外键
	GroupID		bigint		not null,	--发送到群的号码,外键
	ToCusID		bigint		not null,	--收信人的QQ号码,外键
	Status		int			not null,	--消息是否读取0：已读  1：未读
)
go

--为Customer表添加约束
alter table Customer add 
	--主键约束
	constraint PK_Customer primary key (CusID),
	--默认约束
	constraint DF_RegDate default(getdate()) for RegDate,
	constraint DF_Level default(0) for level,
	constraint DF_Customer_Status default(7) for Status,
	--检查约束
	constraint CK_Pass check(len(Pass) >= 6),
	constraint CK_Sex check(Sex in ('男','女')),
	constraint CK_BornDate check(BornDate < RegDate),
	constraint CK_Customer_Status check(Status in (1,2,3,4,5,6,7))
--为好友分组表添加约束和关系
alter table FriendGroup add
	constraint FK_FriendGroup_FriendRank foreign key (FRID) references FriendRank(ID),
	constraint FK_FriendGroup_Customer foreign key (CusID) references Customer(CusID)
--为联系人表添加约束和关系
alter table RelationList add
	constraint FK_RelationList_FriendGroup foreign key (FGID) references FriendGroup(ID)
--为群信息添加约束和关系
alter table GroupInfo add
	constraint FK_Group_Customer foreign key (CusID) references Customer(CusID),
	constraint DF_CreateTime default(getdate()) for CreateTime
--为群联系人添加约束和关系
alter table GroupList add
	constraint FK_GroupList_GroupInfo foreign key (GroupID) references GroupInfo(ID),
	constraint FK_GroupList_Customer foreign key (CusID) references Customer(CusID),
	constraint FK_GroupList_GroupRank foreign key (GRID) references GroupRank(ID)
--为消息类型表添加约束和关系

--为消息列表添加约束和关系
alter table MessageInfo add
	constraint FK_MessageInfo_Customer foreign key (FromCusID) references Customer(CusID),
	constraint DF_MessageInfo_SendTimer default (getdate()) for SendTime,
	constraint FK_MessageInfo_MessageType foreign key (MsgTypeID) references MessageType(ID)
--为个人消息表添加约束和关系
alter table PersonalMessage add
	constraint FK_PersonalMessage_MessageInfo foreign key (MsgID) references MessageInfo(ID),
	constraint FK_PersonalMessage_Customer_ToCusID foreign key (ToCusID) references Customer(CusID),
	constraint CK_PersonalMessage_Status check (Status in (0,1))
--为群组消息添加约束和关系
alter table GroupMessage add
	constraint FK_GroupMessage_MessageInfo foreign key (MsgID) references MessageInfo(ID),
	constraint FK_GroupMessage_GroupInfo_GroupID foreign key (GroupID) references GroupInfo(ID),
	constraint FK_GroupMessage_Customer_ToCusID foreign key (ToCusID) references Customer(CusID),
	constraint CK_GroupMessage_Status check (Status in (0,1))
--添加数据

--添加好友分组级别数据
insert into FriendRank values ('系统默认的好友分组')
insert into FriendRank values ('系统默认的陌生人分组')
insert into FriendRank values ('系统默认的黑名单分组')
insert into FriendRank values ('用户自定义的好友分组')
--添加群用户权限数据
insert into GroupRank values ('群主')
insert into GroupRank values ('管理员')
insert into GroupRank values ('普通成员')

select * from Customer
go
