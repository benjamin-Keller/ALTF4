CREATE PROCEDURE sp_AddVenue
@VenueDescription varchar(50),
@Capacity int,
@DoorNo Int,
@BuildingBlock varchar(50),
@Building varchar(50)
AS
BEGIN
INSERT INTO tblVenue(VenueDescription, Capacity,DoorNo,BuildingBlock,Building)
	Values(@VenueDescription ,@Capacity,@DoorNo,@BuildingBlock,@Building)
END
GO
