using Microsoft.EntityFrameworkCore;
using user_manager_backend.Data;
using user_manager_backend.Services;
using user_manager_backend.repo;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("UsersDb"));


builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<UserRepository>();

builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();

app.Run();
