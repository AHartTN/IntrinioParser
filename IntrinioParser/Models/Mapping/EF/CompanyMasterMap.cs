using IntrinioParser.Models.Binding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntrinioParser.Models.Mapping.EF
{
	public sealed class CompanyMasterMap : IEntityTypeConfiguration<CompanyMaster>
	{
		public void Configure(EntityTypeBuilder<CompanyMaster> builder)
		{
			builder.ToTable("CompanyMaster");
		}
	}
}