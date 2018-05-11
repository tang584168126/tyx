use MyQQ

select * from QQUser

select * from QQUser where Sex = 'ÄÐ'

select * from QQUser where level = 0

select * from QQUser where idiograph <> '' or idiograph is not NULL

select * from QQUser where BloodType = 'A' AND Country = 'ÖÐ¹ú' AND Birthday >= '1990-1-1'

select * from QQUser where QQID = 10001

select * from QQRelation

select * from QQRelation where SQQID = 10000

select * from QQRelation where RelationType = 0 and SQQID = 10000

select * from QQMessage

select Message from QQMessage where SeQQID = 10000

select Message from QQMessage where ReQQID = 10000

select Message from QQMessage where Status = 1

select Message from QQMessage where Status = 1 AND ReQQID = 10000

select Message from QQMessage where Status = 1 AND ReQQID = 10000 AND (SendTime >= '2012-12-1' AND SendTime <= '2012-12-31')