using Microsoft.EntityFrameworkCore;
using user_manager_backend.Data;
using user_manager_backend.models;

namespace user_manager_backend.repo
{
    public class UserRepository : IUserRepo
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Felhasznalo?> GetByIdAsync(int id)
        {
            return await _context.Felhasznalok.FindAsync(id);
        }

        public async Task<List<Felhasznalo>> GetAllAsync(string? nev)
        {
            var query = _context.Felhasznalok.AsQueryable();
            if (!string.IsNullOrEmpty(nev))
            {
                query = query.Where(u => u.Nev.Contains(nev));
            }
            return await query.ToListAsync();
        }

        public async Task AddAsync(Felhasznalo user)
        {
            _context.Felhasznalok.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
