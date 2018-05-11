use Class10

select SUM(SalesPrice) as 美国
from Sales where ClientName = '美国'

select ClientName as 客户名,ProductNumber as 数量 from Sales
where ProductID = 3

select MAX(SalesPrice) from Sales
where ProductID = 2