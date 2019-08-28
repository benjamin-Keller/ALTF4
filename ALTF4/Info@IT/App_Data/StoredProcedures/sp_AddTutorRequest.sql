create procedure sp_AddTutorRequest
@RequestCode  int,
@TutorRequestDate date,
@StartTime  time(7),
@EndTime time(7),
@ModuleCode  int,
@VenueCode int
as
Begin
insert  into  tblTutorRequests(RequestCode,TutorRequestDate,StartTime,EndTime,ModuleCode,VenueCode)
	Values(@RequestCode,@TutorRequestDate,@StartTime,@EndTime,@ModuleCode,@VenueCode)
	end
	go