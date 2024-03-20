using CatalogoCurso.CrossCutting.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Unidade
{
    public class Unidade : Entity<Unidade>
    {
        public string Endereco { get; set; }
    }
}
