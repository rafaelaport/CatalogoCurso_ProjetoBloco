using CatalogoCurso.CrossCutting.Entity;
using CatalogoCurso.Domain.Conta.Factory;
using CatalogoCurso.Domain.Curso.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Conta
{
    public class Usuario : Entity<Usuario>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        public Aluno Cadastrar(Aluno aluno)
        {
            return AlunoFactory.Cadastrar(aluno);
        }

        public Professor Cadastrar(Professor professor)
        {
            return ProfessorFactory.Cadastrar(professor);
        }

        public void Excluir(Usuario professor)
        {
            Ativo = false;
        }

    }

}

