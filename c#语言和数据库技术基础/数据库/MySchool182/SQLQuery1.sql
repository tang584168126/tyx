use MySchool182

IF EXISTS(select *from sysobjects where name = 'usp_sysLogin')
	DROP PROCEDURE usp_sysLogin
GO

CREATE 	PROCEDURE usp_sysLogin

@StuNO int,					--ÕËºÅ
@LoginPwd nvarchar(50),		--ÃÜÂë
@Count int OUTPUT			--ÐÐºÅ
AS
	select @Count = COUNT(*) from Student where StudentNo = @StuNO and LoginPwd = @LoginPwd
	
GO	

--µ÷ÓÃ´æ´¢¹ý³Ì
DECLARE @Count int

EXECUTE usp_sysLogin 10000,'123456',@Count OUTPUT

IF(@Count > 0)
	BEGIN
	select 'µÇÂ½³É¹¦'
	END
ELSE
	BEGIN
	select 'µÇÂ½Ê§°Ü'
	END	