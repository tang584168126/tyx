use MySchool_Work

--1����ѯ��001���γ̱ȡ�002���γ̳ɼ��ߵ�����ѧ����ѧ�ţ�
 Select StuId From tblStudent s1 
  Where (Select Score From tblScore t1 Where t1.StuId=s1.stuId And t1.CourseId='001')>
   (Select Score From tblScore t2 Where t2.StuId=s1.stuId And t2.CourseId='002')

--2����ѯƽ���ɼ�����60�ֵ�ͬѧ��ѧ�ź�ƽ���ɼ��� 

 Select StuId,Avg(Score) as AvgScore From tblScore
  Group By StuId
   Having Avg(Score)>60

--3����ѯ����ͬѧ��ѧ�š�������ѡ�������ܳɼ��� 
 Select StuId,StuName,
  SelCourses=(Select Count(CourseId) From tblScore t1 Where t1.StuId=s1.StuId),
  SumScore=(Select Sum(Score) From tblScore t2 Where t2.StuId=s1.StuId)  
   From tblStudent s1

--4����ѯ�ա������ʦ�ĸ����� 
 Select Count(*) From tblTeacher Where TeaName like '��%'

--5����ѯûѧ����Ҷƽ����ʦ�ε�ͬѧ��ѧ�š������� 
 Select StuId,StuName From tblStudent
  Where StuId Not In
   (
    Select StuID From tblScore sc
     Inner Join tblCourse cu ON sc.CourseId=cu.CourseId
     Inner Join tblTeacher tc ON cu.TeaId=tc.TeaId    
      Where tc.TeaName='Ҷƽ'
   )

--6����ѯѧ����001������Ҳѧ����š�002���γ̵�ͬѧ��ѧ�š������� 
 Select StuId,StuName From tblStudent st
  Where (Select Count(*) From tblScore s1 Where s1.StuId=st.StuId And s1.CourseId='001')>0
   And
   (Select Count(*) From tblScore s2 Where s2.StuId=st.StuId And s2.CourseId='002')>0

--7����ѯѧ����Ҷƽ����ʦ���̵����пε�ͬѧ��ѧ�š������� 
 Select StuId,StuName From tblStudent st Where not exists
  (
   Select CourseID From tblCourse cu Inner Join tblTeacher tc On cu.TeaID=tc.TeaID 
    Where tc.TeaName='Ҷƽ' And CourseID not in 
    (Select CourseID From tblScore Where StuID=st.StuID)
  )

--8����ѯ�γ̱�š�002���ĳɼ��ȿγ̱�š�001���γ̵͵�����ͬѧ��ѧ�š������� 
 Select StuId,StuName From tblStudent s1 
  Where (Select Score From tblScore t1 Where t1.StuId=s1.stuId And t1.CourseId='001')>
   (Select Score From tblScore t2 Where t2.StuId=s1.stuId And t2.CourseId='002')

--9����ѯ���пγ̳ɼ�С��60�ֵ�ͬѧ��ѧ�š�������
 select distinct a.StuId,b.StuName from tblScore as a
 left join tblStudent as b on a.StuId = b.StuId
 where a.Score > 60 and a.StuId not in
  (select Score from tblScore where a.StuId = tblScore.StuId and Score >= 60) 

--10����ѯû��ѧȫ���пε�ͬѧ��ѧ�š������� 
 Select StuId,StuName From tblStudent st
  Where (Select Count(*) From tblScore sc Where st.StuId=sc.StuId)<
   (Select Count(*) From tblCourse)
   

--11����ѯ������һ�ſ���ѧ��Ϊ��1001����ͬѧ��ѧ��ͬ��ͬѧ��ѧ�ź�������
 ------�������Ӳ�ѯ
 Select DistInct st.StuId,StuName From tblStudent as st
  Inner Join tblScore sc ON st.StuId=sc.StuId
   Where sc.CourseId IN (Select CourseId From tblScore Where StuId='1001')
   
   
 ------Ƕ���Ӳ�ѯ
 Select StuId,StuName From tblStudent
  Where StuId In
  (
   Select Distinct StuId From tblScore Where CourseId In (Select CourseId From tblScore Where StuId='1001')
  )

select distinct a.StuId,b.StuName
 from tblScore as a 
 left join tblStudent as b on a.StuId = b.StuId
 where a.CourseId in
 (
 select CourseId from tblScore where StuId = '1001'
 )
