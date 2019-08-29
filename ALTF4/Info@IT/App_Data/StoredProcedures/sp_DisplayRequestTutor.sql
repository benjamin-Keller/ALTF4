create procedure sp_DisplayRequestTutor
as
begin
select TutorRequestCode,tblRequests.* from tblRequests,tblTutorRequests
where tblTutorRequests.RequestCode=tblRequests.RequestCode
end
go