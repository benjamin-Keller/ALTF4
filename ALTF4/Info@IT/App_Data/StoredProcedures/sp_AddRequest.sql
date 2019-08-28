CREATE PROCEDURE sp_AddRequest
@RequestDescription varchar(50),
@StaffCode  int,
@StudentCode int,
@TasktypeCode int,
@RequestDate date,
@RequestTime time,
@AssignedStaffCode  int
AS
BEGIN 
INSERT INTO tblRequests(RequestDescription,StaffCode,StudentCode,TaskTypeCode,RequestTime,AssignedStaffCode)
	VALUES(@RequestDescription,@StaffCode,@StudentCode,@TasktypeCode,@RequestDate,@RequestTime,@AssignedStaffCode)
END
GO