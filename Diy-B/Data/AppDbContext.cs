using Diy_B.Models;
using Microsoft.EntityFrameworkCore;

namespace Diy_B.Data
{
    public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<users> users { get; set; }
	}
}
