public interface IUserRepo
{
    Task<felhasznalo?> GetByIdAsync(int Id);
    Task<List<felhasznalo>> GetAllAsync(string? Nev);
    Task AddAsync(felhasznalo felhasznalo);
}
