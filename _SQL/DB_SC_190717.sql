create Procedure getRepairBySN
@SN varchar(40)
as
begin
select Repairs.idRepair as [Номер], Repairs.datetime as [Дата], Clients.nameClient as [Клиент], Clients.contact as [Контакт], Clients.phone as [Телефон]
, (Categories.nameCategory + ' ' + Brands.nameBrand + ' ' + Models.nameModel) as [Изделие], Repairs.SN as [Серийный номер]
, Types.nameType as [Тип ремонта], Repairs.defect as [Дефект], Repairs.kitview as [Комплектность], Engineers.nameEngineer as [Инженер]
, Repairs.result as [Результат], Repairs.price as [Цена], Status.nameStatus as [Статус] 
from (((((((Repairs inner join Clients on Repairs.idClient = Clients.idClient)inner join Models on Repairs.idModel = Models.idModel)inner join Brands
on Models.idBrand = Brands.idBrand)inner join Categories on Categories.idCategory = Models.idCategory)inner join Types on Repairs.idType = Types.idType)
inner join Engineers on Engineers.idEngineer = Repairs.idEngineer)inner join Status on Status.idStatus = Repairs.idStatus)
WHERE CHARINDEX(@SN, Repairs.SN) > 0
end

create Procedure getRepairByOther
@find varchar(40)
as
begin
select Repairs.idRepair as [Номер], Repairs.datetime as [Дата], Clients.nameClient as [Клиент], Clients.contact as [Контакт], Clients.phone as [Телефон]
, (Categories.nameCategory + ' ' + Brands.nameBrand + ' ' + Models.nameModel) as [Изделие], Repairs.SN as [Серийный номер]
, Types.nameType as [Тип ремонта], Repairs.defect as [Дефект], Repairs.kitview as [Комплектность], Engineers.nameEngineer as [Инженер]
, Repairs.result as [Результат], Repairs.price as [Цена], Status.nameStatus as [Статус] 
from (((((((Repairs inner join Clients on Repairs.idClient = Clients.idClient)inner join Models on Repairs.idModel = Models.idModel)inner join Brands
on Models.idBrand = Brands.idBrand)inner join Categories on Categories.idCategory = Models.idCategory)inner join Types on Repairs.idType = Types.idType)
inner join Engineers on Engineers.idEngineer = Repairs.idEngineer)inner join Status on Status.idStatus = Repairs.idStatus)
WHERE CHARINDEX(@find, Clients.nameClient) > 0 or CHARINDEX(@find, Clients.contact) > 0 or CHARINDEX(@find, Clients.phone) > 0 or CHARINDEX(@find, Categories.nameCategory) > 0
or CHARINDEX(@find, Brands.nameBrand) > 0 or CHARINDEX(@find, Models.nameModel) > 0 or CHARINDEX(@find,Types.nameType) > 0 or CHARINDEX(@find, Repairs.defect) > 0
or CHARINDEX(@find, Repairs.kitview) > 0 or CHARINDEX(@find, Engineers.nameEngineer) > 0 or CHARINDEX(@find, Repairs.result) > 0 or CHARINDEX(@find, Status.nameStatus) > 0
end


/*drop Procedure EditModel  
@oldNameModel varchar(60),
@newNameModel varchar(60),
@nameCategory varchar(60),
@nameBrand varchar(60),
@count int output

as
begin
select @count=0
declare @idModel int
declare @idBrand int
declare @idCategory int
--declare @count int

select @idCategory = idCategory
from Categories where nameCategory = @nameCategory

select @idBrand = idBrand
from Brands
where nameBrand = @nameBrand and idCategory = @idCategory

select @idModel = idModel
from Models
where idCategory = @idCategory and idBrand = @idBrand and nameModel = @oldNameModel

select @count = count(idModel)
from Models
where nameModel = @newNameModel and idBrand = @idBrand and idCategory=@idCategory

if(@count=0)
 UPDATE Models SET nameModel = @newNameModel where idModel = @idModel
 select @count=1
end*/

create Procedure EditModel 
@oldNameModel varchar(60),
@newNameModel varchar(60),
@nameCategory varchar(60),
@nameBrand varchar(60)