--12����ѯ����ѧ��ѧ��Ϊ��1001��ͬѧ���пγ̵�����ͬѧѧ�ź������� 
select StuId,CourseId,Score from tblScore as ts
where not exists
(
	select CourseId from tblScore as b
	where StuId = '1001' and not exists
	(
		select a.StuId,a.CourseId from tblScore as a
		where a.CourseId = b.CourseId and a.StuId = ts.StuId
	)
)
   --select CourseId from tblScore where StuId = '1001'

--13���ѡ�SC�����С�Ҷƽ����ʦ�̵Ŀεĳɼ�������Ϊ�˿γ̵�ƽ���ɼ��� (���Ӳ�ѯ�л�ȡ����ѯ�еı���������Ҳ�У�������)
 --�������Ա� 
 Select * Into Sc From tblScore
 go

 Update Sc Set Score=(Select Avg(Score) From tblScore s1 Where s1.CourseId=sc.CourseId) 
  Where CourseId IN
   (Select CourseId From tblCourse cs INNER JOIN tblTeacher tc ON cs.TeaID=tc.TeaID WHERE TeaName ='Ҷƽ')

--14����ѯ�͡�1002���ŵ�ͬѧѧϰ�Ŀγ���ȫ��ͬ������ͬѧѧ�ź�������  
 Select StuID,StuName From tblStudent st
  Where StuId <> '1002' 
   And 
   Not Exists(Select * From tblScore sc Where sc.StuId=st.StuId And CourseId Not In (Select CourseId From tblScore Where StuId='1002')) 
   And
   Not Exists(Select * From tblScore Where StuId='1002' And CourseId Not In (Select CourseId From tblScore sc Where sc.StuId=st.StuId))

--15��ɾ��ѧϰ��Ҷƽ����ʦ�ε�SC���¼��
 Delete From tblScore Where CourseId IN 
  (Select CourseId From tblCourse cs INNER JOIN tblTeacher tc ON cs.TeaId=tc.TeaId Where tc.TeaName='Ҷƽ')

--16����SC���в���һЩ��¼����Щ��¼Ҫ���������������û���Ϲ���š�003���γ̵�ͬѧѧ�š�'002'�ſε�ƽ���ɼ��� 
 Insert Into tblScore (StuId,CourseId,Score) 
  Select StuId,'002',(Select Avg(Score) From tblScore Where CourseId='002') From tblScore Where
   StuId Not In (Select StuId From tblScore Where CourseId='003') 

--17����ƽ���ɼ��Ӹߵ�����ʾ����ѧ���ġ����ݿ⡱������ҵ��������Ӣ����ŵĿγ̳ɼ�����������ʽ��ʾ�� ѧ��ID,,���ݿ�,��ҵ����,Ӣ��,��Ч�γ���,��Чƽ���� 
 Select StuId
  ,���ݿ�=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where CourseName='���ݿ�' And sc.StuID=st.StuId)
  ,��ҵ����=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where CourseName='��ҵ����' And sc.StuID=st.StuId)
  ,Ӣ��=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where CourseName='Ӣ��' And sc.StuID=st.StuId)
  ,��Ч�γ���=(Select Count(Score) From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where (CourseName='���ݿ�' or CourseName='��ҵ����' or CourseName='Ӣ��') And sc.StuID=st.StuId)
  ,��Чƽ����=(Select Avg(Score) From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where (CourseName='���ݿ�' or CourseName='��ҵ����' or CourseName='Ӣ��') And sc.StuID=st.StuId)
  From tblStudent st
  Order by ��Чƽ���� Desc

--18����ѯ���Ƴɼ���ߺ���͵ķ֣���������ʽ��ʾ���γ�ID����߷֣���ͷ� 
 Select CourseId as �γ�ID, ��߷�=(Select Max(Score) From tblScore sc Where sc.CourseId=cs.CourseId ),
  ��ͷ�=(Select Min(Score) From tblScore sc Where sc.CourseId=cs.CourseId )
  From tblCourse cs

