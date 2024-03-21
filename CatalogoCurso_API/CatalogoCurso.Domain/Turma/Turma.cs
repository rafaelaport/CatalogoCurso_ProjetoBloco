using CatalogoCurso.CrossCutting.Entity;
using CatalogoCurso.Domain.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Turma
{
    public class Turma : Entity<Turma>
    {
        public int Horario { get; set; }
        public int Sala {get; set; }

        public Guid ProfessorId { get; set; }
        public Guid AlunoId { get; set; }
        public Guid UnidadeId { get; set; }
        public Guid DisciplinaId { get; set; }
    }
}
