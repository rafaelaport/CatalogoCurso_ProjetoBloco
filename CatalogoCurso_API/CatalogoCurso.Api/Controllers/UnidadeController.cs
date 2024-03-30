using CatalogoCurso.Application.Turma.Dto;
using CatalogoCurso.Application.Turma;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CatalogoCurso.Application.Unidade;
using CatalogoCurso.Application.Unidade.Dto;

namespace CatalogoCurso.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadeController : ControllerBase
    {
        private UnidadeService _unidadeService;

        public UnidadeController(UnidadeService unidadeService)
        {
            _unidadeService = unidadeService;
        }

        [HttpPost]
        [Route("criar")]
        public async Task<IActionResult> Criar([FromBody] UnidadeDto dto)
        {
            var result = await this._unidadeService.CriarUnidade(dto);

            return Ok(result);
        }

        [HttpPost]
        [Route("editar")]
        public async Task<IActionResult> Editar([FromBody] UnidadeDto dto)
        {
            var result = await this._unidadeService.EditarUnidade(dto);

            return Ok(result);
        }

        [HttpGet]
        [Route("obter-por-id/{id}")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            var result = await this._unidadeService.ObterUnidadePorId(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("excluir/{id}")]
        public async Task<IActionResult> Excluir(Guid id)
        {
            var result = await this._unidadeService.ExcluirUnidade(id);
            return Ok(result);
        }


        [HttpGet]
        [Route("obter-todos")]
        public async Task<IActionResult> ObterTodos()
        {
            var result = await this._unidadeService.ObterTodos();
            return Ok(result);
        }
    }
}
