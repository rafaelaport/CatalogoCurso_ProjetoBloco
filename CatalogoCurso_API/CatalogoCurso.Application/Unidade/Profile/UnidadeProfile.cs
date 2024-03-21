using CatalogoCurso.Application.Unidade.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Unidade.Profile
{
    public class UnidadeProfile : AutoMapper.Profile
    {
        public UnidadeProfile()
        {
            CreateMap<Domain.Unidade.Unidade, UnidadeDto>();
            CreateMap<UnidadeDto, Domain.Unidade.Unidade>();
        }
    }
}
