/*
 *Example3
 *模糊查询 —— IN
 */
 
use MySchool182

--查询S1,S2的学生
select *
from Student
where GradeId in (1,2)

--等价于
select *
from Student
where GradeId = 1 or GradeId = 2

--查询不属于S1,S2的学生
select *
from Student
where GradeId not in (1,2)

--等价于
select *
from Student
where GradeId != 1 and GradeId != 2