use MySchool_Work
------------------------------------��ṹ--------------------------------------
--ѧ����tblStudent�����StuId������StuName������StuAge���Ա�StuSex��
--�γ̱�tblCourse���γ̱��CourseId���γ�����CourseName����ʦ���TeaId��
--�ɼ���tblScore��ѧ�����StuId���γ̱��CourseId���ɼ�Score��
--��ʦ��tblTeacher����ʦ���TeaId������TeaName��
---------------------------------------------------------------------------------
--˵��:����ÿ��ÿ��ֻ��һ�ο��Ի���

--���⣺ 
--1����ѯ��001���γ̱ȡ�002���γ̳ɼ��ߵ�����ѧ����ѧ�ţ�
select StuId from tblStudent 
where 
(select Score from tblScore where tblStudent.StuId = tblScore.StuId and tblScore.CourseId = '001')
 >
(select Score from tblScore where tblStudent.StuId = tblScore.StuId and tblScore.CourseId = '002')

--2����ѯƽ���ɼ�����60�ֵ�ͬѧ��ѧ�ź�ƽ���ɼ��� 
select StuId,avg(Score) as ƽ���ɼ� from tblScore
group by StuId 
having avg(Score) > 60

--3����ѯ����ͬѧ��ѧ�š�������ѡ�������ܳɼ���
select StuId ,StuName,
SelectCource = (select COUNT(CourseId) from tblScore where tblScore.StuId = tblStudent.StuId),
SumScore = (select sum(Score) from tblScore where tblScore.StuId = tblStudent.StuId) 
from tblStudent

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
select StuId,StuName from tblStudent as a
where 
(select COUNT(*) from tblScore as b where a.StuId = b.StuId and b.CourseId = '001' )>0
and
(select COUNT(*) from tblScore as b where a.StuId = b.StuId and b.CourseId = '002' )>0

--7����ѯѧ����Ҷƽ����ʦ���̵����пε�ͬѧ��ѧ�š������� 
select StuId,StuName from tblStudent as a 
where StuId in
(
	Select CourseID From tblCourse as b 
	Inner Join tblTeacher c On b.TeaId=c.TeaId 
    Where c.TeaName='Ҷƽ' And CourseID in 
    (Select CourseID From tblScore Where StuID=a.StuID) 
)

--8����ѯ�γ̱�š�002���ĳɼ��ȿγ̱�š�001���γ̵͵�����ͬѧ��ѧ�š������� 
Select StuId,StuName From tblStudent as a 
  Where (Select Score From tblScore as b Where a.StuId=b.stuId And b.CourseId='001')>
   (Select Score From tblScore as b Where b.StuId=a.stuId And b.CourseId='002')

--9����ѯ���пγ̳ɼ�С��60�ֵ�ͬѧ��ѧ�š�������
select b.StuId,a.StuName From tblStudent as a
left join tblScore as b on a.StuId = b.StuId
where b.Score < 60 and a.StuId not in
(select Score from tblScore where a.StuId = tblScore.StuId and Score >= 60) 
 
--10����ѯû��ѧȫ���пε�ͬѧ��ѧ�š������� 
select StuId,StuName From tblStudent as a
where (select COUNT(*) from tblScore as b where a.StuId = b.StuId)
< (select COUNT(*) from tblScore)

--11����ѯ������һ�ſ���ѧ��Ϊ��1001����ͬѧ��ѧ��ͬ��ͬѧ��ѧ�ź�������
select StuId,StuName From tblStudent as a
where StuId in
(
	
)

--12����ѯ����ѧ��ѧ��Ϊ��1001��ͬѧ���пγ̵�����ͬѧѧ�ź������� 
select StuId,StuName From tblStudent as a
where StuId in
(
	select CourseId from tblScore as b
	where StuId = '1001' and StuId IN
	(
		select a.StuId,a.CourseId from tblScore as a
		where a.CourseId = b.CourseId and a.StuId = b.StuId
	)
)

--13���ѡ�SC�����С�Ҷƽ����ʦ�̵Ŀεĳɼ�������Ϊ�˿γ̵�ƽ���ɼ��� (���Ӳ�ѯ�л�ȡ����ѯ�еı���������Ҳ�У�������)
select * from tblScore as sc
go
update sc set Score = 
(select AVG(Score) from tblScore as ts where ts.CourseId = sc)

--14����ѯ�͡�1002���ŵ�ͬѧѧϰ�Ŀγ���ȫ��ͬ������ͬѧѧ�ź�������  


--15��ɾ��ѧϰ��Ҷƽ����ʦ�ε�SC���¼
Delete From tblScore Where CourseId IN 
(
	Select CourseId From tblCourse cs 
	INNER JOIN tblTeacher tc ON cs.TeaId=tc.TeaId Where tc.TeaName='Ҷƽ'
)
  
