create procedure  sp_DisplayLabRequests
as
begin
select VenueCode,tblRequests.* from tblRequests,tblTutorRequests
where tblRequests.RequestCode=tblTutorRequests.RequestCode
end
go