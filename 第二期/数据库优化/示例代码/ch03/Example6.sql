/*
 *Example6
 *WHILE�ṹ
 */
 
use MySchool182

--�������
DECLARE @SubNO int					--�γ̱��
DECLARE @MaxEameDate datetime		--�������ʱ��
DECLARE @Count int					--����������

--��ȡ����ֵ
select @SubNO = SubjectNo from Subject where SubjectName = 'Winforms'

select @MaxEameDate = MAX(ExamDate) from Result where SubjectNo = @SubNO

select @Count = count(*) from Result where SubjectNo = @SubNO and ExamDate = @MaxEameDate and StudentResult < 60

WHILE(@Count > 0)
	BEGIN
		
		--�޸ĳɼ�
		update Result set
		StudentResult = StudentResult + 2
		where SubjectNo = @SubNO and ExamDate = @MaxEameDate and StudentResult <= 95
		
		--ͳ�Ʋ���������
		select @Count = count(*) from Result where SubjectNo = @SubNO and ExamDate = @MaxEameDate and StudentResult < 60
	
	END
	
select * 
from Result
where SubjectNo = @SubNO and ExamDate = @MaxEameDate