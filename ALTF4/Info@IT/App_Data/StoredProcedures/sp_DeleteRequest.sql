create procedure  sp_DeleteRequest
@RequestCode  int
as
begin
Delete from tblRequests
where RequestCode=@RequestCode
end
go