namespace user_manager_backend.models
{
    public class Felhasznalo
    {
        public int Id { get; set; }
        public string Nev { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
