CREATE TABLE Member(
    MemberID INT PRIMARY KEY IDENTITY(1,1),
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

SELECT*FROM Member
SELECT*FROM Trainer