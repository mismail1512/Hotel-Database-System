-------------Database creation-------------
CREATE DATABASE Hotel

GO
--use Hotel

------------Table Creation-----------------
CREATE TABLE AllServices
(
Kind int not null,
AID int not null,
primary key (AID),
)

create table users
(
mail varchar(100) not null,
username varchar(50) not null,
PASS varchar(50) not null,
ty varchar(50),
primary key (mail),
)

create table Staff
(
S_Name varchar(50)not null,
S_ID int not null,
NID int not null,
Birth date,
Salary int,
Department varchar(50),
Sex varchar(50),
W_Shift char(1),
SWD date,
EWD date,
City varchar(50),
primary key (S_ID),
)



create table Reservation
(
RVID int not null,
TypeR int,
nDays int,
Avl1 int,
Avl2 int,
Avl3 int,
primary key (RVID),
)

ALTER TABLE Reservation ALTER COLUMN TypeR varchar(50);

create table Gym
(
GID int not null,
nHours int,
No# int,
primary key (GID),
)


ALTER TABLE Gym ALTER COLUMN nHours varchar(50);


create table Restaurant
(
RSID int not null,
TypeT varchar(50),
No# int,
Orders varchar(200),
T_Price int,
TypeF varchar(50),
primary key (RSID),
)


create table Menu
(
Nam varchar(50) not null,
Price int,
Typ varchar(50),
primary key (Nam),
)


create table Guests
(
G_Name varchar(50)not null,
G_ID int not null,
NID int,
Sex varchar(50),
Birth date,
City varchar(50),
primary key (G_ID),
)


create table Finance
(
FID int not null,
Descriptions varchar(50),
In_OR_Out char(1),
Amount int,
primary key (FID),
)

create table Dependant
(
S_ID int,
Nam varchar(50),
sex varchar(50),
Bth date,
Relation varchar(50),
Primary key (S_ID,Nam),
foreign key (S_ID) references staff,
)


create table S_phones
(
S_ID int not null,
S_phone int,
primary key(S_ID, S_phone),
foreign key (S_ID) references Staff,
)

create table G_phones
(
G_ID int not null,
G_phone int,
primary key(G_ID,G_phone),
foreign key (G_ID) references Guests,
)
create table Offer
(
RID int,
MName varchar(50),
primary key(RID,MName),
foreign key (RID) references Restaurant,
foreign key (MName) references Menu,
)

create table Outcome
(
S_ID int,
FID int,
primary key(FID,S_ID),
foreign key (FID) references Finance,
foreign key (S_ID) references Staff,
)
create table Booking_Room
(
RRID int,
GID int,
FID int,
Fromdate date,
todate date,
Primary key (RRID,FID,GID),
foreign key (GID) references Guests,
foreign key (FID) references Finance,
foreign key (RRID) references Reservation,
)
create table Training
(
GYID int,
GID int,
FID int,
Dat date,
Primary key (GYID,FID,GID),
foreign key (GID) references Guests,
foreign key (FID) references Finance,
foreign key (GYID) references Gym,
)

create table Requesting_meal
(
RID int,
GID int,
FID int,
Dat date,
Primary key (RID,FID,GID),
foreign key (GID) references Guests,
foreign key (FID) references Finance,
foreign key (RID) references Restaurant,
)

create table CurrentOrder
(
servic varchar(50) PRIMARY KEY ,
price int 
)

