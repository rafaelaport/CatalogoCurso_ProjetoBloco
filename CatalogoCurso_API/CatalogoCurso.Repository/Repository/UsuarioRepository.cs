using CatalogoCurso.Domain.Curso.Repository;
using CatalogoCurso.Domain.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCurso.Domain.Conta;
using CatalogoCurso.Domain.Conta.Repository;
using Microsoft.EntityFrameworkCore;

namespace CatalogoCurso.Repository.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(CatalogoCursoContext context) : base(context)
        {
        }
    }
}
