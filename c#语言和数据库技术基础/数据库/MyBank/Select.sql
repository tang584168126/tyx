use MyBank

--��ѯ������ͨ�ͻ��Ŀͻ���Ϣ
select a.CustID,a.CustName,a.CustTypeID,b.CustTypeName,a.CustPhone,a.CustAddress,a.CustEmail,a.CustRemark
from Cust as a
INNER JOIN CustType as b ON b.CustTypeID = a.CustTypeID
where b.CustTypeName = '������ͨ�ͻ�'

--��ѯ�����ܿͻ���
select COUNT(*) as ���пͻ����� from Cust

--��ѯ3
select a.CardID,b.BusinessTypeID,b.BusinessTypeName,a.BusinessTime,a.BusinessMoney
from BankBusiness as a
INNER JOIN BankBusinessType as b ON b.BusinessTypeID = a.BusinessTypeID
where CardID = '6227 2088 1984 1911'

--��ѯ4
select * from Cust
where CustAddress LIKE '�Ĵ�%'

--��ѯ5
select * from Cust
where CustAddress NOT LIKE '�Ĵ�%'

--��ѯ6
select * from Cust
where CustEmail = '' OR CustEmail = NULL

--��ѯ7
select CardID , SUM(BusinessMoney) as �����ܽ��
from BankBusiness
GROUP BY CardID

--8.��ѯTest1�ͻ���2011/1/17�յĽ�����Ϣ
select b.CardID,c.CustID, a.BusinessTime,a.BusinessTime,a.BusinessMoney
from BankBusiness as a
INNER join BankCard as b on a.CardID = b.CardID
INNER JOIN Cust as c on b.CustID = c.CustID
where c.CustName = 'Test1' and a.BusinessTime = '2011-1-17'

--9.��ѯ���ÿ��Ľ�����Ϣ
select b.CardID,c.CardTypeID,b.BusinessTime,b.BusinessTypeID,b.BusinessMoney
from CardType as a
inner join BankCard as c ON a.CardTypeID = c.CardTypeID
inner join BankBusiness as b ON c.CardID = b.CardID
where a.CardTypeName = '���ÿ�' 

--10.��ѯATM���ϲ����Ľ�����Ϣ
select a.CardID , b.BusinessTypeName ,a.BusinessTime,a.BusinessTypeID,a.BusinessMoney
from BankBusiness as a
inner join BankBusinessType as b on b.BusinessTypeID = a.BusinessTypeID
where b.BusinessTypeName = '����ATM�����'

--11.��ѯ���й�̨����Ľ�����Ϣ
select a.CardID ,b.BusinessTypeName ,a.BusinessTime,a.BusinessTypeID,a.BusinessMoney
from BankBusiness as a
inner join BankBusinessType as b on b.BusinessTypeID = a.BusinessTypeID
where b.BusinessTypeName LIKE '���й�̨%'

--12.ͳ�����й��ж�������Ŀ�
select COUNT(*) as ���п�������
from CardType

--13.ͳ�������ṩ�˶����ֽ������
select COUNT(*) as ��������� from BankBusinessType

--14.ͳ�����й�̨�Ľ����ܽ��
select SUM(BusinessMoney) as �����ܽ��
from BankBusiness

--15.ͳ�����и��࿨�Ľ����ܽ��
select a.CardTypeID,a.CardTypeName,SUM(b.BusinessMoney) as �����ܽ��
from CardType as a
inner join BankCard as c on c.CardTypeID = a.CardTypeID
inner join BankBusiness as b on b.CardID = c.CardID
GROUP BY a.CardTypeID,a.CardTypeName
ORDER BY a.CardTypeID DESC

--16.ͳ�Ƹ����û��Ľ����ܽ��
select SUM(a.BusinessMoney) as �����ܽ��
from CustType as c
inner join Cust as b on b.CustTypeID = c.CustTypeID
inner join BankCard as d on d.CustID = b.CustID
inner join BankBusiness as a on a.CardID = d.CardID
where c.CustTypeName LIKE '����%'

--17.ͳ�ƶԹ��û��Ľ����ܽ��
select SUM(a.BusinessMoney) as �����ܽ��
from CustType as c
inner join Cust as b on b.CustTypeID = c.CustTypeID
inner join BankCard as d on d.CustID = b.CustID
inner join BankBusiness as a on a.CardID = d.CardID
where c.CustTypeName LIKE '�Թ�%'

--18.ͳ�Ƴɶ������Ľ����ܽ��
select SUM(c.BusinessMoney) as �����ܽ��
from Cust as a
inner join BankCard as b on b.CustID = a.CustID
inner join BankBusiness as c on c.CardID = b.CardID
where a.CustAddress LIKE '%�ɶ�%'

