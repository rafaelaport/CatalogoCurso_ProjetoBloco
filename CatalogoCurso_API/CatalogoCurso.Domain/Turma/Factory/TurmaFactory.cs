using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Turma.Factory
{
    public static class TurmaFactory
    {
        public static Turma Cadastrar(Turma turma)
        {
            return new Turma
            {
                Horario = turma.Horario,
                Sala = turma.Sala,
                DataCadastro = turma.DataCadastro,
                Ativo = true
            };
        }
    }
}
