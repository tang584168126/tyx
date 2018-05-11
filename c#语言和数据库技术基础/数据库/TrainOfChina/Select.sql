use TrainOfChina

select * from TrainInfo
where CHARINDEX('T',TNumber) = 1

select TNumber,TDest,TStartTime,TEndTime from TrainInfo
where TFrom= '��ɳ'

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

select AVG(TSpeed) as ƽ���ٶ�
from TrainInfo
where TNumber LIKE'K%'

select AVG(TSpeed) as ƽ���ٶ�
from TrainInfo
where TNumber LIKE'T%'

select AVG(TSpeed) as ƽ���ٶ�
from TrainInfo
where TNumber LIKE'Z%'

select b.SNumber as ����,a.(TDistance / 20 * TUnitPrice) as �۸�
from TrainInfo as a
INNER JOIN TrainScheduler as b ON a.TNumber = b.SNumber
where b.SDate = '2013-5-7' AND a.TFrom = '��ɳ' AND a.TDest = '����' AND b.SLieNumber is NOT NULL

select a.TNumber as ����, a.TFrom as ʼ��, a.TDest as �յ�, b.SConductor as �г���
from TrainInfo as a
INNER JOIN TrainScheduler as b ON a.TNumber = b.SNumber
where b.SDate = '2013-5-7'

select SConductor as �г��� ,COUNT(SConductor) as ����
from TrainScheduler
GROUP BY SConductor
where SDate >= '2013-5-1' AND SDate <= '2013-5-3'