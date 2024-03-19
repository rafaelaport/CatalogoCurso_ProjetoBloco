﻿using CatalogoCurso.Domain.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Conta
{
    public class Aluno : Usuario
    {
        public string Matricula { get; set; }

        public void Editar(Aluno aluno)
        {
            Nome = aluno.Nome;
            Email = aluno.Email;
            Senha = aluno.Senha;
            DataNascimento = aluno.DataNascimento;
            Matricula = aluno.Matricula;
            DataCadastro = DateTime.Now;
            Ativo = true;
        }
    }
}
