CREATE DATABASE GymDatabase;

USE GymDatabase;

CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    ContactNumber NVARCHAR(15) NOT NULL,
    City NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female')) NOT NULL,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Role NVARCHAR(10) CHECK (Role IN ('Trainer', 'Member')) NOT NULL,
);

CREATE TABLE Members (
    MemberID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT UNIQUE NOT NULL,
    MembershipStartDate DATE NULL,
    MembershipType NVARCHAR(50)  NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);

CREATE TABLE Trainers (
    TrainerID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT UNIQUE NOT NULL,
    Specialization NVARCHAR(100) NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);


SELECT u.*, m.MembershipStartDate, m.MembershipType
FROM Users u
JOIN Members m ON u.UserID = m.UserID;

EXEC sp_rename 'Users.PasswordHash', 'Password', 'COLUMN';

SELECT u.*, t.Specialization
FROM Users u
JOIN Trainers t ON u.UserID = t.UserID;

SELECT * FROM Users;
SELECT * FROM Members;
SELECT * FROM Trainers;

CREATE TABLE Classes(
ClassID INT IDENTITY(1, 1) PRIMARY KEY,
ClassName NVARCHAR(100) NOT NULL,
Instructor NVARCHAR(100)NOT NULL,
Schedule NVARCHAR(100)NOT NULL,
Available BIT NOT NULL DEFAULT 1);

INSERT INTO Classes(ClassName, Instructor,Schedule,Available)
VALUES ('Cardio', 'John Doe', 'Monday & Wednesday - 6:00 PM', 1);

INSERT INTO Classes(ClassName, Instructor,Schedule,Available)
VALUES('Yoga', 'Jane Smith', 'Tuesday & Thursday - 7:00 AM', 1);

INSERT INTO Classes(ClassName, Instructor,Schedule,Available)
VALUES('Aerobics', 'Emily Johnson', 'Friday - 5:30 PM', 1);

INSERT INTO Classes(ClassName, Instructor,Schedule,Available)
VALUES('Strength Training', 'Michael Brown', 'Saturday - 10:00 AM', 1);

CREATE TABLE MemberClasses (
    MemberID INT,
    ClassID INT,
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID)  ON DELETE CASCADE,
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)  ON DELETE CASCADE,
    PRIMARY KEY (MemberID, ClassID)
);

SELECT*FROM MemberClasses


CREATE TABLE Attendance (
    AttendanceId INT IDENTITY(1,1) PRIMARY KEY,
    MemberId INT NOT NULL,
    Date DATE NOT NULL DEFAULT GETDATE(),
    IsPresent BIT NOT NULL,
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);
ALTER TABLE Attendance ADD UserID INT NULL;

SELECT A.AttendanceId, A.Date, A.IsPresent, M.Username
FROM Attendance A
JOIN Members M ON A.MemberID = M.MemberID
JOIN Users U ON M.UserID = U.UserID 
WHERE U.Username = @username
ORDER BY A.Date DESC;

SELECT*FROM Attendance

CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
	Username VARCHAR(100) NOT NULL,
    Amount DECIMAL(10,2),
    PaymentDate DATETIME,
    PaymentMethod VARCHAR(50));
	ALTER TABLE Payments DROP CONSTRAINT [FK_Payments_Users];
    ALTER TABLE Payments ADD UserID INT NOT NULL;

    ALTER TABLE Payments
	ADD FOREIGN KEY (UserID) REFERENCES Users(UserID);
	UPDATE Payments
SET UserID = (SELECT UserID FROM Users WHERE Users.Username = Payments.Username);
ALTER TABLE Payments DROP COLUMN Username;

SELECT p.PaymentID, u.Username, p.Amount, p.PaymentDate, p.PaymentMethod
FROM Payments p
INNER JOIN Users u ON p.UserID = u.UserID
WHERE p.UserID = @UserID
ORDER BY p.PaymentDate DESC;
DECLARE @UserID INT = 1; 

SELECT * FROM Payments WHERE UserID = @UserID;

SELECT*FROM Payments


SELECT COLUMN_NAME 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Payments';