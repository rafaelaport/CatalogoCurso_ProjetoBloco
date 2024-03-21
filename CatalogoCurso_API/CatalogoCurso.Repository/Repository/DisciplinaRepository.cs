using CatalogoCurso.Domain.Curso;
using CatalogoCurso.Domain.Curso.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository.Repository
{
    public class DisciplinaRepository : RepositoryBase<Disciplina>, IDisciplinaRepository
    {
        public DisciplinaRepository(CatalogoCursoContext context) : base(context)
        {

        }

        public override async Task<IEnumerable<Disciplina>> ObterTodos()
        {
            return await this.Query
                             .Include(c => c.ModalidadeEnsino)
                             .Include(c => c.Segmento)
                             .Where(c => c.Ativo)
                             .AsNoTrackingWithIdentityResolution()
                             .ToListAsync();
        }

        public override async Task<Disciplina> ObterPorId(Guid id)
        {
            return await this.Query
                             .Include(c => c.ModalidadeEnsino)
                             .Include(c => c.Segmento)
                              .AsNoTrackingWithIdentityResolution()
                              .FirstOrDefaultAsync(x => x.Id == id && x.Ativo);
        }

    }
}
