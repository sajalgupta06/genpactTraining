create database Day14
use Day14
create table Emps(Id int primary key, Fname nvarchar(50), Lname nvarchar(50),Salary float,DOJ datetime)
insert into Emps values(1,'Sr','Lu',150000.5,'2/03/2023')
insert into Emps values (2,'Ar','Ch',180000.5,'12/12/2022')
insert into Emps values (3,'Hr','Cu',100000.5,'11/03/2023')
select * from Emps

create proc usp_sEmps
as 
begin 
select * from Emps
end
exec usp_sEmps

create proc usp_insertEmp
@id int,
@fn nvarchar(50),
@ln nvarchar(50),
@sal float,
@doj date
as
begin
insert into Emps(Id,Fname,Lname,Salary,DOJ) values(@id,@fn,@ln,@sal,@doj)
if(@@ROWCOUNT >=1)
print 'Record Inserted'
end

execute usp_insertEmp 13,'Srajan','Tayal',98000.5,'11/11/2022'



create proc usp_updateEmp
@oldname nvarchar(50),
@newname nvarchar(50)
as
begin
update Emps set Fname = @newname where Emps.Fname = @oldname
if(@@ROWCOUNT >=1)
print 'Record Updated'
end

execute usp_updateEmp 'srajan', 'John'



exec usp_insertEmp 1,'Rohan','K',67000, '11/11/2019'
exec usp_insertEmp 2,'Ravi','K',98000.50, '11/11/2019'
exec usp_insertEmp 3,'Sam','K',45000.23, '11/11/2019'


select max(Salary) 'Max' from Emps
select avg(Salary) 'Avg' from Emps
select min(Salary) 'Min' from Emps
select sum(Salary) 'Sum' from Emps

create proc usp_GetMaxSal
@maxSal float out
as
begin
select @maxSal=max(Salary) from Emps
end

declare @mSalary float
exec usp_GetMaxSal @mSalary out
print @mSalary


create proc usp_deleteEmp
@id int
as
begin
delete from Emps where Id = @id
if(@@ROWCOUNT>=1)
print 'Record Deleted'
end



alter proc usp_deleteEmp
@id int
with encryption
as
begin
delete from Emps where Id = @id
if(@@ROWCOUNT>=1)
print 'Record Deleted'
end

execute sp_helptext usp_deleteEmp
