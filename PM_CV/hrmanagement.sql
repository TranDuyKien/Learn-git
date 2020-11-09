create database HRManagement;
use HRManagement;

create table Category(
Id int not null primary key auto_increment,
Name nvarchar(256) not null,
OrderIndex int not null,
Status bit not null default(1),
CreatedAt date not null default(CURRENT_DATE),
CreatedBy nvarchar(256) not null,
UpdatedAt date not null default(CURRENT_DATE),
UpdatedBy nvarchar(256) null null
);

create table Technology(
Id int not null primary key auto_increment,
Name nvarchar(256) not null,
CategoryId int not null,
Status bit not null default(1),
CreatedAt date not null default(CURRENT_DATE),
CreatedBy nvarchar(256) not null,
UpdatedAt date not null default(CURRENT_DATE),
UpdatedBy nvarchar(256) null null
);
ALTER TABLE Technology ADD CONSTRAINT fk_Technology_Category FOREIGN KEY (CategoryId) REFERENCES Category(Id);

create table Person(
Id int not null primary key auto_increment,
StaffId char(20) not null,
FullName nvarchar(256) not null,
Email nvarchar(256) not null,
Location int not null,
Avatar varchar(500) not null,
Description nvarchar(10000) not null,
Phone char(15) not null,
YearOfBirth date not null,
Gender int not null,
Status bit not null default(1),
CreatedAt date not null default(CURRENT_DATE),
CreatedBy nvarchar(256) not null,
UpdatedAt date not null default(CURRENT_DATE),
UpdatedBy nvarchar(256) null null
);
create table PersonTechnology(
Id int not null primary key auto_increment,
PersonId int not null,
TechnologyId int not null,
Status bit not null default(1),
CreatedAt date not null default(CURRENT_DATE),
CreatedBy nvarchar(256) not null,
UpdatedAt date not null default(CURRENT_DATE),
UpdatedBy nvarchar(256) null null
);
ALTER TABLE PersonTechnology ADD CONSTRAINT fk_PersonTechnology_Person FOREIGN KEY (PersonId) REFERENCES Person(Id);
ALTER TABLE PersonTechnology ADD CONSTRAINT fk_PersonTechnology_Technology FOREIGN KEY (TechnologyId) REFERENCES Technology(Id);

create table Project(
Id int not null primary key auto_increment,
Name nvarchar(256) not null,
Position nvarchar(256) not null,
Responsibilities nvarchar(256) not null,
TeamSize int not null,
OrderIndex int not null,
StartDate date not null,
EndDate date,
PersonId int not null,
Status bit not null default(1),
CreatedAt date not null default(CURRENT_DATE),
CreatedBy nvarchar(256) not null,
UpdatedAt date not null default(CURRENT_DATE),
UpdatedBy nvarchar(256) null null
);
ALTER TABLE Project ADD CONSTRAINT fk_Project_Person FOREIGN KEY (PersonId) REFERENCES Person(Id);

create table ProjectTechnology(
Id int not null primary key auto_increment,
ProjectId int not null,
TechnologyId int not null,
Status bit not null default(1),
CreatedAt date not null default(CURRENT_DATE),
CreatedBy nvarchar(256) not null,
UpdatedAt date not null default(CURRENT_DATE),
UpdatedBy nvarchar(256) null null
);
ALTER TABLE ProjectTechnology ADD CONSTRAINT fk_ProjectTechnology_Project FOREIGN KEY (ProjectId) REFERENCES Project(Id);
ALTER TABLE ProjectTechnology ADD CONSTRAINT fk_ProjectTechnology_Technology FOREIGN KEY (TechnologyId) REFERENCES Technology(Id);

create table Certificate(
Id int not null primary key auto_increment,
Name nvarchar(256) not null,
Provider nvarchar(256) not null,
OrderIndex int not null,
StartDate date not null,
EndDate date,
PersonId int not null,
Status bit not null default(1),
CreatedAt date not null default(CURRENT_DATE),
CreatedBy nvarchar(256) not null,
UpdatedAt date not null default(CURRENT_DATE),
UpdatedBy nvarchar(256) null null
);
ALTER TABLE Certificate ADD CONSTRAINT fk_Certificate_Person FOREIGN KEY (PersonId) REFERENCES Person(Id);

