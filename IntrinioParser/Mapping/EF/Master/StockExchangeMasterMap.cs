namespace IntrinioParser.Mapping.EF.Master
{
	#region
	using System;
	using System.Linq;

	using Classes.Abstract.Base;

	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;

	using Models.Binding.Master;
	#endregion

	internal sealed class StockExchangeMasterMap : IEntityTypeConfiguration<StockExchangeMaster>
	{
		public void Configure(EntityTypeBuilder<StockExchangeMaster> builder)
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