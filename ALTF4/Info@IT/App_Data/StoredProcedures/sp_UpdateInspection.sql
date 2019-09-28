create  procedure sp_UpdateInspection
@InspectionCode int,
@VenueCode int,
@StaffCode int,
@InspectionDate date,
@InspectionTime time(7),
@Comment varchar(50)
AS
Begin
Update tblInspection SET
VenueCode=@VenueCode,
StaffCode=@StaffCode,
InspectionDate=@InspectionDate,
InspectionTime=@InspectionTime,
Comment=@Comment
Where InspectionCode=@InspectionCode
END
Go