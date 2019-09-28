create procedure sp_DisplayInspectDetailByVenue
@VenueCode int
as
begin
select VenueCode,tblInspectionDetail.* from tblInspection,tblInspectionDetail
where tblInspection.InspectionCode = tblInspectionDetail.InspectionCode AND VenueCode=@VenueCode
end
go