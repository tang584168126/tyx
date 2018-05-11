use [E-Market]

select * from Commodity_Category

select * from CommodityInfo

select MName as 会员名,MSex as 性别,Email as 电子邮箱,MAddress as 联系地址,MPhone as 联系电话
from MemberInfo
where MID = 'daxia'

select CID,CName,OutputPrice
from CommodityInfo
where CategoryID = 2