------------------------------------��ṹ--------------------------------------
--ѧ����tblStudent�����StuId������StuName������StuAge���Ա�StuSex��
--�γ̱�tblCourse���γ̱��CourseId���γ�����CourseName����ʦ���TeaId��
--�ɼ���tblScore��ѧ�����StuId���γ̱��CourseId���ɼ�Score��
--��ʦ��tblTeacher����ʦ���TeaId������TeaName��
---------------------------------------------------------------------------------

--���⣺ 
use MySchool_Work

--1����ѯ��001���γ̱ȡ�002���γ̳ɼ��ߵ�����ѧ����ѧ�ţ�
 select StuId from tblStudent 
where 
(select Score from tblScore where tblStudent.StuId = tblScore.StuId and tblScore.CourseId = '001')
 >
(select Score from tblScore where tblStudent.StuId = tblScore.StuId and tblScore.CourseId = '002')


--2����ѯƽ���ɼ�����60�ֵ�ͬѧ��ѧ�ź�ƽ���ɼ��� 
select StuId as ѧ��,AVG(Score) as ƽ���ɼ� from tblScore
group by StuId
having AVG(Score) > 60

select a.StuId,a.ƽ���ɼ� from
(
	select StuId as ѧ��,AVG(Score) as ƽ���ɼ� from tblScore
	group by StuId
) as a
where a.ƽ���ɼ� > 60

--3����ѯ����ͬѧ��ѧ�š�������ѡ�������ܳɼ��� 
 select StuId,StuName,
SelCourse = (select count(CourseId) from tblScore where tblStudent.StuId = tblScore.StuId),
SumScore = (select SUM(Score) from tblScore where tblStudent.StuId = tblScore.StuId)
from tblStudent

select a.StuId,b.StuName,COUNT(a.CourseId) as ѡ����,SUM(a.Score) as �ܳɼ�
from tblScore as a
left join tblStudent as b on a.StuId = b.StuId
group by a.StuId,b.StuName

--4����ѯ�ա������ʦ�ĸ����� 
select COUNT(TeaName) from tblTeacher where TeaName like '��%'

--5����ѯûѧ����Ҷƽ����ʦ�ε�ͬѧ��ѧ�š������� 
select StuId,StuName from tblStudent
where StuId not in 
(
	select StuId from tblScore 
	left join tblCourse on tblCourse.CourseId = tblScore.	CourseId
	left join tblTeacher on tblCourse.TeaId = tblTeacher.TeaId	
	where tblTeacher.TeaName = 'Ҷƽ'
)

--6����ѯѧ����001������Ҳѧ����š�002���γ̵�ͬѧ��ѧ�š������� 

--7����ѯѧ����Ҷƽ����ʦ���̵����пε�ͬѧ��ѧ�š������� 

--8����ѯ�γ̱�š�002���ĳɼ��ȿγ̱�š�001���γ̵͵�����ͬѧ��ѧ�š������� 
select StuId,StuName from tblStudent
where (select Score from tblScore where tblStudent.StuId = tblScore.StuId and tblScore.CourseId = '001')
 >
(select Score from tblScore where tblStudent.StuId = tblScore.StuId and tblScore.CourseId = '002')
 
--9����ѯ���пγ̳ɼ�С��60�ֵ�ͬѧ��ѧ�š�������
 select distinct a.StuId,b.StuName from tblScore as a
 left join tblStudent as b on a.StuId = b.StuId
 where a.Score > 60 and a.StuId not in
  (select Score from tblScore where a.StuId = tblScore.StuId and Score >= 60) 
 
--10����ѯû��ѧȫ���пε�ͬѧ��ѧ�š������� 
select StuId,StuName from tblStudent
where (select COUNT(CourseId) from tblCourse) > (select COUNT(*) from tblScore where tblStudent.StuId = tblScore.StuId)

--11����ѯ������һ�ſ���ѧ��Ϊ��1001����ͬѧ��ѧ��ͬ��ͬѧ��ѧ�ź�������
 ------�������Ӳ�ѯ

 ------Ƕ���Ӳ�ѯ

--12����ѯ����ѧ��ѧ��Ϊ��1001��ͬѧ���пγ̵�����ͬѧѧ�ź������� 

--13���ѡ�SC�����С�Ҷƽ����ʦ�̵Ŀεĳɼ�������Ϊ�˿γ̵�ƽ���ɼ��� (���Ӳ�ѯ�л�ȡ����ѯ�еı���������Ҳ�У�������)
 --�������Ա� 
 select * from tblScore as sc
update sc set Score = (select AVG(Score) as ƽ���ɼ� from tblScore) 
where (
	select TeaName from tblTeacher 
	inner join tblCourse on tblTeacher.TeaId = tblCourse.TeaId
	inner join sc on sc.CourseId = tblCourse.CourseId
	) = 'Ҷƽ'

