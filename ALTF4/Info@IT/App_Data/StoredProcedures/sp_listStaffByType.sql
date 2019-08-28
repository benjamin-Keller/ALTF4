CREATE PROCEDURE sp_listStaffByType
@StaffType varchar(50)
AS
BEGIN
SELECT * FROM tblStaff
WHERE StaffType =  @StaffType
END
GO