using Microsoft.AspNetCore.Mvc;
using API_ConectaCiencia.Model;
using API_ConectaCiencia.repositories;
using API_ConectaCiencia.Repository;
using System.Collections.Generic;
using API_ConectaCiencia.models;

namespace API_ConectaCiencia.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormularioController : ControllerBase
    {
        private readonly FormularioRepository _formularioRepository;

        public FormularioController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("conexao");
            _formularioRepository = new FormularioRepository(connectionString);
        }

        [HttpPost("tema")]
        public async Task<IActionResult> AdicionarTema([FromBody] FormularioModel.FormularioTema formularioTema)
        {
            if (formularioTema == null)
            {
                return BadRequest("Dados do formulário de tema não fornecidos.");
            }

            try
            {
                await _formularioRepository.AdicionarTema(formularioTema);
                return Ok("Sugestão de tema adicionada com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao adicionar a sugestão de tema: {ex.Message}");
            }
        }
    }
}
