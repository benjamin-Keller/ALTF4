create procedure sp_DisplayNotClosedRequests
as
begin
select * from tblRequests
where RequestDescription not like 'Closed'
end
go