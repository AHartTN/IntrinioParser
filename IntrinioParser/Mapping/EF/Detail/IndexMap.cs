namespace IntrinioParser.Mapping.EF.Detail
{
	#region
	using System;
	using System.Linq;

	using Classes.Abstract.Base;

	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	using Models.Binding.Detail;
	#endregion

	internal sealed class IndexMap : IEntityTypeConfiguration<Index>
	{
		public void Configure(EntityTypeBuilder<Index> builder)
		{
			Type genericType = builder.GetType()
									  .GenericTypeArguments.First();
			BaseAbstract instance = Activator.CreateInstance(genericType) as BaseAbstract;

			if (instance == null)
				throw new TypeLoadException($"Unable to set mapping information for {genericType} as it does not appear to be a BaseAbstract object.");

			builder.ToTable(instance.TableName,
							instance.SchemaName);
		}
	}
}