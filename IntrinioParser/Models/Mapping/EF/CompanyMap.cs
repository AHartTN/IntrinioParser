using IntrinioParser.Models.Binding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntrinioParser.Models.Mapping.EF
{
	public sealed class CompanyMap : IEntityTypeConfiguration<Company>
	{
		public void Configure(EntityTypeBuilder<Company> builder)
		{
			builder.ToTable("Company");
		}
	}
}