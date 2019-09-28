CREATE  procedure sp_AddInspection
@VenueCode  int,
@StaffCode int,
@InspectionDate date,
@InspectionTime time(7),
@Comment varchar(50)
as
begin
insert into tblInspection(VenueCode,StaffCode,InspectionDate,InspectionTime,Comment)
	Values(@VenueCode,@StaffCode,@InspectionDate,@InspectionTime,@Comment)
	END
	GO