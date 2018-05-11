/*
 *Example3
 *按区县制作房屋出租清单(为至少有两个街道有出租房屋的区县制作出租房屋清单)
 */
 
use HOUSE

--按区县查询房屋出租信息数量
select z.DID,z.DNAME,COUNT(*) as NUM
from
(
	--按街道查询房屋出租信息数量
	select a.SID,b.SDID,c.DID,c.DName,COUNT(*) as NUM
	from hos_house as a
	left join hos_street as b on a.SID = b.SID
	left join hos_district as c on b.SDID = c.DID
	GROUP BY a.SID,b.SDID,c.DID,c.DName
) as z
GROUP BY z.DID,z.DNAME
HAVING COUNT(*) >= 2

--为至少有两个街道有出租房屋的区县制作出租房屋清单
select b.HTName,c.UName,e.DName,d.SName
from hos_house as a
left join hos_type as b on a.HTID = b.HTID
left join sys_user as c on a.UID = c.UID
left join hos_street as d on a.SID = d.SID
inner join
(
	select z.DID,z.DNAME,COUNT(*) as NUM
	from
	(
		--按街道查询房屋出租信息数量
		select a.SID,b.SDID,c.DID,c.DName,COUNT(*) as NUM
		from hos_house as a
		left join hos_street as b on a.SID = b.SID
		left join hos_district as c on b.SDID = c.DID
		GROUP BY a.SID,b.SDID,c.DID,c.DName
	) as z
	GROUP BY z.DID,z.DNAME
	HAVING COUNT(*) >= 2
) as e on d.SDID = e.DID
--ORDER BY SName
