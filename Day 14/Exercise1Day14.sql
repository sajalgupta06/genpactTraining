create Database ExerciseDb1

create table Products  (PId int  primary key identity(1000,1) ,
	PName varchar(50) not null,
	PPrice float ,
	PTax  as PPrice * 0.1 persisted,
	PCompany varchar(50) check(PCompany='Samsung' or PCompany='Apple' or PCompany='Redmi' or PCompany='HTC' or PCompany='RealMe'  ),
	PQty int check(PQty>=1) default 1
) 

insert into Products (PName,PPrice,PCompany,PQty) values('Galaxy',30000,'Samsung',3)
insert into Products (PName,PPrice,PCompany,PQty) values('Note 7',33000,'Redmi',32)
insert into Products (PName,PPrice,PCompany,PQty) values('Phone',30000,'Apple',31)
insert into Products (PName,PPrice,PCompany,PQty) values('Not Pro ',30000,'Realme',43)
insert into Products (PName,PPrice,PCompany,PQty) values('phone 2',30000,'HTC',53)

insert into Products (PName,PPrice,PCompany,PQty) values('Galaxy2',23000,'Samsung',3)
insert into Products (PName,PPrice,PCompany,PQty) values('Note 100',4300,'Redmi',32)
insert into Products (PName,PPrice,PCompany,PQty) values('Phone 2',33400,'Apple',31)
insert into Products (PName,PPrice,PCompany,PQty) values('Not3 Pro 3 ',32300,'Realme',43)
insert into Products (PName,PPrice,PCompany,PQty) values('phone 32',32300,'HTC',53)

create proc display
with encryption
as
begin
select p.PId , p.PName, p.PPrice + p.PTax as 'Price WIth Tax', p.PCompany, p.PQty * (p.PPrice + p.PTax) as 'Total Price' from Products p
end
exec display


create proc totalTax


@cName varchar(50),
@tax int output
with encryption
as
begin
select @tax = sum(p.PTax)  from Products p where p.PCompany =@cName
end

declare  @tTax int 
exec totalTax 'Apple', @tTax out
print  @tTax



