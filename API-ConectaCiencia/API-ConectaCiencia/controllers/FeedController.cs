﻿using API_ConectaCiencia.models;
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
    }
}