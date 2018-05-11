use TrainOfChina

select * from TrainInfo
where CHARINDEX('T',TNumber) = 1

select TNumber,TDest,TStartTime,TEndTime from TrainInfo
where TFrom= '长沙'

select TNumber,TFrom,TDest from TrainInfo
where TUnitPrice > 200
ORDER BY TUnitPrice DESC

update TrainInfo set TEndTime = '22:14:00'
where TNumber = 'T5'

update TrainInfo set TEndTime = '16:40:00'
where TNumber = 'T8'

update TrainInfo set TEndTime = '13:07:30'
where TNumber = 'Z11'

delete from TrainInfo where TNumber = 'Z11'

select AVG(TSpeed) as 平均速度
from TrainInfo
where TNumber LIKE'K%'

select AVG(TSpeed) as 平均速度
from TrainInfo
where TNumber LIKE'T%'

select AVG(TSpeed) as 平均速度
from TrainInfo
where TNumber LIKE'Z%'

select b.SNumber as 车次,a.(TDistance / 20 * TUnitPrice) as 价格
from TrainInfo as a
INNER JOIN TrainScheduler as b ON a.TNumber = b.SNumber
where b.SDate = '2013-5-7' AND a.TFrom = '长沙' AND a.TDest = '北京' AND b.SLieNumber is NOT NULL

select a.TNumber as 车次, a.TFrom as 始发, a.TDest as 终点, b.SConductor as 列车长
from TrainInfo as a
INNER JOIN TrainScheduler as b ON a.TNumber = b.SNumber
where b.SDate = '2013-5-7'

select SConductor as 列车长 ,COUNT(SConductor) as 天数
from TrainScheduler
GROUP BY SConductor
where SDate >= '2013-5-1' AND SDate <= '2013-5-3'