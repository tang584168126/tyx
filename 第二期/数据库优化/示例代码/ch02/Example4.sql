/*
 *Example4
 *����Լ��(��)
 */
 
--1.ȷ��ʹ�õ����ݿ�
use MySchool182

--2.����Լ��
	
	--ΨһԼ��
	ALTER TABLE Student ADD
		CONSTRAINT UQ_IDENTITYCard UNIQUE(IDENTITYCard)
		
	--Ĭ��Լ��
	ALTER TABLE Student ADD
		CONSTRAINT DF_Address DEFAULT('��ַ����') FOR Address
		
	--���Լ��
	ALTER TABLE Student ADD
		CONSTRAINT CK_BornDate CHECK(BornDate > '1980-1-1')
		
	--���Լ��
	ALTER TABLE Student ADD
		CONSTRAINT FK_Student_Grade_GradeId FOREIGN KEY(GradeId) REFERENCES Grade(GradeId)