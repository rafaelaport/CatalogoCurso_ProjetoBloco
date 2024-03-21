using CatalogoCurso.Application.Disciplina.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Disciplina.Profile
{
    public class DisciplinaProfile : AutoMapper.Profile
    {
        public DisciplinaProfile()
        {
            CreateMap<Domain.Disciplina.Disciplina, DisciplinaDto>();
            CreateMap<DisciplinaDto, Domain.Disciplina.Disciplina>();
        }
    }
}
