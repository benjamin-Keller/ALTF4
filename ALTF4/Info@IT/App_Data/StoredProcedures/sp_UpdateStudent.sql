create procedure sp_UpdateStudent
@StudentCode int,
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(50)
as 
begin
update tblStudent set
FirstName=@FirstName,
LastName=@LastName,
Email=@Email
where StudentCode=@StudentCode
end
go