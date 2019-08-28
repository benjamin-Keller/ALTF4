CREATE PROCEDURE sp_DeleteVenue
@VenueCode  int
AS 
BEGIN
DELETE FROM tblVenue
WHERE VenueCode = @VenueCode
END
GO
