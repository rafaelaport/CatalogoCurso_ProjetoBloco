﻿using CatalogoCurso.Domain.Disciplina;
using CatalogoCurso.Domain.Disciplina.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Repository.Repository
{
    public class ModalidadeEnsinoRepository : RepositoryBase<ModalidadeEnsino>, IModalidadeEnsinoRepository
    {
        public ModalidadeEnsinoRepository(CatalogoCursoContext context) : base(context)
        {
        }
    }
}
