CREATE PROCEDURE sp_AddInspectionDetail
@InspectionCode int,
@EquipmentCode int,
@StaffCode  int,
@FaultComment varchar(50),
@InspectionStatus varchar(30)
AS
BEGIN
INSERT INTO tblInspectionDetail(InspectionCode,EquipmentCode,StaffCode,FaultComment,InspectionStatus)
	VALUES(@InspectionCode,@EquipmentCode,@StaffCode,@FaultComment,@InspectionStatus)
END