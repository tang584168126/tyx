/*
 *Example3
 *ģ����ѯ ���� IN
 */
 
use MySchool182

--��ѯS1,S2��ѧ��
select *
from Student
where GradeId in (1,2)

--�ȼ���
select *
from Student
where GradeId = 1 or GradeId = 2

--��ѯ������S1,S2��ѧ��
select *
from Student
where GradeId not in (1,2)

--�ȼ���
select *
from Student
where GradeId != 1 and GradeId != 2