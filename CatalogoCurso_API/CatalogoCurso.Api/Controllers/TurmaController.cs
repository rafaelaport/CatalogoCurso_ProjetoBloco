using CatalogoCurso.Application.Disciplina.Dto;
using CatalogoCurso.Application.Disciplina;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CatalogoCurso.Application.Turma;
using CatalogoCurso.Application.Turma.Dto;

namespace CatalogoCurso.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private TurmaService _turmaService;

        public TurmaController(TurmaService turmaService)
        {
            _turmaService = turmaService;
        }

        [HttpPost]
        [Route("criar")]
        public async Task<IActionResult> Criar([FromBody] TurmaDto dto)
        {
            var result = await this._turmaService.CriarTurma(dto);

            return Ok(result);
        }

        [HttpPost]
        [Route("editar")]
        public async Task<IActionResult> Editar([FromBody] TurmaDto dto)
        {
            var result = await this._turmaService.EditarTurma(dto);

            return Ok(result);
        }

        [HttpGet]
        [Route("obter-por-id/{id}")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            var result = await this._turmaService.ObterTurmaPorId(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("excluir/{id}")]
        public async Task<IActionResult> Excluir(Guid id)
        {
            var result = await this._turmaService.ExcluirTurma(id);
            return Ok(result);
        }


        [HttpGet]
        [Route("obter-todos")]
        public async Task<IActionResult> ObterTodos()
        {
            var result = await this._turmaService.ObterTodos();
            return Ok(result);
        }
    }
}
