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
set @yt= (select count(*) from studentnew2)
select @yt

declare @yt2 int
Select @yt2= count(*) from studentnew2
select @yt2

ALTER PROCEDURE getcountofstudnew2
AS
	declare @yt2 int
	Select @yt2= count(*) from studentnew2
	select @yt2
	return @yt2
GO

DECLARE @return_value INT
EXEC @return_value = getcountofstudnew2
SELECT 'RETURN VALUE' = @return_value
GO


--- if else if

DECLARE @utu INT, @tut INT, @ttu INT
SET @utu = 1 
set @tut = 2
set @ttu =10

IF @utu %10=0
	PRINT 'utu is divisible by 10'
else if @tut %10=0
	PRINT 'tut is divisible by 10'
else if @ttu % 10 = 0
	PRINT 'ttu is divisible by 10'
else
	PRINT 'none is divisible by 10'


grant insert,select on studentnew2 to harshit
revoke insert,select on studentnew2 to harshit


-------- desgin

Roles 
	User
	Admin

Admin
	Admin details
	password
	product details
	user details
	user order history
	user cart

User
	User details
	Address
	cart
	order history
	product
	password

------



ALTER TABLE cart DROP CONSTRAINT productid


ALTER TABLE Customers
   ADD CONSTRAINT FK_Salesman_Customers FOREIGN KEY (salesman_id)
      REFERENCES Salesman(salesman_id)

select * from salesman
INSERT INTO Salesman(salesman_id, name, city, commission) values(5001, 'James Hoog', 'New York', 0.15)
INSERT INTO Salesman(salesman_id, name, city, commission) values(5002, 'Nail Knite', 'Paris', 0.13), 
(5005, 'Pit Alex', 'London', 0.11),
(5006, 'MC Lyon','Paris',0.14 ),
(5007,'Paul Adam','Rome',0.13),
(5003,'Lauson Hen', 'San Jose', 0.12)



select * from CUstomers

INSERT INTO Customers(customer_id,cust_name,city,grade,salesman_id) values
(3002,'Nick Rimando', 'New York' , 100 , 5001),
(3007,'Brad Davis', 'New York',200,5001),
(3005,'Graham Zusi','California',200,5002),
(3008,'Julian Green','London',300,5002),
(3004,'Fabian Johnson','Paris',300,5006),
(3009,'Geoff Cameron','Berlin',100,5003),
(3003,'Jozy Altido','Moscow',200,5007),
(3001,'Brad Guzan','London',400,5005)

q1:
SELECT * FROM Salesman WHERE city = 'London'

q2:
SELECT name FROM Salesman WHERE commission < 0.15

q3:
SELECT * FROM Salesman WHERE salesman_id BETWEEN 5001 AND 5005

q4:
SELECT * FROM Salesman WHERE city != 'London'

q5:
SELECT name FROM Salesman ORDER BY name DESC

q6:
SELECT city FROM Customers ORDER BY city ASC

q7:
SELECT cust_name FROM Customers WHERE cust_name LIKE 'N%'

q8:
SELECT cust_name FROM Customers WHERE cust_name LIKE '%s'

q9:
SELECT * FROM customers inner JOIN Salesman on customers.salesman_id = Salesman.salesman_id 

q10:
SELECT * FROM customers JOIN Salesman on customers.salesman_id = Salesman.salesman_id 
WHERE customers.city=salesman.city

q11:
SELECT * FROM customers JOIN Salesman on customers.salesman_id = Salesman.salesman_id 
WHERE customers.city=salesman.city AND customers.grade BETWEEN 100 AND 400

q12:
SELECT DISTINCT(city) FROM customers

q13:
SELECT salesman_id FROM Customers WHERE city = 'London' AND grade BETWEEN 100 AND 500

q14.1:
SELECT * FROM Custome
SELECT count(salesman_id) FROM customers GROUP BY city HAVING city='London'

q14.2:
SELECT * from salesman
--SELECT name,city from salesman GROUP BY name,city HAVING city='London'
SELECT max(name) FROM salesman GROUP BY city HAVING city = 'London'

q14.3:
SELECT max(name),commission from salesman 
WHERE city='Paris' 
GROUP BY commission,name 
HAVING commission>0.1 
ORDER BY name asc, commission desc

SELECT * FROM customers WHERE salesman_id IN (SELECT salesman_id FROM Salesman WHERE commission>0.12)

SELECT * FROM customers WHERE salesman_id = ANY (SELECT salesman_id FROM Salesman WHERE commission>0.12)

SELECT * FROM customers WHERE salesman_id >= ALL (SELECT salesman_id FROM Salesman WHERE commission>0.12)

select * from customers

SELECT name,salesman_id FROM salesman WHERE salesman_id < ALL (SELECT salesman_id FROM Customers WHERE grade = 300)

SELECT salesman_id FROM Customers WHERE grade = 300


