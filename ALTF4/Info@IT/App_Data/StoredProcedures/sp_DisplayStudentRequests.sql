create procedure [dbo].[sp_DisplayStudentRequests]
@StudentCode int
as
begin
select * from tblRequests
where StudentCode=@StudentCode
end