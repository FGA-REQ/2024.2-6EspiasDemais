using API_ConectaCiencia.Model;

namespace API_ConectaCiencia.models
{
    public class ArtigoModel
    {
        public int Id_Artigo { get; set; }
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public CategoriaModel Categoria { get; set; }
        public UsuarioSimplificado Usuario { get; set; }

    }
}
