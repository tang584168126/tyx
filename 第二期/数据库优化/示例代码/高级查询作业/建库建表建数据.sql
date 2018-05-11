--/*********************************  建库建表建约束，插入测试数据  ******************************************/
Use master
go
if exists(select * from sysdatabases where name = 'MySchool_Work')
 Drop Database MySchool_Work
Create Database MySchool_Work
go
Use MySchool_Work
go
create table tblStudent
(
 StuId varchar(5) primary key,
 StuName nvarchar(10) not null,
 StuAge int,
 StuSex nchar(1) not null
)
create table tblTeacher
(
 TeaId varchar(3) primary key, 
 TeaName varchar(10) not null
)
create table tblCourse
(
 CourseId varchar(3) primary key,
 CourseName nvarchar(20) not null, 
 TeaId varchar(3) not null foreign key references tblTeacher(teaId)
)
create table tblScore
(
 StuId varchar(5) not null foreign key references tblStudent(stuId),
 CourseId varchar(3) not null foreign key references tblCourse(CourseId),
 Score float
)
----------------------------------表结构----------------------------------------------------
--学生表tblStudent（编号StuId、姓名Stuname、年龄Stuage、性别Stusex）
--课程表tblCourse（课程编号CourseId、课程名称CourseName、教师编号TeaId）
--成绩表tblScore（学生编号StuId、课程编号CourseId、成绩Score）
--教师表tblTeacher（教师编号TeaId、姓名TeaName）
--------------------------------插入数据-------------------------------------------------
insert into tblStudent
select '1000','张无忌',18,'男' union
select '1001','周芷若',19,'女' union
select '1002','杨过',19,'男' union
select '1003','赵敏',18,'女' union
select '1004','小龙女',17,'女' union
select '1005','张三丰',18,'男' union
select '1006','令狐冲',19,'男' union
select '1007','任盈盈',20,'女' union
select '1008','岳灵珊',19,'女' union
select '1009','韦小宝',18,'男' union
select '1010','康敏',17,'女' union
select '1011','萧峰',19,'男' union
select '1012','黄蓉',18,'女' union
select '1013','郭靖',19,'男' union
select '1014','周伯通',19,'男' union
select '1015','瑛姑',20,'女' union
select '1016','李秋水',21,'女' union
select '1017','黄药师',18,'男' union
select '1018','李莫愁',18,'女' union
select '1019','冯默风',17,'男' union
select '1020','王重阳',17,'男' union
select '1021','郭襄',18,'女' 
go

insert  into tblTeacher
select '001','姚明' union
select '002','叶平' union
select '003','叶开' union
select '004','孟星魂' union
select '005','独孤求败' union
select '006','裘千仞' union
select '007','裘千尺' union
select '008','赵志敬' union
select '009','阿紫' union
select '010','郭芙蓉' union
select '011','佟湘玉' union
select '012','白展堂' union
select '013','吕轻侯' union
select '014','李大嘴' union
select '015','花无缺' union
select '016','金不换' union
select '017','乔丹'
go

insert into tblCourse
select '001','企业管理','002' union
select '002','马克思','008' union
select '003','UML','006' union
select '004','数据库','007' union
select '005','逻辑电路','006' union
select '006','英语','003' union
select '007','电子电路','005' union
select '008','毛泽东思想概论','004' union
select '009','西方哲学史','012' union
select '010','线性代数','017' union
select '011','计算机基础','013' union
select '012','AUTO CAD制图','015' union
select '013','平面设计','011' union
select '014','Flash动漫','001' union
select '015','Java开发','009' union
select '016','C#基础','002' union
select '017','Oracl数据库原理','010'
go

insert into tblScore
select '1001','003',90 union
select '1001','002',87 union
select '1001','001',96 union
select '1001','010',85 union
select '1002','003',70 union
select '1002','002',87 union
select '1002','001',42 union
select '1002','010',65 union
select '1003','006',78 union
select '1003','003',70 union
select '1003','005',70 union
select '1003','001',32 union
select '1003','010',85 union
select '1003','011',21 union
select '1004','007',90 union
select '1004','002',87 union
select '1005','001',23 union
select '1006','015',85 union
select '1006','006',46 union
select '1006','003',59 union
select '1006','004',70 union
select '1006','001',99 union
select '1007','011',85 union
select '1007','006',84 union
select '1007','003',72 union
select '1007','002',87 union
select '1008','001',94 union
select '1008','012',85 union
select '1008','006',32 union
select '1009','003',90 union
select '1009','002',82 union
select '1009','001',96 union
select '1009','010',82 union
select '1009','008',92 union
select '1010','003',90 union
select '1010','002',87 union
select '1010','001',96 union

select '1011','009',24 union
select '1011','009',25 union

select '1012','003',30 union
select '1013','002',37 union
select '1013','001',16 union
select '1013','007',55 union
select '1013','006',42 union
select '1013','012',34 union
select '1000','004',16 union
select '1002','004',55 union
select '1004','004',42 union
select '1008','004',34 union
select '1013','016',86 union
select '1013','016',44 union
select '1000','014',75 union
select '1002','016',100 union
select '1004','001',83 union
select '1008','013',97
go

