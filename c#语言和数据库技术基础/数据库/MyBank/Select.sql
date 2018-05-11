use MyBank

--查询个人普通客户的客户信息
select a.CustID,a.CustName,a.CustTypeID,b.CustTypeName,a.CustPhone,a.CustAddress,a.CustEmail,a.CustRemark
from Cust as a
INNER JOIN CustType as b ON b.CustTypeID = a.CustTypeID
where b.CustTypeName = '个人普通客户'

--查询银行总客户数
select COUNT(*) as 银行客户总数 from Cust

--查询3
select a.CardID,b.BusinessTypeID,b.BusinessTypeName,a.BusinessTime,a.BusinessMoney
from BankBusiness as a
INNER JOIN BankBusinessType as b ON b.BusinessTypeID = a.BusinessTypeID
where CardID = '6227 2088 1984 1911'

--查询4
select * from Cust
where CustAddress LIKE '四川%'

--查询5
select * from Cust
where CustAddress NOT LIKE '四川%'

--查询6
select * from Cust
where CustEmail = '' OR CustEmail = NULL

--查询7
select CardID , SUM(BusinessMoney) as 交易总金额
from BankBusiness
GROUP BY CardID

--8.查询Test1客户在2011/1/17日的交易信息
select b.CardID,c.CustID, a.BusinessTime,a.BusinessTime,a.BusinessMoney
from BankBusiness as a
INNER join BankCard as b on a.CardID = b.CardID
INNER JOIN Cust as c on b.CustID = c.CustID
where c.CustName = 'Test1' and a.BusinessTime = '2011-1-17'

--9.查询信用卡的交易信息
select b.CardID,c.CardTypeID,b.BusinessTime,b.BusinessTypeID,b.BusinessMoney
from CardType as a
inner join BankCard as c ON a.CardTypeID = c.CardTypeID
inner join BankBusiness as b ON c.CardID = b.CardID
where a.CardTypeName = '信用卡' 

--10.查询ATM机上产生的交易信息
select a.CardID , b.BusinessTypeName ,a.BusinessTime,a.BusinessTypeID,a.BusinessMoney
from BankBusiness as a
inner join BankBusinessType as b on b.BusinessTypeID = a.BusinessTypeID
where b.BusinessTypeName = '银行ATM机存款'

--11.查询银行柜台办理的交易信息
select a.CardID ,b.BusinessTypeName ,a.BusinessTime,a.BusinessTypeID,a.BusinessMoney
from BankBusiness as a
inner join BankBusinessType as b on b.BusinessTypeID = a.BusinessTypeID
where b.BusinessTypeName LIKE '银行柜台%'

--12.统计银行共有多少种类的卡
select COUNT(*) as 银行卡种类数
from CardType

--13.统计银行提供了多少种交易类别
select COUNT(*) as 交易类别数 from BankBusinessType

--14.统计银行柜台的交易总金额
select SUM(BusinessMoney) as 交易总金额
from BankBusiness

--15.统计银行各类卡的交易总金额
select a.CardTypeID,a.CardTypeName,SUM(b.BusinessMoney) as 交易总金额
from CardType as a
inner join BankCard as c on c.CardTypeID = a.CardTypeID
inner join BankBusiness as b on b.CardID = c.CardID
GROUP BY a.CardTypeID,a.CardTypeName
ORDER BY a.CardTypeID DESC

--16.统计个人用户的交易总金额
select SUM(a.BusinessMoney) as 交易总金额
from CustType as c
inner join Cust as b on b.CustTypeID = c.CustTypeID
inner join BankCard as d on d.CustID = b.CustID
inner join BankBusiness as a on a.CardID = d.CardID
where c.CustTypeName LIKE '个人%'

--17.统计对公用户的交易总金额
select SUM(a.BusinessMoney) as 交易总金额
from CustType as c
inner join Cust as b on b.CustTypeID = c.CustTypeID
inner join BankCard as d on d.CustID = b.CustID
inner join BankBusiness as a on a.CardID = d.CardID
where c.CustTypeName LIKE '对公%'

--18.统计成都地区的交易总金额
select SUM(c.BusinessMoney) as 交易总金额
from Cust as a
inner join BankCard as b on b.CustID = a.CustID
inner join BankBusiness as c on c.CardID = b.CardID
where a.CustAddress LIKE '%成都%'

--19.统计今年的交易金额
select SUM(BusinessMoney) as 今年交易总金额
from BankBusiness
where DATEPART(YY,BusinessTime) = DATEPART(YY,GETDATE())

