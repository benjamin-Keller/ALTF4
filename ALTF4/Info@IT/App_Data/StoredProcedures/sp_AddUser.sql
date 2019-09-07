create procedure [dbo].[sp_AddUser]
@Username varchar(30),
@Password varchar(50),
@Role varchar(30)
as
begin
insert into tblUsers(Username,Password,Role,UserAdmin)
	values(@Username,@Password,@Role,0)
	end