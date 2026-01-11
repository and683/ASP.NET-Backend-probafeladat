public class AppDbContext : DbContext
{
    public DbSet<felhasznalo> felhasznalo => Set<felhasznalo>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
}
