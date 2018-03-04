namespace IntrinioParser.Models
{
	#region
	using Binding.Detail;
	using Binding.Master;

	using Mapping.EF.Base;

	using Microsoft.EntityFrameworkCore;

	using Properties;
	#endregion

	internal sealed class IntrinioDatabase : DbContext
	{
		internal static readonly string DefaultConnectionString = $"Data Source={Resources.MSSQL_Server};Initial Catalog={Resources.MSSQL_Database};Integrated Security=True;";

		public DbSet<CompanyMaster> CompanyMasters { get; set; }
		public DbSet<SecurityMaster> SecurityMasters { get; set; }
		public DbSet<IndexMaster> IndexMasters { get; set; }
		public DbSet<OwnerMaster> OwnerMasters { get; set; }
		public DbSet<StockExchangeMaster> StockExchangeMasters { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<Security> Securities { get; set; }
		public DbSet<Index> Indices { get; set; }
		public DbSet<Owner> Owners { get; set; }
		public DbSet<StockExchange> StockExchanges { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(DefaultConnectionString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new BaseMap<CompanyMaster>());
			modelBuilder.ApplyConfiguration(new BaseMap<SecurityMaster>());
			modelBuilder.ApplyConfiguration(new BaseMap<IndexMaster>());
			modelBuilder.ApplyConfiguration(new BaseMap<OwnerMaster>());
			modelBuilder.ApplyConfiguration(new BaseMap<StockExchangeMaster>());

			modelBuilder.ApplyConfiguration(new BaseMap<Company>());
			modelBuilder.ApplyConfiguration(new BaseMap<Security>());
			modelBuilder.ApplyConfiguration(new BaseMap<Index>());
			modelBuilder.ApplyConfiguration(new BaseMap<Owner>());
			modelBuilder.ApplyConfiguration(new BaseMap<StockExchange>());

			//modelBuilder.ApplyConfiguration(new CompanyMasterMap());
			//modelBuilder.ApplyConfiguration(new SecurityMasterMap());
			//modelBuilder.ApplyConfiguration(new IndexMasterMap());
			//modelBuilder.ApplyConfiguration(new OwnerMasterMap());
			//modelBuilder.ApplyConfiguration(new StockExchangeMasterMap());

			//modelBuilder.ApplyConfiguration(new CompanyMap());
			//modelBuilder.ApplyConfiguration(new SecurityMap());
			//modelBuilder.ApplyConfiguration(new IndexMap());
			//modelBuilder.ApplyConfiguration(new OwnerMap());
			//modelBuilder.ApplyConfiguration(new StockExchangeMap());

			base.OnModelCreating(modelBuilder);
		}
	}
}