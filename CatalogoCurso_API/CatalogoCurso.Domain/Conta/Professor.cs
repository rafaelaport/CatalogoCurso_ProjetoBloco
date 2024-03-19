using CatalogoCurso.Domain.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Conta
{
    public class Professor: Usuario
    {
        public string Titulo { get; set; }

        public void Editar(Professor professor)
        {
            Nome = professor.Nome;
            Email = professor.Email;
            Senha = professor.Senha;
            DataNascimento = professor.DataNascimento;
            Titulo = professor.Titulo;
            DataCadastro = DateTime.Now;
            Ativo = true;
        }

        
    }
}