--19��������ƽ���ɼ��ӵ͵��ߺͼ����ʵİٷ����Ӹߵ���˳�� (�ٷ�������θ�ʽ��Ϊ��λС��??)
 Select �γ�ID,ƽ����,������ From
  (Select CourseId as �γ�ID, ƽ����=(Select Avg(Score) From tblScore sc Where sc.CourseId=cs.CourseId ),
   ������=Convert(varchar(10),((Select Count(*) From tblScore sc Where sc.CourseId=cs.CourseId And sc.Score>=60)*10000/(Select Count(*) From tblScore sc Where sc.CourseId=cs.CourseId))/100)+'%'
   From tblScore cs) as tmp
  Group by �γ�ID,ƽ����,������
   Order by ƽ����, Convert(float,substring(������,1,len(������)-1)) Desc

--20����ѯ���¿γ�ƽ���ɼ��ͼ����ʵİٷ���(��"1��"��ʾ): ��ҵ����001�������˼��002����OO&UML ��003�������ݿ⣨004�� 
 Select �γ�ID=sc.CourseId,�γ�����=cs.CourseName,ƽ���ɼ�=Avg(Score)
  ,������ =Convert(varchar(10),((Select Count(Score) From tblScore Where CourseId=sc.CourseId And Score>=60)*10000/Count(Score))/100.0)+'%'
  From tblScore sc
  Inner Join tblCourse cs ON sc.CourseId=cs.CourseId
  Where sc.CourseId like '00[1234]'
  Group By sc.CourseId,cs.CourseName

--21����ѯ��ͬ��ʦ���̲�ͬ�γ�ƽ���ִӸߵ�����ʾ 
 Select �γ�ID=CourseId,�γ�����=CourseName,�ڿν�ʦ=TeaName,ƽ���ɼ�=(Select Avg(Score) From tblScore Where CourseId=cs.CourseId)
  From tblCourse cs
  Inner Join tblTeacher tc ON cs.TeaId=tc.TeaId
  Order by ƽ���ɼ� Desc

--22����ѯ���¿γ̳ɼ��� 3 ������ 6 ����ѧ���ɼ�������ҵ����001�������˼��002����UML ��003�������ݿ⣨004�� ��ʽ��[ѧ��ID],[ѧ������],��ҵ����,���˼,UML,���ݿ�,ƽ���ɼ� 
 Select * From 
  (
   Select Top 6 ѧ��ID=StuId,ѧ������=StuName
    ,��ҵ����=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where CourseName='��ҵ����' And sc.StuID=st.StuId)
    ,���˼=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where CourseName='���˼' And sc.StuID=st.StuId)
    ,UML=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where CourseName='UML' And sc.StuID=st.StuId)
    ,���ݿ�=(Select Score From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where CourseName='���ݿ�' And sc.StuID=st.StuId)
    ,ƽ���ɼ�=(Select Avg(Score) From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where (CourseName='���ݿ�' or CourseName='��ҵ����' or CourseName='UML'or CourseName='���˼') And sc.StuID=st.StuId)
    ,����=Row_Number() Over(Order by(Select Avg(Score) From tblScore sc Inner Join tblCourse cs On sc.CourseId=cs.CourseId Where (CourseName='���ݿ�' or CourseName='��ҵ����' or CourseName='UML'or CourseName='���˼') And sc.StuID=st.StuId) DESC)
    From tblStudent st
    Order by ����
  ) as tmp
  Where ���� between 3 And 6

--23��ͳ����ӡ���Ƴɼ�,������������:�γ�ID,�γ�����,[100-85],[85-70],[70-60],[ <60] 
 Select �γ�ID=CourseId, �γ�����=CourseName
  ,[100-85]=(Select Count(*) From tblScore sc Where CourseId=cs.CourseId And Score between 85 And 100)
  ,[85-70]=(Select Count(*) From tblScore sc Where CourseId=cs.CourseId And Score between 70 And 84)
  ,[70-60]=(Select Count(*) From tblScore sc Where CourseId=cs.CourseId And Score between 60 And 69)
  ,[<60]=(Select Count(*) From tblScore sc Where CourseId=cs.CourseId And Score <60)
  From tblCourse cs

--24����ѯѧ��ƽ���ɼ��������� 
 Select ѧ��=st.StuId, ����=StuName,ƽ���ɼ�=sc.AvgScore,����=(Dense_Rank() Over(Order by sc.AvgScore Desc)) From tblStudent st
  Inner Join (Select StuId,Avg(Score) as AvgScore From tblScore Group by StuId) as sc On sc.StuId=st.StuId
  Order by ѧ��

