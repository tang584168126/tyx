use MySchool

if exists(select * from sysobjects where name = 'usp_GetStudentInfo')
	drop procedure usp_GetStudentInfo

GO

create procedure usp_GetStudentInfo
	@sex char(1)
as
	select StudentNo,StudentName,Sex,[Address] 
	from Student where Sex = @sex
GO

execute usp_GetStudentInfo 0