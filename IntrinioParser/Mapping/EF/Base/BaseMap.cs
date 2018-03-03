using System;
using IntrinioParser.Classes;
using IntrinioParser.Classes.Abstract.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntrinioParser.Mapping.EF.Base
{
	internal class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseAbstract
	{
		public void Configure(EntityTypeBuilder<T> builder)
		{
			T instance = Activator.CreateInstance<T>();

			if (instance == null)
				throw new TypeLoadException(
					$"Unable to set mapping information for {typeof(T)} as it does not appear to be a BaseAbstract object.");

			builder.ToTable(instance.TableName, instance.SchemaName);
		}
	}
}