/*
 *Example1
 *分组查询-GROUP BY
 */
 
use MySchool182

--统计学员人数
select COUNT(*) as 学员人数
from Student

--按年级统计学员人数
select COUNT(*) as 学员人数,GradeId
from Student
GROUP BY GradeId

--按性别统计学员人数
select COUNT(*) as 学员人数,Sex
from Student
GROUP BY Sex

--统计Java Logic考试的总分(课程编号、总分)
select Sum(StudentResult) as 总分,SubjectNo
from Result
where SubjectNo = 1
GROUP BY SubjectNo

--统计各科考试的总分
select Sum(StudentResult) as 总分,SubjectNo
from Result
GROUP BY SubjectNo

--统计每名学生各科考试的总分(学号、科目编号、总分)
select StudentNo,SubjectNo,SUM(StudentResult) as 总分
from Result
GROUP BY StudentNo,SubjectNo

--统计10000号学生各科考试的总分超过100分的科目信息
select StudentNo,SubjectNo,SUM(StudentResult) as 总分
from Result
where StudentNo = 10000
GROUP BY StudentNo,SubjectNo
HAVING SUM(StudentResult) > 100

--统计总课时超过300课时的年级
select GradeId,SUM(ClassHour) as 总课时
from Subject
GROUP BY GradeId
HAVING SUM(ClassHour) > 300