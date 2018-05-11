use NetBar

update Card
set PassWord = '0023abc',Balance = 98
where ID = '0023_ABC'

delete from Card where ID = '0024_ABD'

update Card
set Balance = 44
where ID = '0024_ABE'

insert into Card
(ID,PassWord,Balance,UserName)
values
('0036_CCD','36ccd',100,'ºÎÁø')

insert into Card
(ID,PassWord,Balance,UserName)
values
('0089_EDE','zhang',134,'ÕÇ¾þ')