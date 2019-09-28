create procedure sp_Login
@Username varchar(30),
@Password varchar(30)
as
begin
select * from tblUsers
where Username=@Username AND Password=@Password
end
go