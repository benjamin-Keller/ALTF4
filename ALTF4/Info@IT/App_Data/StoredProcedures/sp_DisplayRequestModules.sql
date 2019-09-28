create procedure sp_DisplayRequestModules
as
begin
select ModuleCode,tblRequests.* from tblRequests,tblTutorRequests
where tblRequests.RequestCode=tblTutorRequests.RequestCode
end
go