/*
 *Example1
 *�����ѯ-GROUP BY
 */
 
use MySchool182

--ͳ��ѧԱ����
select COUNT(*) as ѧԱ����
from Student

--���꼶ͳ��ѧԱ����
select COUNT(*) as ѧԱ����,GradeId
from Student
GROUP BY GradeId

--���Ա�ͳ��ѧԱ����
select COUNT(*) as ѧԱ����,Sex
from Student
GROUP BY Sex

--ͳ��Java Logic���Ե��ܷ�(�γ̱�š��ܷ�)
select Sum(StudentResult) as �ܷ�,SubjectNo
from Result
where SubjectNo = 1
GROUP BY SubjectNo

--ͳ�Ƹ��ƿ��Ե��ܷ�
select Sum(StudentResult) as �ܷ�,SubjectNo
from Result
GROUP BY SubjectNo

--ͳ��ÿ��ѧ�����ƿ��Ե��ܷ�(ѧ�š���Ŀ��š��ܷ�)
select StudentNo,SubjectNo,SUM(StudentResult) as �ܷ�
from Result
GROUP BY StudentNo,SubjectNo

--ͳ��10000��ѧ�����ƿ��Ե��ֳܷ���100�ֵĿ�Ŀ��Ϣ
select StudentNo,SubjectNo,SUM(StudentResult) as �ܷ�
from Result
where StudentNo = 10000
GROUP BY StudentNo,SubjectNo
HAVING SUM(StudentResult) > 100

--ͳ���ܿ�ʱ����300��ʱ���꼶
select GradeId,SUM(ClassHour) as �ܿ�ʱ
from Subject
GROUP BY GradeId
HAVING SUM(ClassHour) > 300