as
begin
declare @idModel int
declare @idBrand int
declare @idCategory int
declare @count int

select @idCategory = idCategory
from Categories where nameCategory = @nameCategory

select @idBrand = idBrand
from Brands
where nameBrand = @nameBrand and idCategory = @idCategory

select @idModel = idModel
from Models
where idCategory = @idCategory and idBrand = @idBrand and nameModel = @oldNameModel

select @count = count(idModel)
from Models
where nameModel = @newNameModel and idBrand = @idBrand and idCategory=@idCategory

if(@count=0)
 UPDATE Models SET nameModel = @newNameModel where idModel = @idModel
end


create database SC

use SC

CREATE LOGIN user1 WITH PASSWORD = 'user1';

CREATE USER user1 FOR LOGIN user1;  


create table Repairs(idRepair int identity(1,1) not null primary key, 
datetime DateTime, idClient int, idModel int, SN varchar(40), idType int, defect varchar(250), kitview varchar(250), idEngineer int, result varchar(250), price int, idStatus int);

create table Status(idStatus int identity(1,1) not null primary key, nameStatus varchar(40)); 
insert into Status values ('В работе');
insert into Status values ('На согласовании');
insert into Status values ('Ожидает запчастей');
insert into Status values ('На выдаче');
insert into Status values ('Завершен');

--drop table Repairs

create table Categories(idCategory int identity(1,1) not null primary key, nameCategory varchar(40));

create table Brands(idBrand int identity(1,1) not null primary key, nameBrand varchar(40), idCategory int); 

create table Models(idModel int identity(1,1) not null primary key, nameModel varchar(100), idBrand int, idCategory int); 

create table Types(idType int identity(1,1) not null primary key, nameType varchar(40));

create table Engineers(idEngineer int identity(1,1) not null primary key, nameEngineer varchar(40));


create table Clients(idClient int identity(1,1) not null primary key, nameClient varchar(100),
contact varchar(100), phone varchar(100), address varchar(100), email varchar(40)); 

--забить клиентов

insert into Clients values ('ФОП Вертинский Д.В.','Смирнов А.А.','0504789632','Независимой Украины 65','saa@ukr.net');
insert into Clients values ('ФОП Шварценгольд И.З.','Шварценгольд И.З.','0978541269','Складская 4','shyz@ukr.net');
insert into Clients values ('Частное лицо','Стешенко В.В.','0503225879','Кремлевская 45/22','vvs@ukr.net');


insert into Models values ('Chromebook 14-ak013dx (N9E35UA)',1,1);--Add HP notebook
insert into Models values ('Pavilion x2 10-N110CA (N5X74UA)',1,1);

insert into Models values ('Inspiron 3552 (I35C25NIL-R46)',2,1);--Add Dell notebook
insert into Models values ('Inspiron 3542 (I35C25NIW-11)',2,1);

insert into Models values ('IdeaPad MIIX 300 (80NR0042PB)',3,1);--Add Lenovo notebook
insert into Models values ('IdeaPad 110-15 (80TJ009CRA)',3,1);

insert into Models values ('Aspire R 11 R3-131T-C1YF (NX.G10AA.005)',4,1);--Add Acer notebook
insert into Models values ('Switch 10 One S1002-138B (NT.G53EP.004)',4,1);

insert into Models values ('Transformer Book T100TAF (T100TAF-DK001B)',5,1);--Add Asus notebook
insert into Models values ('Chromebook C200 (C200MA-DS01)',5,1);

--Телефоны

insert into Models values ('B110E Dual Sim (Blue)',6,2);--Add Samsung phone
insert into Models values ('J110 Galaxy J1 Duos (White)',6,2);

insert into Models values ('Redmi 2 (Black)',7,2);--Add Xiaomi phone
insert into Models values ('Redmi 3S 2/16GB (Silver)',7,2);

insert into Models values ('M3 16GB (Gold)',8,2);--Add Meizu phone
insert into Models values ('M5 16GB Mint Green',8,2);

