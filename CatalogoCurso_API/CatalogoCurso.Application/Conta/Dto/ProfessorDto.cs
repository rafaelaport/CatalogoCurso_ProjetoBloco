using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Conta.Dto
{
    public class ProfessorDto: UsuarioDto
    {
        [Required]
        public string Titulo { get; set; }
    }
}
