--进入数据库
use ST182

--1)统计各科目总分
select a.courseId as 科目编号,b.courseName as 科目名称,
SUM(a.witScore) as 笔试总分,SUM(a.labScore) as 机试总分
from Score as a
left join Course as b on a.courseId = b.courseId
GROUP BY a.courseId,b.courseName
ORDER BY a.courseId ASC

--2)统计各科目平均分
select a.courseId as 科目编号,b.courseName as 科目名称,
AVG(a.witScore) as 笔试平均分,AVG(a.labScore) as 机试平均分
from Score as a
left join Course as b on a.courseId = b.courseId
GROUP BY a.courseId,b.courseName
ORDER BY a.courseId ASC

--3)查看各科目最高分
select a.courseId as 科目编号,b.courseName as 科目名称,
MAX(a.witScore) as 笔试最高分,MAX(a.labScore) as 机试最高分
from Score as a
left join Course as b on a.courseId = b.courseId
GROUP BY a.courseId,b.courseName
ORDER BY a.courseId ASC

--4)查看各科目最低分
select a.courseId as 科目编号,b.courseName as 科目名称,
MIN(a.witScore) as 笔试最低分,MIN(a.labScore) as 机试最低分
from Score as a
left join Course as b on a.courseId = b.courseId
GROUP BY a.courseId,b.courseName
ORDER BY a.courseId ASC

--5)统计个学员总平分(笔记+机试的总平分)
select a.stuId as 学生编号,b.stuName as 学生姓名,
SUM(a.witScore + a.labScore) as 总分,
SUM(a.witScore + a.labScore) / COUNT(*) as 总平分
from Score as a
left join Student as b on a.stuId = b.stuId
GROUP BY a.stuId,b.stuName
ORDER BY a.stuId ASC

--6)查看笔试最高分学员信息
select top 1 a.stuId as 学生编号,
a.courseId as 课程编号,c.courseName as 课程名称,
a.witScore as 笔试分数,
b.stuName as 学生姓名,b.stuSex as 性别,b.stuBirthday as 生日,b.stuAddress as 地址
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY a.witScore DESC

--7)查看机试最高分学员信息
select top 1 a.stuId as 学生编号,
a.courseId as 课程编号,c.courseName as 课程名称,
a.labScore as 机试分数,
b.stuName as 学生姓名,b.stuSex as 性别,b.stuBirthday as 生日,b.stuAddress as 地址
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY a.labScore DESC

--8)查看笔试最低分学员信息
select top 1 a.stuId as 学生编号,
a.courseId as 课程编号,c.courseName as 课程名称,
a.witScore as 笔试分数,
b.stuName as 学生姓名,b.stuSex as 性别,b.stuBirthday as 生日,b.stuAddress as 地址
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY a.witScore ASC

--9)查看机试最低分学员信息
select top 1 a.stuId as 学生编号,
a.courseId as 课程编号,c.courseName as 课程名称,
a.labScore as 机试分数,
b.stuName as 学生姓名,b.stuSex as 性别,b.stuBirthday as 生日,b.stuAddress as 地址
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY a.labScore ASC

--10)查看总分最高分学员信息
select top 1 a.stuId as 学生编号,
a.courseId as 课程编号,c.courseName as 课程名称,
(a.labScore + a.witScore) as 总分数,
b.stuName as 学生姓名,b.stuSex as 性别,b.stuBirthday as 生日,b.stuAddress as 地址
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY (a.labScore + a.witScore) DESC

--11)查看总分最低分学员信息
select top 1 a.stuId as 学生编号,
a.courseId as 课程编号,c.courseName as 课程名称,
(a.labScore + a.witScore) as 总分数,
b.stuName as 学生姓名,b.stuSex as 性别,b.stuBirthday as 生日,b.stuAddress as 地址
from Score as a 
left join Student as b on a.stuId = b.stuId
left join Course as c on a.courseId = c.courseId
ORDER BY (a.labScore + a.witScore) ASC

--12)统计各班级总分
select b.classId as 班级编号,c.className as 班级名称,
SUM(a.witScore) as 笔试总分,SUM(a.labScore) as 机试总分
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY b.classId ASC

--13)统计各班级平均分
select b.classId as 班级编号,c.className as 班级名称,
SUM(a.witScore) as 笔试总分,SUM(a.labScore) as 机试总分,
COUNT(*) as 参考人数,
AVG(a.witScore) as 笔试平均分,AVG(a.labScore) as 机试平均分
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY b.classId ASC

--14)统计各班级各科目总分
select
a.courseId as 课程编号,b.courseName as 课程名称,
c.classId as 班级编号,d.className as 班级名称,
SUM(a.witScore) as 笔试总分,SUM(a.labScore) as 机试总分
from Score as a
left join Course as b on a.courseId = b.courseId
left join Student as c on a.stuId = c.stuId
left join Class as d on c.classId = d.classId
GROUP BY a.courseId,b.courseName,c.classId,d.className

--15)统计各班级各科目平均分
select
a.courseId as 课程编号,b.courseName as 课程名称,
c.classId as 班级编号,d.className as 班级名称,
AVG(a.witScore) as 笔试平均分,AVG(a.labScore) as 机试平均分
from Score as a
left join Course as b on a.courseId = b.courseId
left join Student as c on a.stuId = c.stuId
left join Class as d on c.classId = d.classId
GROUP BY a.courseId,b.courseName,c.classId,d.className

--16)查看总分最高的班级及分数
select TOP 1
b.classId as 班级编号,c.className as 班级名称,
(SUM(a.witScore) + SUM(a.labScore)) as 总分
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY (SUM(a.witScore) + SUM(a.labScore)) DESC

--17)查看总分最低的班级及分数
select TOP 1
b.classId as 班级编号,c.className as 班级名称,
(SUM(a.witScore) + SUM(a.labScore)) as 总分
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY (SUM(a.witScore) + SUM(a.labScore)) ASC

--18)查看平均分最高的班级及分数
select TOP 1 
b.classId as 班级编号,c.className as 班级名称,
(AVG(a.witScore) + AVG(a.labScore)) as 平均分
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY (AVG(a.witScore) + AVG(a.labScore)) DESC

--19)查看平均分最低的班级及分数
select TOP 1 
b.classId as 班级编号,c.className as 班级名称,
(AVG(a.witScore) + AVG(a.labScore)) as 平均分
from Score as a
left join Student as b on a.stuId = b.stuId
left join Class as c on b.classId = c.classId
GROUP BY b.classId,c.className
ORDER BY (AVG(a.witScore) + AVG(a.labScore)) ASC