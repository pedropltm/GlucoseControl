using GlucoseControl.Models;
using GlucoseControl.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.Configure<GlucoseControlDatabaseSettings>(
    builder.Configuration.GetSection("GlucoseControlDatabase"));
builder.Services.AddSingleton<MealsService>();
builder.Services.AddSingleton<MedicinesService>();
builder.Services.AddSingleton<PatientsService>();
builder.Services.AddSingleton<PhysicalActivitiesService>();
builder.Services.AddSingleton<ScoutingsService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
