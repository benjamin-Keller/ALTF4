Create Procedure sp_UpdateTutorRequest
@TutorRequestCode int,
@RequestCode int,
@TutorRequestDate date,
@StartTime time(7),
@EndTime time(7),
@ModuleCode int,
@VenueCode int
AS
begin
update tblTutorRequests set
RequestCode=@RequestCode,
TutorRequestDate=@TutorRequestDate,
StartTime=@StartTime,
EndTime=@EndTime,
ModuleCode=@ModuleCode,
VenueCode=@VenueCode
where TutorRequestCode=@TutorRequestCode
end
go