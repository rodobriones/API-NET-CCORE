using clase4590_ejemploAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ProductosCRUDContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
//agregar swagger
builder.Services.AddSwaggerGen();

var app = builder.Build();

//para redireccionar a swagger para que inicie 
app.MapGet("/", (HttpContext context) => context.Response.Redirect("/swagger/index.html", false));



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    //agregar estas dos lineas
    app.UseSwaggerUI();
    app.UseSwagger();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
