using Microsoft.AspNetCore.Mvc;
using user_manager_backend.Services;
using user_manager_backend.models;

namespace user_manager_backend.iranyitopult
{
    [ApiController]
    [Route("api/[controller]")]
    public class FelhasznaloIranyito : ControllerBase
    {
        private readonly IUserService _userService;

        public FelhasznaloIranyito(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] string? name)
        {
            var users = await _userService.GetAllUsersAsync(name);
            return Ok(users);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        // :D
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Felhasznalo user)
        {
            await _userService.CreateUserAsync(user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }
    }
}
