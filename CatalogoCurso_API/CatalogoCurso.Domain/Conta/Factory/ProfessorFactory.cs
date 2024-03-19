using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Conta.Factory
{
    public static class ProfessorFactory
    {
        public static Professor Cadastrar(Professor professor)
        {
            return new Professor
            {
                Nome = professor.Nome,
                Email = professor.Email,
                Senha = professor.Senha,
                DataNascimento = professor.DataNascimento,
                Titulo = professor.Titulo,
                DataCadastro = DateTime.Now,
                Ativo = true
            };
        }


    }
}
