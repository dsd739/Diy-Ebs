using Diy_B.Models;
using Microsoft.EntityFrameworkCore;

namespace Diy_B.Data
{
    public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<User> Users { get; set; }
        public DbSet<Claim> Claims { get; set; }

    }
}
