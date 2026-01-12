using user_manager_backend.models;

namespace user_manager_backend.Services
{
    public interface IUserService
    {
        Task<Felhasznalo?> GetByIdAsync(int id);
        Task<List<Felhasznalo>> GetAllUsersAsync(string? nev = null);
        Task CreateUserAsync(Felhasznalo user);
    }
}
