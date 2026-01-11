public class UserService : IUserService
{
    private readonly IUserRepo _repo;

    public UserService(IUserRepo repo)
    {
        _repo = repo;
    }

    public Task<felhasznalo?> GetUserAsync(int Id) => _repo.GetByIdAsync(Id);
    public Task<List<felhasznalo>> GetUsersAsync(string? Nev) => _repo.GetAllAsync(Nev);

    public async Task<felhasznalo> CreateUserAsync(felhasznalo felhasznalo)
    {
        await _repo.AddAsync(felhasznalo);
        return felhasznalo;
    }
}
