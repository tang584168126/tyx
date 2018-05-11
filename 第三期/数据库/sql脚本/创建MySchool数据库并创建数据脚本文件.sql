-- ʹ��˵����
-- ͨ�����ű�����D�̴���һ��Project�ļ��У������ļ�����
-- �������������ļ������û��D�̣����޸Ĵ������ݿ�ʱ����������
-- ע�⣺ͨ�����ű����Խ��⽨��Լ���������벿������

use master
go
--�����ļ���
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

--�������ݿ�
if exists(select * from sysdatabases where name = 'MySchool')
	drop database MySchool
create database MySchool
on primary
(
	name='MySchool'  --���ݿ���߼�����
   ,filename='D:\Project\MySchool.mdf'  --��������
   ,size=5MB         --�ļ��ĳ�ʼ��С
   ,maxsize=100MB    --�ļ������ֵ��С
   ,filegrowth=15%   --�ļ�������
)
log on
(
	name='MySchool_log'  --���ݿ���߼�����
   ,filename='D:\Project\MySchool_log.ldf'  --��������
   ,size=5MB         --�ļ��ĳ�ʼ��С
   ,maxsize=10MB    --�ļ������ֵ��С
   ,filegrowth=15%   --�ļ�������	
)
go

------------------------
use MySchool
--����Student��
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
--����Subject��
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
--����Result��
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
--����Grade��
if exists(select * from sysobjects where name='Grade')
   drop table Grade
create table Grade
(
	 GradeID int identity(1,1) primary key not null
	,GradeName nvarchar(50) not null
)
go
--��Student����Լ��
--����Լ��
alter table Student
   add constraint PK_StudentNo primary key(StudentNo)
--ΨһԼ��
alter table Student
   add constraint UQ_IdentityCard unique(IdentityCard)
--Ĭ��Լ��
alter table Student
   add constraint DF_Address default('��ַ����') for [Address]
--���Լ�� 
alter table Student
   add constraint CK_BorenDate check(BornDate > '1980-01-01')
--���Լ��
alter table Student
   add constraint FK_Grade_Student foreign key(GradeID)
	   references Grade(GradeID)

GO
--��Subject����Լ��
ALTER TABLE Subject   --����Լ�����γ̱�ţ�
   ADD CONSTRAINT PK_Subject PRIMARY KEY (SubjectNo)

ALTER TABLE Subject  --�ǿ�Լ�����γ����ƣ�
   ADD CONSTRAINT CK_SubjectName CHECK (SubjectName is not null)

ALTER TABLE Subject WITH NOCHECK  --���Լ����ѧʱ������ڵ���0��
   ADD CONSTRAINT CK_ClassHour CHECK (ClassHour>=0)

ALTER TABLE Subject   --���Լ��������Grade�ʹӱ�Subject�������ù�ϵ��
   ADD CONSTRAINT FK_GradeId          
      FOREIGN KEY (GradeId) REFERENCES Grade (GradeId)
GO

--��Result����Լ��  
ALTER TABLE Result   --����Լ����ѧ�š���Ŀ�š����ڣ�
   ADD CONSTRAINT PK_Result PRIMARY KEY
      (StudentNo, SubjectNo, ExamDate)

ALTER TABLE Result   --Ĭ��Լ��������Ϊϵͳ��ǰ���ڣ�
   ADD CONSTRAINT CK_ExamDate DEFAULT (getdate()) FOR ExamDate

ALTER TABLE Result   --���Լ�����������ܴ���100��С��0��
   ADD CONSTRAINT CK_StudentResult CHECK
      (StudentResult BETWEEN 0 AND 100)

ALTER TABLE Result   --���Լ��������Student�ʹӱ�Result������ϵ��
   ADD CONSTRAINT FK_StudentNo          
      FOREIGN KEY (StudentNo) REFERENCES Student (StudentNo)

ALTER TABLE Result   --���Լ��������Subject�ʹӱ�Result������ϵ��
   ADD CONSTRAINT FK_SubjectNo          
      FOREIGN KEY (SubjectNo) REFERENCES Subject (SubjectNo)
GO

--��Grade���������
INSERT INTO Grade VALUES('S1')
INSERT INTO Grade VALUES('S2')
INSERT INTO Grade VALUES('Y2')

--��Subject���������
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

--��Student���������
INSERT INTO Student VALUES('10000','GuoJing','����',1,1,02088762106,'����к�����','1987-09-08 00:00:00','GuoJing@sohu.com',111111)
INSERT INTO Student VALUES('10001','LiWenCai','���Ĳ�',1,1,01062768866,'��ַ����','1993-03-04 00:00:00','LiWenCai@sohu.com',111112)
INSERT INTO Student VALUES('10002','LiSiWen','��˹��',1,1,02183410615,'��������','1992-08-08 00:00:00','LiSiWen@sohu.com',111113)
INSERT INTO Student VALUES('10011','WuSong','����',0,1,01062768888,'��ַ����','1984-12-31 00:00:00','WuSong@sohu.com',111114)
INSERT INTO Student VALUES('10012','HeQiang','��ǿ',0,1,02183567890,'��ַ����','1991-08-30 00:00:00','HeQiang@sohu.com',111120)
INSERT INTO Student VALUES('20011','ZhangSan','����',1,1,15290234178,'�����к�����','1994-01-01 00:00:00','ZhangSan@sohu.com',111115)
INSERT INTO Student VALUES('20012','ZhangQiuYu','������',0,2,01062751414,'�����ж�����','1990-06-05 00:00:00','ZhangQiuYu@sohu.com',111116)
INSERT INTO Student VALUES('20015','XiaoMei','Ф÷',0,2,031466557171,'�ӱ�ʡʯ��ׯ��','1996-10-01 00:00:00','XiaoMei@sohu.com',111117)
INSERT INTO Student VALUES('30021','OuYangJunXiong','ŷ������',1,2,02277585000,'�Ϻ���¬����','1995-09-29 00:00:00','OuYangJunXiong@sohu.com',111118)
INSERT INTO Student VALUES('30023','MeiChaoFeng','÷����',0,2,031466557172,'�����������','1997-08-30 00:00:00','MeiChaoFeng@sohu.com',111119)

--��Result���������
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
