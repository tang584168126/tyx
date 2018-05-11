/*
 *Example3
 *创建约束(一)
 */
 
--1.确定使用的数据库
use MySchool182

--2.创建约束(主键)
ALTER TABLE Student ADD
	CONSTRAINT PK_Student PRIMARY KEY(StudentNo)
	
ALTER TABLE Grade ADD
	CONSTRAINT PK_Grade PRIMARY KEY(GradeId)