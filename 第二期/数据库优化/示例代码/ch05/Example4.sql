/*
 *Example4
 *按季度统计本年发布的房屋出租数量
 *union:将具有相同列的查询结果合并为一张表；若有重复的结果，将合并为一条结果显示
 *union all:将具有相同列的查询结果合并为一张表；若有重复的结果，各自显示
 */

--按季度县区街道房屋类型统计数量
select a.Season as 季度,a.DName as 区县,a.SName as 街道,a.HTName as 房屋类型 ,COUNT(*) as 房屋数量
from
(
	--本年各季度各县区各街道出粗房屋信息 
	select CASE 
			WHEN MONTH(a.HTIME) in (1,2,3) THEN '1'
			WHEN MONTH(a.HTIME) in (4,5,6) THEN '2'
			WHEN MONTH(a.HTIME) in (7,8,9) THEN '3'
			WHEN MONTH(a.HTIME) in (10,11,12) THEN '4' 
	END as Season,c.DName,b.SName,d.HTName
	from hos_house as a
	left join hos_street as b on a.SID = b.SID
	left join hos_district as c on b.SDID = c.DID
	left join hos_type as d on a.HTID = d.HTID
	where YEAR(a.HTIME) = '2009'
) as a
GROUP BY a.Season,a.DName,a.SName,a.HTName
union
--按季度县区统计数量
select a.Season as 季度,a.DName as 区县,' 小计' as 街道,' ' as 房屋类型 ,COUNT(*) as 房屋数量
from
(
	--本年各季度各县区各街道出粗房屋信息 
	select CASE 
			WHEN MONTH(a.HTIME) in (1,2,3) THEN '1'
			WHEN MONTH(a.HTIME) in (4,5,6) THEN '2'
			WHEN MONTH(a.HTIME) in (7,8,9) THEN '3'
			WHEN MONTH(a.HTIME) in (10,11,12) THEN '4' 
	END as Season,c.DName,b.SName,d.HTName
	from hos_house as a
	left join hos_street as b on a.SID = b.SID
	left join hos_district as c on b.SDID = c.DID
	left join hos_type as d on a.HTID = d.HTID
	where YEAR(a.HTIME) = '2009'
) as a
GROUP BY a.Season,a.DName
union
--按季度统计数量
select a.Season as 季度,' 合计' as 区县,' ' as 街道,' ' as 房屋类型 ,COUNT(*) as 房屋数量
from
(
	--本年各季度各县区各街道出粗房屋信息 
	select CASE 
			WHEN MONTH(a.HTIME) in (1,2,3) THEN '1'
			WHEN MONTH(a.HTIME) in (4,5,6) THEN '2'
			WHEN MONTH(a.HTIME) in (7,8,9) THEN '3'
			WHEN MONTH(a.HTIME) in (10,11,12) THEN '4' 
	END as Season,c.DName,b.SName,d.HTName
	from hos_house as a
	left join hos_street as b on a.SID = b.SID
	left join hos_district as c on b.SDID = c.DID
	left join hos_type as d on a.HTID = d.HTID
	where YEAR(a.HTIME) = '2009'
) as a
GROUP BY a.Season