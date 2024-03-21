using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Curso.Factory
{
    public static class DisciplinaFactory
    {
        public static Disciplina Cadastrar(Disciplina curso)
        {
            return new Disciplina
            {
                Nome = curso.Nome,
                Objetivo = curso.Objetivo,
                Bibliografia = curso.Bibliografia,
                Avaliacao = curso.Avaliacao,
                Certificacao = curso.Certificacao,
                ModalidadeEnsinoId = curso.ModalidadeEnsinoId,
                SegmentoId = curso.SegmentoId,
                DataCadastro = DateTime.Now,
                Ativo = true
            };
        }
    }
}
