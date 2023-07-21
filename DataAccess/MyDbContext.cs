using Microsoft.EntityFrameworkCore;

namespace DBTreeView
{
    internal class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Models.Link> Links { get; set; }
        public DbSet<Models.Object> Objects { get; set; }
        public DbSet<Models.Attribute> Attributes { get; set; }
    }
}
