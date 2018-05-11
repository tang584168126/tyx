/*
 *Example4
 *左外联接 —— LEFT JOIN
 *以left join为主，左边的表为主表，右边的表为子表；主表的数据将全部显示，若子表数据满足联接条件，则显示子表数据，否则以NULL填充
 */
 
use MySchool182

--查询未参加考试的学生信息(学号,姓名,性别,年级编号,地址)
select a.StudentNo,a.StudentName,a.Sex,a.GradeId,a.Address,b.SubjectNo,b.StudentResult
from Student as a 
left join Result as b on a.StudentNo = b.StudentNo
where b.StudentResult is NULL

--查询全部S1女同学的信息
select a.*
from Student as a
left join Grade as b on a.GradeId = b.GradeId
where b.GradeName = 'S1'