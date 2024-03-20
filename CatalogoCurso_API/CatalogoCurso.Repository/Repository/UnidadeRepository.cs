using CatalogoCurso.Domain.Conta.Repository;
using CatalogoCurso.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCurso.Domain.Unidade;
using CatalogoCurso.Domain.Unidade.Repository;

namespace CatalogoCurso.Repository.Repository
{
    public class UnidadeRepository : RepositoryBase<Unidade>, IUnidadeRepository
    {
        public UnidadeRepository(CatalogoCursoContext context) : base(context)
        {
        }
    }
}
