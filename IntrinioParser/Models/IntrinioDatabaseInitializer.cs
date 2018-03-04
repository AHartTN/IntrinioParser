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
		}
	}
}