using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Server.Api.Core.Interfaces;
using Server.Api.Core.Repository;
using Server.Api.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// builder.Services.Add
builder.Services.AddSwaggerGen(options =>{
    options.SwaggerDoc("v1", new OpenApiInfo{
                Version = "v1",
                Title = "Server.Api",
                Description = "Backend server for book directory project"
                });
    // var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    // options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    options.EnableAnnotations();
});

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
