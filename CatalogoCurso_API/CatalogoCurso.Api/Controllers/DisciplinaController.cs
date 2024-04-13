using CatalogoCurso.Application.Conta;
using CatalogoCurso.Application.Conta.Dto;
using CatalogoCurso.Application.Disciplina;
using CatalogoCurso.Application.Disciplina.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoCurso.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private DisciplinaService _disciplinaService;

        public DisciplinaController(DisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }

        [HttpPost]
        [Route("criar")]
        public async Task<IActionResult> CriarDisciplina([FromBody] DisciplinaDto dto)
        {
            try
            {
                var result = await this._disciplinaService.CriarDisciplina(dto);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("editar")]
        public async Task<IActionResult> EditarDisciplina([FromBody] DisciplinaDto dto)
        {
            try
            {
                var result = await this._disciplinaService.EditarDisciplina(dto);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("obter-por-id/{id}")]
        public async Task<IActionResult> ObterDisciplinaPorId(Guid id)
        {
            try
            {
                var result = await this._disciplinaService.ObterDisciplinaPorId(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("excluir/{id}")]
        public async Task<IActionResult> ExcluirDisciplina(Guid id)
        {
            try
            {
                var result = await this._disciplinaService.ExcluirDisciplina(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("obter-todos")]
        public async Task<IActionResult> ObterTodos()
        {
            try
            {
                var result = await this._disciplinaService.ObterTodos();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
