using CatalogoCurso.Application.Conta.Profile;
using CatalogoCurso.Application.Conta;
using CatalogoCurso.Repository;
using CatalogoCurso.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using CatalogoCurso.Application.Disciplina;
using CatalogoCurso.Application.Turma;
using CatalogoCurso.Application.Unidade;
using CatalogoCurso.Domain.Conta.Repository;
using CatalogoCurso.Domain.Disciplina.Repository;
using CatalogoCurso.Domain.Turma.Repository;
using CatalogoCurso.Domain.Unidade.Repository;

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
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
builder.Services.AddScoped<ITurmaRepository, TurmaRepository>();
builder.Services.AddScoped<IUnidadeRepository, UnidadeRepository>();

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
