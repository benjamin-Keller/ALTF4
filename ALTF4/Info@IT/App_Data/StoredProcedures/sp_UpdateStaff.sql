CREATE PROCEDURE sp_UpdateStaff
@StaffCode int,
@StaffNumber int,
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(50),
@ContactNumber varchar(10),
@StaffType nvarchar(30),
@DepartmentCode int
AS
BEGIN
UPDATE tblStaff SET
StaffNumber =@StaffNumber ,
FirstName = @FirstName ,
LastName = @Lastname,
Email = @Email ,
ContactNumber = @ContactNumber,
StaffType = @StaffType ,
DepartmentCode = @DepartmentCode 
WHERE StaffCode = @StaffCode
END
GO
