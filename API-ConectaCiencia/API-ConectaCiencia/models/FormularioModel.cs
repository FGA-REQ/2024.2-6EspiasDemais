using API_ConectaCiencia.Model;

namespace API_ConectaCiencia.models
{
    public class FormularioModel
    {
        public class FormularioTema
        {
            public int IdSugestaoTema { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Tema { get; set; }
            public int Id_Categoria { get; set; }
            public CategoriaModel Categoria { get; set; }
        }
        public class FormularioArtigo
        {
            public int IdSugestaoArtigo { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Titulo { get; set; }
            public string Conteudo { get; set; }
            public int Id_Categoria { get; set; }
            public CategoriaModel Categoria { get; set; }

        }
    }
}
