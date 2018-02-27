using IntrinioParser.Models.Binding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntrinioParser.Models.Mapping.EF
{
	public sealed class SecurityMasterMap : IEntityTypeConfiguration<SecurityMaster>
	{
		public void Configure(EntityTypeBuilder<SecurityMaster> builder)
		{
			builder.ToTable("SecurityMaster");
		}
	}
}