insert into Models values ('G360 (Red)',9,2);--Add LG phone
insert into Models values ('K350E K8 LTE Dual Sim (White)',9,2);

insert into Models values ('Xperia M (Purple)',10,2);--Add Sony phone
insert into Models values ('Xperia T2 Ultra Dual D5322 (White)',10,2);


--Планшеты
insert into Models values ('iPad mini Wi-Fi 16 GB Black (MD528, MF432)',11,3);--Add Apple notepad
insert into Models values ('iPad mini 3 Wi-Fi 16GB Silver (MGNV2)',11,3);

insert into Models values ('Mi Pad 2 2/16GB (Gold)',12,3);--Add Xiaomi notepad
insert into Models values ('Mi Pad 2 Windows 2/64GB (Silver)',12,3);

insert into Models values ('MeMO Pad 7 ME375 16Gb WiFi Black (ME375C-1A003A)',13,3);--Add  Asus notepad
insert into Models values ('ZenPad C 7.0 3G 8GB (Z170CG-1C014A) Red',13,3);

insert into Models values ('Talk8 (U27GT-3G)',14,3);--Add CUBE notepad
insert into Models values ('i9 (U122GT2)',14,3);

insert into Models values ('Galaxy Tab 3 Lite 7.0 VE White (SM-T113NDWASEK)',15,3);--Add Samsung notepad
insert into Models values ('Galaxy Tab 4 8.0 16GB Wi-Fi (White) SM-T330NZWA',15,3);

insert into Types values ('Гарантийный');
insert into Types values ('Не гарантийный');
insert into Types values ('Предпродажный');

insert into Engineers values ('Коганов');
insert into Engineers values ('Клименко');
insert into Engineers values ('Тыщенко');
insert into Engineers values ('Вагис');
insert into Engineers values ('Горбачев');

insert into Categories values ('Ноутбук');
insert into Categories values ('Телефон');
insert into Categories values ('Планшет');
insert into Categories values ('Принтер');

insert into Brands values ('HP',1);
insert into Brands values ('Dell',1);
insert into Brands values ('Lenovo',1);
insert into Brands values ('Acer',1);
insert into Brands values ('Asus',1);

insert into Brands values ('Samsung',2);
insert into Brands values ('Xiaomi',2);
insert into Brands values ('Meizu',2);
insert into Brands values ('LG',2);
insert into Brands values ('Sony',2);

insert into Brands values ('Apple',3);
insert into Brands values ('Xiaomi',3);
insert into Brands values ('Asus',3);
insert into Brands values ('CUBE',3);
insert into Brands values ('Samsung',3);

insert into Repairs values (GETDATE(),3,22,'sams12578bntm',2,'Не вкл','Б/У изделие и батарея',1,'Замена дисплея.',750,1);--не гарантия

insert into Repairs values (GETDATE(),1,1,'qwe258nmbvd',1,'Не вкл','Б/У изделие и батарея',2,'Замена MB.',0,4);--гарантия

insert into Repairs values (GETDATE(),2,6,'asd254sddsd',2,'Не вкл','Б/У, только изделие',2,'Ремонт нецелесообразен. Только диагностика',240,2);--не гарантия

insert into Repairs values (GETDATE(),1,29,'zxcde235gbh',3,'Не работает','Полный комплект, как новое',2,'Требуется замена MB.',0,3);--предпродажный



create Procedure getStatusById
@id int
as
begin
select nameStatus from Status where idStatus = @id
end

--Execute getStatusById 1


create Procedure getEngineerById
@id int
as
begin
select nameEngineer from Engineers where idEngineer = @id
end

--Execute getEngineerById 1


create Procedure getTypeRepairById
@id int
as
begin
select nameType from Types where idType = @id
end

--Execute getTypeRepairById 1


create Procedure getNameCategoryByIdModel
@id int
as
declare @idModel int
begin
select @idModel = idCategory from Models where idModel = @id

select nameCategory from Categories where idCategory = @idModel
end

--Execute getNameCategoryByIdModel 22


create Procedure getNameBrandByIdModel
@idModel int
as
declare @id int
begin
select @id = idBrand from Models where idModel = @idModel

