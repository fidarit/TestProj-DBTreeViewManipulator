using Microsoft.EntityFrameworkCore;

namespace DBTreeView
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Models.Link> Links { get; set; }
        public DbSet<Models.Object> Objects { get; set; }
        public DbSet<Models.Attribute> Attributes { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
