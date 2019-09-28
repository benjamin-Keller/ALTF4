create procedure  [dbo].[sp_UpdateRequest]
@RequestCode int,
@RequestDescription varchar(50),
@StaffCode int,
@TaskTypeCode  int,
@RequestDate date,
@RequestTime time(7),
@AssignedStaffCode int,
@RequestStatus varchar(50)
AS
begin
update tblRequests set
RequestDescription=@RequestDescription,
StaffCode=@StaffCode,
TaskTypeCode=@TaskTypeCode,
RequestDate=@RequestDate,
RequestTime=@RequestTime,
AssignedStaffCode=@AssignedStaffCode,
RequestStatus=@RequestStatus
Where RequestCode=@RequestCode
end