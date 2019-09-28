CREATE PROCEDURE sp_AddStaff
@StaffNumber int,
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(50),
@ContactNumber varchar(10),
@StaffType varchar(30),
@DepartmentCode int
AS
BEGIN
INSERT INTO tblStaff(StaffNumber, FirstName, LastName, Email, ContactNumber, StaffType, DepartmentCode)
	VALUES (@StaffNumber,@FirstName,@LastName,@Email,@ContactNumber,@StaffType,@DepartmentCode)
END
GO