--25����ѯ���Ƴɼ�ǰ�����ļ�¼:(�����ǳɼ��������)
 Select ѧ��=StuId,�γ̺�=CourseId,����=Score
  From 
  (Select Row_Number() Over(order by CourseId,Score Desc) as i,* From tblScore) as tmp --�õ�һ����ʱ��������,����i��ʾ���
   Where i In 
   (
    Select Top 3 i From (Select Row_Number() Over(order by CourseId,Score Desc) as i,* From tblScore) as t1 Where t1.CourseId=tmp.CourseId
   )

--26����ѯÿ�ſγ̱�ѡ�޵�ѧ���� 
 Select �γ�ID=CourseId,ѡ������=(Select Count(*) From (Select Distinct StuId From tblScore Where CourseId=cs.CourseId) as tmp)
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
 Select Distinct ѧ������=StuName,ͬ������=(Select Count(*) From tblStudent s2 Where s2.StuName=st.StuName) From tblStudent st
  Where (Select Count(*) From tblStudent s2 Where s2.StuName=st.StuName)>=2

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
 Select ѧ��=StuId,ѡ����=(Select Count(*) From (Select Distinct CourseId From tblScore Where StuId=st.StuId) as tmp)
  From tblStudent st 

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
Select CourseId,CourseName
 ,�ÿ����ѧ��=(Select StuName From tblStudent Where StuId in (Select Top 1 StuID From tblScore Where CourseId=cs.CourseId Order by Score Desc))
 ,�ɼ�=(Select Top 1 Score From tblScore Where CourseId=cs.CourseId Order by Score Desc)
 From tblCourse cs Inner Join tblTeacher tc ON cs.TeaId=tc.TeaId
 Where TeaName='Ҷƽ'

--41����ѯ�����γ̼���Ӧ��ѡ������ 
 Select �γ�ID=CourseId,ѡ������=(Select Count(*) From (Select Distinct StuId From tblScore Where CourseId=cs.CourseId) as tmp)
  From tblCourse cs 

--42����ѯ��ͬ�γ̳ɼ���ͬ��ѧ����ѧ�š��γ̺š�ѧ���ɼ� 
 Select ѧ��=StuId, �γ̺�=CourseId, �ɼ�=Score From tblScore sc 
  Where Exists (Select * From tblScore Where Score=sc.Score And StuId=sc.StuId And CourseId <>sc.CourseId)
  Order by ѧ��,�ɼ�

--43����ѯÿ�Ź��ɼ���õ�ǰ���� 
 Select �γ̺�=CourseId,
  ��1��=(Select Top 1 StuId From tblScore Where CourseId=cs.CourseId Order by Score DESC),
  ��2��=(Select Top 1 StuID From (Select Top 2 StuId,Score From tblScore Where CourseId=cs.CourseId Order by Score DESC) as tmp Order by Score)
  From tblCourse cs

--44��ͳ��ÿ�ſγ̵�ѧ��ѡ������������10�˵Ŀγ̲�ͳ�ƣ���Ҫ������γ̺ź�ѡ����������ѯ����������������У���������ͬ�����γ̺���������  
 Select �γ�ID=CourseId,ѡ������=(Select Count(*) From (Select Distinct StuId From tblScore Where CourseId=cs.CourseId) as tmp)
  From tblCourse cs 
  Where (Select Count(*) From (Select Distinct StuId From tblScore Where CourseId=cs.CourseId) as tmp)>=10
  Order by ѡ������ DESC, �γ�ID  

--45����������ѡ�����ſγ̵�ѧ��ѧ�� 
 Select StuId from tblScore Group by Stuid having Count(*)>=2 --û���ظ��γ�����ʱ���ô˷���

 --���ظ��γ�ʱ�ô˷���(�粹��)
 Select StuId from tblStudent st Where
  (Select Count(*) From (Select Distinct CourseId From tblScore Where StuId=st.StuId) as tmp)>=2

--46����ѯȫ��ѧ����ѡ�޵Ŀγ̵Ŀγ̺źͿγ��� 
 Select CourseId,CourseName From tblCourse cs
  Where Not Exists
  (
   Select * From tblStudent Where StuId Not In     --ûѧ�����γ̵�ѧ���Ƿ����
   (Select StuId From tblScore Where CourseId=cs.CourseId)
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
 Delete From SC Where StuId='1002' And CourseId='001'