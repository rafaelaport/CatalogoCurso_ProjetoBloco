using CatalogoCurso.CrossCutting.Entity;
using CatalogoCurso.Domain.Conta;
using CatalogoCurso.Domain.Disciplina;
using CatalogoCurso.Domain.Turma.Factory;
using CatalogoCurso.Domain.Unidade.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Turma
{
    public class Turma : Entity<Turma>
    {
        public int Horario { get; set; }
        public int Sala {get; set; }

        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }
        public Domain.Unidade.Unidade Unidade { get; set; }
        public Disciplina.Disciplina Disciplina { get; set; }

        public Turma Cadastrar(Turma turma)
        {
            return TurmaFactory.Cadastrar(turma);
        }

        public void Atualizar(Turma turma)
        {
            Id = turma.Id;
            Horario = turma.Horario;
            Sala = turma.Sala;
            Professor = turma.Professor;
            Alunos = turma.Alunos;
            Unidade = turma.Unidade;
            Disciplina = turma.Disciplina;
        }

        public void Destivar()
        {
            Ativo = false;
        }
    }
}
