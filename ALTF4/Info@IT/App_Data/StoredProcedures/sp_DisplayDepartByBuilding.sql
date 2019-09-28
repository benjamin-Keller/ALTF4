CREATE PROCEDURE sp_DisplayDepartByBuilding
@Building varchar(50)
AS
BEGIN
SELECT * FROM tblDepartment
WHERE Building=@Building
END
GO