select Brands.nameBrand from Brands where idBrand = @id
end

--Execute getNameBrandByIdModel 22

create Procedure getNameModelByIdModel
@id int
as
begin
select nameModel from models where idModel = @id
end

--Execute getNameModelByIdModel 22

create Procedure getNameClientByIdRepair
@id int
as
declare @idClient int
begin
select @idClient = idClient from Repairs where idRepair = @id

select nameClient from Clients where idClient = @idClient
end

--Execute getNameClientByIdRepair 3


create Procedure getIdClientByIdRepair
@id int
as
begin
select idClient from Repairs where idRepair = @id
end

--Execute getIdClientByIdRepair 3

create Procedure getDateByIdRepair
@id int
as
begin
select datetime from Repairs where idRepair = @id
end

--Execute getDateByIdRepair 3


create Procedure getClientById
@id int
as
begin
select nameClient, contact, phone, address, email from Clients where idClient = @id
end

--Execute getClientById 2

create Procedure getRepair
@id int
as
begin
select * from Repairs where idRepair = @id
end

--Execute getRepair 1007

create Procedure getClients
as
begin
select idClient, nameClient, contact, phone, address, email from Clients
end


create Procedure EditRepair
@idRepair int,
@nameClient varchar(60),
@nameCategory varchar(60),
@nameBrand varchar(60),
@nameModel varchar(60),

@SN varchar(60),
@typeRepair varchar(60),
@defect varchar(60),
@kitView varchar(60),
@engineer varchar(60),
@result varchar(60),
@price float,
@statusRepair varchar(60)

as
begin

declare @idCl int

select @idCl = idClient from Clients where nameClient = @nameClient

declare @idCat int

select @idCat = idCategory from Categories where nameCategory = @nameCategory

declare @idBr int

select @idBr = idBrand from Brands where nameBrand = @nameBrand and idCategory = @idCat

declare @idMod int

select @idMod = idModel from Models where nameModel = @nameModel and idCategory = @idCat and idBrand = @idBr

declare @idTy int

select @idTy = idType from Types where nameType = @typeRepair

declare @idEng int

select @idEng = idEngineer from Engineers where nameEngineer = @engineer

declare @idStat int

select @idStat = idStatus from Status where nameStatus = @statusRepair

declare @count int

 UPDATE Repairs
SET idClient = @idCl, idModel = @idMod, SN = @SN, idType = @idTy, defect = @defect, kitView=@kitView, idEngineer = @idEng, result = @result, price = @price, idStatus = @idStat
where idRepair = @idRepair

end


create Procedure EditClient
@oldNameClient varchar(60),
@newNameClient varchar(60),
@contact varchar(60),
@phone varchar(60),
@address varchar(60),
@email varchar(60)
as
begin
declare @id int
declare @count int

select @id = idClient
from Clients where nameClient = @oldNameClient

 UPDATE Clients
                 SET nameClient = @newNameClient, contact = @contact, phone = @phone, address = @address, email = @email
				 where idClient = @id
end


create Procedure AddRepair
@nameClient varchar(60),
@nameCategory varchar(60),
@nameBrand varchar(60),
@nameModel varchar(60),

@SN varchar(60),
@typeRepair varchar(60),
@defect varchar(60),
@kitView varchar(60),
@engineer varchar(60),
@result varchar(60),
@price float,
@statusRepair varchar(60)

as
begin

declare @idCl int

select @idCl = idClient from Clients where nameClient = @nameClient

declare @idCat int

select @idCat = idCategory from Categories where nameCategory = @nameCategory

declare @idBr int

select @idBr = idBrand from Brands where nameBrand = @nameBrand and idCategory = @idCat

declare @idMod int

select @idMod = idModel from Models where nameModel = @nameModel and idCategory = @idCat and idBrand = @idBr

declare @idTy int

select @idTy = idType from Types where nameType = @typeRepair

declare @idEng int

select @idEng = idEngineer from Engineers where nameEngineer = @engineer

declare @idStat int

select @idStat = idStatus from Status where nameStatus = @statusRepair

declare @count int

select @count = count(idClient)
from Repairs

