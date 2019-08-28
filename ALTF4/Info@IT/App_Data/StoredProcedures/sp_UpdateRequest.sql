create procedure  sp_UpdateRequest
@RequestCode int,
@RequestDescription varchar(50),
@StaffCode int,
@TaskTypeCode  int,
@RequestDate date,
@RequestTime time(7),
@AssignedStaffCode int
AS
begin
update tblRequests set
RequestDescription=@RequestDescription,
StaffCode=@StaffCode,
TaskTypeCode=@TaskTypeCode,
RequestDate=@RequestDate,
RequestTime=@RequestTime,
AssignedStaffCode=@AssignedStaffCode
Where RequestCode=@RequestCode
end
go
