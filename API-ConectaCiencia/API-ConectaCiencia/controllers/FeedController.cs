using API_ConectaCiencia.models;
using API_ConectaCiencia.repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_ConectaCiencia.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FeedController : ControllerBase
    {
        private readonly FeedRepository _feedRepository;

        public FeedController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("conexao");
            _feedRepository = new FeedRepository(connectionString);
        }

        [HttpGet]
        public ActionResult<IEnumerable<ArtigoModel>> Pesquisa([FromQuery] string textoPesquisa = null, [FromQuery] string nomeCategoria = null, [FromQuery] DateTime? dataPublicacao = null)
        {
            try
            {
                var artigos = _feedRepository.Pesquisa(textoPesquisa, nomeCategoria, dataPublicacao);
                if (artigos == null || !artigos.Any())
                {
                    return NotFound("Nenhum artigo encontrado.");
                }
                return Ok(artigos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao obter os artigos: {ex.Message}");
            }
        }

        [HttpGet("MeusArtigos")]
        public ActionResult<IEnumerable<ArtigoModel>> PesquisaMeusArtigos(int id_usuario)
        {
            try
            {
                var artigos = _feedRepository.PesquisaMeusArtigos(id_usuario);
                if (artigos == null || !artigos.Any())
                {
                    return NotFound("Nenhum artigo encontrado.");
                }
                return Ok(artigos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao obter os artigos: {ex.Message}");
            }
        }

        [HttpGet("Artigo/{id}")]
        public async Task<IActionResult> ObterArtigoPorId(int id)
        {
            var artigoExistente = await _feedRepository.ObterPublicacaoPorId(id);
            if (artigoExistente == null)
            {
                return null;
            }

            return Ok(artigoExistente);
        }

        [HttpPost("Artigo")]
        public async Task<IActionResult> AdicionarPublicacao([FromBody] ArtigoModel artigoModel)
        {
            if (artigoModel == null)
            {
                return BadRequest("Dados de publicação não fornecidos.");
            }

            if (string.IsNullOrEmpty(artigoModel.Titulo) || string.IsNullOrEmpty(artigoModel.Conteudo) || artigoModel.Categoria == null)
            {
                return BadRequest("Dados incompletos: título, conteúdo e categoria são obrigatórios.");
            }

            if (artigoModel.Usuario == null || artigoModel.Usuario.Id_Usuario <= 0 || string.IsNullOrEmpty(artigoModel.Usuario.Nome))
            {
                return Unauthorized("Usuário não está autenticado.");
            }

            var artigoCompleto = new ArtigoModel
            {
                Titulo = artigoModel.Titulo,
                Conteudo = artigoModel.Conteudo,
                Categoria = artigoModel.Categoria,
                Usuario = new UsuarioSimplificado
                {
                    Id_Usuario = artigoModel.Usuario.Id_Usuario,
                    Nome = artigoModel.Usuario.Nome
                },
                Data = DateTime.UtcNow
            };

            try
            {
                await _feedRepository.AdicionarPublicacao(artigoCompleto);
                return Ok("Publicação adicionada com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao adicionar a publicação: {ex.Message}");
            }
        }

        [HttpPatch("Artigo/Patch/{id}")]
        public async Task<IActionResult> AtualizarPublicacao(int id, [FromBody] ArtigoModel artigoModel)
        {
            if (artigoModel == null)
            {
                return BadRequest("Dados de publicação não fornecidos.");
            }

            if (string.IsNullOrEmpty(artigoModel.Titulo) && string.IsNullOrEmpty(artigoModel.Conteudo) && artigoModel.Categoria == null)
            {
                return BadRequest("Pelo menos um dos seguintes campos deve ser preenchido: título, conteúdo ou categoria.");
            }

            var artigoExistente = await _feedRepository.ObterPublicacaoPorId(id);
            if (artigoExistente == null)
            {
                return NotFound("Publicação não encontrada.");
            }

            if (artigoModel.Titulo != null)
            {
                artigoExistente.Titulo = artigoModel.Titulo;
            }

            if (artigoModel.Conteudo != null)
            {
                artigoExistente.Conteudo = artigoModel.Conteudo;
            }

            if (artigoModel.Categoria != null)
            {
                artigoExistente.Categoria = artigoModel.Categoria;
            }

            try
            {
                await _feedRepository.AtualizarPublicacao(artigoExistente);
                return Ok("Publicação atualizada com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao atualizar a publicação: {ex.Message}");
            }
        }

        [HttpDelete("Artigo/Delete/{id}")]
        public async Task<IActionResult> DeletarPublicacao(int id)
        {
            var artigoExistente = await _feedRepository.ObterPublicacaoPorId(id);
            if (artigoExistente == null)
            {
                return NotFound("Publicação não encontrada.");
            }

            try
            {
                await _feedRepository.DeletarPublicacao(id);
                return Ok("Publicação deletada com sucesso.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao deletar a publicação: {ex.Message}");
            }
        }
    }
}