use S1T182

--1.统计各科目总分
select a.courseId as 科目编号,a.courseName as 科目名称, SUM(b.witScore) as 笔试总分, SUM(b.labScore) as 机试总分
from Course as a
inner join Score as b on b.courseId = a.courseId
group by a.courseId,a.courseName

--2.统计各科目平均分
select a.courseId as 科目编号,a.courseName as 科目名称, AVG(b.witScore) as 笔试平均分, AVG(b.labScore) as 机试平均分
from Course as a
inner join Score as b on b.courseId = a.courseId
group by a.courseId,a.courseName

--3.查看各科目最高分
select a.courseId as 科目编号,a.courseName as 科目名称, MAX(b.witScore) as 笔试最高分, MAX(b.labScore) as 机试最高分
from Course as a
inner join Score as b on b.courseId = a.courseId
group by a.courseId,a.courseName

--4.查看各科目最低分
select a.courseId as 科目编号,a.courseName as 科目名称, MIN(b.witScore) as 笔试最低分, MIN(b.labScore) as 机试最低分
from Course as a
inner join Score as b on b.courseId = a.courseId
group by a.courseId,a.courseName

--5.统计个学员总平分（笔记+机试的总平分）
select a.stuId as 学生编号,a.stuName as 学生姓名,SUM(b.witScore)+SUM(b.labScore) as 总分, AVG(b.witScore+b.labScore) as 总平分
from Student as a
inner join Score as b on b.stuId = a.stuId
group by a.stuId,a.stuName

--6.查看笔试最高分学员信息
select top 1 a.stuId as 学生编号,c.courseId as 课程编号,c.courseName as 课程名称,b.witScore as 笔试分数,a.stuName as 学生姓名,a.stuSex as 性别,a.stuBirthday as 生日,a.stuAddress as 地址
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.witScore desc

--7.查看机试最高分学员信息
select top 1 a.stuId as 学生编号,c.courseId as 课程编号,c.courseName as 课程名称,b.labScore as 机试分数,a.stuName as 学生姓名,a.stuSex as 性别,a.stuBirthday as 生日,a.stuAddress as 地址
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.labScore desc

--8.查看笔试最低分学员信息
select top 1 a.stuId as 学生编号,c.courseId as 课程编号,c.courseName as 课程名称,b.witScore as 笔试分数,a.stuName as 学生姓名,a.stuSex as 性别,a.stuBirthday as 生日,a.stuAddress as 地址
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.witScore

--9.查看机试最低分学员信息
select top 1 a.stuId as 学生编号,c.courseId as 课程编号,c.courseName as 课程名称,b.labScore as 机试分数,a.stuName as 学生姓名,a.stuSex as 性别,a.stuBirthday as 生日,a.stuAddress as 地址
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.labScore

--10.查看总分最高分学员信息
select top 1 a.stuId as 学生编号,c.courseId as 课程编号,c.courseName as 课程名称,b.labScore + b.witScore as 总分,a.stuName as 学生姓名,a.stuSex as 性别,a.stuBirthday as 生日,a.stuAddress as 地址
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.labScore + b.witScore desc

--11.查看总分最低分学员信息
select top 1 a.stuId as 学生编号,c.courseId as 课程编号,c.courseName as 课程名称,b.labScore + b.witScore as 总分,a.stuName as 学生姓名,a.stuSex as 性别,a.stuBirthday as 生日,a.stuAddress as 地址
from Student as a
inner join Score as b on b.stuId = a.stuId
inner join Course as c on c.courseId = b.courseId
order by b.labScore + b.witScore

--12.统计各班级总分
select a.classId as 班级编号, a.className as 班级名称, SUM(b.witScore) as 笔试总分,SUM(b.labScore) as 机试总分
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className

--13.统计各班级平均分
select a.classId as 班级编号, a.className as 班级名称,SUM(b.witScore) as 笔试总分,SUM(b.labScore) as 机试总分,COUNT(b.stuId) as 参考人数,AVG(b.witScore) as 笔试平均分,AVG(b.labScore) as 机试平均分
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className

--14.统计各班级各科目总分
select d.courseId as 课程编号,d.courseName as 课程名称,a.classId as 班级编号, a.className as 班级名称,SUM(b.witScore) as 笔试总分,SUM(b.labScore) as 机试总分
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
inner join Course as d on d.courseId = b.courseId
group by a.classId,a.className,d.courseId,d.courseName

--15.统计各班级各科目平均分
select d.courseId as 课程编号,d.courseName as 课程名称,a.classId as 班级编号, a.className as 班级名称,AVG(b.witScore) as 笔试平均分,AVG(b.labScore) as 机试平均分
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
inner join Course as d on d.courseId = b.courseId
group by a.classId,a.className,d.courseId,d.courseName

--16.查看总分最高的班级及分数
select top 1 a.classId as 班级编号,a.className as 班级名称,SUM(b.witScore + b.labScore) as 总分
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className
order by SUM(b.witScore + b.labScore) desc

--17.查看总分最低的班级及分数
select top 1 a.classId as 班级编号,a.className as 班级名称,SUM(b.witScore + b.labScore) as 总分
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className
order by SUM(b.witScore + b.labScore)

--18.查看平均分最高的班级及分数
select top 1 a.classId as 班级编号,a.className as 班级名称,AVG(b.witScore + b.labScore) as 平均分
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className
order by AVG(b.witScore + b.labScore) desc

--19.查看平均分最低的班级及分数
select top 1 a.classId as 班级编号,a.className as 班级名称,AVG(b.witScore + b.labScore) as 平均分
from Class as a
inner join Student as c on c.classId = a.classId
inner join Score as b on b.stuId = c.stuId
group by a.classId,a.className
order by AVG(b.witScore + b.labScore)

--20.查看各科目最低分的班级信息及分数
select top 3 a.courseId as 课程编号,a.courseName as 课程名称,b.classId as 班级编号,b.className as 班级名称,MIN(c.witScore + c.labScore) as 分数
from Course as a
inner join Score as c on c.courseId = a.courseId
inner join Student as d on d.stuId = c.stuId
inner join Class as b on b.classId = d.classId
group by a.courseId,a.courseName,b.classId,b.className
order by MIN(c.witScore + c.labScore)

--21.查看各科目最高分的班级信息及分数
select a.courseId as 课程编号,a.courseName as 课程名称,b.classId as 班级编号,b.className as 班级名称,MIN(c.witScore + c.labScore) as 分数
from Course as a
inner join Score as c on c.courseId = a.courseId
inner join Student as d on d.stuId = c.stuId
inner join Class as b on b.classId = d.classId
group by a.courseId,a.courseName,b.classId,b.className

--22.查看各科目最低分的学员信息、班级信息及分数

--23.查看各科目最高分的学员信息、班级信息及分数