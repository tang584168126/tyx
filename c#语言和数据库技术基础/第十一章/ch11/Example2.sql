/*
 *Example2
 *��ѯ����д�Ĳ���
 *1.����������Щ��			=> from
 *2.���ݾ������ڵ��л���	=> select 
 *3.ȷ���Ƿ��в�ѯ����		=> where
 *4.ȷ���Ƿ���Ҫ����		=> GROUP BY
 *5.ȷ���Ƿ�ɸѡ���		=> HAVING
 *6.ȷ���Ƿ�����			=> ORDER BY
 */
 
use MySchool182

--��ѯ10000��ѧ��ÿ�ſγ̵ĳɼ�ƽ���֣����Ӹߵ�������
select StudentNo,SubjectNo,AVG(StudentResult) as ƽ����
from Result
where StudentNo = 10000
GROUP BY StudentNo,SubjectNo
ORDER BY AVG(StudentResult) DESC