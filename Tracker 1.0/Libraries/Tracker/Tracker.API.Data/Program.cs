using Microsoft.EntityFrameworkCore;
using System;

using Tracker.API.Data.DataContext;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("Tracker"))
);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
