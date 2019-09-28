CREATE PROCEDURE sp_UpdateEquip
@VenueCode int,
@EquipmentCode int,
@EquipmentDescription  varchar(50)
AS
BEGIN
UPDATE tblEquipment SET
VenueCode  = @VenueCode,
EquipmentDescription = @EquipmentDescription
WHERE EquipmentCode = @EquipmentCode
END
GO
