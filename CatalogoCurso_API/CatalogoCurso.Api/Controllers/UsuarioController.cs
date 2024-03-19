using CatalogoCurso.Application.Conta;
using CatalogoCurso.Application.Conta.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoCurso.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService) 
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        [Route("professor/criar")]
        public async Task<IActionResult> CriarProfessor([FromBody] ProfessorDto dto)
        {
            var result = await this._usuarioService.CriarProfessor(dto);

            return Ok(result);
        }

        [HttpPost]
        [Route("professor/editar")]
        public async Task<IActionResult> EditarProfessor([FromBody] ProfessorDto dto)
        {
            var result = await this._usuarioService.EditarProfessor(dto);

            return Ok(result);
        }

        [HttpGet]
        [Route("professor/obter-por-id/{id}")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            var result = await this._usuarioService.ObterPorId(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("professor/excluir/{id}")]
        public async Task<IActionResult> Excluir(Guid id)
        {
            var result = await this._usuarioService.ExcluirProfessor(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("obter-todos")]
        public async Task<IActionResult> ObterTodos()
        {
            var result = await this._usuarioService.ObterTodos();
            return Ok(result);
        }


    }
}
