/*
 *Example2
 *ģ����ѯ ���� BETWEEN
 */
 
use MySchool182

--��ѯ�����ѧ���ɼ�
select *
from Result
where StudentResult BETWEEN 60 AND 100

select *
from Result
where StudentResult BETWEEN 100 AND 60

--�ȼ���
select *
from Result
where StudentResult >= 60 and StudentResult <= 100