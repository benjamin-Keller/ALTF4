CREATE PROCEDURE sp_AddRequest
@RequestDescription varchar(50),
@StaffCode  int,
@StudentCode int,
@TasktypeCode int,
@RequestDate date,
@RequestTime time,
@AssignedStaffCode  int,
@RequestStatus varchar(50)
AS
BEGIN 
INSERT INTO tblRequests(RequestDescription,StaffCode,StudentCode,TaskTypeCode,RequestTime,AssignedStaffCode,RequestStatus)
	VALUES(@RequestDescription,@StaffCode,@StudentCode,@TasktypeCode,@RequestDate,@RequestTime,@AssignedStaffCode,@RequestStatus)
END
GO