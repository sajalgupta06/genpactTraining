create database StaffDb

use StaffDb

create table Dept
(DId int primary key,
DName nvarchar(50) not null unique)

insert into Dept values (1, 'App-Development')
insert into Dept values (2, 'Web-Development')
insert into Dept values (3, 'Agile-Scrum')
insert into Dept values (4, 'HRM')

create Table Staff
(Id int primary key,
Fname nvarchar(50),
Lname nvarchar(50),
Designation nvarchar(50) check
(Designation in ('Developer', 'Manager', 'Tester', 'Designer', 'CTO', 'CFO', 'Other')),
Salary decimal(8,2),
Department int foreign key references Dept(DId)
)
insert into Staff values
(12, 'Deep', 'Singh', 'Developer', 96000.45,1),

(2, 'Vipin', 'T.N.R', 'CTO', 99800.234,3),

(3, 'Disha', 'M.', 'Manager', 98000.45,3),

(4, 'Gagan', 'Kapoor', 'Manager', 98000.465,3),

(5, 'Vibha', 'J.j', 'Developer', 759.7845,2),

(9, 'Arun', 'N', 'Developer',96000.45, 2),

(11, 'Vishal', 'M', 'Tester', 96000.5545,1)

select  * from Dept join Staff on Dept.DId = Staff.Department where Staff.Department=2

create proc usp_GetDId
@dname nvarchar(50),
@did int output
as
begin
select @did = DId From Dept where DName = @dname
end

declare @deptId int;
exec usp_GetDId 'App-Development' , @deptId out
print @deptId

create proc usp_StaffCount
@dname nvarchar(50)
as
begin
declare @deptid int;

execute usp_GetDId @dname, @deptId out

select count(s.Id) as 'Number of Employees' from Dept d Join Staff s on d.DId=s.Department
where s.Department=@deptId
end
execute usp_StaffCount 'Web-Development'

























