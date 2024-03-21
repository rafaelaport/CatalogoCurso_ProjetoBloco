using CatalogoCurso.Domain.Conta;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Turma.Dto
{
    public class TurmaDto
    {
        [Required]
        public int Horario { get; set; }

        [Required]
        public int Sala { get; set; }

        [Required]
        public Professor Professor { get; set; }

        [Required]
        public List<Aluno> Alunos { get; set; }

        [Required]
        public Domain.Unidade.Unidade Unidade { get; set; }

        [Required]
        public Domain.Disciplina.Disciplina Disciplina { get; set; }
    }
}
