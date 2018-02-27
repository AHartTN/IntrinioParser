using IntrinioParser.Models.Binding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntrinioParser.Models.Mapping.EF
{
    public sealed class IndexMasterMap : IEntityTypeConfiguration<IndexMaster>
    {
	    public void Configure(EntityTypeBuilder<IndexMaster> builder)
	    {
		    builder.ToTable("Master", "Index");
	    }
    }
}
