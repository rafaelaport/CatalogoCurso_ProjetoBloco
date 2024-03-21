using CatalogoCurso.Domain.Disciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Disciplina.Dto
{
    public class DisciplinaDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Nome { get; set; }
        
        public string? Objetivo { get; set; }
        public string? Bibliografia { get; set; }
        public string? Avaliacao { get; set; }
        public string? Certificacao { get; set; }

        [Required]
        public Guid ModalidadeEnsinoId { get; set; } // Ead ou prensencial

        [Required]
        public Guid SegmentoId { get; set; }
    }
}
