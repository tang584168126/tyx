/*
 *Example2
 *ָ���ͻ������ĳ��ⷿ����Ϣ
 */

use HOUSE

select c.DName as ����,b.SName as �ֵ�,a.HTID as ��������,a.PRICE as �۸�,a.TOPIC as ����,a.CONTENTS as ����,a.HTIME as ʱ��,a.COPY as ��ע
from hos_house as a
left join hos_street as b on a.SID = b.SID
left join hos_district as c on b.SDID = c.DID
left join sys_user as d on a.UID = d.UID
where d.UName = '����'