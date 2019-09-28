create procedure sp_GetStudentRequest
as
begin
select tblRequests.* from tblRequests,tblStudent
where tblRequests.StudentCode=tblStudent.studentCode
end
go