using CatalogoCurso.CrossCutting.Entity;
using CatalogoCurso.CrossCutting.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository
{
    public class RepositoryBase<T> : IRepository<T> where T : Entity<T>
    {
        public DbSet<T> Query { get; set; }
        public DbContext Context { get; set; }

        public RepositoryBase(CatalogoCursoContext context)
        {
            Context = context;
            Query = Context.Set<T>();
        }

        public async Task Desativar(T entity)
        {
            Query.Update(entity);
            await Context.SaveChangesAsync();
        }

        public virtual async Task<T> ObterPorId(Guid id)
        {
            return await Query
                              .AsNoTrackingWithIdentityResolution()
                              .FirstOrDefaultAsync(x => x.Id == id && x.Ativo);
        }

        public virtual async Task<IEnumerable<T>> ObterTodos()
        {
            return await Query.Where(x => x.Ativo)
                             .AsNoTrackingWithIdentityResolution()
                             .ToListAsync();
        }
        public virtual async Task Salvar(T entity)
        {
            await this.Query.AddAsync(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task Atualizar(T entity)
        {
            Query.Update(entity);
            await Context.SaveChangesAsync();

        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return this.Context.Set<T>().Where(expression);
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return this.Find(expression).Any();
        }
    }
}
