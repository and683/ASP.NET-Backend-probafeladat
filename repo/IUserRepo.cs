using user_manager_backend.models;

namespace user_manager_backend.repo
{
    public interface IUserRepo
    {
        Task<Felhasznalo?> GetByIdAsync(int id);
        Task<List<Felhasznalo>> GetAllAsync(string? nev);
        Task AddAsync(Felhasznalo user);
    }
}
