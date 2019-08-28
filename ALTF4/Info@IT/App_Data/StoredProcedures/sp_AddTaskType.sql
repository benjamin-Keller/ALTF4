create procedure sp_AddTaskType
@TaskName varchar(50)
as
begin
insert into tblTaskType(TaskName)
	values(@TaskName)
end
go