--19.ͳ�ƽ���Ľ��׽��
select SUM(BusinessMoney) as ���꽻���ܽ��
from BankBusiness
where DATEPART(YY,BusinessTime) = DATEPART(YY,GETDATE())

--20.ͳ��ȥ��Ľ��׽��
select SUM(BusinessMoney) as ���꽻���ܽ��
from BankBusiness
where DATEPART(YY,BusinessTime) = DATEPART(YY,GETDATE()) - 1

--21.ͳ�����е����ѽ��(ˢ�����Ѻ���������)
select SUM(b.BusinessMoney) as �������ѽ��
from BankBusinessType as a
inner join BankBusiness as b on a.BusinessTypeID = b.BusinessTypeID
where BusinessTypeName = 'ˢ������' and BusinessTypeName = '��������'

--22.ͳ�Ƹ���ͻ��Ľ����ܽ��
select c.CustTypeID , c.CustTypeName , SUM(a.BusinessMoney) as �����ܽ��
from CustType as c
left join Cust as b on b.CustTypeID = c.CustTypeID
left join BankCard as d on d.CustID = b.CustID
left join BankBusiness as a on a.CardID = d.CardID
GROUP BY c.CustTypeID , c.CustTypeName

--23.ͳ��ATM�������Ľ��׽��
select a.BusinessTypeID , a.BusinessTypeName , SUM(b.BusinessMoney) as ATM�������ܽ��
from BankBusinessType as a
inner join BankBusiness as b on a.BusinessTypeID = b.BusinessTypeID
where BusinessTypeName ='����ATM�����'
GROUP BY a.BusinessTypeID , a.BusinessTypeName

--24.ͳ�����й�̨�����Ľ��׽��
select a.BusinessTypeID , a.BusinessTypeName , SUM(b.BusinessMoney) as ATM�������ܽ��
from BankBusinessType as a
inner join BankBusiness as b on a.BusinessTypeID = b.BusinessTypeID
where BusinessTypeName LIKE'���й�̨%'
GROUP BY a.BusinessTypeID , a.BusinessTypeName 

--25.��ѯ���׽����ߵĿͻ����
select TOP 1 c.BusinessMoney, c.CardID, a.CustTypeID, a.CustTypeName
from CustType as a
inner join Cust as b on b.CustTypeID = a.CustTypeID
inner join BankCard as d on d.CustID = b.CustID
inner join BankBusiness as c on c.CardID = d.CardID
ORDER BY c.BusinessMoney DESC

--26.��ѯ���׽����͵����п����
select TOP 1 c.BusinessMoney, c.CardID,b.CardTypeID,a.CardTypeName
from CardType as a
inner join BankCard as b on b.CardTypeID = a.CardTypeID
inner join BankBusiness as c on c.CardID = b.CardID
ORDER BY c.BusinessMoney

--27.��ѯ��ͬ���׽��Ľ�������
select BusinessMoney , COUNT(BusinessMoney) as ���׽����ͬ�Ľ�������
from BankBusiness
where BusinessMoney = BusinessMoney
GROUP BY BusinessMoney

--28.��ѯ��δ���н��׵Ŀͻ���Ϣ
select a.CustID, a.CustName, SUM(b.BusinessMoney) as �����ܽ��
from Cust as a
left join BankCard as c on c.CustID = a.CustID
left join BankBusiness as b on b.CardID = c.CardID
GROUP BY a.CustID, a.CustName
HAVING SUM(b.BusinessMoney) is NULL or SUM(b.BusinessMoney) = ''

--29.��ѯ��δ�������ѵĿͻ���Ϣ(ˢ�����Ѻ���������)
select a.CustID, a.CustName, SUM(b.BusinessMoney) as �����ܽ��
from Cust as a
left join BankCard as c on c.CustID = a.CustID
left join BankBusiness as b on b.CardID = c.CardID
GROUP BY a.CustID, a.CustName
HAVING SUM(b.BusinessMoney) is NULL or SUM(b.BusinessMoney) = ''
union
select a.CustID, a.CustName, SUM(b.BusinessMoney) as �����ܽ��
from Cust as a
inner join BankCard as c on c.CustID = a.CustID
inner join BankBusiness as b on b.CardID = c.CardID
inner join BankBusinessType as d on b.BusinessTypeID = d.BusinessTypeID
where d.BusinessTypeName not in('ˢ������','��������')
GROUP BY a.CustID, a.CustName

--30.���Թ�ҵ��ֻ��ʹ�����������ǰ칫ҵ���Ӧ�����п�������Щ
select a.CardID,b.CardTypeID,b.CardTypeName
from BankCard as a
inner join CardType as b on b.CardTypeID = a.CardTypeID
inner join Cust as c on c.CustID = a.CustID
inner join CustType as d on d.CustTypeID = c.CustTypeID
where d.CustTypeName LIKE '�Թ�%' and b.CardTypeName = '������'