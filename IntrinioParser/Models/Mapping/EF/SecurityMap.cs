using IntrinioParser.Models.Binding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntrinioParser.Models.Mapping.EF
{
	public sealed class SecurityMap : IEntityTypeConfiguration<Security>
	{
		public void Configure(EntityTypeBuilder<Security> builder)
		{
			builder.ToTable("Security");
		}
	}
}