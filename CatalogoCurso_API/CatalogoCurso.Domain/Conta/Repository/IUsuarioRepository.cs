﻿using CatalogoCurso.CrossCutting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Domain.Conta.Repository
{
    public interface IUsuarioRepository: IRepository<Usuario>
    {
    }
}
