begin transaction

DECLARE @SumError int

set @SumError = 0

update Book set BCount = BCount - 1 
where BName = '深入.NET平台和C#编程'

set @SumError += @@ERROR

insert into Borrow
(RID,BID,LendDate,WillDate,ReturnDate)
values
('12345','ISBN003',GETDATE(),DEFAULT,null)

set @SumError += @@ERROR

update Reader set LendNum += 1 
where RName = '张无忌'

set @SumError += @@ERROR

IF(@SumError <> 0)
	BEGIN
		select '借阅失败' 
		ROLLBACK TRANSACTION
	END
ELSE
	BEGIN
		select '借阅成功' 
		COMMIT TRANSACTION
	END	