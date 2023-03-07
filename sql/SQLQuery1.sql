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


BEGIN TRANSACTION
INSERT INTO Product VALUES(8,'Microsd Card',299,5)
--check for error
IF (@@ERROR>0)
BEGIN
	SELECT 'ROLL BACK'
	ROLLBACK TRANSACTION
END
ELSE
BEGIN
	SELECT 'COMMIT'
	COMMIT TRANSACTION
END


BEGIN TRANSACTION
DELETE FROM Product WHERE Product_id=8
--check for error
IF (@@ERROR>0)
BEGIN
	SELECT 'ROLL BACK'
	ROLLBACK TRANSACTION
END
ELSE
BEGIN
	SELECT 'COMMIT'
	COMMIT TRANSACTION
END

BEGIN TRANSACTION
UPDATE Product SET Price = 2999 WHERE Product_id = 4
--check for error
IF (@@ERROR>0)
BEGIN
	SELECT 'ROLL BACK'
	ROLLBACK TRANSACTION
END
ELSE
BEGIN
	SELECT 'COMMIT'
	COMMIT TRANSACTION
END

--auto rollback
BEGIN TRANSACTION
INSERT INTO Product VALUES(118,'Desktop',25000,15)
UPDATE Product SET Quantity='TEN' WHERE Product_id=4
SELECT * FROM Product
COMMIT TRANSACTION

BEGIN TRANSACTION
	INSERT INTO Product VALUES(118,'Desktop',25000,15)
SAVE TRANSACTION insertcommand
	DELETE FROM Product WHERE Product_id = 118
	SELECT * FROM Product
ROLLBACK TRANSACTION insertcommand
COMMIT

SELECT * FROM Product


-- implicit transaction

SET IMPLICIT_TRANSACTIONS ON
UPDATE Product SET Quantity = 10 WHERE Product_id = 5
DELETE FROM Product WHERE Product_id = 6
SELECT IIF(@@OPTIONS & 2 = 2,
'IMPLICIT TRANSACTION MODE ON',
'IMPLICIT TRANSACTION MODE OFF') AS 'Transaction Mode'
SELECT @@TRANCOUNT AS OpenTrans
COMMIT TRANSACTION
SELECT @@TRANCOUNT AS OpenTrans

-- can give transaction name also to the transaction 
BEGIN TRANSACTION DisplayProdcut
SELECT * FROM Product
COMMIT TRANSACTION DisplayProduct


--===== Mathematical function
select sin(0) as 'sin(0)' , cos(0) as 'cos(0)', abs(-5.42) as 'abs(-5.42)'
select floor(9.87) as 'floor(9.87)'
select power(2,2) as 'power(2,2)'
select Rand() as 'Rand()'
 

 --======== String Function
select stuff('hello my name is harshit',4,10,'xxxxx')

select * from String_split('hello this is my string', ' ')
select SOUNDEX('SEAS') , SOUNDEX('SHE') , SOUNDEX('SEEing')

--===date and time function
select datename(month,getdate())
select datename(year,getdate())
select datename(day,getdate())

select getdate();
select CURRENT_TIMESTAMP

select GETUTCDATE()

select DATEDIFF(year,'2021-2-13',getdate())
SELECT DATEPART(month, '2017/08/25') AS DatePartInt;


insert into Mobile values('realme')
select * from Mobile


--======loops

DECLARE @a INT
SET @a = 0
WHILE @a <= 10
BEGIN
	PRINT @a
	IF @a = 2
	GOTO tech
	
	SET @a = @a + 1
END

tech: 
	PRINT 'Welcome sir'


-------------------------------------

DECLARE @x INT
IF @x = 1
	PRINT ' Welcome sir'
ELSE
	PRINT 'BYE'


----------------------------------------

DECLARE @y INT
SET @y = 1

WHILE @y <= 10
BEGIN
	PRINT @y
	SET @y = @y + 1
END  

-------------
-- WAP for even number b/w 1 to 100
DECLARE @e INT
SET @e = 1

WHILE @e <= 100
BEGIN 
IF @e % 2 = 0
	PRINT @e
SET @e = @e + 1
END


-- WAP for odd number b/w 1 to 100
DECLARE @o INT
SET @o = 1

WHILE @o <= 100
BEGIN 
IF @o % 2 != 0
	PRINT @o
SET @o = @o + 1
END

declare @yt int
set @yt= select count(*) from studentnew2