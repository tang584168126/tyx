use Class11

select COUNT(*) as 人数, NationalityID as 国籍 from customerInfo
GROUP BY NationalityID

select COUNT(*) as 人数 from customerInfo
where Sex = '1' 
GROUP BY Sex

select COUNT(*) as 人数 from customerInfo
where Sex = '0' 
GROUP BY Sex

select COUNT(*) as 人数, Certificate as 证件 from customerInfo
GROUP BY Certificate

select b.Certificate as 证件 from NationalityInfo as a
INNER JOIN customerInfo as b ON a.NationalityID = b.NationalityID
where a.nationality = '新加坡'

select COUNT(a.Sex) from customerInfo as a
INNER JOIN NationalityInfo as b ON b.NationalityID = a.NationalityID
where b.nationality = '中国' AND Sex = '1'

select COUNT(a.Sex) from customerInfo as a
INNER JOIN NationalityInfo as b ON b.NationalityID = a.NationalityID
where b.nationality = '中国' AND Sex = '0'