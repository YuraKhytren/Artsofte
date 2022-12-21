USE [ArtSofteDB]

CREATE TABLE Employers(
Id int IDENTITY(1,1) primary key not null,
Name varchar(50),
SurName varchar(50),
Age int,
Gender varchar(10),
Department int,
Language int,
Created datetime,
Changed datetime
)

CREATE TABLE Department(
Id int IDENTITY(1,1) primary key not null,
Name varchar(50),
Floor int
)

CREATE TABLE Languages(
Id int IDENTITY(1,1) primary key not null,
Name varchar(50)
)

CREATE TABLE Logs(
Id int IDENTITY(1,1) primary key not null,
OperationId varchar(100),
ErrorMessage varchar(1000),
StackTrace varchar(2000),
Created datetime
)