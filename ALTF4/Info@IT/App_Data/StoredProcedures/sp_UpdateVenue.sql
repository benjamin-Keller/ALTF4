CREATE PROCEDURE sp_UpdateVenue
@VenueCode int,
@VenueDescription varchar(50),
@Capacity int,
@DoorNo Int,
@BuildingBlock varchar(50),
@Building varchar(50)
AS
BEGIN
UPDATE tblVenue SET
VenueDescription = @VenueDescription,
Capacity = @Capacity,
DoorNo = @DoorNo,
BuildingBlock = @BuildingBlock,
Building = @Building
WHERE VenueCode = @VenueCode
END
GO
