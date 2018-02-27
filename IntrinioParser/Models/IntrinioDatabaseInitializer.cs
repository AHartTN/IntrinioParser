using Microsoft.EntityFrameworkCore;

namespace IntrinioParser.Models
{
	public sealed class IntrinioDatabaseInitializer
	{
		public static void Initialize(DbContext context)
		{
			context.Database.EnsureCreated();
		}
	}
}