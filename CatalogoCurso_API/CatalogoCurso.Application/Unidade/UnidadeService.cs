using AutoMapper;
using CatalogoCurso.Application.Unidade.Dto;
using CatalogoCurso.Domain.Unidade.Repository;
using CatalogoCurso.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCurso.Application.Unidade
{
    public class UnidadeService
    {
        private IMapper Mapper { get; set; }
        private IUnidadeRepository UnidadeRepository { get; set; }

        public UnidadeService(IMapper mapper, IUnidadeRepository unidadeRepository)
        {
            Mapper = mapper;
            UnidadeRepository = unidadeRepository;
        }

        public async Task<UnidadeDto> CriarUnidade(UnidadeDto unidadeDto)
        {
            var unidade = this.Mapper.Map<Domain.Unidade.Unidade>(unidadeDto);
            var unidadeCriado = unidade.Cadastrar(unidade);

            await this.UnidadeRepository.Salvar(unidadeCriado);
            var result = this.Mapper.Map<UnidadeDto>(unidadeCriado);

            return result;
        }

        public async Task<UnidadeDto> EditarUnidade(UnidadeDto unidadeDto)
        {
            var unidade = this.Mapper.Map<Domain.Unidade.Unidade>(unidadeDto);

            unidade.Atualizar(unidade);

            await this.UnidadeRepository.Atualizar(unidade);

            return this.Mapper.Map<UnidadeDto>(unidade);
        }

        public async Task<UnidadeDto> ExcluirUnidade(Guid id)
        {
            var unidade = await this.UnidadeRepository.ObterPorId(id);

            unidade.Destivar();

            await this.UnidadeRepository.Desativar(unidade);

            return this.Mapper.Map<UnidadeDto>(unidade);
        }


        public async Task<UnidadeDto> ObterUnidadePorId(Guid id)
        {
            var unidade = await this.UnidadeRepository.ObterPorId(id);

            return this.Mapper.Map<UnidadeDto>(unidade);
        }

        public async Task<IEnumerable<UnidadeDto>> ObterTodos()
        {
            var unidade = await this.UnidadeRepository.ObterTodos();

            return this.Mapper.Map<IEnumerable<UnidadeDto>>(unidade);
        }
    }
}
