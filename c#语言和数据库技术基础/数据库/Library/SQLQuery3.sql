begin transaction

DECLARE @SumError int

set @SumError = 0

update Book set BCount = BCount - 1 
where BName = '����.NETƽ̨��C#���'

set @SumError += @@ERROR

insert into Borrow
(RID,BID,LendDate,WillDate,ReturnDate)
values
('12345','ISBN003',GETDATE(),DEFAULT,null)

set @SumError += @@ERROR

update Reader set LendNum += 1 
where RName = '���޼�'

set @SumError += @@ERROR

IF(@SumError <> 0)
	BEGIN
		select '����ʧ��' 
		ROLLBACK TRANSACTION
	END
ELSE
	BEGIN
		select '���ĳɹ�' 
		COMMIT TRANSACTION
	END	