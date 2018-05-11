begin transaction

DECLARE @SumError int

set @SumError = 0

insert into Penalty
(RID,BID,PDate,PType,Amount)
values
('11111','ISBN005',DEFAULT,1,5.6) 

set @SumError += @@ERROR

update Reader set LendNum -= 1
where RName = '������'

set @SumError += @@ERROR

update Borrow set ReturnDate = GETDATE()
where RID = '11111'

set @SumError += @@ERROR

update Book set BCount += 1
where BID = 'ISBN005'

set @SumError += @@ERROR

IF(@SumError <> 0)
	BEGIN
		select '�黹ʧ��' 
		ROLLBACK TRANSACTION
	END
ELSE
	BEGIN
		select '�黹�ɹ�' 
		COMMIT TRANSACTION
	END	