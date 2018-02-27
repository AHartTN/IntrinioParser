using System;
using IntrinioParser.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntrinioParser.Models.Mapping.EF
{
	public sealed class BaseMap<T> : IEntityTypeConfiguration<T> where T : class
	{
		public void Configure(EntityTypeBuilder<T> builder)
		{
			T instance = Activator.CreateInstance<T>();
			BaseAbstract baseModel = instance as BaseAbstract;

			if (baseModel == null)
				throw new TypeLoadException($"Unable to set mapping information for {typeof(T)} as it does not appear to be a BaseAbstract object.");

			builder.ToTable(baseModel.TableName, baseModel.SchemaName);
		}
	}
}