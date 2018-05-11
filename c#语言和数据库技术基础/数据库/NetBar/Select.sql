use NetBar

select UserName from Card
where PassWord = ID or PassWord = UserName

select TOP 1 ID from Record
where ComputerID = 'B01'
ORDER BY BeginTime DESC

update Record set Fee = Fee / 2
where DATENAME(dw,BeginTime) = '������' or DATENAME(dw,BeginTime) = '������'

select TOP 3 ID from Record
where DATEDIFF(mm,BeginTime,EndTime) > 0 and DATEPART(MM,BeginTime) = DATEPART(MM,GETDATE())

select COUNT(BeginTime) as �ϻ�����,CardID
from Record as a
where CardID = '0023_ABC'
GROUP BY CardID

select b.BeginTime as �ϻ�ʱ��,a.UserName as �û���
from Card as a
INNER JOIN Record as b ON b.CardID = a.ID
where DATEDIFF(HH,BeginTime,GETDATE()) = 24

select b.UserName as ����,a.ComputerID,SUM(a.Fee)as �ܷ���
from Record as a
INNER JOIN Card as b ON a.CardID = b.ID
where DATEPART(ww,a.BeginTime) = DATEPART(ww,GETDATE())
GROUP BY b.UserName,a.ComputerID

select a.Fee,b.UserName,SUM(a.Fee) as ������
from Record as a
INNER JOIN Card as b ON a.CardID = b.ID
where a.CardID LIKE '_____AB_'
GROUP BY a.Fee,b.UserName