--14����ѯ�͡�1002���ŵ�ͬѧѧϰ�Ŀγ���ȫ��ͬ������ͬѧѧ�ź�������  
select StuId,StuName from tblStudent
where (select CourseId from tblScore) = (select CourseId from tblScore where StuId = '1002')

--15��ɾ��ѧϰ��Ҷƽ����ʦ�ε�SC���¼��
 
 
--16����SC���в���һЩ��¼����Щ��¼Ҫ���������������û���Ϲ���š�003���γ̵�ͬѧѧ�š�'002'�ſε�ƽ���ɼ��� 


--17����ƽ���ɼ��Ӹߵ�����ʾ����ѧ���ġ����ݿ⡱������ҵ��������Ӣ����ŵĿγ̳ɼ�����������ʽ��ʾ�� ѧ��ID,,���ݿ�,��ҵ����,Ӣ��,��Ч�γ���,��Чƽ���� 


--18����ѯ���Ƴɼ���ߺ���͵ķ֣���������ʽ��ʾ���γ�ID����߷֣���ͷ� 
 

--19��������ƽ���ɼ��ӵ͵��ߺͼ����ʵİٷ����Ӹߵ���˳�� (�ٷ�������θ�ʽ��Ϊ��λС��??)


--20����ѯ���¿γ�ƽ���ɼ��ͼ����ʵİٷ���(��"1��"��ʾ): ��ҵ����001�������˼��002����OO&UML ��003�������ݿ⣨004�� 
 

--21����ѯ��ͬ��ʦ���̲�ͬ�γ�ƽ���ִӸߵ�����ʾ 


--22����ѯ���¿γ̳ɼ��� 3 ������ 6 ����ѧ���ɼ�������ҵ����001�������˼��002����UML ��003�������ݿ⣨004�� ��ʽ��[ѧ��ID],[ѧ������],��ҵ����,���˼,UML,���ݿ�,ƽ���ɼ� 


--23��ͳ����ӡ���Ƴɼ�,������������:�γ�ID,�γ�����,[100-85],[85-70],[70-60],[ <60] 


--24����ѯѧ��ƽ���ɼ��������� 


--25����ѯ���Ƴɼ�ǰ�����ļ�¼:(�����ǳɼ��������)


--26����ѯÿ�ſγ̱�ѡ�޵�ѧ���� 


--27����ѯ��ֻѡ����һ�ſγ̵�ȫ��ѧ����ѧ�ź����� 


--28����ѯ������Ů������ 


--29����ѯ�ա��š���ѧ������ 


--30����ѯͬ��ͬ��ѧ����������ͳ��ͬ������ 
 
 
--31��1981�������ѧ������(ע��Student����Sage�е�������datetime) 


--32����ѯÿ�ſγ̵�ƽ���ɼ��������ƽ���ɼ��������У�ƽ���ɼ���ͬʱ�����γ̺Ž������� 


--33����ѯƽ���ɼ�����85������ѧ����ѧ�š�������ƽ���ɼ� 


--34����ѯ�γ�����Ϊ�����ݿ⡱���ҷ�������60��ѧ�������ͷ��� 


--35����ѯ����ѧ����ѡ������� 
 

--36����ѯ�κ�һ�ſγ̳ɼ���70�����ϵ��������γ����ƺͷ����� 


--37����ѯ������Ŀγ̣������γ̺ŴӴ�С���� 
 

--38����ѯ�γ̱��Ϊ003�ҿγ̳ɼ���80�����ϵ�ѧ����ѧ�ź������� 
 

--39����ѡ�˿γ̵�ѧ������ 
  

--40����ѯѡ�ޡ�Ҷƽ����ʦ���ڿγ̵�ѧ���У��ɼ���ߵ�ѧ����������ɼ� 


--41����ѯ�����γ̼���Ӧ��ѡ������ 


--42����ѯ��ͬ�γ̳ɼ���ͬ��ѧ����ѧ�š��γ̺š�ѧ���ɼ� 


--43����ѯÿ�Ź��ɼ���õ�ǰ���� 


--44��ͳ��ÿ�ſγ̵�ѧ��ѡ������������10�˵Ŀγ̲�ͳ�ƣ���Ҫ������γ̺ź�ѡ����������ѯ����������������У���������ͬ�����γ̺���������  


--45����������ѡ�����ſγ̵�ѧ��ѧ�� 
 
 
--46����ѯȫ��ѧ����ѡ�޵Ŀγ̵Ŀγ̺źͿγ��� 


--47����ѯûѧ����Ҷƽ����ʦ���ڵ���һ�ſγ̵�ѧ������ 
 

--48����ѯ�������ϲ�����γ̵�ͬѧ��ѧ�ż���ƽ���ɼ� 


--49��������004���γ̷���С��60���������������е�ͬѧѧ�� (ok)
 
 
--50��ɾ����002��ͬѧ�ġ�001���γ̵ĳɼ� 

