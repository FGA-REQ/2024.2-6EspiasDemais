using Microsoft.AspNetCore.Mvc;

namespace API_ConectaCiencia.controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsuarioController
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioController(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("conexao");
            _usuarioRepository = new UsuarioRepository(connectionString);
        }
    }
}
