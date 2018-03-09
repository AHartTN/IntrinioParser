namespace IntrinioParser.Models
{
	#region
	using Microsoft.EntityFrameworkCore;
	#endregion

	internal sealed class IntrinioDatabaseInitializer
	{
		internal static void Initialize(DbContext context)
		{
			context.Database.EnsureCreated();

			// Some kind of BS Check for seeded data
			// If the check fails, seed some data
		}
	}
}