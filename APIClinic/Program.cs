using BLClinic.Models;
using BLClinic.Services;
using DALClinic.Models;
using DALClinic.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Host.ConfigureServices(services =>
{   
    services.AddTransient<IPatientsRepository,PatientsRepository>();
    services.AddTransient<IPatientsService, PatientsService>();
    services.AddDbContext<Clinic>(options => options.UseSqlServer("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = H:\\WebApiProject\\APIClinic\\DALClinic\\ClinicDB.mdf; Integrated Security = True; Connect Timeout = 30"));
    services.AddMvcCore();
    services.AddControllers();
});

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
app.UseCors();


app.UseAuthorization();

app.MapControllers();

app.Run();