where idModel = @idMod and SN = @SN and idStatus = @idStat


if(@count=0)
insert into Repairs values (GETDATE(),@idCl, @idMod, @SN, @idTy, @defect, @kitView, @idEng, @result, @price, @idStat)
end


create Procedure AddClient
@nameClient varchar(60),
@contact varchar(60),
@phone varchar(60),
@address varchar(60),
@email varchar(60)
as
begin
declare @count int

select @count = count(idClient)
from Clients
where nameClient = @nameClient and contact = @contact and phone = @phone and address = @address and email = @email

if(@count=0)
insert into Clients values (@nameClient, @contact, @phone, @address, @email)
end

--Execute AddClient 'Частное лицо', 'Третяк Остап Александрович','0503225879','Кремлевская 45/22','vvs@ukr.net'


create Procedure getBrandsByCategory
@nameCategory varchar(40)
as
begin
declare @idCat int

select  @idCat = idCategory from Categories where nameCategory = @nameCategory

select  nameBrand from Brands where idCategory = @idCat
end

create Procedure getBrandsByCategoryAll
@nameCategory varchar(40)
as
begin
declare @idCat int

select  @idCat = idCategory from Categories where nameCategory = @nameCategory

select  * from Brands where idCategory = @idCat
end

create Procedure getModelByCategoryAndBrand
@nameCategory varchar(40),
@nameBrand varchar(40)
as
begin
declare @idCat int
declare @idBra int

select  @idCat = idCategory from Categories where nameCategory = @nameCategory

select  @idBra = idBrand from Brands where nameBrand = @nameBrand and idCategory = @idCat

select  nameModel from Models where idBrand = @idBra and idCategory = @idCat

end

--Execute getModelByCategoryAndBrand 'Телефон', 'Samsung'


create Procedure getModelByCategoryAndBrandAll
@nameCategory varchar(40),
@nameBrand varchar(40)
as
begin
declare @idCat int
declare @idBra int

select  @idCat = idCategory from Categories where nameCategory = @nameCategory

select  @idBra = idBrand from Brands where nameBrand = @nameBrand and idCategory = @idCat

select  * from Models where idBrand = @idBra and idCategory = @idCat

end


create Procedure getRepair
@id int
as
select * from Repairs where idRepair = @id

create Procedure getEngineers
as
select nameEngineer from Engineers

create Procedure getEngineersAll
as
select * from Engineers

create Procedure getStatus
as
select nameStatus from Status

create Procedure getStatusAll
as
select * from Status

create Procedure getTypes
as
select nameType from Types

create Procedure getTypesAll
as
select * from Types

create Procedure getBrands
as
begin
select nameBrand from Brands
end

--Execute getBrands 


create Procedure EditBrand
@oldNameBrand varchar(60),
@oldNameCategory varchar(60),
@newNameBrand varchar(60),
@newNameCategory varchar(60)
as
begin
declare @id int
declare @newId int

select @id = idCategory
from Categories
where nameCategory = @oldNameCategory

select @newId = idCategory
from Categories
where nameCategory = @newNameCategory

 UPDATE Brands
                 SET nameBrand = @newNameBrand, idCategory = @newId
				 where nameBrand = @oldNameBrand and idCategory = @id
end

--Execute EditBrand 'Xiaomi','Телефон','XiaomiCool','Планшет'


create Procedure getAllBrandsWithCategories
as
select Brands.nameBrand as [Brand], Categories.nameCategory as [Category]
from Brands inner join Categories on Brands.idCategory = Categories.idCategory

--Execute getAllBrendsWithCategories

create Procedure AddBrand
@nameBrand varchar(60),
@nameCategory varchar(60)
as
begin
declare @count int
declare @id int

select @id = idCategory
from Categories
where nameCategory = @nameCategory

select @count = count(idBrand)
from Brands
where nameBrand = @nameBrand and idCategory=@id

if(@count=0)
insert into Brands values (@nameBrand, @id)
end

--Execute AddBrand 'Panasonic','Телефон'


create Procedure AddModel
@nameModel varchar(60),
@nameBrand varchar(60),
@nameCategory varchar(60)
as
begin
declare @count int
declare @idCategory int
declare @idBrand int

