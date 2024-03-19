using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Conta.Factory
{
    public static class AlunoFactory
    {
        public static Aluno Cadastrar(Aluno aluno)
        {
            return new Aluno
            {
                Nome = aluno.Nome,
                Email = aluno.Email,
                Senha = aluno.Senha,
                DataNascimento = aluno.DataNascimento,
                Matricula = aluno.Matricula,
                DataCadastro = DateTime.Now,
                Ativo = true
            };
        }
    }
}
