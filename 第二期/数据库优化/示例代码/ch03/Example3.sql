/*
 *Example3
 *T-SQL变量的应用
 */

use MySchool182

--定义变量
DECLARE @StuName nvarchar(20)		--学生姓名
DECLARE @StuNO int					--学号

--赋值
SET @StuName = '李文才'				--获取学生姓名

select @StuNO = StudentNo
from Student
where StudentName = @StuName		--获取学号

--输出信息
select *
from Student
where StudentNo = @StuNO + 1 or StudentNo = @StuNO - 1