/*
 *Example4
 *�������� ���� LEFT JOIN
 *��left joinΪ������ߵı�Ϊ�����ұߵı�Ϊ�ӱ���������ݽ�ȫ����ʾ�����ӱ�����������������������ʾ�ӱ����ݣ�������NULL���
 */
 
use MySchool182

--��ѯδ�μӿ��Ե�ѧ����Ϣ(ѧ��,����,�Ա�,�꼶���,��ַ)
select a.StudentNo,a.StudentName,a.Sex,a.GradeId,a.Address,b.SubjectNo,b.StudentResult
from Student as a 
left join Result as b on a.StudentNo = b.StudentNo
where b.StudentResult is NULL

--��ѯȫ��S1Ůͬѧ����Ϣ
select a.*
from Student as a
left join Grade as b on a.GradeId = b.GradeId
where b.GradeName = 'S1'