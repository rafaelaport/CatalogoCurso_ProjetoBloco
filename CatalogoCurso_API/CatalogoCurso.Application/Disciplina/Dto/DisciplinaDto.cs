using CatalogoCurso.Domain.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Disciplina.Dto
{
    public class DisciplinaDto
    {
        public string Nome { get; set; }
        public string? Objetivo { get; set; }
        public string? Bibliografia { get; set; }
        public string? Avaliacao { get; set; }
        public string? Certificacao { get; set; }

        public Guid ModalidadeEnsinoId { get; set; } // Ead ou prensencial

        public Guid SegmentoId { get; set; }
    }
}
