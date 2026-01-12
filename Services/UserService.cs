using user_manager_backend.models;
using user_manager_backend.repo;

namespace user_manager_backend.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<Felhasznalo?> GetByIdAsync(int id)
        {
            return await _userRepo.GetByIdAsync(id);
        }

        public async Task<List<Felhasznalo>> GetAllUsersAsync(string? nev = null)
        {
            return await _userRepo.GetAllAsync(nev);
        }

        public async Task CreateUserAsync(Felhasznalo user)
        {
            await _userRepo.AddAsync(user);
        }
    }
}
