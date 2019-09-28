create procedure sp_AddStudent
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(50)
as
begin
insert into tblStudent(FirstName,LastName,Email,UserAdmin)
	values(@FirstName,@LastName,@Email,0)
	end
	go