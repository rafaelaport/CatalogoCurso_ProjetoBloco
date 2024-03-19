using CatalogoCurso.Application.Conta.Profile;
using CatalogoCurso.Application.Conta;
using CatalogoCurso.Repository;
using CatalogoCurso.Repository.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CatalogoCursoContext>(c =>
{
    c.UseSqlServer(builder.Configuration.GetConnectionString("CatalogoCursoConnection"));
});

builder.Services.AddAutoMapper(typeof(UsuarioProfile).Assembly);

//Repositories
builder.Services.AddScoped<UsuarioRepository>();

//Services
builder.Services.AddScoped<UsuarioService>();

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
