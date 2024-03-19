using CatalogoCurso.Domain.Conta;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Conta.Dto
{
    public class AlunoDto: UsuarioDto
    {
        [Required]
        public string Matricula { get; set; }

        

    }
}
