/*
 *Example1
 *�������ݿ�
 */
 
--1.ȷ��ʹ�õ����ݿ�
use master

--2.�жϴ����ݿ��Ƿ���ڣ������ڣ�ɾ�������ݿ�
IF EXISTS(select * from sysdatabases where name = 'MySchool182')
	DROP DATABASE MySchool182

--3.�������ݿ�
CREATE DATABASE MySchool182
ON PRIMARY
(
	--���ݿ��������ļ�
	NAME = 'MySchool182',
	FILENAME = 'F:\Program\DataBase\MyDataBase\DB\MySchool182.mdf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 1MB
)
LOG ON
(
	--���ݿ���־�����ļ�
	NAME = 'MySchool182_log',
	FILENAME = 'F:\Program\DataBase\MyDataBase\DB\MySchool182_log.ldf',
	SIZE = 3MB,
	MAXSIZE = 20MB,
	FILEGROWTH = 1MB
)