select @idCategory = idCategory
from Categories
where nameCategory = @nameCategory

select @idBrand = idBrand
from Brands
where nameBrand = @nameBrand and idCategory = @idCategory

select @count = count(idModel)
from Models
where nameModel = @nameModel and idBrand = @idBrand and idCategory=@idCategory

if(@count=0)
insert into Models values (@nameModel, @idBrand, @idCategory)
end

--Execute AddModel 'Xperia Z1','Sony','Телефон'


create Procedure ShowRepairsNotFinish
as
begin
select Repairs.idRepair as [Номер], Repairs.datetime as [Дата], Clients.nameClient as [Клиент], Clients.contact as [Контакт], Clients.phone as [Телефон]
, (Categories.nameCategory + ' ' + Brands.nameBrand + ' ' + Models.nameModel) as [Изделие], Repairs.SN as [Серийный номер]
, Types.nameType as [Тип ремонта], Repairs.defect as [Дефект], Repairs.kitview as [Комплектность], Engineers.nameEngineer as [Инженер]
, Repairs.result as [Результат], Repairs.price as [Цена], Status.nameStatus as [Статус] 
from (((((((Repairs inner join Clients on Repairs.idClient = Clients.idClient)inner join Models on Repairs.idModel = Models.idModel)inner join Brands
on Models.idBrand = Brands.idBrand)inner join Categories on Categories.idCategory = Models.idCategory)inner join Types on Repairs.idType = Types.idType)
inner join Engineers on Engineers.idEngineer = Repairs.idEngineer)inner join Status on Status.idStatus = Repairs.idStatus)
where Status.nameStatus<>'Завершен'
end

Execute ShowRepairsNotFinish


create Procedure ShowRepairByNameClient
@nameClient varchar(60)
as
begin
select Repairs.idRepair as [Номер], Repairs.datetime as [Дата], Clients.nameClient as [Клиент], Clients.contact as [Контакт], Clients.phone as [Телефон]
, (Categories.nameCategory + ' ' + Brands.nameBrand + ' ' + Models.nameModel) as [Изделие], Repairs.SN as [Серийный номер]
, Types.nameType as [Тип ремонта], Repairs.defect as [Дефект], Repairs.kitview as [Комплектность], Engineers.nameEngineer as [Инженер]
, Repairs.result as [Результат], Repairs.price as [Цена], Status.nameStatus as [Статус] 
from (((((((Repairs inner join Clients on Repairs.idClient = Clients.idClient)inner join Models on Repairs.idModel = Models.idModel)inner join Brands
on Models.idBrand = Brands.idBrand)inner join Categories on Categories.idCategory = Models.idCategory)inner join Types on Repairs.idType = Types.idType)
inner join Engineers on Engineers.idEngineer = Repairs.idEngineer)inner join Status on Status.idStatus = Repairs.idStatus)
where Clients.nameClient = @nameClient
end

--Execute ShowRepairByNameClient 'ФОП Вертинский Д.В.'


create Procedure getRepairByNumber
@number int
as
begin
select Repairs.idRepair as [Номер], Repairs.datetime as [Дата], Clients.nameClient as [Клиент], Clients.contact as [Контакт], Clients.phone as [Телефон]
, (Categories.nameCategory + ' ' + Brands.nameBrand + ' ' + Models.nameModel) as [Изделие], Repairs.SN as [Серийный номер]
, Types.nameType as [Тип ремонта], Repairs.defect as [Дефект], Repairs.kitview as [Комплектность], Engineers.nameEngineer as [Инженер]
, Repairs.result as [Результат], Repairs.price as [Цена], Status.nameStatus as [Статус] 
from (((((((Repairs inner join Clients on Repairs.idClient = Clients.idClient)inner join Models on Repairs.idModel = Models.idModel)inner join Brands
on Models.idBrand = Brands.idBrand)inner join Categories on Categories.idCategory = Models.idCategory)inner join Types on Repairs.idType = Types.idType)
inner join Engineers on Engineers.idEngineer = Repairs.idEngineer)inner join Status on Status.idStatus = Repairs.idStatus)
where Repairs.idRepair = @number
end

