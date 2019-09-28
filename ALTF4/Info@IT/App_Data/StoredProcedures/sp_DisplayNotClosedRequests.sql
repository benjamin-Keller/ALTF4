create procedure sp_DisplayNotClosedRequests
as
begin
select * from tblRequests
where RequestStatus not like 'Closed'
end
go