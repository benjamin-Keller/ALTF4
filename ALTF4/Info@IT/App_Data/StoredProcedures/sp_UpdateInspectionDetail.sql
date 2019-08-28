CREATE PROCEDURE sp_UpdateInspectionDetail
@InspectionDetailCode int,
@InspectinCode int,
@EquipmentCode int,
@StaffCode int,
@FaultComment varchar(50),
@Status varchar(30)
AS
BEGIN
UPDATE tblInspectionDetail SET
InspectionCode=@InspectinCode,
EquipmentCode=@EquipmentCode,
StaffCode=@StaffCode,
FaultComment=@FaultComment,
InspectionStatus=@Status
Where InspectionDetailCode=@InspectionDetailCode
END
GO