/*
 *Example4
 *创建约束(二)
 */
 
--1.确定使用的数据库
use MySchool182

--2.创建约束
	
	--唯一约束
	ALTER TABLE Student ADD
		CONSTRAINT UQ_IDENTITYCard UNIQUE(IDENTITYCard)
		
	--默认约束
	ALTER TABLE Student ADD
		CONSTRAINT DF_Address DEFAULT('地址不详') FOR Address
		
	--检查约束
	ALTER TABLE Student ADD
		CONSTRAINT CK_BornDate CHECK(BornDate > '1980-1-1')
		
	--外键约束
	ALTER TABLE Student ADD
		CONSTRAINT FK_Student_Grade_GradeId FOREIGN KEY(GradeId) REFERENCES Grade(GradeId)