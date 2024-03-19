using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.CrossCutting.Entity
{
    public class Entity<T>
    {
        public virtual Guid Id { get; set; }
        public virtual bool Ativo { get; set; }
        public virtual DateTime DataCadastro { get; set; }

    }
}
