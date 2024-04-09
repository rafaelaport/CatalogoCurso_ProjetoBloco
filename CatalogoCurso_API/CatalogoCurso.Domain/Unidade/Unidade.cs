using CatalogoCurso.CrossCutting.Entity;
using CatalogoCurso.Domain.Disciplina;
using CatalogoCurso.Domain.Disciplina.Factory;
using CatalogoCurso.Domain.Unidade.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Unidade
{
    public class Unidade : Entity<Unidade>
    {
        public string Endereco { get; set; }

        public void Destivar()
        {
            Ativo = false;
        }

        public Unidade Cadastrar(Unidade unidade)
        {
            return UnidadeFactory.Cadastrar(unidade);
        }

        public void Atualizar(Unidade unidade)
        {
            Id = unidade.Id;
            Endereco = unidade.Endereco;
            DataCadastro = DateTime.Now;
            Ativo = true;
        }
    }
}
