using AutoMapper;
using CatalogoCurso.Application.Conta.Dto;
using CatalogoCurso.Application.Disciplina.Dto;
using CatalogoCurso.Domain.Conta;
using CatalogoCurso.Domain.Disciplina.Repository;
using CatalogoCurso.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Disciplina
{
    public class DisciplinaService
    {
        private IMapper Mapper { get; set; }
        private IDisciplinaRepository DisciplinaRepository { get; set; }

        public DisciplinaService(IMapper mapper, IDisciplinaRepository disciplinaRepository)
        {
            Mapper = mapper;
            DisciplinaRepository = disciplinaRepository;
        }

        public async Task<DisciplinaDto> CriarDisciplina(DisciplinaDto disciplinaDto)
        {
            var disciplina = this.Mapper.Map<Domain.Disciplina.Disciplina>(disciplinaDto);
            var disciplinaCriado = disciplina.Cadastrar(disciplina);

            await this.DisciplinaRepository.Salvar(disciplinaCriado);
            var result = this.Mapper.Map<DisciplinaDto>(disciplinaCriado);

            return result;
        }

        public async Task<DisciplinaDto> EditarDisciplina(DisciplinaDto disciplinaDto)
        {
            var disciplina = this.Mapper.Map<Domain.Disciplina.Disciplina>(disciplinaDto);

            disciplina.Atualizar(disciplina);

            await this.DisciplinaRepository.Atualizar(disciplina);

            return this.Mapper.Map<DisciplinaDto>(disciplina);
        }

        public async Task<DisciplinaDto> ExcluirDisciplina(Guid id)
        {
            var disciplina = await this.DisciplinaRepository.ObterPorId(id);

            disciplina.Destivar();

            await this.DisciplinaRepository.Desativar(disciplina);

            return this.Mapper.Map<DisciplinaDto>(disciplina);
        }


        public async Task<DisciplinaDto> ObterDisciplinaPorId(Guid id)
        {
            var disciplina = await this.DisciplinaRepository.ObterPorId(id);

            return this.Mapper.Map<DisciplinaDto>(disciplina);
        }

        public async Task<IEnumerable<DisciplinaDto>> ObterTodos()
        {
            var disciplina = await this.DisciplinaRepository.ObterTodos();

            return this.Mapper.Map<IEnumerable<DisciplinaDto>>(disciplina);
        }
    }
}
