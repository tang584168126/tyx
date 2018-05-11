use NetBar

select UserName from Card
where PassWord = ID or PassWord = UserName

select TOP 1 ID from Record
where ComputerID = 'B01'
ORDER BY BeginTime DESC

update Record set Fee = Fee / 2
where DATENAME(dw,BeginTime) = '星期六' or DATENAME(dw,BeginTime) = '星期日'

select TOP 3 ID from Record
where DATEDIFF(mm,BeginTime,EndTime) > 0 and DATEPART(MM,BeginTime) = DATEPART(MM,GETDATE())

select COUNT(BeginTime) as 上机次数,CardID
from Record as a
where CardID = '0023_ABC'
GROUP BY CardID

select b.BeginTime as 上机时间,a.UserName as 用户名
from Card as a
INNER JOIN Record as b ON b.CardID = a.ID
where DATEDIFF(HH,BeginTime,GETDATE()) = 24

select b.UserName as 姓名,a.ComputerID,SUM(a.Fee)as 总费用
from Record as a
INNER JOIN Card as b ON a.CardID = b.ID
where DATEPART(ww,a.BeginTime) = DATEPART(ww,GETDATE())
GROUP BY b.UserName,a.ComputerID

select a.Fee,b.UserName,SUM(a.Fee) as 总消费
from Record as a
INNER JOIN Card as b ON a.CardID = b.ID
where a.CardID LIKE '_____AB_'
GROUP BY a.Fee,b.UserName