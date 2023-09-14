using ApiFirstProgramm.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace ApiFirstProgramm.ConnectBase
{
	public class ApplicationConnect: DbContext
	{
		public DbSet<person> person {  get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(Contains.ConnectSqlBase);
		}
	}
}
