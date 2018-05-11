/*
 *Example3
 *内联接-INNER JOIN
 *以inner join为主，联接inner join左右两张表，将符合联接条件的数据查询出来
 */
 
use MySchool182

--查询每位学生每门功课的分数(学号、姓名、科目编号、考试时间、成绩)
select a.StudentNo,b.StudentName,a.SubjectNo,a.ExamDate,a.StudentResult
from Result as a 
inner join Student as b on a.StudentNo = b.StudentNo

--查询每位学生每门功课的分数(学号、姓名、科目编号、科目名称、考试时间、成绩)
select a.StudentNo,b.StudentName,a.SubjectNo,c.SubjectName,a.ExamDate,a.StudentResult
from Result as a
inner join Student as b on a.StudentNo = b.StudentNo
inner join Subject as c on a.SubjectNo = c.SubjectNo

--查询每位学生考试科目所在的年级信息(学号、姓名、科目编号、科目名称、年级编号、年级名称)
select a.StudentNo,b.StudentName,a.SubjectNo,c.SubjectName,c.GradeId,d.GradeName
from Result as a
inner join Student as b on a.StudentNo = b.StudentNo
inner join Subject as c on a.SubjectNo = c.SubjectNo
inner join Grade as d on c.GradeId = d.GradeId

--查询课时超过60的科目所在年级信息
select a.GradeId,b.GradeName,a.ClassHour
from Subject as a
inner join Grade as b on a.GradeId = b.GradeId
where a.ClassHour > 60