CREATE TABLE Employee (
	Empid int NOT NULL IDENTITY(1,1) , 
	Empname varchar(50) NOT NULL, 
	gross_salary int NOT NULL,
	net_gross int NOT NULL, 
	bonus int NOT NULL, 
	city varchar(50) NOT NULL, 
	address varchar(50) NOT NULL,
	CONSTRAINT PK_Employee PRIMARY KEY(Empid,Empname),
)

INSERT INTO Employee VALUES('Harshit',100000,90000,8987,'Delhi','NEW DELHI')

CREATE TABLE Company (
	Company_id INT NOT NULL IDENTITY(10,10) ,
	company_name VARCHAR(50) , 
	 
	cid int NOT NULL FOREIGN KEY REFERENCES Employee(Empid) ,
	CONSTRAINT PK_company PRIMARY KEY(Company_id),
	--CONSTRAINT FK_Company_Employee FOREIGN KEY(Empid) REFERENCES Employee(Empid),
)


CREATE TABLE student2 (
	studid int NOT NULL IDENTITY(1,1) , 
	name varchar(50) NOT NULL,
	city varchar(50) NOT NULL,
	mobile int not null,
	CONSTRAINT PK_student2 PRIMARY KEY(studid),
)

CREATE TABLE subject2 (
	studid int NOT NULL,
	sub_name varchar(50) not null,
	marks int not null,
	CONSTRAINT FK_subject2_student2 FOREIGN KEY(studid) REFERENCES student2(studid)
)

INSERT INTO student2 VALUES('Harshit','delhi',1234567),
('Rohan','Patna',44556677),
('Sohan','Benguluru',9657654),
('Mohan','Kochi',92357654),
('Kohan','Srinagar',96387654),
('Pohan','Mumbai',99837654),
('Yohan','Kolkata',99885654),
('Tohan','Chennai',99887344)

SELECT * FROM student2

INSERT INTO subject2 VALUES
(1,'English',100),
(1,'Hindi',87),
(1,'Maths',98),
(1,'Physics',78),
(1,'Chemistry',88),
(2,'English',45),
(2,'Hindi',76),
(2,'Maths',56),
(2,'Physics',65),
(2,'Chemistry',78),
(3,'English',56),
(3,'Hindi',87),
(3,'Maths',78),
(3,'Physics',45),
(3,'Chemistry',44),
(4,'English',67),
(4,'Hindi',87),
(4,'Maths',67),
(4,'Physics',56),
(4,'Chemistry',45),
(5,'English',67),
(5,'Hindi',77),
(5,'Maths',76),
(5,'Physics',68),
(5,'Chemistry',98),
(6,'English',100),
(6,'Hindi',100),
(6,'Maths',78),
(6,'Physics',89),
(6,'Chemistry',78),
(7,'English',100),
(7,'Hindi',100),
(7,'Maths',100),
(7,'Physics',50),
(7,'Chemistry',70),
(8,'English',40),
(8,'Hindi',47),
(8,'Maths',57),
(8,'Physics',55),
(8,'Chemistry',78)

DELETE FROM subject2 WHERE studid = 8

SELECT * from student2
SELECT * from subject2

SELECT * FROM student2 left join subject2 on student2.studid = subject2.studid;
SELECT * FROM subject2 right join  student2 on student2.studid = subject2.studid;

SELECT * FROM student2 full join subject2 on student2.studid = subject2.studid;

CREATE TABLE manager2 (
	managerid int not null IDENTITY(1,1),
	name varchar(50) not null,
	salesmanid int not null,
	salesmanname varchar(50) not null,
	city varchar(50) not null
	CONSTRAINT PK_manager2 PRIMARY KEY (managerid)
)



INSERT INTO manager2 VALUES
('Harshit',11,'sales-harshit','Delhi'),
('Rohan',21,'sales-rohan','Paris'),
('Mohan',31,'sales-mohan','Kochi'),
('Sohan',41,'sales-sohan','Chennai'),
('Kohan',51,'sales-kohan','Kolkata'),
('Pohan',61,'sales-pohan','Patna'),
('Tohan',71,'sales-tohan','Ranchi'),
('Yohan',81,'sales-yohan','Salem')

SELECT * FROM manager2 m1 join manager2 m2 on m1.managerid = m2.managerid WHERE m1.salesmanid>20


CREATE FUNCTION GetAvgMarks(@Studid int)
RETURNS FLOAT
	AS
	BEGIN
		DECLARE @avgmarks float = 0
		SET @avgmarks = (SELECT avg(marks) FROM subject2 GROUP BY studid HAVING studid = @Studid)
		RETURN @avgmarks
	END

SELECT dbo.GetAvgMarks(1) AS 'avg marks of student 1'

SELECT * FROM subject2 WHERE studid=2
SELECT avg(marks) FROM subject2 WHERE studid=1
