using CatalogoCurso.Domain.Curso;
using CatalogoCurso.Domain.Curso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository.Repository
{
    public class SegmentoRepository : RepositoryBase<Segmento>, ISegmentoRepository
    {
        public SegmentoRepository(CatalogoCursoContext context) : base(context)
        {
        }
    }
}
