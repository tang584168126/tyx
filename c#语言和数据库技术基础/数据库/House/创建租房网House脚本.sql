USE MASTER 
GO
EXEC XP_CMDSHELL 'MKDIR E:\HOUSE1'
GO
SET NOCOUNT ON----不显示影响行数
IF EXISTS(SELECT * FROM SYS.DATABASES WHERE NAME='HOUSE')
DROP DATABASE HOUSE
GO
----创建数据库HOUSE
CREATE DATABASE HOUSE
ON
(NAME='HOUSE_DATA',
FILENAME='E:\HOUSE1\HOUSE_DATA.MDF',
SIZE=3,FILEGROWTH=1
)
LOG ON
(NAME='HOUSE_LOG',
FILENAME='E:\HOUSE1\HOUSE_DATA.LDF',
SIZE=10,FILEGROWTH=10%
)
GO
/*------创建表-----------*/
--------建表:sys_user(用户信息表)
USE House
GO
IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME='sys_user')
DROP TABLE sys_user
GO
CREATE TABLE sys_user
(UID INT IDENTITY (1,1) NOT NULL,---用户编号
UNAME VARCHAR(20) NOT NULL ,---姓名
UPASSWORD VARCHAR(20) NOT NULL---密码
)
GO
------建表sys_user的约束
ALTER TABLE sys_user
ADD CONSTRAINT PK_UID PRIMARY KEY (UID),
    CONSTRAINT CK_UPASSWORD CHECK(LEN(UPASSWORD)>6)
GO
-----建表hos_district
IF EXISTS( SELECT * FROM SYS.OBJECTS WHERE NAME='hos_district')
DROP TABLE hos_district 
GO
CREATE TABLE hos_district
(
DID INT IDENTITY (1,1) PRIMARY KEY NOT NULL ,---区县编号(主键)
DNAME VARCHAR(20) NOT NULL ----区县名称
)
GO
----建表hos_street
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME='hos_street')
DROP TABLE hos_street
GO
CREATE TABLE hos_street
(
SID INT IDENTITY(1,1) PRIMARY KEY  NOT NULL,---街道编号(主键)
SNAME VARCHAR(100) NOT NULL,---街道名称
SDID INT FOREIGN KEY (SDID)  REFERENCES hos_district (DID) NOT NULL 
)
GO
-----建表hos_type
IF EXISTS (SELECT * FROM SYS.OBJECTS WHERE NAME='hos_type')
DROP TABLE hos_type
GO
CREATE TABLE hos_type
(
HTID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,----房屋类型编号(主键)
HTNAME VARCHAR(20) NOT NULL ---房屋类型
)
GO
-----建表：hos_house
IF EXISTS(SELECT * FROM SYS.OBJECTS WHERE NAME='hos_house')
DROP TABLE hos_house
GO
CREATE TABLE hos_house
(
HMID INT IDENTITY(1,1) NOT NULL,---(房屋信息编号)
UID INT NOT NULL,----用户编号
--DID INT NOT NULL,----区县编号
SID INT NOT NULL,----街道编号
HTID INT NOT NULL,---房屋类型编号
PRICE  DECIMAL(18,2) NOT NULL,--价格
TOPIC VARCHAR(20) NOT NULL,---标题
CONTENTS VARCHAR(100) NOT NULL,---描述
HTIME DATETIME NOT NULL,---发布时间
COPY VARCHAR(20) ---备注
)
GO
-----添加约束(house)
ALTER TABLE hos_house
ADD CONSTRAINT PK_HMID PRIMARY KEY (HMID),
    CONSTRAINT DF_PRICE DEFAULT(0) FOR PRICE,
    CONSTRAINT CK_PRICE CHECK(PRICE>0),
    CONSTRAINT DF_HTIME DEFAULT(GETDATE()) FOR HTIME,
    CONSTRAINT CK_HTIME CHECK(HTIME<=GETDATE()),
    CONSTRAINT FK_UID FOREIGN KEY (UID) REFERENCES sys_user(UID) ,
   -- CONSTRAINT FK_DID FOREIGN KEY (DID) REFERENCES hos_district(DID),
    CONSTRAINT FK_SID FOREIGN KEY (SID) REFERENCES hos_street (SID),
    CONSTRAINT FK_HTID FOREIGN KEY(HTID) REFERENCES hos_type(HTID)
