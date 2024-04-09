using AutoMapper;
using CatalogoCurso.Application.Conta.Dto;
using CatalogoCurso.Application.Conta;
using CatalogoCurso.Domain.Conta;
using CatalogoCurso.Repository.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCurso.Application.Disciplina.Dto;
using CatalogoCurso.Domain.Disciplina;
using CatalogoCurso.Application.Disciplina;
using CatalogoCurso.Domain.Disciplina.Repository;

namespace CatalogoCurso.Test.Application
{
    public class DisciplinaServiceTests
    {
        [Fact]
        public async Task DeveCriarDisciplinaComSucesso()
        {
            DisciplinaDto disciplinaDto = new DisciplinaDto()
            {
                Id = Guid.NewGuid(),
                Nome = "Disciplina Dto",
                Objetivo = "Objetivo",
                Bibliografia = "Bibliografia",
                Avaliacao = "Avaliação",
                Certificacao = "Certificação",
                ModalidadeEnsinoId = Guid.Parse("40D79441-6F06-4A62-BD9E-1400CA1C4C7A"),
                SegmentoId =  Guid.Parse("3FB20675-B555-468A-A32E-0F548F23F19C")

            };

            Mock<IDisciplinaRepository> mockRepository = new Mock<IDisciplinaRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Disciplina disciplina = new Disciplina()
            {
                Id = Guid.NewGuid(),
                Nome = "Disciplina Dto",
                Objetivo = "Objetivo",
                Bibliografia = "Bibliografia",
                Avaliacao = "Avaliação",
                Certificacao = "Certificação",
                ModalidadeEnsinoId = Guid.Parse("40D79441-6F06-4A62-BD9E-1400CA1C4C7A"),
                SegmentoId = Guid.Parse("3FB20675-B555-468A-A32E-0F548F23F19C"),
                DataCadastro = DateTime.Now,
                Ativo = true
            };

            mockMapper.Setup(x => x.Map<Disciplina>(disciplinaDto)).Returns(disciplina);
            mockRepository.Setup(x => x.Salvar(It.IsAny<Disciplina>())).Returns(Task.FromResult(disciplina));
            mockMapper.Setup(x => x.Map<DisciplinaDto>(disciplina)).Returns(disciplinaDto);

            var service = new DisciplinaService(mockMapper.Object, mockRepository.Object);
            var result = await service.CriarDisciplina(disciplinaDto);

            Assert.NotNull(result);
        }

    }
}
