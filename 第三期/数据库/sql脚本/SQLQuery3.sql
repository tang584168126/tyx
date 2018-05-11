use MySchool

if exists(select * from sysobjects where name = 'usp_GetStudentInfoByOutput')
	drop procedure usp_GetStudentInfoByOutput

GO	

create procedure usp_GetStudentInfoByOutput
	@sex char(1),
	@count int output
as
	select StudentNo,StudentName,Sex,[Address] 
	from Student where Sex = @sex
	
	select @count = COUNT(*) from Student where Sex = @sex
go

declare @totalNum int
execute usp_GetStudentInfoByOutput 0,@totalNum output
select @totalNum