using AutoMapper;
using CatalogoCurso.Application.Conta;
using CatalogoCurso.Application.Conta.Dto;
using CatalogoCurso.Domain.Conta;
using CatalogoCurso.Domain.Conta.Repository;
using CatalogoCurso.Repository.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Test.Application
{
    public class UsuarioServiceTests
    {
        [Fact]
        public async Task DeveCriarProfessorComSucesso()
        {
            ProfessorDto professorDto = new ProfessorDto()
            {
                Id = Guid.NewGuid(),
                Nome = "Professor Dto",
                Email = "professor@gmail.com",
                Senha = "123456",
                DataNascimento = DateTime.Now,
                Titulo = "Mestre"
            };

            Mock<IUsuarioRepository> mockRepository = new Mock<IUsuarioRepository>();
            Mock<IMapper> mockMapper = new Mock<IMapper>();

            Professor professor = new Professor()
            {
                Nome = "Professor",
                Email = "professor@gmail.com",
                Senha = "1234",
                DataNascimento = DateTime.Now,
                Titulo = "Mestre",
                DataCadastro = DateTime.Now,
                Ativo = true
            };

            mockMapper.Setup(x => x.Map<Professor>(professorDto)).Returns(professor);
            mockRepository.Setup(x => x.Salvar(It.IsAny<Usuario>())).Returns(Task.FromResult(professor));
            mockMapper.Setup(x => x.Map<ProfessorDto>(professor)).Returns(professorDto);            

            var service = new UsuarioService(mockMapper.Object, mockRepository.Object);
            var result = await service.CriarProfessor(professorDto);

            Assert.NotNull(result);
        }
    }
}
