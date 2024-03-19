using AutoMapper;
using CatalogoCurso.Application.Conta.Dto;
using CatalogoCurso.Domain.Conta;
using CatalogoCurso.Domain.Conta.Repository;
using CatalogoCurso.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Conta
{
    public class UsuarioService
    {
        private IMapper Mapper { get; set; }
        private UsuarioRepository UsuarioRepository { get; set; }

        public UsuarioService(IMapper mapper, UsuarioRepository usuarioRepository)
        {
            Mapper = mapper;
            UsuarioRepository = usuarioRepository;
        }

        public async Task<ProfessorDto> CriarProfessor(ProfessorDto professorDto)
        {
           if (this.UsuarioRepository.Exists(x => x.Email == professorDto.Email))
                throw new Exception("Usuário já existente na base");

            var professor = this.Mapper.Map<Professor>(professorDto);
            var professorCriado = professor.Cadastrar(professor);

            await this.UsuarioRepository.Salvar(professorCriado);
            var result = this.Mapper.Map<ProfessorDto>(professorCriado);

            return result;
        }

        public async Task<ProfessorDto> EditarProfessor(ProfessorDto professorDto)
        {
            var professor = this.Mapper.Map<Professor>(professorDto);

            professor.Editar(professor);

            await this.UsuarioRepository.Atualizar(professor);

            return this.Mapper.Map<ProfessorDto>(professor);
        }

        public async Task<ProfessorDto> ExcluirProfessor(Guid id)
        {
            var professor = await this.UsuarioRepository.ObterPorId(id);
            
            professor.Excluir(professor);

            await this.UsuarioRepository.Desativar(professor);

            return this.Mapper.Map<ProfessorDto>(professor);
        }


        public async Task<ProfessorDto> ObterProfessorPorId(Guid id)
        { 
            var professor = await this.UsuarioRepository.ObterPorId(id);

            return this.Mapper.Map<ProfessorDto>(professor);
        }

        public async Task<AlunoDto> CriarAluno(AlunoDto alunoDto)
        {
            if (this.UsuarioRepository.Exists(x => x.Email == alunoDto.Email))
                throw new Exception("Usuário já existente na base");

            var aluno = this.Mapper.Map<Aluno>(alunoDto);
            var alunoCriado = aluno.Cadastrar(aluno);

            await this.UsuarioRepository.Salvar(alunoCriado);
            var result = this.Mapper.Map<AlunoDto>(alunoCriado);

            return result;
        }

        public async Task<AlunoDto> EditarAluno(AlunoDto alunoDto)
        {
            var aluno = this.Mapper.Map<Aluno>(alunoDto);

            aluno.Editar(aluno);

            await this.UsuarioRepository.Atualizar(aluno);

            return this.Mapper.Map<AlunoDto>(aluno);
        }

        public async Task<AlunoDto> ExcluirAluno(Guid id)
        {
            var aluno = await this.UsuarioRepository.ObterPorId(id);

            aluno.Excluir(aluno);

            await this.UsuarioRepository.Desativar(aluno);

            return this.Mapper.Map<AlunoDto>(aluno);
        }


        public async Task<AlunoDto> ObterAlunoPorId(Guid id)
        {
            var aluno = await this.UsuarioRepository.ObterPorId(id);

            return this.Mapper.Map<AlunoDto>(aluno);
        }

        public async Task<IEnumerable<UsuarioDto>> ObterTodos()
        {
            var usuario = await this.UsuarioRepository.ObterTodos();

            return this.Mapper.Map<IEnumerable<UsuarioDto>>(usuario);
        }
    }
}
