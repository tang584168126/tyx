/*
 *∑÷“≥≤È—Ø
 *
 */
 use House
 
 select top 5 a.HMID,a.UID,a.SID,a.HTID,a.PRICE,a.TOPIC,a.CONTENTS,a.HTIME,a.COPY from 
 hos_house as a
 left join hos_street as b on a.SID = b.SID
 left join hos_district as c on b.SDID = c.DID
 where a.HMID not in
 (
	select TOP 5 a.HMID from hos_house as a
 )
 
 --select a.HMID,a.UID,a.SID,a.HTID,a.PRICE,a.TOPIC,a.CONTENTS,a.HTIME,a.COPY
 --from
 --(
	--select ROW_NUMBER() OVER(ORDER BY a.HMID) as Index,a.*
	--from
	--(
	--	select a.HMID,a.UID,a.SID,a.HTID,a.PRICE,a.TOPIC,a.CONTENTS,a.HTIME,a.COPY from hos_house as a
	--	left join hos_street as b on a.SID = b.SID
	--	left join hos_district as c on b.SDID = c.DID
	--)
 --)
 
