/*
 *Example2
 *指定客户发布的出租房屋信息
 */

use HOUSE

select c.DName as 区县,b.SName as 街道,a.HTID as 户型类型,a.PRICE as 价格,a.TOPIC as 标题,a.CONTENTS as 描述,a.HTIME as 时间,a.COPY as 备注
from hos_house as a
left join hos_street as b on a.SID = b.SID
left join hos_district as c on b.SDID = c.DID
left join sys_user as d on a.UID = d.UID
where d.UName = '张三'