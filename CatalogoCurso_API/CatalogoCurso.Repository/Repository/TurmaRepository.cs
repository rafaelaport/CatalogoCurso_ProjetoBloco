using CatalogoCurso.Domain.Conta.Repository;
using CatalogoCurso.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCurso.Domain.Turma.Repository;
using CatalogoCurso.Domain.Turma;

namespace CatalogoCurso.Repository.Repository
{
    public class TurmaRepository : RepositoryBase<Turma>, ITurmaRepository
    {
        public TurmaRepository(CatalogoCursoContext context) : base(context)
        {
        }
    }
}
