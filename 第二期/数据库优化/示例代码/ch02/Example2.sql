/*
 *Example2
 *�������ݱ�
 */
 
--1.ȷ��ʹ�õ����ݿ�
use MySchool182

--2.�ж����ݿ���Ƿ���ڣ������ڣ�ɾ�����ݿ��
IF EXISTS(select * from sysobjects where name = 'Student')
	DROP TABLE Student
	
IF EXISTS(select * from sysobjects where name = 'Grade')
	DROP TABLE Grade
	
--3.������
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