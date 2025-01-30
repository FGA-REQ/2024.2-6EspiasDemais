using API_ConectaCiencia.models;
using Microsoft.AspNetCore.Mvc;
using API_ConectaCiencia.repositories;

namespace API_ConectaCiencia.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("conexao");
            _usuarioRepository = new UsuarioRepository(connectionString);
        }

        [HttpGet("login")]
        public ActionResult<dynamic> Login(string email, string senha)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                return BadRequest("E-mail e senha são obrigatórios.");
            }

            try
            {
                var user = _usuarioRepository.ObterUsuarioPorEmailESenha(email, senha);
                if (user != null)
                {
                    return Ok(new { Id_Usuario = user.Id_Usuario, Nome = user.Nome });
                }
                return Unauthorized("E-mail ou senha inválidos.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }

        [HttpPost("cadastro")]
        public ActionResult<dynamic> Register([FromBody] UsuarioModel usuario)
        {
            if (usuario == null || string.IsNullOrEmpty(usuario.Nome) || string.IsNullOrEmpty(usuario.Email) || string.IsNullOrEmpty(usuario.Senha))
            {
                return BadRequest("Nome, e-mail e senha são obrigatórios.");
            }

            try
            {
                var idUsuario = _usuarioRepository.AdicionarUsuario(usuario);

                return CreatedAtAction(nameof(Login), new { email = usuario.Email }, new { Id_Usuario = idUsuario, Nome = usuario.Nome });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro interno no servidor: {ex.Message}");
            }
        }
    }
}