GO
--------添加测试数据
-----sys_user插入数据
INSERT INTO sys_user(UName,UPASSWORD) VALUES('张三','s217701')
INSERT INTO sys_user(UName,UPASSWORD) VALUES('李四','s217702')
INSERT INTO sys_user(UName,UPASSWORD) VALUES('王鑫','s217703')
INSERT INTO sys_user(UName,UPASSWORD) VALUES('张建','s217704')
INSERT INTO sys_user(UName,UPASSWORD) VALUES('李剑','s217705')
INSERT INTO sys_user(UName,UPASSWORD) VALUES('蒋以然','s217706')
INSERT INTO sys_user(UName,UPASSWORD) VALUES('王晓超','s217707')
INSERT INTO sys_user(UName,UPASSWORD) VALUES('张冬雪','s217708')
INSERT INTO sys_user(UName,UPASSWORD) VALUES('孙鹏','s217709')
INSERT INTO sys_user(UName,UPASSWORD) VALUES('蒋连昌','s217710')
GO
-----表hos_district插入数据
INSERT INTO hos_district (DNAME) VALUES('海淀区')
INSERT INTO hos_district (DNAME) VALUES('西城区')
INSERT INTO hos_district (DNAME) VALUES('东城区')
INSERT INTO hos_district (DNAME) VALUES('朝阳区')
INSERT INTO hos_district (DNAME) VALUES('景山区')
INSERT INTO hos_district (DNAME) VALUES('宣武区')
INSERT INTO hos_district (DNAME) VALUES('大兴')
INSERT INTO hos_district (DNAME) VALUES('丰台')
GO
----表hos_street插入数据
INSERT INTO hos_street (SNAME,SDID) VALUES('中关村',1)
INSERT INTO hos_street (SNAME,SDID) VALUES('苏州街',1)
INSERT INTO hos_street (SNAME,SDID) VALUES('万泉庄',1)
INSERT INTO hos_street (SNAME,SDID) VALUES('东四',3)
INSERT INTO hos_street (SNAME,SDID) VALUES('东单',3)
INSERT INTO hos_street (SNAME,SDID) VALUES('西四',2)
INSERT INTO hos_street (SNAME,SDID) VALUES('西单',2)
INSERT INTO hos_street (SNAME,SDID) VALUES('东湖',4)
INSERT INTO hos_street (SNAME,SDID) VALUES('八里庄',4)
INSERT INTO hos_street (SNAME,SDID) VALUES('双井',5)
INSERT INTO hos_street (SNAME,SDID) VALUES('陶然亭',5)
INSERT INTO hos_street (SNAME,SDID) VALUES('南菜园',6)
INSERT INTO hos_street (SNAME,SDID) VALUES('兴丰街',7)
INSERT INTO hos_street (SNAME,SDID) VALUES('黄村',7)
INSERT INTO hos_street (SNAME,SDID) VALUES('南苑街',8)
INSERT INTO hos_street (SNAME,SDID) VALUES('东铁营',8)
GO
-----表hos_type插入数据
INSERT INTO hos_type (HTNAME) VALUES('一室一卫')
INSERT INTO hos_type (HTNAME) VALUES('一室一厅')
INSERT INTO hos_type (HTNAME) VALUES('两室一卫')
INSERT INTO hos_type (HTNAME) VALUES('两室一厅')
INSERT INTO hos_type (HTNAME) VALUES('三室一厅')
INSERT INTO hos_type (HTNAME) VALUES('三室两厅')
GO
----表hos_house插入数据
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(1,1,2,2600,'中关村','中关村一条街','2009-1-2','中关村')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(2,2,3,3600,'苏州街','苏州街一条街','2009-1-3','苏州街')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(3,3,4,4600,'万泉庄','万泉庄一条街','2009-1-4','万泉庄')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(1,3,2,1500,'万泉庄附近','万泉庄附近一条街','2009-7-2','万泉庄附近')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(1,5,2,2700,'东单','东单很多美食','2009-9-2','东单')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(3,1,2,2600,'中关村','中关村电脑城','2009-4-1','中关村')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(4,4,1,2000,'东四','东四一条街','2009-4-2','东四')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(5,6,3,3600,'西四','西四一条街','2009-1-2','西四')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(5,7,2,3600,'西单','西单购物城','2009-4-2','西单')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(6,2,2,2600,'苏州街','苏州街美食','2009-2-2','苏州街')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(7,8,3,2900,'朝阳东湖','朝阳东湖一景','2009-3-2','朝阳')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(8,3,1,700,'万泉庄','万泉庄一条街','2009-5-2','万泉庄')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(3,2,3,4200,'苏州街','苏州街二条街','2009-1-3','苏州街')
INSERT INTO hos_house(UID,SID,HTID,PRICE,TOPIC,CONTENTS,HTIME,COPY)
VALUES(4,2,3,4100,'苏州街','苏州街西街','2009-1-3','苏州街')



GO





