public class UserRepo : IUserRepo
{
    private readonly AppDbContext _context;

    public UserRepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task<felhasznalo?> GetByIdAsync(int Id) =>
        await _context.felhasznalo.FindAsync(Id);

    public async Task<List<felhasznalo>> GetAllAsync(string? Nev)
    {
        var query = _context.Users.AsQueryable();
        if (!string.IsNullOrEmpty(Nev))
            query = query.Where(u => u.Nev.Contains(Nev));
        return await query.ToListAsync();
    }

    public async Task AddAsync(felhasznalo felhasznalo)
    {
        _context.felhasznalo.Add(felhasznalo);
        await _context.SaveChangesAsync();
    }
}
