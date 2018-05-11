/*
 *Example1
 *模糊查询 —— LIKE
 */
 
use MySchool182

--开头包含(查找姓李的同学)
select *
from Student
where StudentName like '李%'

--包含(查找河北省的同学)
select *
from Student
where Address like '%河北%'

--结尾包含(查找电话号码以25结尾的同学)
select *
from Student
where Phone like '%25'