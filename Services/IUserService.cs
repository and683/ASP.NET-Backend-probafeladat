using System.Collections.Generic;
using System.Threading.Tasks;
using user_manager_backend.models;

namespace user_manager_backend.Services
{
    public interface IUserService
    {
        Task<List<Felhasznalo>> GetAllUsersAsync();
        Task CreateUserAsync(Felhasznalo user);
    }
}
