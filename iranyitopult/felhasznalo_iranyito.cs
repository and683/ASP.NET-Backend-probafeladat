[ApiController]
[Route("api/felhasznalo")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }

   
    [HttpGet("{Id}")]
    public async Task<IActionResult> Get(int Id)
    {
        var felhasznalo = await _service.GetUserAsync(Id);
        return felhasznalo == null ? NotFound() : Ok(felhasznalo);
    }

    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? Nev)
    {
        return Ok(await _service.GetUsersAsync(Nev));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] felhasznalo felhasznalo)
    {
        var created = await _service.CreateUserAsync(felhasznalo);
        return CreatedAtAction(nameof(Get), new { Id = created.Id }, created);
    }
}
