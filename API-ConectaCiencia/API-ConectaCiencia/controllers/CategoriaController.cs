using Microsoft.AspNetCore.Mvc;
using API_ConectaCiencia.Model;
using API_ConectaCiencia.Repository;
using System.Collections.Generic;

namespace API_ConectaCiencia.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly CategoriaRepository _categoriaRepository;

        public CategoriaController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("conexao");
            _categoriaRepository = new CategoriaRepository(connectionString);
        }

        [HttpGet]
        public IEnumerable<CategoriaModel> Pesquisa()
        {
            return _categoriaRepository.Pesquisa();
        }
    }
}