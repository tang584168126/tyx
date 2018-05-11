--���Ƚ���ϵͳ���ݿ�
use master
go
--�ж����ݿ��Ƿ���ڣ�������ھ�ɾ��
if exists(select * from sysdatabases where name = 'IQQ')
drop database IQQ
--�������ݿ�
create database IQQ
on primary
(
	name = 'IQQ',
	filename = 'E:\����\c#���Ժ����ݿ⼼������\���ݿ�\IQQ\IQQ.mdf',
	size = 3mb,
	maxsize = 100mb,
	filegrowth = 15%
)
log on
(
	name = 'IQQ_log',
	filename = 'E:\����\c#���Ժ����ݿ⼼������\���ݿ�\IQQ\IQQ_log.ldf',
	size = 1mb,
	maxsize = 10,
	filegrowth = 15%
)
go
--ʹ��MyQQ���ݿ�
use IQQ
go
--�ж�QQ�û����Ƿ���� ���ھ�ɾ��
if exists (select * from sysobjects where name = 'Customer')
drop table Customer
--����Customer��
create table Customer
(
	--����		 ��������					����
	CusID		bigint	identity(10000,1),	--QQ����,��������ʶ��
	NickName	varchar(20) 	not null,	--QQ���ǳ�
	Pass		nvarchar(20)	not null,	--QQ����,���Ȳ�С��6λ
	Sex			nvarchar(2)		not null,	--�Ա�ֻ�����к�Ů
	BornDate	datetime		not null,	--��������
	RegDate		datetime		not null,	--��ǰ����	ע��ʱ��
	Head		nvarchar(255)	not null,	--ͷ��
	Level		int				not null,	--QQ�ȼ�
	Idiograph	nvarchar(255),				--����ǩ��
	Caption		nvarchar(255),				--����˵��
	CName		nvarchar(50),				--��������
	EName		nvarchar(50),				--Ӣ������
	Language	nvarchar(50),				--����
	BloodType	nvarchar(4)	,				--Ѫ��
	Profession	nvarchar(50),				--ְҵ
	Educational	nvarchar(50),				--ѧ��
	School		nvarchar(50),				--ѧУ
	Phone		nvarchar(20),				--�绰
	Mobile		nvarchar(11),				--�ֻ�
	Email		nvarchar(50),				--����
	HomePage	nvarchar(100),				--��ҳ
	NativePlace	nvarchar(255),				--����(����)
	LocationPlace	nvarchar(255)	not null,	--���ڵ�
	Address		nvarchar(255),				--��ϵ��ַ
	Postcode	nvarchar(6),				--�ʱ�
	Status		int				not null	--����״̬(7�� 1����������,2��Q�Ұ�,3���뿪,4��æµ,5���������,6������,7������)
)
go
--�������ѷ��鼶���(ȷ����ϵͳĬ�� ���� İ���� ������ �û��Զ������)
if exists (select * from sysobjects where name = 'FriendRank')
drop table FriendRank
--����QQRelation��
create table FriendRank
(
	--����		 ��������					����
	ID			int	identity(1,1) primary key,--���ѷ��鼶����
	Name		nvarchar(50)		not null,	--���ѷ��鼶������
)
go
--�������ѷ����(ȷ��ÿ���û�����ϵ�˷���)
if exists (select * from sysobjects where name = 'FriendGroup')
drop table FriendGroup
--����FriendGroup��
create table FriendGroup
(
	--����		 ��������					����
	ID			int	identity(1,1) primary key,--������
	CusID		bigint	not null,	--���������Customer��ȷ������ʱ�ĸ��û���
	Name		nvarchar(50)		not null,	--��������
	FRID		int 	not null	--��������鼶���� ����FriendRank��
)
go
--������ϵ�˱�
--�ж�RelationList�Ƿ���� ���ھ�ɾ��
if exists (select * from sysobjects where name = 'RelationList')
drop table RelationList
--����RelationList��
create table RelationList
(
	--����		 ��������					����
	ID			int	identity(1,1) primary key,--��ϵ���
	CusID		 bigint		not null,	--��ϵ�˵�QQ����,���
	Name		nvarchar(255),			--��ϵ�˵ı�ע����
	FGID		 int		not null,	--���,���÷���ı�ţ�ȷ����˭����ϵ��
)
go
--����Ⱥ��
--�ж�Group�Ƿ���� ���ھ�ɾ��
if exists (select * from sysobjects where name = 'GroupInfo')
drop table GroupInfo
--����Group��
create table GroupInfo
(
	--����		 ��������					����
	ID			bigint	identity(1,1) primary key,--Ⱥ���
	Name		nvarchar(255)	not null,	--Ⱥ����
	TypeName	nvarchar(255)	not null,	--Ⱥ��������
	Caption		nvarchar(255)	not null,	--Ⱥ����
	CusID	bigint	not null,	--�����Ӧ���û���������
	CreateTime	datetime	not null,	--����ʱ�䣬Ĭ�ϵ�ǰʱ��
)
go
--����Ⱥ�û�Ȩ�ޱ�(ȷ��Ⱥ������Ա����ͨȺ�û�)
--�ж�QQGroupRank�Ƿ���� ���ھ�ɾ��
if exists (select * from sysobjects where name = 'GroupRank')
drop table GroupRank
--����QQGroupRank��
create table GroupRank
(
	--����		 ��������					����
	ID			int	identity(1,1) primary key,--��ϵ���
	Name		nvarchar(100)		not null,	--Ȩ������
)
go
--����Ⱥ�û��б�
--�ж�QQGroupList�Ƿ���� ���ھ�ɾ��
if exists (select * from sysobjects where name = 'GroupList')
drop table GroupList
--����GroupList��
create table GroupList
(
	--����		 ��������					����
	ID			int	identity(1,1) primary key,--��ϵ���
	GroupID		bigint		not null,	--���������Ⱥ��Ϣ��ı��
	GroupRemarkName	nvarchar(255),	--Ⱥ��ע���ƣ�
	CusID		bigint		not null,	--����������û����QQ����
	RemarkName	nvarchar(255),	--Ⱥ��Ƭ����ʾ�û���Ⱥ��ʹ�õ�����
	GRID		int		not null	--���������Ⱥ�û�Ȩ�ޱ�ȷ��Ⱥ�û��ļ���
)
go
--������Ϣ���ͱ�
if exists (select * from sysobjects where name = 'MessageType')
drop table MessageType
--����MessageType��
create table MessageType
(
	--����		 ��������					����
	ID			int	identity(1,1) primary key,--��Ϣ���ͱ��
	Name 		nvarchar(20)		not null--��Ϣ��������
)
go

