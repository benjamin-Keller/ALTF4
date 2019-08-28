CREATE PROCEDURE sp_DisplayEquipByType
AS
BEGIN
SELECT * FROM tblEquipment
ORDER BY EquipTypeCode
END
GO