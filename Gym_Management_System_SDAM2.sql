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