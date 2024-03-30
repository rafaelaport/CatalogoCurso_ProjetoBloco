using CatalogoCurso.Application.Conta.Profile;
using CatalogoCurso.Application.Conta;
using CatalogoCurso.Repository;
using CatalogoCurso.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using CatalogoCurso.Application.Disciplina;
using CatalogoCurso.Application.Turma;
using CatalogoCurso.Application.Unidade;

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
builder.Services.AddScoped<DisciplinaRepository>();
builder.Services.AddScoped<TurmaRepository>();
builder.Services.AddScoped<UnidadeRepository>();

//Services
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<DisciplinaService>();
builder.Services.AddScoped<TurmaService>();
builder.Services.AddScoped<UnidadeService>();

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
