using System.Collections.Generic;
using System.Threading.Tasks;
using user_manager_backend.models; 

namespace user_manager_backend.repo
{
    public interface IUserRepo
    {
        Task<Felhasznalo?> GetByIdAsync(int Id);
        Task<List<Felhasznalo>> GetAllAsync(string? Nev);
        Task AddAsync(Felhasznalo user);
    }
}
