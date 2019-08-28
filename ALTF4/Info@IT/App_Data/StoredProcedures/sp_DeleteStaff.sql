CREATE PROCEDURE sp_DeleteStaff
@StaffCode int
AS
BEGIN
DELETE FROM tblStaff
WHERE StaffCode = @StaffCode
END
GO
