use MySchool182

IF EXISTS(select *from sysobjects where name = 'usp_sysLogin')
	DROP PROCEDURE usp_sysLogin
GO

CREATE 	PROCEDURE usp_sysLogin

@StuNO int,					--�˺�
@LoginPwd nvarchar(50),		--����
@Count int OUTPUT			--�к�
AS
	select @Count = COUNT(*) from Student where StudentNo = @StuNO and LoginPwd = @LoginPwd
	
GO	

--���ô洢����
DECLARE @Count int

EXECUTE usp_sysLogin 10000,'123456',@Count OUTPUT

IF(@Count > 0)
	BEGIN
	select '��½�ɹ�'
	END
ELSE
	BEGIN
	select '��½ʧ��'
	END	