--Execute getRepairByNumber 3

create Procedure getAllRepairs
as
begin
select Repairs.idRepair as [Номер], Repairs.datetime as [Дата], Clients.nameClient as [Клиент], Clients.contact as [Контакт], Clients.phone as [Телефон]
, (Categories.nameCategory + ' ' + Brands.nameBrand + ' ' + Models.nameModel) as [Изделие], Repairs.SN as [Серийный номер]
, Types.nameType as [Тип ремонта], Repairs.defect as [Дефект], Repairs.kitview as [Комплектность], Engineers.nameEngineer as [Инженер]
, Repairs.result as [Результат], Repairs.price as [Цена], Status.nameStatus as [Статус] 
from (((((((Repairs inner join Clients on Repairs.idClient = Clients.idClient)inner join Models on Repairs.idModel = Models.idModel)inner join Brands
on Models.idBrand = Brands.idBrand)inner join Categories on Categories.idCategory = Models.idCategory)inner join Types on Repairs.idType = Types.idType)
inner join Engineers on Engineers.idEngineer = Repairs.idEngineer)inner join Status on Status.idStatus = Repairs.idStatus)
end

--Execute getAllRepairs
			

create Procedure ShowRepairsByType
@type varchar(60)
as
begin
select Repairs.idRepair as [Номер], Repairs.datetime as [Дата], Clients.nameClient as [Клиент], Clients.contact as [Контакт], Clients.phone as [Телефон]
, (Categories.nameCategory + ' ' + Brands.nameBrand + ' ' + Models.nameModel) as [Изделие], Repairs.SN as [Серийный номер]
, Types.nameType as [Тип ремонта], Repairs.defect as [Дефект], Repairs.kitview as [Комплектность], Engineers.nameEngineer as [Инженер]
, Repairs.result as [Результат], Repairs.price as [Цена] 
from ((((((Repairs inner join Clients on Repairs.idClient = Clients.idClient)inner join Models on Repairs.idModel = Models.idModel)inner join Brands
on Models.idBrand = Brands.idBrand)inner join Categories on Categories.idCategory = Models.idCategory)inner join Types on Repairs.idType = Types.idType)
inner join Engineers on Engineers.idEngineer = Repairs.idEngineer)
where Types.nameType = @type
end

--Execute ShowRepairsByType 'Не гарантийный'




--select * from Repairs where Repairs.idType <>-1


create Procedure AddCategory
@name varchar(60)
as
begin
declare @count int

select @count = count(idCategory)
from Categories
where nameCategory = @name

if(@count=0)
insert into Categories values (@name)
end

--Execute AddCategory 'Монитор'

create Procedure EditCategory
@oldname varchar(60),
@newname varchar(60)
as
begin
 UPDATE Categories
                 SET nameCategory = @newname
				 where nameCategory = @oldname
end

--Execute EditCategory 'Принтер','МФУ'

create Procedure getCategories
as
begin
select Categories.nameCategory from Categories
end

--Execute getCategories 

create Procedure getCategoriesAll
as
begin
select * from Categories
end
--Execute getCategoriesAll

create Procedure AddUser
@login varchar(60),
@password int,
@address varchar(60),
@phone varchar(60),
@admin bit
as
begin
declare @count int

select @count = count(idUser)
from Users 
where login = @login

if(@count=0)
insert into Users values
(@login, @password, @address, @phone, @admin)
end

--Execute AddUser 'user01','101','Ukraine','+380502568741',0;


create Procedure EditUser
@login varchar(60),
@newlogin varchar(60),
@password int,
@address varchar(60),
@phone varchar(60),
@admin bit
as
begin

 UPDATE Users
                 SET login = @newlogin, password = @password, address = @address, phone = @phone, admin = @admin
                 WHERE login = @login;
end



--Execute EditUser 'user01','user011','102','USA','+380679854236' ,1


create Procedure DeleteUser
@login varchar(60)
as
DELETE FROM Users
WHERE login = @login

--Execute DeleteUser 'user011'
