/*
 *Example4
 *MyQQ数据库练习
 */
 
use MyQQ

--1.使用T-SQL语句查询全部QQ用户信息
select * from QQUser

--2.使用T-SQ;语句查询性别为男的QQ用户信息
select *
from QQUser
where Sex = '男'

--3.使用T-SQL语句查询QQ等级为0的用户信息
select *
from QQUser
where level = 0

--4.使用T-SQL语句查询个性签名不为空的QQ用户信息
select *
from QQUser
where idiograph != '' or idiograph is not NULL

--5.使用T-SQL语句查询血型为A、国家是中国并且出生日期是1990年以后的QQ用户信息
select *
from QQUser
where BloodType = 'A' and Country = '中国' and Birthday >= '1990-1-1'

--6.查询QQID为10001的QQ用户信息
select *
from QQUser
where QQID = 10001

--7.使用T-SQL语句查询全部联系人信息的数据
select *
from QQRelation

--8.查询QQ号码为10000的联系人的信息
select *
from QQRelation
where SQQID = 10000

--9.查询QQ号码为10000的联系人中好友的的信息
select *
from QQRelation
where SQQID = 10000 and RelationType = 0

--10.使用T-SQL语句查询全部消息表的数据
select *
from QQMessage

--11.查询QQ号码为10000的用户发送的消息
select *
from QQMessage
where SeQQID = 10000

--12.查询发送给QQ号码为10000的消息
select *
from QQMessage
where ReQQID = 10000

--13.查询所有的未读消息
select *
from QQMessage
where Status = 1

--14.查询发送给QQ号码为10000的未读消息
select *
from QQMessage
where ReQQID = 10000 and Status = 1

--15.查询发送给QQ号码为10000的未读消息，并且发送时间为2012年12月的
select *
from QQMessage
where ReQQID = 10000 and Status = 1 and YEAR(SendTime) = '2012' and MONTH(SendTime) = '12'