create database EYdatabase

use EYdatabase

create table customer(custid int, custname varchar(50), custsalary int)

create table student(studid int, studname varchar(50))

drop table student;

go;
--

--create database testdb
--drop database testdb;
--go;

SELECT name FROM master.sys.databases ORDER BY name;
go


select * from customer

insert into customer(custid, custname, custsalary) values(10,'Harshit',5000)

insert into customer(custid, custsalary, custname) values(123,450,'Sohan')

--====
select name from sys.tables

update customer set custsalary=20000 where custid=10

DELETE from customer where custid=10;

insert into customer( custsalary, custname) values(450,'Sohan')



select * from customer where custid is not null;

--crud - create read update delete

go



select * from studentnew order by name desc, id asc

select * from student
select * from studentnew

select * from student s inner join studentnew sn on s.studid = sn.id

select * from student s inner join studentnew sn on s.studid >= sn.id

select * from student s inner join studentnew sn on s.studid <= sn.id

select * from student s left join studentnew sn on s.studid = sn.id

select * from student s left outer join studentnew sn on s.studid = sn.id
select * from student s left inner join studentnew sn on s.studid = sn.id   --error no such thing


--left / left outer join
--right / right outer join
--full join / full outer join

select * from student s left join studentnew sn on s.studid = sn.id
select * from student s right join studentnew sn on s.studid = sn.id

select * from student s full join studentnew sn on s.studid = sn.id


select * from student s join student s1 on s.studid > s1.studid
select * from student s left join student s1 on s.studid > s1.studid

select * from studentnew except select * from studentnew2

select * from studentnew
select * from studentnew2



-- stored procedure
-- without parameter

without parameters :
	create proc displayallrecs 
	as 
	begin
		select * from student
	end


exec displayallrecs

create proc insterstudent 
	as 
	begin
		insert into student(studid,studname,studgrade,addmissiondate,exitdate) values(10,'tg','g','2020-09-10','2024-12-2')
	end

exec insterstudent

create proc deletestudent
	as 
	begin
		delete from student where studid=10
	end

exec deletestudent

--with parameters:

select * from studentnew

create proc insstudent
(@sid int, @sname varchar(50), @srollno int, @sgrade varchar(1))
	as 
	begin
		insert into studentnew(id,name,rollno,grade) values(@sid, @sname, @srollno, @sgrade)
	end

exec insstudent 12,'harshit',12,'r'


create proc delstudent
(@sid int)
	as 
	begin
		delete from studentnew where id = @sid
	end

exec delstudent 12

create proc updatestud_grade
(@sid int,  @sgrade varchar(1))
	as 
	begin
		update studentnew set grade=@sgrade where id=@sid
	end

exec updatestud_grade 12,'a'

select * from studentnew


-- question display based on user input

create proc dispstud_id
(@sid int)
	as 
	begin
		select * from studentnew where id=@sid
	end
	 
exec dispstud_id 5

sp_helptext deletestudent

drop proc deletestudent


select * from student where studid in (select id from studentnew where id>1)

insert into student select * from student where studid in (select id from studentnew where id>1)

delete from student select * from student where studid in (select id from studentnew where id>1)


select * from studentnew where id in (select id from studentnew2 where id>5)

insert into studentnew select * from studentnew where id in (select id from studentnew2 where id>5)

select * from studentnew

update studentnew set id = id * 10 where id in (select id from studentnew2 where roll>5)


select * from studentnew cross join studentnew2


==============================
Transaction : 

CREATE TABLE Product 
(
	Product_id INT PRIMARY KEY,
	Product_Name VARCHAR(40),
	Price INT,
	Quantity INT
)


INSERT INTO Product VALUES (1,'Mobile',10000,10),
(2,'TV',15999,2),
(3,'Computer',110499,1),
(4,'Laptop',76543,4),
(5,'SSD',2435,50)

SELECT * FROM Product

--Start of transaction
BEGIN TRANSACTION
--SQL statements
INSERT INTO Product VALUES(6,'USB Cable',149,22)
UPDATE Product SET Price = 8999 WHERE Product_id=1
COMMIT TRANSACTION



-- roll back
--Start of transaction
BEGIN TRANSACTION
--SQL statements
INSERT INTO Product VALUES(7,'Keylogger',599,7)
UPDATE Product SET Price = 8999 WHERE Product_id=1
DELETE FROM Product WHERE Product_id = 6
--commit or rollback
ROLLBACK TRANSACTION

SELECT * FROM Product

