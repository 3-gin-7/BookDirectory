using Microsoft.EntityFrameworkCore;
using Server.Api.Core.Interfaces;
using Server.Api.Core.Repository;
using Server.Api.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// builder.Services.Add
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BookDbContext>(opt => {
        opt.UseSqlServer(builder.Configuration.GetConnectionString("BookDbConnectionString"));
        });
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