create table Education(
Id int not null primary key auto_increment,
CollegeName nvarchar(256) not null,
Major nvarchar(256) not null,
OrderIndex int not null,
StartDate date not null,
EndDate date,
PersonId int not null,
Status bit not null default(1),
CreatedAt date not null default(CURRENT_DATE),
CreatedBy nvarchar(256) not null,
UpdatedAt date not null default(CURRENT_DATE),
UpdatedBy nvarchar(256) null null
);
ALTER TABLE Education ADD CONSTRAINT fk_Education_Person FOREIGN KEY (PersonId) REFERENCES Person(Id);

create table WorkHistory(
Id int not null primary key auto_increment,
Position nvarchar(256) not null,
CompanyName nvarchar(256) not null,
OrderIndex int not null,
StartDate date not null,
EndDate date,
PersonId int not null,
Status bit not null default(1),
CreatedAt date not null default(CURRENT_DATE),
CreatedBy nvarchar(256) not null,
UpdatedAt date not null default(CURRENT_DATE),
UpdatedBy nvarchar(256) null null
);
ALTER TABLE WorkHistory ADD CONSTRAINT fk_WorkHistory_Person FOREIGN KEY (PersonId) REFERENCES Person(Id);


insert into Person(StaffId, FullName, Email, Location, Avatar, Description, Phone, YearOfBirth, Gender, CreatedBy, UpdatedBy)
values("201109001", "Án Dạ La", "laad@gmail.com", 1, "avataradl.jpg", "This is Description", "0123456789", "2020-11-09", 1, "anhnh", "anhnh");
insert into Person(StaffId, FullName, Email, Location, Avatar, Description, Phone, YearOfBirth, Gender, CreatedBy, UpdatedBy)
values("201109001", "Liệt Như Ca", "canl@gmail.com", 1, "avatarlnc.jpg", "This is Description", "0987654321", "2020-11-09", 2, "anhnh", "anhnh");

insert into Category(Name, OrderIndex, CreatedBy, UpdatedBy)
values("Backend", 1, "anhnh", "anhnh");
insert into Category(Name, OrderIndex, CreatedBy, UpdatedBy)
values("Frontend", 2, "anhnh", "anhnh");
insert into Category(Name, OrderIndex, CreatedBy, UpdatedBy)
values("Database", 3, "anhnh", "anhnh");

insert into Technology(Name, CategoryId, CreatedBy, UpdatedBy)
values("Java", 1, "anhnh", "anhnh");
insert into Technology(Name, CategoryId, CreatedBy, UpdatedBy)
values("C#", 1, "anhnh", "anhnh");
insert into Technology(Name, CategoryId, CreatedBy, UpdatedBy)
values("PHP", 1, "anhnh", "anhnh");
insert into Technology(Name, CategoryId, CreatedBy, UpdatedBy)
values("Vuejs", 2, "anhnh", "anhnh");
insert into Technology(Name, CategoryId, CreatedBy, UpdatedBy)
values("Angularjs", 2, "anhnh", "anhnh");
insert into Technology(Name, CategoryId, CreatedBy, UpdatedBy)
values("Reactjs", 2, "anhnh", "anhnh");
insert into Technology(Name, CategoryId, CreatedBy, UpdatedBy)
values("MySQL", 3, "anhnh", "anhnh");
insert into Technology(Name, CategoryId, CreatedBy, UpdatedBy)
values("MSSQL", 2, "anhnh", "anhnh");

insert into PersonTechnology(PersonId, TechnologyId, CreatedBy, UpdatedBy)
values(1, 1, "anhnh", "anhnh");
insert into PersonTechnology(PersonId, TechnologyId, CreatedBy, UpdatedBy)
values(1, 2, "anhnh", "anhnh");
insert into PersonTechnology(PersonId, TechnologyId, CreatedBy, UpdatedBy)
values(1, 4, "anhnh", "anhnh");
insert into PersonTechnology(PersonId, TechnologyId, CreatedBy, UpdatedBy)
values(1, 8, "anhnh", "anhnh");

insert into PersonTechnology(PersonId, TechnologyId, CreatedBy, UpdatedBy)
values(2, 3, "anhnh", "anhnh");
insert into PersonTechnology(PersonId, TechnologyId, CreatedBy, UpdatedBy)
values(1, 5, "anhnh", "anhnh");
insert into PersonTechnology(PersonId, TechnologyId, CreatedBy, UpdatedBy)
values(1, 7, "anhnh", "anhnh");