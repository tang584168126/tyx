use Library

IF EXISTS(select * from sysobjects where name = 'manager')
	drop view manager
	
IF EXISTS(select * from sysobjects where name = 'reader')
	drop view reader	
go

create view manager
(
	select b.BID,b.BName,c.RID,c.RName,c.RAddress,a.LendDate,a.WillDate from Borrow as a
	left join Book as b on b.BID = a.BID
	left join Reader as c on c.RID = a.RID
)

go
create view	reader
(
	selectBID,BName,
)