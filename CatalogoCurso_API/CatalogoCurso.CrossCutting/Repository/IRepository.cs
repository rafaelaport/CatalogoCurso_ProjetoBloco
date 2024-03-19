using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.CrossCutting.Repository
{
    public interface IRepository<T> where T : class
    {
        Task Salvar(T entity);
        Task Desativar(T entity);
        Task Atualizar(T entity);
        Task<T> ObterPorId(Guid id);
        Task<IEnumerable<T>> ObterTodos();
        

    }
}
