/*
 *Example3
 *������-INNER JOIN
 *��inner joinΪ��������inner join�������ű��������������������ݲ�ѯ����
 */
 
use MySchool182

--��ѯÿλѧ��ÿ�Ź��εķ���(ѧ�š���������Ŀ��š�����ʱ�䡢�ɼ�)
select a.StudentNo,b.StudentName,a.SubjectNo,a.ExamDate,a.StudentResult
from Result as a 
inner join Student as b on a.StudentNo = b.StudentNo

--��ѯÿλѧ��ÿ�Ź��εķ���(ѧ�š���������Ŀ��š���Ŀ���ơ�����ʱ�䡢�ɼ�)
select a.StudentNo,b.StudentName,a.SubjectNo,c.SubjectName,a.ExamDate,a.StudentResult
from Result as a
inner join Student as b on a.StudentNo = b.StudentNo
inner join Subject as c on a.SubjectNo = c.SubjectNo

--��ѯÿλѧ�����Կ�Ŀ���ڵ��꼶��Ϣ(ѧ�š���������Ŀ��š���Ŀ���ơ��꼶��š��꼶����)
select a.StudentNo,b.StudentName,a.SubjectNo,c.SubjectName,c.GradeId,d.GradeName
from Result as a
inner join Student as b on a.StudentNo = b.StudentNo
inner join Subject as c on a.SubjectNo = c.SubjectNo
inner join Grade as d on c.GradeId = d.GradeId

--��ѯ��ʱ����60�Ŀ�Ŀ�����꼶��Ϣ
select a.GradeId,b.GradeName,a.ClassHour
from Subject as a
inner join Grade as b on a.GradeId = b.GradeId
where a.ClassHour > 60