--16����SC���в���һЩ��¼����Щ��¼Ҫ���������������û���Ϲ���š�003���γ̵�ͬѧѧ�š�'002'�ſε�ƽ���ɼ��� 
Insert Into tblScore (StuId,CourseId,Score) 
Select StuId,'002',(Select Avg(Score) From tblScore Where CourseId='002') From tblScore Where
StuId Not In (Select StuId From tblScore Where CourseId='003') 

--17����ƽ���ɼ��Ӹߵ�����ʾ����ѧ���ġ����ݿ⡱������ҵ��������Ӣ����ŵĿγ̳ɼ�����������ʽ��ʾ�� ѧ��ID,,���ݿ�,��ҵ����,Ӣ��,��Ч�γ���,��Чƽ���� 
select 
���ݿ�=(Select Score From tblScore sc 
	Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
	Where CourseName='���ݿ�' And sc.StuID=st.StuId),
��ҵ����=(Select Score From tblScore sc 
	Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
	Where CourseName='��ҵ����' And sc.StuID=st.StuId),
Ӣ��=(Select Score From tblScore sc 
	Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
	Where CourseName='Ӣ��' And sc.StuID=st.StuId),
��Ч�γ���=(Select Count(Score) From tblScore sc 
	Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
	Where (CourseName='���ݿ�' or CourseName='��ҵ����' or CourseName='Ӣ��') 
	And sc.StuID=st.StuId),
��Чƽ����=(Select Avg(Score) From tblScore sc 
	Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
	Where (CourseName='���ݿ�' or CourseName='��ҵ����' or CourseName='Ӣ��') 
	And sc.StuID=st.StuId)
From tblStudent st
Order by ��Чƽ���� Desc

--18����ѯ���Ƴɼ���ߺ���͵ķ֣���������ʽ��ʾ���γ�ID����߷֣���ͷ� 
Select CourseId as �γ�ID, 
��߷�=(Select Max(Score) From tblScore sc Where sc.CourseId=cs.CourseId ),
��ͷ�=(Select Min(Score) From tblScore sc Where sc.CourseId=cs.CourseId )
From tblCourse cs
 
--19��������ƽ���ɼ��ӵ͵��ߺͼ����ʵİٷ����Ӹߵ���˳�� (�ٷ�������θ�ʽ��Ϊ��λС��??)
Select �γ�ID,ƽ����,������ From
(Select CourseId as �γ�ID, 
ƽ����=(Select Avg(Score) From tblScore sc Where sc.CourseId=cs.CourseId ),
������=Convert(varchar(10),((Select Count(*) From tblScore sc 
	Where sc.CourseId=cs.CourseId 
	And sc.Score>=60)*10000/(Select Count(*) From tblScore sc Where sc.CourseId=cs.CourseId))/100)+'%'
	From tblScore cs) as tmp
Group by �γ�ID,ƽ����,������
Order by ƽ����, Convert(float,substring(������,1,len(������)-1)) Desc

--20����ѯ���¿γ�ƽ���ɼ��ͼ����ʵİٷ���(��"1��"��ʾ): ��ҵ����001�������˼��002����OO&UML ��003�������ݿ⣨004�� 
Select �γ�ID=sc.CourseId,�γ�����=cs.CourseName,ƽ���ɼ�=Avg(Score),
������ =Convert(varchar(10),((Select Count(Score) From tblScore 
	Where CourseId=sc.CourseId And Score>=60)*10000/Count(Score))/100.0)+'%'
From tblScore sc
Inner Join tblCourse cs ON sc.CourseId=cs.CourseId
Where sc.CourseId like '00[1234]'
Group By sc.CourseId,cs.CourseName

--21����ѯ��ͬ��ʦ���̲�ͬ�γ�ƽ���ִӸߵ�����ʾ 
Select �γ�ID=CourseId,�γ�����=CourseName,�ڿν�ʦ=TeaName,
ƽ���ɼ�=(Select Avg(Score) From tblScore Where CourseId=cs.CourseId)
From tblCourse cs
Inner Join tblTeacher tc ON cs.TeaId=tc.TeaId
Order by ƽ���ɼ� Desc

