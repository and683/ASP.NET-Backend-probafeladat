using System.Collections.Generic;
using System.Threading.Tasks;
using user_manager_backend.models;
using user_manager_backend.repo;

namespace user_manager_backend.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repository;

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Felhasznalo>> GetAllUsersAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task CreateUserAsync(Felhasznalo user)
        {
            await _repository.AddAsync(user);
        }
    }
}
