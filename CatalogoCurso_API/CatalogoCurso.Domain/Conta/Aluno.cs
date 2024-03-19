using CatalogoCurso.Domain.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Conta
{
    public class Aluno : Usuario
    {
        public string Matricula { get; set; }
    }
}
