use Class10

select AVG(Age) as 平均年龄 from Test3
where Sex = '男'

select * from Test3
where Education = '本科'

select AVG(Salary) as 平均工资 from Test3
where Age >= 25

select MAX(Salary) as 男最高工资,MIN(Salary) as 男最低工资
where Sex = '男'

select MAX(Salary) as 女最高工资,MIN(Salary) as 女最低工资
where Sex = '女'