/*
 *Example3
 *�������������ݳ����嵥(Ϊ�����������ֵ��г��ⷿ�ݵ������������ⷿ���嵥)
 */
 
use HOUSE

--�����ز�ѯ���ݳ�����Ϣ����
select z.DID,z.DNAME,COUNT(*) as NUM
from
(
	--���ֵ���ѯ���ݳ�����Ϣ����
	select a.SID,b.SDID,c.DID,c.DName,COUNT(*) as NUM
	from hos_house as a
	left join hos_street as b on a.SID = b.SID
	left join hos_district as c on b.SDID = c.DID
	GROUP BY a.SID,b.SDID,c.DID,c.DName
) as z
GROUP BY z.DID,z.DNAME
HAVING COUNT(*) >= 2

--Ϊ�����������ֵ��г��ⷿ�ݵ������������ⷿ���嵥
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
		--���ֵ���ѯ���ݳ�����Ϣ����
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
