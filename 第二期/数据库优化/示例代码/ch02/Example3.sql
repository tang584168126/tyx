/*
 *Example3
 *����Լ��(һ)
 */
 
--1.ȷ��ʹ�õ����ݿ�
use MySchool182

--2.����Լ��(����)
ALTER TABLE Student ADD
	CONSTRAINT PK_Student PRIMARY KEY(StudentNo)
	
ALTER TABLE Grade ADD
	CONSTRAINT PK_Grade PRIMARY KEY(GradeId)