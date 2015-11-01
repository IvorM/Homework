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

insert into Country
values('Hrvatska'),('BIH'),('Slovenija')
go

create proc spGetCountries
as
begin
select * from Country
end
go

create proc spDeleteCountries
@IDCountry int
as
begin
delete from Country
where IDCountry=@IDCountry
end
go

create proc spInsertCountry
@CountyName nvarchar(50)
as
begin
insert into Country
values(@CountyName)
end
go

create proc spDeleteCountriesByName
@CountryName nvarchar(50)
as
begin
delete from Country
where Name=@CountryName
end
go