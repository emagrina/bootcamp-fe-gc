using System;
using ex02.Data;
using ex02.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure db
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<IAsignadoRepository, AsignadoRepository>();
builder.Services.AddScoped<ICientificoRepository, CientificoRepository>();
builder.Services.AddScoped<IProyectoRepository, ProyectoRepository>();

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

