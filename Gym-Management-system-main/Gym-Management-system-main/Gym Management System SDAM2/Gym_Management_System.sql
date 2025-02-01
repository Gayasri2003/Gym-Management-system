USE [master]
GO
/****** Object:  Database [Gym_Management_System_SDAM2]    Script Date: 1/29/2025 4:45:03 PM ******/
CREATE DATABASE [Gym_Management_System_SDAM2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gym_Management_System_SDAM2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Gym_Management_System_SDAM2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gym_Management_System_SDAM2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Gym_Management_System_SDAM2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gym_Management_System_SDAM2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET  MULTI_USER 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET QUERY_STORE = ON
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Gym_Management_System_SDAM2]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 1/29/2025 4:45:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[MembershipStartDate] [date] NOT NULL,
	[MembershipType] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trainers]    Script Date: 1/29/2025 4:45:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trainers](
	[TrainerID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Specialization] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TrainerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 1/29/2025 4:45:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[ContactNumber] [nvarchar](15) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[PasswordHash] [nvarchar](255) NOT NULL,
	[Role] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Members]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Trainers]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Gender]='Female' OR [Gender]='Male'))
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD CHECK  (([Role]='Member' OR [Role]='Trainer'))
GO
USE [master]
GO
ALTER DATABASE [Gym_Management_System_SDAM2] SET  READ_WRITE 
GO

USE [Gym_Management_System_SDAM2]
GO

CREATE TABLE [dbo].[TrainerClass](
	[ClassID] [nvarchar](50) NOT NULL,
	[ClassDate] [nvarchar](50) NOT NULL,
	[ClassLocation] [nvarchar](50) NOT NULL,
	[ClassTime] [time] NOT NULL,
	[ClassType] [nvarchar](50) NOT NULL,
);

INSERT INTO TrainerClass(ClassID, ClassDate, ClassLocation, ClassTime, ClassType)VALUES('PG021','Monday', 'Floor 2 - Room 4','10:45:00','Cardio')
INSERT INTO TrainerClass(ClassID, ClassDate, ClassLocation, ClassTime, ClassType)VALUES('PG067','Wednesday', 'Floor 1 - Room 1','09:30:00','Yoga')
INSERT INTO TrainerClass(ClassID, ClassDate, ClassLocation, ClassTime, ClassType)VALUES('PG023','Saturday', 'Floor 3 - Room 1','13:00:00','Aerobics')
INSERT INTO TrainerClass(ClassID, ClassDate, ClassLocation, ClassTime, ClassType)VALUES('PG019','Friday', 'Floor 2 - Room 2','10:30:00','Stretching')

SELECT * FROM TrainerClass;


	


