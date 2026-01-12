using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using user_manager_backend.Data;
using user_manager_backend.models;

namespace user_manager_backend.repo
{
    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Felhasznalo>> GetAllAsync()
        {
            return await _context.Felhasznalok.ToListAsync();
        }

        public async Task AddAsync(Felhasznalo user)
        {
            _context.Felhasznalok.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
