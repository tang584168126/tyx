/*
 *Example4
 *������ͳ�Ʊ��귢���ķ��ݳ�������
 *union:��������ͬ�еĲ�ѯ����ϲ�Ϊһ�ű������ظ��Ľ�������ϲ�Ϊһ�������ʾ
 *union all:��������ͬ�еĲ�ѯ����ϲ�Ϊһ�ű������ظ��Ľ����������ʾ
 */

--�����������ֵ���������ͳ������
select a.Season as ����,a.DName as ����,a.SName as �ֵ�,a.HTName as �������� ,COUNT(*) as ��������
from
(
	--��������ȸ��������ֵ����ַ�����Ϣ 
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
--����������ͳ������
select a.Season as ����,a.DName as ����,' С��' as �ֵ�,' ' as �������� ,COUNT(*) as ��������
from
(
	--��������ȸ��������ֵ����ַ�����Ϣ 
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
--������ͳ������
select a.Season as ����,' �ϼ�' as ����,' ' as �ֵ�,' ' as �������� ,COUNT(*) as ��������
from
(
	--��������ȸ��������ֵ����ַ�����Ϣ 
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