--������Ϣ��
--�ж�MessageInfo�Ƿ���� ���ھ�ɾ��
if exists (select * from sysobjects where name = 'MessageInfo')
drop table MessageInfo
--����PersonalMessage��
create table MessageInfo
(
	--����		 ��������					����
	ID			int	identity(1,1) primary key,--��Ϣ���
	FromCusID		bigint		not null,	--�����˵�QQ����,���
	Message		ntext		not null,	--��Ϣ����
	MsgTypeID		int		not null,	--��Ϣ���ͱ��,���������Ϣ���ͱ��
	SendTime	datetime	not null	--��Ϣ����ʱ��
)
go

--����������Ϣ��
--�ж�PersonalMessage�Ƿ���� ���ھ�ɾ��
if exists (select * from sysobjects where name = 'PersonalMessage')
drop table PersonalMessage
--����PersonalMessage��
create table PersonalMessage
(
	--����		 ��������					����
	ID			int	identity(1,1) primary key,--��Ϣ���
	MsgID		int		not null,		--��Ϣ���,���
	ToCusID		bigint		not null,	--�����˵�QQ����,���
	Status		int			not null	--��Ϣ�Ƿ��ȡ0���Ѷ�  1��δ��
)
go
--����Ⱥ��Ϣ��
--�ж�GroupMessage�Ƿ���� ���ھ�ɾ��
if exists (select * from sysobjects where name = 'GroupMessage')
drop table GroupMessage
--����GroupMessage��
create table GroupMessage
(
	--����		 ��������					����
	ID			int	identity(1,1) primary key,--��Ϣ���
	MsgID		int		not null,		--��Ϣ���,���
	GroupID		bigint		not null,	--���͵�Ⱥ�ĺ���,���
	ToCusID		bigint		not null,	--�����˵�QQ����,���
	Status		int			not null,	--��Ϣ�Ƿ��ȡ0���Ѷ�  1��δ��
)
go

