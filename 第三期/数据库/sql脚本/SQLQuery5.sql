use MySchool
if exists(select * from sysobjects where name = 'usp_GetPagedList')
	drop procedure usp_GetPagedList
go

create procedure usp_GetPagedList
	@pageIndex int,		/*页下标，即第几页*/
	@pageSize int		/*每页显示的数据条数*/
as
	declare @startRow int, @endRow int
	set @startRow = (@pageIndex - 1)*@pageSize + 1
	set @endRow = @startRow + @pageSize - 1
	select * from (
		select *,ROW_NUMBER() over(order by GradeID asc) as number
		from Grade
	) t
	where t.number between @startRow and @endRow;
go	