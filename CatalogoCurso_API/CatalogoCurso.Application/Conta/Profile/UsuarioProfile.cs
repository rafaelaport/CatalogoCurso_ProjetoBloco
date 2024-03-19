using CatalogoCurso.Application.Conta.Dto;
using CatalogoCurso.Domain.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Conta.Profile
{
    public class UsuarioProfile : AutoMapper.Profile
    {
        public UsuarioProfile()
        {
            CreateMap<ProfessorDto, Professor>();

            CreateMap<Professor, ProfessorDto>()
                .AfterMap((s, d) =>
                {
                    d.Senha = "xxxxxxxxx";

                });

            CreateMap<UsuarioDto, Usuario>();

            CreateMap<Usuario, UsuarioDto>()
            .AfterMap((s, d) =>
            {
                d.Senha = "xxxxxxxxx";

            });
        }
    }
}

