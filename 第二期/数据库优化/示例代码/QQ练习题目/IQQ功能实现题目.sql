--都要通过存储过程和事务完成
use IQQ

--1.注册功能
	--1)插入数据到Customer表
	--2)插入默认分组数据到FriendGroup表(3个分组需要3条插入语句)
	insert into Customer
	(NickName,Pass,Sex,BornDate,RegDate,Head,[Level],Idiograph,Caption,CName,EName,Language,BloodType,Profession,Educational,		School,Phone,Mobile,Email,HomePage,NativePlace,LocationPlace,Address,Postcode,Status)
	values
	('张三丰','123456','男','1993-05-18','2004-2-25','乌龟',35,'','','','','简体中文','A型','学生','','','','12345678910','','',''	,'成都','','',1)

	insert into Customer
	(NickName,Pass,Sex,BornDate,RegDate,Head,[Level],Idiograph,Caption,CName,EName,Language,BloodType,Profession,Educational,		School,Phone,Mobile,Email,HomePage,NativePlace,LocationPlace,Address,Postcode,Status)
	values
	('李静','123456','男','1993-05-18','2004-2-25','乌龟',35,'','','','','简体中文','A型','学生','','','','12345678910','','',''	,'成都','','',1)
	
	insert into Customer
	(NickName,Pass,Sex,BornDate,RegDate,Head,[Level],Idiograph,Caption,CName,EName,Language,BloodType,Profession,Educational,		School,Phone,Mobile,Email,HomePage,NativePlace,LocationPlace,Address,Postcode,Status)
	values
	('恍然','123456','男','1993-05-18','2004-2-25','乌龟',35,'','','','','简体中文','A型','学生','','','','12345678910','','',''	,'成都','','',1)		
	
--2.登陆功能
	--得到个人信息
	--得到好友分组
	--得到每个分组下的人员列表
	--得到群信息	
	--得到未读的消息
	
--3.创建好友分组
	--1)插入数据到好友分组表FriendGroup中
	--2)查询出新添加的好友分组信息
                                                                                                                      
--4.创建群
	--1)插入数据到群表GroupInfo中
	--2)查询出新添加的群信息
	
--5.查找联系人
	--通过模糊查询或者是精确查询

--6.发送添加好友的消息
	--1)插入数据到消息信息表MessageInfo中
	--2)插入数据到个人消息表PersonalMessage中
	
--7.同意添加好友的消息
	--1)插入数据到消息信息表MessageInfo中
	--2)插入数据到个人消息表PersonalMessage中
	--3)插入数据到联系人表RelationList中(需要2条插入语句)
	--4)查询新添加的联系人的信息

--8.拒绝添加好友的消息
	--1)插入数据到消息信息表MessageInfo中
	--2)插入数据到个人消息表PersonalMessage中

--9.查找群信息
	--通过模糊查询或者是精确查询
	
--10.发送添加群的消息
	--1)插入数据到消息信息表MessageInfo中
	--2)插入数据到群消息信息表GroupMessage中

--11.同意添加群的消息
	--1)插入数据到消息信息表MessageInfo中
	--2)插入数据到群消息信息表GroupMessage中(需要多条插入语句)
	--3)插入数据到群组联系人表GroupList中
	--4)查询得到新添加的群信息

--12.拒绝添加群的消息
	--1)插入数据到消息信息表MessageInfo中
	--2)插入数据到群消息信息表GroupMessage中

--13.发送个人聊天消息
	--1)插入数据到消息信息表MessageInfo中
	--2)插入数据到个人消息表PersonalMessage中

--14.发送群聊天消息
	--1)插入数据到消息信息表MessageInfo中
	--2)插入数据到群消息信息表GroupMessage中(可能会有多条插入语句)
	
--15.删除联系人
	--1)插入数据到消息信息表MessageInfo中
	--2)插入数据到个人消息表PersonalMessage中
	--3)从联系人表RelationList中删除数据
	
--16.退出群
	--)群主退出
		--1)插入数据到消息信息表MessageInfo中
		--2)插入数据到个人消息表PersonalMessage中(可能会有多条插入语句)
		--3)从群消息信息表GroupMessage中删除该群的消息
		--4)从群表GroupInfo中删除该群的信息
		--5)从群组联系人表GroupList中删除该群所有联系人的信息
	--)其他人退出
		--1)插入数据到消息信息表MessageInfo中
		--2)插入数据到群消息信息表GroupMessage中(可能会有多条插入语句)
		--3)从群组联系人表GroupList中删除该人的信息
	
--17.移动联系人到另一个分组中
	--1)修改联系人表RelationList中的信息
	
--18.删除好友分组
	--1)修改联系人表RelationList中的信息到默认分组我的好友中
	--2)删除好友分组表FriendGroup中该分组的信息
	--3)查询默认分组中的好友信息

--19.更新个人信息
	--1)更新QQ用户表Customer中的数据
	--2)通过查询语句更新当前的信息
	
--20.修改联系人的备注名称
	--1)更新联系人表RelationList中的信息
	--2)通过查询语句更新当前的信息
	
--21.修改群名片
	--1)更新群组联系人表GroupList中的信息
	--2)通过查询语句更新当前的信息
	
--22.修改在线状态
	--1)更新QQ用户表Customer中的数据
	--2)插入数据到消息信息表MessageInfo中
	--3)插入数据到个人消息表PersonalMessage中
	--4)查询当前更新的信息
