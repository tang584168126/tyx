/*
 *Example2
 *T-SQL�����Ľ���
 */
 
use MySchool182

--�������
DECLARE @StuName nvarchar(20)		--ѧ������

--��ֵ
--1)����ѯ����ĸ�ֵ(ѧ��Ϊ10000��ѧ��������)
--select @StuName  = StudentName from Student where StudentNo = 10000

--2)���ѯ����ĸ�ֵ(ѧ������)
--select @StuName = StudentName from Student

--3)����ѯ����ĸ�ֵ(ѧ��Ϊ20000��ѧ��������)
--select @StuName  = StudentName from Student where StudentNo = 20000

--4)����ѯ����ĸ�ֵ(ѧ��Ϊ20000��ѧ��������,ѧ��Ϊ10000��ѧ��������)
SET @StuName = 'Michael'
--select @StuName  = StudentName from Student where StudentNo = 20000
select @StuName  = StudentName from Student where StudentNo = 10000

--����
PRINT 'ѧ������Ϊ:' + @StuName