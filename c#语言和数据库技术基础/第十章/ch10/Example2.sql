/*
 *Example2
 *模糊查询 —— BETWEEN
 */
 
use MySchool182

--查询及格的学生成绩
select *
from Result
where StudentResult BETWEEN 60 AND 100

select *
from Result
where StudentResult BETWEEN 100 AND 60

--等价于
select *
from Result
where StudentResult >= 60 and StudentResult <= 100