--ΪCustomer�����Լ��
alter table Customer add 
	--����Լ��
	constraint PK_Customer primary key (CusID),
	--Ĭ��Լ��
	constraint DF_RegDate default(getdate()) for RegDate,
	constraint DF_Level default(0) for level,
	constraint DF_Customer_Status default(7) for Status,
	--���Լ��
	constraint CK_Pass check(len(Pass) >= 6),
	constraint CK_Sex check(Sex in ('��','Ů')),
	constraint CK_BornDate check(BornDate < RegDate),
	constraint CK_Customer_Status check(Status in (1,2,3,4,5,6,7))
--Ϊ���ѷ�������Լ���͹�ϵ
alter table FriendGroup add
	constraint FK_FriendGroup_FriendRank foreign key (FRID) references FriendRank(ID),
	constraint FK_FriendGroup_Customer foreign key (CusID) references Customer(CusID)
--Ϊ��ϵ�˱����Լ���͹�ϵ
alter table RelationList add
	constraint FK_RelationList_FriendGroup foreign key (FGID) references FriendGroup(ID)
--ΪȺ��Ϣ���Լ���͹�ϵ
alter table GroupInfo add
	constraint FK_Group_Customer foreign key (CusID) references Customer(CusID),
	constraint DF_CreateTime default(getdate()) for CreateTime
--ΪȺ��ϵ�����Լ���͹�ϵ
alter table GroupList add
	constraint FK_GroupList_GroupInfo foreign key (GroupID) references GroupInfo(ID),
	constraint FK_GroupList_Customer foreign key (CusID) references Customer(CusID),
	constraint FK_GroupList_GroupRank foreign key (GRID) references GroupRank(ID)
--Ϊ��Ϣ���ͱ����Լ���͹�ϵ

--Ϊ��Ϣ�б����Լ���͹�ϵ
alter table MessageInfo add
	constraint FK_MessageInfo_Customer foreign key (FromCusID) references Customer(CusID),
	constraint DF_MessageInfo_SendTimer default (getdate()) for SendTime,
	constraint FK_MessageInfo_MessageType foreign key (MsgTypeID) references MessageType(ID)
--Ϊ������Ϣ�����Լ���͹�ϵ
alter table PersonalMessage add
	constraint FK_PersonalMessage_MessageInfo foreign key (MsgID) references MessageInfo(ID),
	constraint FK_PersonalMessage_Customer_ToCusID foreign key (ToCusID) references Customer(CusID),
	constraint CK_PersonalMessage_Status check (Status in (0,1))
--ΪȺ����Ϣ���Լ���͹�ϵ
alter table GroupMessage add
	constraint FK_GroupMessage_MessageInfo foreign key (MsgID) references MessageInfo(ID),
	constraint FK_GroupMessage_GroupInfo_GroupID foreign key (GroupID) references GroupInfo(ID),
	constraint FK_GroupMessage_Customer_ToCusID foreign key (ToCusID) references Customer(CusID),
	constraint CK_GroupMessage_Status check (Status in (0,1))
--�������

--��Ӻ��ѷ��鼶������
insert into FriendRank values ('ϵͳĬ�ϵĺ��ѷ���')
insert into FriendRank values ('ϵͳĬ�ϵ�İ���˷���')
insert into FriendRank values ('ϵͳĬ�ϵĺ���������')
insert into FriendRank values ('�û��Զ���ĺ��ѷ���')
--���Ⱥ�û�Ȩ������
insert into GroupRank values ('Ⱥ��')
insert into GroupRank values ('����Ա')
insert into GroupRank values ('��ͨ��Ա')

select * from Customer
go
