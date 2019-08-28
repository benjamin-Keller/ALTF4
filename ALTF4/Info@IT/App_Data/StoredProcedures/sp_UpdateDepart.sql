CREATE PROCEDURE sp_UpdateDepart
@DepartmentCode int,
@DepartmentName varchar(30),
@Building varchar(50),
@ContactPerson varchar(50),
@Email varchar(50),
@ContactNumber varchar(30)
AS
BEGIN
UPDATE tblDepartment SET
DepartmentName =@DepartmentName, 
Building = @Building, 
ContactPerson = @ContactPerson,
Email = @Email
WHERE DepartmentCode =@DepartmentCode
END
GO
