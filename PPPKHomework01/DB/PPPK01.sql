--Ivor Mariæ RP
create database PPPK
go

use PPPK
go

create table Country
(
	IDCountry int constraint pk_IDCountry primary key identity,
	Name nvarchar(50) not null
)
go

insert into Country(Name)
values('Hrvatska'),('BIH'),('Slovenija')
go

