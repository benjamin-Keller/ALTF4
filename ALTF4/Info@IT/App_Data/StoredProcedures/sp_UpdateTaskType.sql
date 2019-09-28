create  procedure sp_UpdateTaskType
@TaskTypeCode int,
@TaskTypeName varchar(50)
as
begin
update tblTaskType  set
TaskName =@TaskTypeName
where  TaskTypeCode=@TaskTypeCode
end
go