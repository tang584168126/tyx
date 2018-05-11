/*
 *Example2
 *查询语句编写的步骤
 *1.数据来自哪些表			=> from
 *2.数据具体所在的列或函数	=> select 
 *3.确定是否有查询条件		=> where
 *4.确定是否需要分组		=> GROUP BY
 *5.确定是否筛选结果		=> HAVING
 *6.确定是否排序			=> ORDER BY
 */
 
use MySchool182

--查询10000号学生每门课程的成绩平均分，并从高到底排列
select StudentNo,SubjectNo,AVG(StudentResult) as 平均分
from Result
where StudentNo = 10000
GROUP BY StudentNo,SubjectNo
ORDER BY AVG(StudentResult) DESC