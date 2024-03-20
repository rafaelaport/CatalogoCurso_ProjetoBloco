using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Unidade.Factory
{
    public static class UnidadeFactory
    {
        public static Unidade Cadastrar(Unidade unidade)
        {
            return new Unidade
            {
                Endereco = unidade.Endereco,
                DataCadastro = unidade.DataCadastro,
                Ativo = true
            };
        }
    }
}
