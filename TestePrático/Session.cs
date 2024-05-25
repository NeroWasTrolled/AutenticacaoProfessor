namespace TestePrático
{
	public static class Session
	{
		public static int UserId { get; private set; }
		public static string Email { get; private set; }
		public static string Nome { get; private set; }

		public static void StartSession(int userId, string email, string nome)
		{
			UserId = userId;
			Email = email;
			Nome = nome;
		}

		public static void EndSession()
		{
			UserId = 0;
			Email = null;
			Nome = null;
		}

		public static bool IsLoggedIn()
		{
			return UserId != 0;
		}
	}
}
