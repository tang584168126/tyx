DECLARE @i int
DECLARE @j int
DECLARE @RESULT nvarchar(255)

SET @i = 1 

while(@i <= 9)
BEGIN
			SET @j = 1 
			SET @RESULT = ''
			
			while(@j <= @i)
			BEGIN
				
				set @RESULT += convert(nvarchar,@j) + '*' + convert(nvarchar,@i) + '=' + convert(nvarchar,@i * @j) + '	'
				
				set @j = @j + 1
				
			END
			
			set @i = @i + 1
			print @RESULT
END