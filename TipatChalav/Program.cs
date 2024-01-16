using Tipa.Core.repositories;
using Tipa.Core.repositories.services;
using Tipa.Core.services;
using Tipa.Data.Repository;
using Tipa.Service;
using TipatChalav;
using TipatChalav.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IDataContext, DataContext>();
builder.Services.AddScoped<INurseService, NurseService>();
builder.Services.AddScoped<INurseRepository, NurseRepository>();
builder.Services.AddScoped<IBabyService, BabyService>();
builder.Services.AddScoped<IBabyRepository, BabyRepository>();
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

