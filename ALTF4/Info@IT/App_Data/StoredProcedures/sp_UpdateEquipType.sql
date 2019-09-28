CREATE PROCEDURE sp_UpdateEquipType
@TypeDescription varchar(50),
@EquipTypeCode int
AS
BEGIN
UPDATE tblEquipType SET
TypeDescription = @TypeDescription
WHERE EquipTypeCode = @EquipTypeCode
END
GO
