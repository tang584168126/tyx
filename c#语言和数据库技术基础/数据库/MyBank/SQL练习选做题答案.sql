--进入数据库
use ST182

--1)查看各科目最低分的班级信息及分数
select a.courseId 课程编号,c.courseName 课程名称,
d.classId as 班级编号,e.className 班级名称,
a.totalScore as 分数
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

--2)查看各科目最高分的班级信息及分数
select a.courseId 课程编号,c.courseName 课程名称,
d.classId as 班级编号,e.className 班级名称,
a.totalScore as 分数
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

--3)查看各科目最低分的学员信息,班级信息及分数
select a.courseId 课程编号,c.courseName 课程名称,
d.stuId as 学号,d.stuName as 学生姓名,
d.classId as 班级编号,e.className 班级名称,
a.totalScore as 分数
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

--4)查看各科目最高分的学员信息,班级信息及分数
select a.courseId 课程编号,c.courseName 课程名称,
d.stuId as 学号,d.stuName as 学生姓名,
d.classId as 班级编号,e.className 班级名称,
a.totalScore as 分数
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