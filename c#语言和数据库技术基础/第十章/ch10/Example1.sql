/*
 *Example1
 *ģ����ѯ ���� LIKE
 */
 
use MySchool182

--��ͷ����(���������ͬѧ)
select *
from Student
where StudentName like '��%'

--����(���Һӱ�ʡ��ͬѧ)
select *
from Student
where Address like '%�ӱ�%'

--��β����(���ҵ绰������25��β��ͬѧ)
select *
from Student
where Phone like '%25'