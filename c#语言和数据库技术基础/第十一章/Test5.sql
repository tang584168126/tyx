use Class11

select COUNT(a.empID) as ������, b.DeptName as ��������
from empInfo as a
INNER JOIN deptInfo as b ON a.DepID = b.DepID
GROUP BY b.DeptName
ORDER BY COUNT(a.empID) DESC

select COUNT(a.empID) as ������, b.DeptName as ��������
from empInfo as a
INNER JOIN deptInfo as b ON a.DepID = b.DepID
where empSex = 1
GROUP BY b.DeptName

select COUNT(a.empID) as ������, b.DeptName as ��������
from empInfo as a
INNER JOIN deptInfo as b ON a.DepID = b.DepID
where empSex = 0
GROUP BY b.DeptName

select COUNT(a.empID) as ����
from empInfo as a
INNER JOIN deptInfo as b ON a.DepID = b.DepID
where empSex = 0 AND b.DeptName = '��Ʒ�з���'
GROUP BY b.DeptName

select COUNT(a.empID) as ����
from empInfo as a
INNER JOIN deptInfo as b ON a.DepID = b.DepID
where empSex = 1 AND b.DeptName = '��Ʒ�з���'
GROUP BY b.DeptName