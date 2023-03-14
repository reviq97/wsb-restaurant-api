using Microsoft.EntityFrameworkCore;
using wsb_restaurant_models.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql("Host=localhost:5432;Database=postgres;Username=postgres;Password=admin", b => b.MigrationsAssembly("wsb-restaurant-api")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
