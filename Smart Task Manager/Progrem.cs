using Microsoft.EntityFrameworkCore;
using UnicornTaskManager.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<UnicornDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("UnicornConnection"),
    new MySqlServerVersion(new Version(8, 0, 23))));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
