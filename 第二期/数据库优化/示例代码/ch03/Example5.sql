/*
 *Example5
 *IF-ELSE�ṹ
 */
 
use MySchool182

--�������
DECLARE @SubNO	int					--��Ŀ���
DECLARE @AvgResult decimal(18,2)	--ƽ����

--��ȡ����ֵ
select @SubNO = SubjectNo from Subject where SubjectName = 'Java Logic'

select @AvgResult = AVG(StudentResult)
from Result
where SubjectNo = @SubNO and ExamDate = '2009-2-17'

--��ʾ���
IF(@AvgResult >= 70)
	BEGIN
		
		PRINT '���Գɼ�����'
		
		select top 3 *
		from Result
		where SubjectNo = @SubNO and ExamDate = '2009-2-17'
		ORDER BY StudentResult DESC
	END
ELSE
	BEGIN
		
		PRINT '���Գɼ��ϲ�'
		
		select top 3 *
		from Result
		where SubjectNo = @SubNO and ExamDate = '2009-2-17'
		ORDER BY StudentResult ASC
		
	END