--22����ѯ���¿γ̳ɼ��� 3 ������ 6 ����ѧ���ɼ�������ҵ����001�������˼��002����UML ��003�������ݿ⣨004�� ��ʽ��[ѧ��ID],[ѧ������],��ҵ����,���˼,UML,���ݿ�,ƽ���ɼ� 
Select * From 
(
   Select Top 6 ѧ��ID=StuId,ѧ������=StuName,
	��ҵ����=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
		Where CourseName='��ҵ����' And sc.StuID=st.StuId),
    ���˼=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
		Where CourseName='���˼' And sc.StuID=st.StuId),
    UML=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
		Where CourseName='UML' And sc.StuID=st.StuId),
    ���ݿ�=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
		Where CourseName='���ݿ�' And sc.StuID=st.StuId),
    ƽ���ɼ�=(Select Avg(Score) From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
		Where (CourseName='���ݿ�' or CourseName='��ҵ����' or CourseName='UML'or CourseName='���˼') 
		And sc.StuID=st.StuId),
    ����=Row_Number() Over(Order by(Select Avg(Score) From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId 
		Where (CourseName='���ݿ�' or CourseName='��ҵ����' or CourseName='UML'or CourseName='���˼') 
		And sc.StuID=st.StuId) DESC)
    From tblStudent st
    Order by ����
) as tmp
Where ���� between 3 And 6

--23��ͳ����ӡ���Ƴɼ�,������������:�γ�ID,�γ�����,[100-85],[85-70],[70-60],[ <60] 
Select �γ�ID=CourseId, �γ�����=CourseName,
  [100-85]=(Select Count(*) From tblScore sc Where CourseId=cs.CourseId And Score between 85 And 100),
  [85-70]=(Select Count(*) From tblScore sc Where CourseId=cs.CourseId And Score between 70 And 84),
  [70-60]=(Select Count(*) From tblScore sc Where CourseId=cs.CourseId And Score between 60 And 69),
  [<60]=(Select Count(*) From tblScore sc Where CourseId=cs.CourseId And Score <60)
  from tblCourse cs

--24����ѯѧ��ƽ���ɼ��������� 
Select ѧ��=st.StuId, ����=StuName,ƽ���ɼ�=sc.AvgScore,����=(Dense_Rank() Over(Order by sc.AvgScore Desc)) 
From tblStudent st
Inner Join (Select StuId,Avg(Score) as AvgScore From tblScore Group by StuId) as sc On sc.StuId=st.StuId
Order by ѧ��

--25����ѯ���Ƴɼ�ǰ�����ļ�¼:(�����ǳɼ��������)


--26����ѯÿ�ſγ̱�ѡ�޵�ѧ���� 
Select �γ�ID=CourseId,ѡ������=(Select Count(*) From (Select Distinct StuId From tblScore
Where CourseId=cs.CourseId) as tmp)
From tblCourse cs 

--27����ѯ��ֻѡ����һ�ſγ̵�ȫ��ѧ����ѧ�ź����� 
Select ѧ��=StuId,����=StuName
From tblStudent st 
Where (Select Count(*) From (Select Distinct CourseId From tblScore Where StuId=st.StuId) as tmp)=1

--28����ѯ������Ů������ 
Select ��������=(select Count(*) From tblStudent Where StuSex='��'),
Ů������=(select Count(*) From tblStudent Where StuSex='Ů')

--29����ѯ�ա��š���ѧ������ 
Select * From tblStudent Where StuName like '��%'

--30����ѯͬ��ͬ��ѧ����������ͳ��ͬ������ 

 
--31��1981�������ѧ������(ע��Student����Sage�е�������datetime) 
Select * From tblStudent Where Year(Sage)=1981

--32����ѯÿ�ſγ̵�ƽ���ɼ��������ƽ���ɼ��������У�ƽ���ɼ���ͬʱ�����γ̺Ž������� 
Select �γ�ID=CourseId,�γ�����=CourseName,ƽ���ɼ�=(Select Avg(Score) From tblScore Where CourseId=cs.CourseId)
From tblCourse cs
Order by ƽ���ɼ�,CourseId Desc

--33����ѯƽ���ɼ�����85������ѧ����ѧ�š�������ƽ���ɼ� 
Select ѧ��=StuId,����=StuName,ƽ���ɼ�=(Select Avg(Score) From tblScore Where StuId=st.StuId) From tblStudent st
Where (Select Avg(Score) From tblScore Where StuId=st.StuId)>85

--34����ѯ�γ�����Ϊ�����ݿ⡱���ҷ�������60��ѧ�������ͷ��� 
Select ����=StuName,����=Score From tblScore sc
Inner Join tblStudent st On sc.StuId=st.StuId
Inner Join tblCourse cs On sc.CourseId=cs.CourseId
Where CourseName='���ݿ�' And Score<60

--35����ѯ����ѧ����ѡ������� 
Select distinct ����=StuName,ѡ�޿γ�=CourseName From tblScore sc
Inner Join tblStudent st On sc.StuId=st.StuId
Inner Join tblCourse cs On sc.CourseId=cs.CourseId

