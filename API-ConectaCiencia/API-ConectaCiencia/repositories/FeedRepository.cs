using API_ConectaCiencia.Model;
using API_ConectaCiencia.models;
using Microsoft.Data.SqlClient;

namespace API_ConectaCiencia.repositories
{
    public class FeedRepository
    {
        private readonly string _connectionString;

        public FeedRepository(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("ConnectionString sem valor válido");
            }
            _connectionString = connectionString;
        }

        public IEnumerable<ArtigoModel> Pesquisa(string textoPesquisa = null, string nomeCategoria = null, DateTime? dataPublicacao = null)
        {
            var artigos = new List<ArtigoModel>();
            var sql = @"SELECT a.*, c.nome_categoria, u.nome, u.id_usuario
                        FROM Artigos a
                        JOIN Categorias c ON a.id_categoria = c.id_categoria
                        JOIN Usuarios u ON a.id_usuario = u.id_usuario
                        WHERE 1=1";
            var parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(textoPesquisa))
            {
                sql += " AND (a.titulo LIKE @textoPesquisa OR a.conteudo LIKE @textoPesquisa)";
                parameters.Add(new SqlParameter("@textoPesquisa", "%" + textoPesquisa + "%"));
            }

            if (!string.IsNullOrEmpty(nomeCategoria))
            {
                sql += " AND c.nome_categoria LIKE @nomeCategoria";
                parameters.Add(new SqlParameter("@nomeCategoria", "%" + nomeCategoria + "%"));
            }

            if (dataPublicacao.HasValue)
            {
                sql += " AND CAST(a.data AS DATE) = @dataPublicacao";
                parameters.Add(new SqlParameter("@dataPublicacao", dataPublicacao.Value.Date));
            }

            sql += " ORDER BY a.data DESC";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddRange(parameters.ToArray());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                artigos.Add(new ArtigoModel
                                {
                                    Id_Artigo = reader.GetInt32(reader.GetOrdinal("id_artigo")),
                                    Data = reader.GetDateTime(reader.GetOrdinal("data")),
                                    Titulo = reader.GetString(reader.GetOrdinal("titulo")),
                                    Conteudo = reader.GetString(reader.GetOrdinal("conteudo")),
                                    Usuario = new UsuarioSimplificado
                                    {
                                        Id_Usuario = reader.GetInt32(reader.GetOrdinal("id_usuario")),
                                        Nome = reader.GetString(reader.GetOrdinal("nome"))
                                    },
                                    Categoria = new CategoriaModel
                                    {
                                        Id_Categoria = reader.GetInt32(reader.GetOrdinal("id_categoria")),
                                        Nome_Categoria = reader.GetString(reader.GetOrdinal("nome_categoria"))
                                    }
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados.", ex);
            }

            return artigos;
        }
    }
}
