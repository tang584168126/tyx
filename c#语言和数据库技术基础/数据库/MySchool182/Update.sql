use MySchool182

update Student 
set LoginPwd = '123456'
where StudentNo = 10000

update Student
set Address = '四川成都'
where StudentNo = 10011

update Student
set LoginPwd = StudentNo
where GradeId = 3

update Subject
set SubjectName = '第一年级'
where SubjectNo = 7

update Subject
set SubjectName = '第二年级'
where SubjectNo = 8

update Subject
set SubjectName = '第三年级'
where SubjectNo = 9

update Subject
set ClassHour = '50'
where SubjectNo = 1

update Result
set StudentResult = 75
where StudentNo = 10000 AND SubjectNo = 1

update Result
set StudentResult = '75'
where SubjectNo = 4 AND StudentResult < 75

update Student set 
LoginPwd = '223344',GradeId = 2 , Phone = 87654321
where StudentName = '李文才';


