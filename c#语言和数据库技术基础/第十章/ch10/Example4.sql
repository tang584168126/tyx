/*
 *Example4
 *MyQQ���ݿ���ϰ
 */
 
use MyQQ

--1.ʹ��T-SQL����ѯȫ��QQ�û���Ϣ
select * from QQUser

--2.ʹ��T-SQ;����ѯ�Ա�Ϊ�е�QQ�û���Ϣ
select *
from QQUser
where Sex = '��'

--3.ʹ��T-SQL����ѯQQ�ȼ�Ϊ0���û���Ϣ
select *
from QQUser
where level = 0

--4.ʹ��T-SQL����ѯ����ǩ����Ϊ�յ�QQ�û���Ϣ
select *
from QQUser
where idiograph != '' or idiograph is not NULL

--5.ʹ��T-SQL����ѯѪ��ΪA���������й����ҳ���������1990���Ժ��QQ�û���Ϣ
select *
from QQUser
where BloodType = 'A' and Country = '�й�' and Birthday >= '1990-1-1'

--6.��ѯQQIDΪ10001��QQ�û���Ϣ
select *
from QQUser
where QQID = 10001

--7.ʹ��T-SQL����ѯȫ����ϵ����Ϣ������
select *
from QQRelation

--8.��ѯQQ����Ϊ10000����ϵ�˵���Ϣ
select *
from QQRelation
where SQQID = 10000

--9.��ѯQQ����Ϊ10000����ϵ���к��ѵĵ���Ϣ
select *
from QQRelation
where SQQID = 10000 and RelationType = 0

--10.ʹ��T-SQL����ѯȫ����Ϣ�������
select *
from QQMessage

--11.��ѯQQ����Ϊ10000���û����͵���Ϣ
select *
from QQMessage
where SeQQID = 10000

--12.��ѯ���͸�QQ����Ϊ10000����Ϣ
select *
from QQMessage
where ReQQID = 10000

--13.��ѯ���е�δ����Ϣ
select *
from QQMessage
where Status = 1

--14.��ѯ���͸�QQ����Ϊ10000��δ����Ϣ
select *
from QQMessage
where ReQQID = 10000 and Status = 1

--15.��ѯ���͸�QQ����Ϊ10000��δ����Ϣ�����ҷ���ʱ��Ϊ2012��12�µ�
select *
from QQMessage
where ReQQID = 10000 and Status = 1 and YEAR(SendTime) = '2012' and MONTH(SendTime) = '12'