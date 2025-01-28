CREATE DATABASE TrainerClass;

USE TrainerClass;

CREATE TABLE TrainerClasss(
	ClassID NVARCHAR(5) PRIMARY KEY,
	ClassDate NVARCHAR(10),
	ClassTime TIME,
	ClassLocation NVARCHAR(20),
	ClassType NVARCHAR(15)
);

INSERT INTO TrainerClasss(ClassID, ClassDate, ClassLocation, ClassTime, ClassType)VALUES('PG021','Monday', 'Floor 2 - Room 4','10:45:00','Cardio')
INSERT INTO TrainerClasss(ClassID, ClassDate, ClassLocation, ClassTime, ClassType)VALUES('PG067','Wednesday', 'Floor 1 - Room 1','09:30:00','Yoga')
INSERT INTO TrainerClasss(ClassID, ClassDate, ClassLocation, ClassTime, ClassType)VALUES('PG023','Saturday', 'Floor 3 - Room 1','13:00:00','Aerobics')
INSERT INTO TrainerClasss(ClassID, ClassDate, ClassLocation, ClassTime, ClassType)VALUES('PG019','Friday', 'Floor 2 - Room 2','10:30:00','Stretching')

SELECT * FROM TrainerClasss;