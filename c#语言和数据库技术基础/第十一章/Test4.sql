use Class11

select COUNT(*) as ����, NationalityID as ���� from customerInfo
GROUP BY NationalityID

select COUNT(*) as ���� from customerInfo
where Sex = '1' 
GROUP BY Sex

select COUNT(*) as ���� from customerInfo
where Sex = '0' 
GROUP BY Sex

select COUNT(*) as ����, Certificate as ֤�� from customerInfo
GROUP BY Certificate

select b.Certificate as ֤�� from NationalityInfo as a
INNER JOIN customerInfo as b ON a.NationalityID = b.NationalityID
where a.nationality = '�¼���'

select COUNT(a.Sex) from customerInfo as a
INNER JOIN NationalityInfo as b ON b.NationalityID = a.NationalityID
where b.nationality = '�й�' AND Sex = '1'

select COUNT(a.Sex) from customerInfo as a
INNER JOIN NationalityInfo as b ON b.NationalityID = a.NationalityID
where b.nationality = '�й�' AND Sex = '0'