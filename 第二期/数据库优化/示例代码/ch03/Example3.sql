/*
 *Example3
 *T-SQL������Ӧ��
 */

use MySchool182

--�������
DECLARE @StuName nvarchar(20)		--ѧ������
DECLARE @StuNO int					--ѧ��

--��ֵ
SET @StuName = '���Ĳ�'				--��ȡѧ������

select @StuNO = StudentNo
from Student
where StudentName = @StuName		--��ȡѧ��

--�����Ϣ
select *
from Student
where StudentNo = @StuNO + 1 or StudentNo = @StuNO - 1