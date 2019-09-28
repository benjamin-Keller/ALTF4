CREATE PROCEDURE sp_AddEquipType
@TypeDescription varchar(50)
AS
BEGIN
INSERT INTO tblEquipType(TypeDescription)
	VALUES(@TypeDescription)
END
GO
