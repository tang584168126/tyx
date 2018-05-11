--�������ݿ�
use ST182

--1)ͳ�Ƹ���Ŀ�ܷ�
select a.courseId as ��Ŀ���,b.courseName as ��Ŀ����,
SUM(a.witScore) as �����ܷ�,SUM(a.labScore) as �����ܷ�
from Score as a
left join Course as b on a.courseId = b.courseId
GROUP BY a.courseId,b.courseName
ORDER BY a.courseId ASC

--2)ͳ�Ƹ���Ŀƽ����
select a.courseId as ��Ŀ���,b.courseName as ��Ŀ����,
AVG(a.witScore) as ����ƽ����,AVG(a.labScore) as ����ƽ����
from Score as a
left join Course as b on a.courseId = b.courseId
GROUP BY a.courseId,b.courseName
ORDER BY a.courseId ASC

--3)�鿴����Ŀ��߷�
select a.courseId as ��Ŀ���,b.courseName as ��Ŀ����,
MAX(a.witScore) as ������߷�,MAX(a.labScore) as ������߷�
from Score as a
left join Course as b on a.courseId = b.courseId
GROUP BY a.courseId,b.courseName
ORDER BY a.courseId ASC

--4)�鿴����Ŀ��ͷ�
select a.courseId as ��Ŀ���,b.courseName as ��Ŀ����,
MIN(a.witScore) as ������ͷ�,MIN(a.labScore) as ������ͷ�
from Score as a
left join Course as b on a.courseId = b.courseId
GROUP BY a.courseId,b.courseName
ORDER BY a.courseId ASC

--5)ͳ�Ƹ�ѧԱ��ƽ��(�ʼ�+���Ե���ƽ��)
select a.stuId as ѧ�����,b.stuName as ѧ������,
SUM(a.witScore + a.labScore) as �ܷ�,
SUM(a.witScore + a.labScore) / COUNT(*) as ��ƽ��
from Score as a
left join Student as b on a.stuId = b.stuId
GROUP BY a.stuId,b.stuName
ORDER BY a.stuId ASC

--6)�鿴������߷�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,
a.courseId as �γ̱��,c.courseName as �γ�����,
a.witScore as ���Է���,
b.stuName as ѧ������,b.stuSex as �Ա�,b.stuBirthday as ����,b.stuAddress as ��ַ
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY a.witScore DESC

--7)�鿴������߷�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,
a.courseId as �γ̱��,c.courseName as �γ�����,
a.labScore as ���Է���,
b.stuName as ѧ������,b.stuSex as �Ա�,b.stuBirthday as ����,b.stuAddress as ��ַ
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY a.labScore DESC

--8)�鿴������ͷ�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,
a.courseId as �γ̱��,c.courseName as �γ�����,
a.witScore as ���Է���,
b.stuName as ѧ������,b.stuSex as �Ա�,b.stuBirthday as ����,b.stuAddress as ��ַ
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY a.witScore ASC

--9)�鿴������ͷ�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,
a.courseId as �γ̱��,c.courseName as �γ�����,
a.labScore as ���Է���,
b.stuName as ѧ������,b.stuSex as �Ա�,b.stuBirthday as ����,b.stuAddress as ��ַ
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY a.labScore ASC

--10)�鿴�ܷ���߷�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,
a.courseId as �γ̱��,c.courseName as �γ�����,
(a.labScore + a.witScore) as �ܷ���,
b.stuName as ѧ������,b.stuSex as �Ա�,b.stuBirthday as ����,b.stuAddress as ��ַ
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY (a.labScore + a.witScore) DESC

--11)�鿴�ܷ���ͷ�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,
a.courseId as �γ̱��,c.courseName as �γ�����,
(a.labScore + a.witScore) as �ܷ���,
b.stuName as ѧ������,b.stuSex as �Ա�,b.stuBirthday as ����,b.stuAddress as ��ַ
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY (a.labScore + a.witScore) ASC

--12)ͳ�Ƹ��༶�ܷ�
select b.classId as �༶���,c.className as �༶����,
SUM(a.witScore) as �����ܷ�,SUM(a.labScore) as �����ܷ�
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY b.classId ASC

--13)ͳ�Ƹ��༶ƽ����
select b.classId as �༶���,c.className as �༶����,
SUM(a.witScore) as �����ܷ�,SUM(a.labScore) as �����ܷ�,
COUNT(*) as �ο�����,
AVG(a.witScore) as ����ƽ����,AVG(a.labScore) as ����ƽ����
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY b.classId ASC

--14)ͳ�Ƹ��༶����Ŀ�ܷ�
select
a.courseId as �γ̱��,b.courseName as �γ�����,
c.classId as �༶���,d.className as �༶����,
SUM(a.witScore) as �����ܷ�,SUM(a.labScore) as �����ܷ�
from Score as a
left join Course as b on a.courseId = b.courseId
left join Student as c on a.stuId = c.stuId
left join Class as d on c.classId = d.classId
GROUP BY a.courseId,b.courseName,c.classId,d.className

--15)ͳ�Ƹ��༶����Ŀƽ����
select
a.courseId as �γ̱��,b.courseName as �γ�����,
c.classId as �༶���,d.className as �༶����,
AVG(a.witScore) as ����ƽ����,AVG(a.labScore) as ����ƽ����
from Score as a
left join Course as b on a.courseId = b.courseId
left join Student as c on a.stuId = c.stuId
left join Class as d on c.classId = d.classId
GROUP BY a.courseId,b.courseName,c.classId,d.className

--16)�鿴�ܷ���ߵİ༶������
select TOP 1
b.classId as �༶���,c.className as �༶����,
(SUM(a.witScore) + SUM(a.labScore)) as �ܷ�
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY (SUM(a.witScore) + SUM(a.labScore)) DESC

--17)�鿴�ܷ���͵İ༶������
select TOP 1
b.classId as �༶���,c.className as �༶����,
(SUM(a.witScore) + SUM(a.labScore)) as �ܷ�
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY (SUM(a.witScore) + SUM(a.labScore)) ASC

--18)�鿴ƽ������ߵİ༶������
select TOP 1 
b.classId as �༶���,c.className as �༶����,
(AVG(a.witScore) + AVG(a.labScore)) as ƽ����
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY (AVG(a.witScore) + AVG(a.labScore)) DESC

--19)�鿴ƽ������͵İ༶������
select TOP 1 
b.classId as �༶���,c.className as �༶����,
(AVG(a.witScore) + AVG(a.labScore)) as ƽ����
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY (AVG(a.witScore) + AVG(a.labScore)) ASC