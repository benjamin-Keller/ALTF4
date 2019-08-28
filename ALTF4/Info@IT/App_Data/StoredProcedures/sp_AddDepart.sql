CREATE PROCEDURE sp_AddDepart
@DepartmentName varchar(50),
@Building varchar(50),
@ContactPerson varchar(50),
@Email varchar(50),
@ContactNumber varchar(30)
AS
BEGIN
INSERT INTO tblDepartment(DepartmentName,Building,ContactPerson,Email,ContactNumber)
	VALUES(@DepartmentName,@Building,@ContactPerson,@Email,@ContactNumber)
END
GO
