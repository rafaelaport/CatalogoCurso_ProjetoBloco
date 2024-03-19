using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Conta.Dto
{
    public class UsuarioDto
    {
        [Required]
        public Guid Id { get; set; }

        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }
    }
}
