public interface IUserService
{
    Task<felhasznalo?> GetUserAsync(int Id);
    Task<List<felhasznalo>> GetUsersAsync(string? Nev);
    Task<felhasznalo> CreateUserAsync(Nev Nev);
}
