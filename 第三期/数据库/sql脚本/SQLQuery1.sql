use MySchool

if exists(select * from sysobjects where name = 'usp_GetStudentCount')
	drop procedure usp_GetStudentCount

GO	

create procedure usp_GetStudentCount
as
	select COUNT(*) from Student
go