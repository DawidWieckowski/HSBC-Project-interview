CREATE TABLE #employee 
(
	employeeId int,
	name VARCHAR(20),
	surname VARCHAR(20),
	managerId int,
	PRIMARY KEY(employeeId)
)

CREATE TABLE #manager
(
	managerId int,
	employeeId int,
	managerTitle VARCHAR(20),
	PRIMARY KEY (managerID),
	FOREIGN KEY(employeeId) REFERENCES #employee(employeeId)
)

