use S1T182

--1.ͳ�Ƹ���Ŀ�ܷ�
select a.courseId as ��Ŀ���,a.courseName as ��Ŀ����, SUM(b.witScore) as �����ܷ�, SUM(b.labScore) as �����ܷ�
from Course as a
inner join Score as b on b.courseId = a.courseId
group by a.courseId,a.courseName

--2.ͳ�Ƹ���Ŀƽ����
select a.courseId as ��Ŀ���,a.courseName as ��Ŀ����, AVG(b.witScore) as ����ƽ����, AVG(b.labScore) as ����ƽ����
from Course as a
inner join Score as b on b.courseId = a.courseId
group by a.courseId,a.courseName

--3.�鿴����Ŀ��߷�
select a.courseId as ��Ŀ���,a.courseName as ��Ŀ����, MAX(b.witScore) as ������߷�, MAX(b.labScore) as ������߷�
from Course as a
inner join Score as b on b.courseId = a.courseId
group by a.courseId,a.courseName

--4.�鿴����Ŀ��ͷ�
select a.courseId as ��Ŀ���,a.courseName as ��Ŀ����, MIN(b.witScore) as ������ͷ�, MIN(b.labScore) as ������ͷ�
from Course as a
inner join Score as b on b.courseId = a.courseId
group by a.courseId,a.courseName

--5.ͳ�Ƹ�ѧԱ��ƽ�֣��ʼ�+���Ե���ƽ�֣�
select a.stuId as ѧ�����,a.stuName as ѧ������,SUM(b.witScore)+SUM(b.labScore) as �ܷ�, AVG(b.witScore+b.labScore) as ��ƽ��
from Student as a
inner join Score as b on b.stuId = a.stuId
group by a.stuId,a.stuName

--6.�鿴������߷�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,c.courseId as �γ̱��,c.courseName as �γ�����,b.witScore as ���Է���,a.stuName as ѧ������,a.stuSex as �Ա�,a.stuBirthday as ����,a.stuAddress as ��ַ
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.witScore desc

--7.�鿴������߷�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,c.courseId as �γ̱��,c.courseName as �γ�����,b.labScore as ���Է���,a.stuName as ѧ������,a.stuSex as �Ա�,a.stuBirthday as ����,a.stuAddress as ��ַ
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.labScore desc

--8.�鿴������ͷ�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,c.courseId as �γ̱��,c.courseName as �γ�����,b.witScore as ���Է���,a.stuName as ѧ������,a.stuSex as �Ա�,a.stuBirthday as ����,a.stuAddress as ��ַ
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.witScore

--9.�鿴������ͷ�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,c.courseId as �γ̱��,c.courseName as �γ�����,b.labScore as ���Է���,a.stuName as ѧ������,a.stuSex as �Ա�,a.stuBirthday as ����,a.stuAddress as ��ַ
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.labScore

--10.�鿴�ܷ���߷�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,c.courseId as �γ̱��,c.courseName as �γ�����,b.labScore + b.witScore as �ܷ�,a.stuName as ѧ������,a.stuSex as �Ա�,a.stuBirthday as ����,a.stuAddress as ��ַ
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.labScore + b.witScore desc

--11.�鿴�ܷ���ͷ�ѧԱ��Ϣ
select top 1 a.stuId as ѧ�����,c.courseId as �γ̱��,c.courseName as �γ�����,b.labScore + b.witScore as �ܷ�,a.stuName as ѧ������,a.stuSex as �Ա�,a.stuBirthday as ����,a.stuAddress as ��ַ
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.labScore + b.witScore

--12.ͳ�Ƹ��༶�ܷ�
select a.classId as �༶���, a.className as �༶����, SUM(b.witScore) as �����ܷ�,SUM(b.labScore) as �����ܷ�
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className

--13.ͳ�Ƹ��༶ƽ����
select a.classId as �༶���, a.className as �༶����,SUM(b.witScore) as �����ܷ�,SUM(b.labScore) as �����ܷ�,COUNT(b.stuId) as �ο�����,AVG(b.witScore) as ����ƽ����,AVG(b.labScore) as ����ƽ����
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className

--14.ͳ�Ƹ��༶����Ŀ�ܷ�
select d.courseId as �γ̱��,d.courseName as �γ�����,a.classId as �༶���, a.className as �༶����,SUM(b.witScore) as �����ܷ�,SUM(b.labScore) as �����ܷ�
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
inner join Course as d on d.courseId = b.courseId
group by a.classId,a.className,d.courseId,d.courseName

--15.ͳ�Ƹ��༶����Ŀƽ����
select d.courseId as �γ̱��,d.courseName as �γ�����,a.classId as �༶���, a.className as �༶����,AVG(b.witScore) as ����ƽ����,AVG(b.labScore) as ����ƽ����
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
inner join Course as d on d.courseId = b.courseId
group by a.classId,a.className,d.courseId,d.courseName

--16.�鿴�ܷ���ߵİ༶������
select top 1 a.classId as �༶���,a.className as �༶����,SUM(b.witScore + b.labScore) as �ܷ�
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className
order by SUM(b.witScore + b.labScore) desc

--17.�鿴�ܷ���͵İ༶������
select top 1 a.classId as �༶���,a.className as �༶����,SUM(b.witScore + b.labScore) as �ܷ�
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className
order by SUM(b.witScore + b.labScore)

--18.�鿴ƽ������ߵİ༶������
select top 1 a.classId as �༶���,a.className as �༶����,AVG(b.witScore + b.labScore) as ƽ����
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className
order by AVG(b.witScore + b.labScore) desc

--19.�鿴ƽ������͵İ༶������
select top 1 a.classId as �༶���,a.className as �༶����,AVG(b.witScore + b.labScore) as ƽ����
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className
order by AVG(b.witScore + b.labScore)

--20.�鿴����Ŀ��ͷֵİ༶��Ϣ������
select top 3 a.courseId as �γ̱��,a.courseName as �γ�����,b.classId as �༶���,b.className as �༶����,MIN(c.witScore + c.labScore) as ����
from Course as a
inner join Score as c on c.courseId = a.courseId
inner join Student as d on d.stuId = c.stuId
inner join Class as b on b.classId = d.classId
group by a.courseId,a.courseName,b.classId,b.className
order by MIN(c.witScore + c.labScore)

--21.�鿴����Ŀ��߷ֵİ༶��Ϣ������
select a.courseId as �γ̱��,a.courseName as �γ�����,b.classId as �༶���,b.className as �༶����,MIN(c.witScore + c.labScore) as ����
from Course as a
inner join Score as c on c.courseId = a.courseId
inner join Student as d on d.stuId = c.stuId
inner join Class as b on b.classId = d.classId
group by a.courseId,a.courseName,b.classId,b.className

--22.�鿴����Ŀ��ͷֵ�ѧԱ��Ϣ���༶��Ϣ������

--23.�鿴����Ŀ��߷ֵ�ѧԱ��Ϣ���༶��Ϣ������