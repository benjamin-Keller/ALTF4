create procedure sp_DisplayInspectionFaults
as
begin
select VenueCode,FaultComment  from tblInspection,tblInspectionDetail
where
tblInspection.InspectionCode=tblInspectionDetail.InspectionCode
end
go