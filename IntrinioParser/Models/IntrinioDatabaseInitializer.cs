using Microsoft.EntityFrameworkCore;

namespace IntrinioParser.Models
{
	internal sealed class IntrinioDatabaseInitializer
	{
		internal static void Initialize(DbContext context)
		{
			context.Database.EnsureCreated();
		}
	}
}