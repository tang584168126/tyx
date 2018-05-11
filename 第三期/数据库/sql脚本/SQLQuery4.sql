use MySchool

if exists(select * from sysobjects where name = 'usp_GetStudentInfoByReturn')
	drop procedure usp_GetStudentInfoByReturn

GO	

create procedure usp_GetStudentInfoByReturn
	@sex char(1)
as
	select StudentNo,StudentName,Sex,[Address] 
	from Student where Sex = @sex
	
	declare @count int
	select @count = COUNT(*) from Student where Sex = @sex
	return @count
go

declare @count int
execute @count = usp_GetStudentInfoByReturn 0
select @count as ×ÜÊý