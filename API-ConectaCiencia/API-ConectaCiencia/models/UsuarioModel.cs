namespace API_ConectaCiencia.models
{
    public class UsuarioModel
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public class UsuarioSimplificado
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
    }
}
