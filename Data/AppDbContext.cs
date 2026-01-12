using Microsoft.EntityFrameworkCore;
using user_manager_backend.models;

namespace user_manager_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Felhasznalo> Felhasznalok { get; set; }
    }
}
