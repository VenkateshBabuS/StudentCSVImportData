create database studentdata

use studentdata

create table student
(
ExternalStudentID int primary key,
FirstName nvarchar(50),
LastName nvarchar(50),
DOB nvarchar(50),
SSN int ,
Address varchar(50),
City nvarchar(50),
State nvarchar(50),
Email nvarchar(50),
MaritalStatus nvarchar(50))

select*from student

create table Attendance
(
ExternalStudentID int ,
AttendanceDate date,
Status nvarchar(50))

select*from Attendance





