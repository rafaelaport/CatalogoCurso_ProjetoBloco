using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Curso.Factory
{
    public static class CursoFactory
    {
        public static Curso Cadastrar(Curso curso)
        {
            return new Curso
            {
                Nome = curso.Nome,
                Objetivo = curso.Objetivo,
                Bibliografia = curso.Bibliografia,
                Avaliacao = curso.Avaliacao,
                Certificacao = curso.Certificacao,
                ModalidadeEnsinoId = curso.ModalidadeEnsinoId,
                TipoCursoId = curso.TipoCursoId,
                SegmentoId = curso.SegmentoId,
                DataCadastro = DateTime.Now,
                Ativo = true
            };
        }
    }
}
