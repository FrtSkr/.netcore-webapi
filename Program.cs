using Microsoft.EntityFrameworkCore;
using webapi_challenge.Data;
using webapi_challenge.Repository;
using webapi_challenge.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Add database connection string
builder.Services.AddDbContext<DatabaseContext>(
        opt=> opt.UseSqlServer(
               builder.Configuration.GetConnectionString("DatabaseConnection")
            )
    );
//To be used for Dependency Injection
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped(typeof(IBusRepository), typeof(BusRepository));
builder.Services.AddScoped<IBusService, BusService>();
builder.Services.AddScoped(typeof(IBoatRepository), typeof(BoatRepository));
builder.Services.AddScoped<IBoatService, BoatService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
