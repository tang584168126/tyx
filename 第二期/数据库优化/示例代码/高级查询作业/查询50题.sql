------------------------------------表结构--------------------------------------
--学生表tblStudent（编号StuId、姓名StuName、年龄StuAge、性别StuSex）
--课程表tblCourse（课程编号CourseId、课程名称CourseName、教师编号TeaId）
--成绩表tblScore（学生编号StuId、课程编号CourseId、成绩Score）
--教师表tblTeacher（教师编号TeaId、姓名TeaName）
---------------------------------------------------------------------------------

--问题： 
use MySchool_Work

--1、查询“001”课程比“002”课程成绩高的所有学生的学号；
 select StuId from tblStudent 
where 
(select Score from tblScore where tblStudent.StuId = tblScore.StuId and tblScore.CourseId = '001')
 >
(select Score from tblScore where tblStudent.StuId = tblScore.StuId and tblScore.CourseId = '002')


--2、查询平均成绩大于60分的同学的学号和平均成绩； 
select StuId as 学号,AVG(Score) as 平均成绩 from tblScore
group by StuId
having AVG(Score) > 60

select a.StuId,a.平均成绩 from
(
	select StuId as 学号,AVG(Score) as 平均成绩 from tblScore
	group by StuId
) as a
where a.平均成绩 > 60

--3、查询所有同学的学号、姓名、选课数、总成绩； 
 select StuId,StuName,
SelCourse = (select count(CourseId) from tblScore where tblStudent.StuId = tblScore.StuId),
SumScore = (select SUM(Score) from tblScore where tblStudent.StuId = tblScore.StuId)
from tblStudent

select a.StuId,b.StuName,COUNT(a.CourseId) as 选课数,SUM(a.Score) as 总成绩
from tblScore as a
left join tblStudent as b on a.StuId = b.StuId
group by a.StuId,b.StuName

--4、查询姓“李”的老师的个数； 
select COUNT(TeaName) from tblTeacher where TeaName like '李%'

--5、查询没学过“叶平”老师课的同学的学号、姓名； 
select StuId,StuName from tblStudent
where StuId not in 
(
	select StuId from tblScore 
	left join tblCourse on tblCourse.CourseId = tblScore.	CourseId
	left join tblTeacher on tblCourse.TeaId = tblTeacher.TeaId	
	where tblTeacher.TeaName = '叶平'
)

--6、查询学过“001”并且也学过编号“002”课程的同学的学号、姓名； 

--7、查询学过“叶平”老师所教的所有课的同学的学号、姓名； 

--8、查询课程编号“002”的成绩比课程编号“001”课程低的所有同学的学号、姓名； 
select StuId,StuName from tblStudent
where (select Score from tblScore where tblStudent.StuId = tblScore.StuId and tblScore.CourseId = '001')
 >
(select Score from tblScore where tblStudent.StuId = tblScore.StuId and tblScore.CourseId = '002')
 
--9、查询所有课程成绩小于60分的同学的学号、姓名；
 select distinct a.StuId,b.StuName from tblScore as a
 left join tblStudent as b on a.StuId = b.StuId
 where a.Score > 60 and a.StuId not in
  (select Score from tblScore where a.StuId = tblScore.StuId and Score >= 60) 
 
--10、查询没有学全所有课的同学的学号、姓名； 
select StuId,StuName from tblStudent
where (select COUNT(CourseId) from tblCourse) > (select COUNT(*) from tblScore where tblStudent.StuId = tblScore.StuId)

--11、查询至少有一门课与学号为“1001”的同学所学相同的同学的学号和姓名；
 ------运用连接查询

 ------嵌套子查询

--12、查询至少学过学号为“1001”同学所有课程的其他同学学号和姓名； 

--13、把“SC”表中“叶平”老师教的课的成绩都更改为此课程的平均成绩； (从子查询中获取父查询中的表名，这样也行？？？？)
 --创建测试表 
 select * from tblScore as sc
update sc set Score = (select AVG(Score) as 平均成绩 from tblScore) 
where (
	select TeaName from tblTeacher 
	inner join tblCourse on tblTeacher.TeaId = tblCourse.TeaId
	inner join sc on sc.CourseId = tblCourse.CourseId
	) = '叶平'

--14、查询和“1002”号的同学学习的课程完全相同的其他同学学号和姓名；  
select StuId,StuName from tblStudent
where (select CourseId from tblScore) = (select CourseId from tblScore where StuId = '1002')

--15、删除学习“叶平”老师课的SC表记录；
 
 
--16、向SC表中插入一些记录，这些记录要求符合以下条件：没有上过编号“003”课程的同学学号、'002'号课的平均成绩； 


--17、按平均成绩从高到低显示所有学生的“数据库”、“企业管理”、“英语”三门的课程成绩，按如下形式显示： 学生ID,,数据库,企业管理,英语,有效课程数,有效平均分 


--18、查询各科成绩最高和最低的分：以如下形式显示：课程ID，最高分，最低分 
 

--19、按各科平均成绩从低到高和及格率的百分数从高到低顺序 (百分数后如何格式化为两位小数??)


--20、查询如下课程平均成绩和及格率的百分数(用"1行"显示): 企业管理（001），马克思（002），OO&UML （003），数据库（004） 
 

--21、查询不同老师所教不同课程平均分从高到低显示 


--22、查询如下课程成绩第 3 名到第 6 名的学生成绩单：企业管理（001），马克思（002），UML （003），数据库（004） 格式：[学生ID],[学生姓名],企业管理,马克思,UML,数据库,平均成绩 


--23、统计列印各科成绩,各分数段人数:课程ID,课程名称,[100-85],[85-70],[70-60],[ <60] 


--24、查询学生平均成绩及其名次 


--25、查询各科成绩前三名的记录:(不考虑成绩并列情况)


--26、查询每门课程被选修的学生数 


--27、查询出只选修了一门课程的全部学生的学号和姓名 


--28、查询男生、女生人数 


--29、查询姓“张”的学生名单 


--30、查询同名同性学生名单，并统计同名人数 
 
 
--31、1981年出生的学生名单(注：Student表中Sage列的类型是datetime) 


--32、查询每门课程的平均成绩，结果按平均成绩升序排列，平均成绩相同时，按课程号降序排列 


--33、查询平均成绩大于85的所有学生的学号、姓名和平均成绩 


--34、查询课程名称为“数据库”，且分数低于60的学生姓名和分数 


--35、查询所有学生的选课情况； 
 

--36、查询任何一门课程成绩在70分以上的姓名、课程名称和分数； 


--37、查询不及格的课程，并按课程号从大到小排列 
 

--38、查询课程编号为003且课程成绩在80分以上的学生的学号和姓名； 
 

--39、求选了课程的学生人数 
  

--40、查询选修“叶平”老师所授课程的学生中，成绩最高的学生姓名及其成绩 


--41、查询各个课程及相应的选修人数 


--42、查询不同课程成绩相同的学生的学号、课程号、学生成绩 


--43、查询每门功成绩最好的前两名 


--44、统计每门课程的学生选修人数（超过10人的课程才统计）。要求输出课程号和选修人数，查询结果按人数降序排列，若人数相同，按课程号升序排列  


--45、检索至少选修两门课程的学生学号 
 
 
--46、查询全部学生都选修的课程的课程号和课程名 


--47、查询没学过“叶平”老师讲授的任一门课程的学生姓名 
 

--48、查询两门以上不及格课程的同学的学号及其平均成绩 


--49、检索“004”课程分数小于60，按分数降序排列的同学学号 (ok)
 
 
--50、删除“002”同学的“001”课程的成绩 

