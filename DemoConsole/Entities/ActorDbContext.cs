using Microsoft.EntityFrameworkCore;

namespace DemoConsole.Entities
{
    class ActorDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ActorDb;Trusted_Connection=True");
        }
    }
}
