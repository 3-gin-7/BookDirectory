using Microsoft.EntityFrameworkCore;
using Server.Api.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddDbContext<BookDbContext>(opt => {
        opt.UseSqlServer(builder.Configuration.GetConnectionString("BookDbConnectionString"));
        });
var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();
