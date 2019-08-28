CREATE PROCEDURE sp_DeleteEquip
@EquipmentCode int
AS
BEGIN
DELETE FROM tblEquipment 
WHERE EquipmentCode = @EquipmentCode
END
GO