--36����ѯ�κ�һ�ſγ̳ɼ���70�����ϵ��������γ����ƺͷ����� 
Select ����=StuName,�γ�����=CourseName,����=Score From tblScore sc
Inner Join tblStudent st On sc.StuId=st.StuId
Inner Join tblCourse cs On sc.CourseId=cs.CourseId
Where Score>=70

--37����ѯ������Ŀγ̣������γ̺ŴӴ�С���� 
Select * From tblScore Where Score<60 order by CourseId Desc

--38����ѯ�γ̱��Ϊ003�ҿγ̳ɼ���80�����ϵ�ѧ����ѧ�ź������� 
Select StuId,StuName From tblStudent 
Where StuId in 
(Select StuId From tblScore Where CourseId='003' And Score>=80) 

--39����ѡ�˿γ̵�ѧ������ 
Select ѡ�˿γ̵�ѧ������=Count(*) From tblStudent st Where StuId IN (Select StuID From tblScore) 

--40����ѯѡ�ޡ�Ҷƽ����ʦ���ڿγ̵�ѧ���У��ɼ���ߵ�ѧ����������ɼ� 
Select CourseId,CourseName,
�ÿ����ѧ��=(Select StuName From tblStudent Where StuId in 
	(Select Top 1 StuID From tblScore Where CourseId=cs.CourseId Order by Score Desc)),
�ɼ�=(Select Top 1 Score From tblScore Where CourseId=cs.CourseId Order by Score Desc)
From tblCourse cs Inner Join tblTeacher tc ON cs.TeaId=tc.TeaId
Where TeaName='Ҷƽ'

--41����ѯ�����γ̼���Ӧ��ѡ������ 
Select �γ�ID=CourseId,
ѡ������=(Select Count(*) From (Select Distinct StuId From tblScore Where CourseId=cs.CourseId) as tmp)
From tblCourse cs 

--42����ѯ��ͬ�γ̳ɼ���ͬ��ѧ����ѧ�š��γ̺š�ѧ���ɼ� 
Select ѧ��=StuId, �γ̺�=CourseId, �ɼ�=Score From tblScore sc 
Where Exists (Select * From tblScore Where Score=sc.Score And StuId=sc.StuId And CourseId <>sc.CourseId)
Order by ѧ��,�ɼ�

--43����ѯÿ�Ź��ɼ���õ�ǰ���� 
Select �γ̺�=CourseId,
��1��=(Select Top 1 StuId From tblScore Where CourseId=cs.CourseId Order by Score DESC),
��2��=(Select Top 1 StuID From (Select Top 2 StuId,Score From tblScore 
	Where CourseId=cs.CourseId Order by Score DESC) as tmp Order by Score)
From tblCourse cs

--44��ͳ��ÿ�ſγ̵�ѧ��ѡ������������10�˵Ŀγ̲�ͳ�ƣ���Ҫ������γ̺ź�ѡ����������ѯ����������������У���������ͬ�����γ̺���������  
Select �γ�ID=CourseId,
ѡ������=(Select Count(*) From (Select Distinct StuId From tblScore Where CourseId=cs.CourseId) as tmp)
From tblCourse cs 
Where (Select Count(*) From (Select Distinct StuId From tblScore Where CourseId=cs.CourseId) as tmp)>=10
Order by ѡ������ DESC, �γ�ID  

--45����������ѡ�����ſγ̵�ѧ��ѧ�� 
Select StuId from tblScore 
Group by Stuid 
having Count(*)>=2
 
--46����ѯȫ��ѧ����ѡ�޵Ŀγ̵Ŀγ̺źͿγ��� 
Select CourseId,CourseName From tblCourse cs
where CourseId in
(
	Select StuId From tblScore Where CourseId=cs.CourseId
)

--47����ѯûѧ����Ҷƽ����ʦ���ڵ���һ�ſγ̵�ѧ������ 
Select StuId,StuName From tblStudent
Where StuId Not In
(
	Select StuID From tblScore sc
    Inner Join tblCourse cu ON sc.CourseId=cu.CourseId
    Inner Join tblTeacher tc ON cu.TeaId=tc.TeaId    
    Where tc.TeaName='Ҷƽ'
) 

--48����ѯ�������ϲ�����γ̵�ͬѧ��ѧ�ż���ƽ���ɼ� 
Select StuID as ѧ��,Avg(Score) as ƽ���ɼ� From tblScore sc
Where (Select Count(*) From tblScore s1 Where s1.StuId=sc.StuId And Score<60)>=2
Group By StuId

--49��������004���γ̷���С��60���������������е�ͬѧѧ�� (ok)
Select StuID,Score From tblScore Where CourseId='004' And Score<60 Order by Score Desc
 
--50��ɾ����002��ͬѧ�ġ�001���γ̵ĳɼ� 
Delete From tblScore Where StuId='1002' And CourseId='001'
