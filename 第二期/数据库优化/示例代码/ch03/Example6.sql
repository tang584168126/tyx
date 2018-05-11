/*
 *Example6
 *WHILE结构
 */
 
use MySchool182

--定义变量
DECLARE @SubNO int					--课程编号
DECLARE @MaxEameDate datetime		--最近考试时间
DECLARE @Count int					--不及格人数

--获取变量值
select @SubNO = SubjectNo from Subject where SubjectName = 'Winforms'

select @MaxEameDate = MAX(ExamDate) from Result where SubjectNo = @SubNO

select @Count = count(*) from Result where SubjectNo = @SubNO and ExamDate = @MaxEameDate and StudentResult < 60

WHILE(@Count > 0)
	BEGIN
		
		--修改成绩
		update Result set
		StudentResult = StudentResult + 2
		where SubjectNo = @SubNO and ExamDate = @MaxEameDate and StudentResult <= 95
		
		--统计不及格人数
		select @Count = count(*) from Result where SubjectNo = @SubNO and ExamDate = @MaxEameDate and StudentResult < 60
	
	END
	
select * 
from Result
where SubjectNo = @SubNO and ExamDate = @MaxEameDate