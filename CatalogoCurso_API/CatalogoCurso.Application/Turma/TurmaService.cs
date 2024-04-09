using AutoMapper;
using CatalogoCurso.Application.Turma.Dto;
using CatalogoCurso.Application.Unidade.Dto;
using CatalogoCurso.Domain.Turma.Repository;
using CatalogoCurso.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Turma
{
    public class TurmaService
    {
        private IMapper Mapper { get; set; }
        private ITurmaRepository TurmaRepository { get; set; }

        public TurmaService(IMapper mapper, ITurmaRepository turmaRepository)
        {
            Mapper = mapper;
            TurmaRepository = turmaRepository;
        }

        public async Task<TurmaDto> CriarTurma(TurmaDto turmaDto)
        {
            var turma = this.Mapper.Map<Domain.Turma.Turma>(turmaDto);
            var turmaCriada = turma.Cadastrar(turma);

            await this.TurmaRepository.Salvar(turmaCriada);
            var result = this.Mapper.Map<TurmaDto>(turmaCriada);

            return result;
        }

        public async Task<TurmaDto> EditarTurma(TurmaDto turmaDto)
        {
            var turma = this.Mapper.Map<Domain.Turma.Turma>(turmaDto);

            turma.Atualizar(turma);

            await this.TurmaRepository.Atualizar(turma);

            return this.Mapper.Map<TurmaDto>(turma);
        }

        public async Task<TurmaDto> ExcluirTurma(Guid id)
        {
            var turma = await this.TurmaRepository.ObterPorId(id);

            turma.Destivar();

            await this.TurmaRepository.Desativar(turma);

            return this.Mapper.Map<TurmaDto>(turma);
        }


        public async Task<TurmaDto> ObterTurmaPorId(Guid id)
        {
            var turma = await this.TurmaRepository.ObterPorId(id);

            return this.Mapper.Map<TurmaDto>(turma);
        }

        public async Task<IEnumerable<TurmaDto>> ObterTodos()
        {
            var turma = await this.TurmaRepository.ObterTodos();

            return this.Mapper.Map<IEnumerable<TurmaDto>>(turma);
        }
    }
}
