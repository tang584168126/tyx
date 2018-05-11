use class10

select * from Test2
where HouseType LIKE'%一厅%'

select * from Test2
where LandLord LIKE'于_玲'

select * from Test2
where Adress LIKE'%解放区%'

select AVG(Area) from Test2
where HouseType LIKE'%一室一厅%'