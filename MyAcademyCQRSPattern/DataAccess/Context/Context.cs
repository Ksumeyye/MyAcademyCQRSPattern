using Microsoft.EntityFrameworkCore;
using MyAcademyCQRSPattern.DataAccess.Entities;

namespace MyAcademyCQRSPattern.DataAccess.Context
{
	public class Context: DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=LAPTOP-O1DRK0LF;database=MyAcademyCQRSPatternDb;integrated security=true;trustServerCertificate=true");
		}
		public DbSet<Customer>Customers { get; set; }
	}
}
