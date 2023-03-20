using Microsoft.EntityFrameworkCore;
using wsb_restaurant_application;
using wsb_restaurant_models.Repository;
using wsb_restaurant_infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql("Host=localhost:5432;Database=postgres;Username=postgres;Password=admin", b => b.MigrationsAssembly("wsb-restaurant-api")));
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

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