--20.统计去年的交易金额
select SUM(BusinessMoney) as 今年交易总金额
from BankBusiness
where DATEPART(YY,BusinessTime) = DATEPART(YY,GETDATE()) - 1

--21.统计银行的消费金额(刷卡消费和网络消费)
select SUM(b.BusinessMoney) as 银行消费金额
from BankBusinessType as a
inner join BankBusiness as b on a.BusinessTypeID = b.BusinessTypeID
where BusinessTypeName = '刷卡消费' and BusinessTypeName = '网络消费'

--22.统计各类客户的交易总金额
select c.CustTypeID , c.CustTypeName , SUM(a.BusinessMoney) as 交易总金额
from CustType as c
left join Cust as b on b.CustTypeID = c.CustTypeID
left join BankCard as d on d.CustID = b.CustID
left join BankBusiness as a on a.CardID = d.CardID
GROUP BY c.CustTypeID , c.CustTypeName

--23.统计ATM机产生的交易金额
select a.BusinessTypeID , a.BusinessTypeName , SUM(b.BusinessMoney) as ATM机交易总金额
from BankBusinessType as a
inner join BankBusiness as b on a.BusinessTypeID = b.BusinessTypeID
where BusinessTypeName ='银行ATM机存款'
GROUP BY a.BusinessTypeID , a.BusinessTypeName

--24.统计银行柜台产生的交易金额
select a.BusinessTypeID , a.BusinessTypeName , SUM(b.BusinessMoney) as ATM机交易总金额
from BankBusinessType as a
inner join BankBusiness as b on a.BusinessTypeID = b.BusinessTypeID
where BusinessTypeName LIKE'银行柜台%'
GROUP BY a.BusinessTypeID , a.BusinessTypeName 

--25.查询交易金额最高的客户类别
select TOP 1 c.BusinessMoney, c.CardID, a.CustTypeID, a.CustTypeName
from CustType as a
inner join Cust as b on b.CustTypeID = a.CustTypeID
inner join BankCard as d on d.CustID = b.CustID
inner join BankBusiness as c on c.CardID = d.CardID
ORDER BY c.BusinessMoney DESC

--26.查询交易金额最低的银行卡类别
select TOP 1 c.BusinessMoney, c.CardID,b.CardTypeID,a.CardTypeName
from CardType as a
inner join BankCard as b on b.CardTypeID = a.CardTypeID
inner join BankBusiness as c on c.CardID = b.CardID
ORDER BY c.BusinessMoney

--27.查询相同交易金额的交易数量
select BusinessMoney , COUNT(BusinessMoney) as 交易金额相同的交易数量
from BankBusiness
where BusinessMoney = BusinessMoney
GROUP BY BusinessMoney

--28.查询还未进行交易的客户信息
select a.CustID, a.CustName, SUM(b.BusinessMoney) as 交易总金额
from Cust as a
left join BankCard as c on c.CustID = a.CustID
left join BankBusiness as b on b.CardID = c.CardID
GROUP BY a.CustID, a.CustName
HAVING SUM(b.BusinessMoney) is NULL or SUM(b.BusinessMoney) = ''

--29.查询还未进行消费的客户信息(刷卡消费和网络消费)
select a.CustID, a.CustName, SUM(b.BusinessMoney) as 交易总金额
from Cust as a
left join BankCard as c on c.CustID = a.CustID
left join BankBusiness as b on b.CardID = c.CardID
GROUP BY a.CustID, a.CustName
HAVING SUM(b.BusinessMoney) is NULL or SUM(b.BusinessMoney) = ''
union
select a.CustID, a.CustName, SUM(b.BusinessMoney) as 交易总金额
from Cust as a
inner join BankCard as c on c.CustID = a.CustID
inner join BankBusiness as b on b.CardID = c.CardID
inner join BankBusinessType as d on b.BusinessTypeID = d.BusinessTypeID
where d.BusinessTypeName not in('刷卡消费','网络消费')
GROUP BY a.CustID, a.CustName

--30.若对公业务只能使用联名卡，那办公业务对应的银行卡号有哪些
select a.CardID,b.CardTypeID,b.CardTypeName
from BankCard as a
inner join CardType as b on b.CardTypeID = a.CardTypeID
inner join Cust as c on c.CustID = a.CustID
inner join CustType as d on d.CustTypeID = c.CustTypeID
where d.CustTypeName LIKE '对公%' and b.CardTypeName = '联名卡'