use MySchool182

select * from Student
where GradeId = 1

select StudentName , Phone
from Student
where GradeId = 2

select * from Student
where GradeId = 1 and Sex = 0

select * from Subject
where ClassHour >= 60

select * from Subject
where GradeId = 2

select StudentName,GradeId from Student
where GradeId = 2 and Sex = 1

select StudentName,GradeId from Student
where Email = ''

select StudentName,GradeId from Student
where BornDate > '1990-1-1' and GradeId = 2

select * from Result
where SubjectNo = 2 and ExamDate = '2010-2-15'