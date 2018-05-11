/*
 *Example1
 *T-SQL变量的定义
 */
 
--定义变量
DECLARE @StudentName nvarchar(20)	--学生姓名

--赋值
--SET @StudentName = 'Michael'

select @StudentName = StudentName from Student where StudentNo = 10000

--调用
PRINT @StudentName