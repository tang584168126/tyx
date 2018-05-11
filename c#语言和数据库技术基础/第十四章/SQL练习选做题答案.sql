--�������ݿ�
use ST182

--1)�鿴����Ŀ��ͷֵİ༶��Ϣ������
select a.courseId �γ̱��,c.courseName �γ�����,
d.classId as �༶���,e.className �༶����,
a.totalScore as ����
from
(
	select courseId,MIN(witScore + labScore) as totalScore
	from Score
	GROUP BY courseId
) as a
left join Score as b on a.courseId = b.courseId and a.totalScore = (b.witScore + b.labScore)
left join Course as c on a.courseId = c.courseId
left join Student as d on b.stuId = d.stuId
left join Class as e on d.classId = e.classId

--2)�鿴����Ŀ��߷ֵİ༶��Ϣ������
select a.courseId �γ̱��,c.courseName �γ�����,
d.classId as �༶���,e.className �༶����,
a.totalScore as ����
from
(
	select courseId,MAX(witScore + labScore) as totalScore
	from Score
	GROUP BY courseId
) as a
left join Score as b on a.courseId = b.courseId and a.totalScore = (b.witScore + b.labScore)
left join Course as c on a.courseId = c.courseId
left join Student as d on b.stuId = d.stuId
left join Class as e on d.classId = e.classId

--3)�鿴����Ŀ��ͷֵ�ѧԱ��Ϣ,�༶��Ϣ������
select a.courseId �γ̱��,c.courseName �γ�����,
d.stuId as ѧ��,d.stuName as ѧ������,
d.classId as �༶���,e.className �༶����,
a.totalScore as ����
from
(
	select courseId,MIN(witScore + labScore) as totalScore
	from Score
	GROUP BY courseId
) as a
left join Score as b on a.courseId = b.courseId and a.totalScore = (b.witScore + b.labScore)
left join Course as c on a.courseId = c.courseId
left join Student as d on b.stuId = d.stuId
left join Class as e on d.classId = e.classId

--4)�鿴����Ŀ��߷ֵ�ѧԱ��Ϣ,�༶��Ϣ������
select a.courseId �γ̱��,c.courseName �γ�����,
d.stuId as ѧ��,d.stuName as ѧ������,
d.classId as �༶���,e.className �༶����,
a.totalScore as ����
from
(
	select courseId,MAX(witScore + labScore) as totalScore
	from Score
	GROUP BY courseId
) as a
left join Score as b on a.courseId = b.courseId and a.totalScore = (b.witScore + b.labScore)
left join Course as c on a.courseId = c.courseId
left join Student as d on b.stuId = d.stuId
left join Class as e on d.classId = e.classId