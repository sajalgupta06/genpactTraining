create database ExerciseDb2

use ExerciseDb2

-- Creating Student Table
create table Student(Sid int primary key  identity(1,1), SName varchar(30), SEmail varchar(50) , SContact varchar(10))

insert into Student(SName,SEmail,SContact) values('Sajal Gupta','sajalgupta@gmail.com','1234567890')
insert into Student(SName,SEmail,SContact) values('Rohan Sharma','rohansharma@gmail.com','2134567430')
insert into Student(SName,SEmail,SContact) values('Mohit Yadav','mohityadav@gmail.com','9893224678')


create table Fee(Sid int foreign key references Student(Sid), SFees decimal(6,2) , SMonth int, SYear int, primary key (Sid,SMonth,SYear) )

create table PayConfirmation(Sid int , Name varchar(30),Email varchar(50),Fee int ,PaidOnDate date)


alter trigger trgFeePayConfirmation
on Fee
after insert
as
declare @id int
declare @SFees  decimal(6,2)
declare @name varchar(30)
declare @email varchar(50)
select @id = Sid from inserted
select @SFees = SFees from inserted
begin
select @name = SName , @email = SEMail from Student where Sid = @id
insert into PayConfirmation values(@id ,@name,@email,@SFees,GETDATE())
print 'Pay Confirmation Table Updated'
end

insert into Fee values (1,2500,4,2023)
insert into Fee values (1,2500,5,2023)

insert into Fee values (2,1500,6,2023)
insert into Fee values (2,1700,7,2023)

