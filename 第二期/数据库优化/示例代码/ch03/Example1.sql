/*
 *Example1
 *T-SQL�����Ķ���
 */
 
--�������
DECLARE @StudentName nvarchar(20)	--ѧ������

--��ֵ
--SET @StudentName = 'Michael'

select @StudentName = StudentName from Student where StudentNo = 10000

--����
PRINT @StudentName