/*
 *Example2
 *T-SQL变量的进阶
 */
 
use MySchool182

--定义变量
DECLARE @StuName nvarchar(20)		--学生姓名

--赋值
--1)单查询结果的赋值(学号为10000号学生的姓名)
--select @StuName  = StudentName from Student where StudentNo = 10000

--2)多查询结果的赋值(学生姓名)
--select @StuName = StudentName from Student

--3)单查询结果的赋值(学号为20000号学生的姓名)
--select @StuName  = StudentName from Student where StudentNo = 20000

--4)单查询结果的赋值(学号为20000号学生的姓名,学号为10000号学生的姓名)
SET @StuName = 'Michael'
--select @StuName  = StudentName from Student where StudentNo = 20000
select @StuName  = StudentName from Student where StudentNo = 10000

--调用
PRINT '学生姓名为:' + @StuName