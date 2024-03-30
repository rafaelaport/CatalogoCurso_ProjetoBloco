using CatalogoCurso.Application.Turma.Dto;
using CatalogoCurso.Application.Unidade.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Turma.Profile
{
    public class TurmaProfile : AutoMapper.Profile
    {
        public TurmaProfile()
        {
            CreateMap<Domain.Turma.Turma, TurmaDto>();
            CreateMap<TurmaDto, Domain.Turma.Turma>();
        }
    }
}
