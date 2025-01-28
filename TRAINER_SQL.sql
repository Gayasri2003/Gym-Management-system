CREATE DATABASE Trainer;

USE Trainer;

CREATE TABLE Trainer(
    TrainerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(10),
    LastName NVARCHAR(20),
    DateOfBirth DATE,
    ContactNumber NVARCHAR(15),
    City NVARCHAR(20),
    Gender NVARCHAR(10),
    Role NVARCHAR(10),
    Username NVARCHAR(10),
    Password NVARCHAR(10)
);

INSERT INTO Trainer(FirstName, LastName, DateOfBirth, City, ContactNumber, Gender)VALUES('John','Phillips','1990-05-15','New York','0776219928','Male');
INSERT INTO Trainer(FirstName, LastName, DateOfBirth, City, ContactNumber, Gender)VALUES('Alex','Warner','1997-01-25','Queens','0718829754','Male');
INSERT INTO Trainer(FirstName, LastName, DateOfBirth, City, ContactNumber, Gender)VALUES('Michelle','Robbie','1992-09-13','Washington','0766233488','Female');
INSERT INTO Trainer(FirstName, LastName, DateOfBirth, City, ContactNumber, Gender)VALUES('Anna','Darren','1993-11-08','Queens','0778817610','Femle');
INSERT INTO Trainer(FirstName, LastName, DateOfBirth, City, ContactNumber, Gender)VALUES('Fred','Aspen','1997-08-31','Chicago','0718890274','Male');


SELECT * FROM Trainer;