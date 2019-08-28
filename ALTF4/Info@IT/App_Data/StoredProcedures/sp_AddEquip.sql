CREATE PROCEDURE sp_AddEquip
@EquipmentDescription varchar(50),
@VenueCode int,
@EquipTypeCode int
AS
BEGIN
INSERT INTO tblEquipment(EquipmentDescription,VenueCode,EquipTypeCode)
	VALUES(@EquipmentDescription,@VenueCode)
END
GO
