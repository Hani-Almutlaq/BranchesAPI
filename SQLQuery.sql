CREATE DATABASE Branches;

USE Branches;

-- Create the Branches table
CREATE TABLE Branches (
    BranchId INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

-- Create the Schedule table
CREATE TABLE Schedule (
    ScheduleId INT PRIMARY KEY,
    BranchId INT NOT NULL,
    Sunday NVARCHAR(100) NULL,
    Monday NVARCHAR(100) NULL,
    Tuesday NVARCHAR(100) NULL,
    Wednesday NVARCHAR(100) NULL,
    Thursday NVARCHAR(100) NULL,
    Friday NVARCHAR(100) NULL,
    Saturday NVARCHAR(100) NULL,
    FOREIGN KEY (BranchId) REFERENCES Branches(BranchId)
);

-- Adding dummy data

INSERT INTO Branches (Id, Name) VALUES (1, 'BranchA');

INSERT INTO Branches (Id, Name) VALUES (2, 'BranchB');

INSERT INTO Schedule (
	ScheduleId, 
	BranchId, 
	Sunday,
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday
	) 
VALUES (
	1, 
	1,
	'8:00 - 17:00',
	'8:00 - 17:00',
	'8:00 - 17:00',
	'8:00 - 17:00',
	'8:00 - 17:00',
	NULL,
	NULL
	);

INSERT INTO Schedule (
	ScheduleId, 
	BranchId, 
	Sunday,
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday,
	Saturday
	) 
VALUES (
	2, 
	2,
	'10:00 - 18:00',
	'10:00 - 18:00',
	'10:00 - 18:00',
	'10:00 - 18:00',
	'10:00 - 18:00',
	NULL,
	NULL
	);
