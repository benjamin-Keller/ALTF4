namespace DAL
{
	public class LoginClass
	{
		public string Username { get; set; }
		public string Password { get; set; }

		public LoginClass(string username, string password)
		{
			Username = username;
			Password = password;
		}
	}
}
