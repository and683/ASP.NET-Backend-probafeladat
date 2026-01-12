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
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Felhasznalo user)
        {
            await _userService.CreateUserAsync(user);
            return Ok();
        }
    }
}
