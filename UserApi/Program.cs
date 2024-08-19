using Microsoft.EntityFrameworkCore;
using UserApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar el contexto de la base de datos
builder.Services.AddDbContext<UserContext>(options =>
    options.UseSqlite("Data Source=users.db"));

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
