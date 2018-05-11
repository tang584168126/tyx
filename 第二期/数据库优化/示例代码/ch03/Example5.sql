/*
 *Example5
 *IF-ELSE结构
 */
 
use MySchool182

--定义变量
DECLARE @SubNO	int					--科目编号
DECLARE @AvgResult decimal(18,2)	--平均分

--获取变量值
select @SubNO = SubjectNo from Subject where SubjectName = 'Java Logic'

select @AvgResult = AVG(StudentResult)
from Result
where SubjectNo = @SubNO and ExamDate = '2009-2-17'

--显示结果
IF(@AvgResult >= 70)
	BEGIN
		
		PRINT '考试成绩优秀'
		
		select top 3 *
		from Result
		where SubjectNo = @SubNO and ExamDate = '2009-2-17'
		ORDER BY StudentResult DESC
	END
ELSE
	BEGIN
		
		PRINT '考试成绩较差'
		
		select top 3 *
		from Result
		where SubjectNo = @SubNO and ExamDate = '2009-2-17'
		ORDER BY StudentResult ASC
		
	END