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

        public IEnumerable<ArtigoModel> PesquisaMeusArtigos(int id_usuario)
        {
            var artigos = new List<ArtigoModel>();
            var sql = @"SELECT a.*, c.nome_categoria, u.nome, u.id_usuario
                        FROM Artigos a
                        JOIN Categorias c ON a.id_categoria = c.id_categoria
                        JOIN Usuarios u ON a.id_usuario = u.id_usuario
                        WHERE a.id_usuario = @id_usuario
                        ORDER BY a.data DESC;";

            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@id_usuario", id_usuario)
            };

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
                                var artigo = new ArtigoModel
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
                                };

                                artigos.Add(artigo);
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

        public async Task<ArtigoModel> ObterPublicacaoPorId(int id)
        {
            ArtigoModel artigo = null;
            var sql = @"SELECT a.*, c.nome_categoria, u.nome, u.id_usuario
                FROM Artigos a
                JOIN Categorias c ON a.id_categoria = c.id_categoria
                JOIN Usuarios u ON a.id_usuario = u.id_usuario
                WHERE a.id_artigo = @id_artigo";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_artigo", id);
                    connection.Open();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            artigo = new ArtigoModel
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
                            };
                        }
                    }
                }
            }

            return artigo;
        }

        public async Task AdicionarPublicacao(ArtigoModel artigoModel)
        {
            var sql = @"INSERT INTO Artigos (titulo, conteudo, id_categoria, id_usuario, nome, data) 
                VALUES (@titulo, @conteudo, @id_categoria, @id_usuario, @nome, @data)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@titulo", artigoModel.Titulo);
                    command.Parameters.AddWithValue("@conteudo", artigoModel.Conteudo);
                    command.Parameters.AddWithValue("@id_categoria", artigoModel.Categoria.Id_Categoria);
                    command.Parameters.AddWithValue("@id_usuario", artigoModel.Usuario.Id_Usuario);
                    command.Parameters.AddWithValue("@nome", artigoModel.Usuario.Nome);
                    command.Parameters.AddWithValue("@data", artigoModel.Data);

                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<bool> AtualizarPublicacao(ArtigoModel artigoModel)
        {
            var sql = @"UPDATE Artigos
                SET titulo = @titulo,
                    conteudo = @conteudo,
                    id_categoria = @id_categoria
                WHERE id_artigo = @id_artigo";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@titulo", artigoModel.Titulo);
                    command.Parameters.AddWithValue("@conteudo", artigoModel.Conteudo);
                    command.Parameters.AddWithValue("@id_categoria", artigoModel.Categoria.Id_Categoria);
                    command.Parameters.AddWithValue("@id_artigo", artigoModel.Id_Artigo);

                    connection.Open();
                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
        }

        public async Task<bool> DeletarPublicacao(int id)
        {
            var sql = @"DELETE FROM Artigos WHERE id_artigo = @id_artigo";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_artigo", id);

                    connection.Open();
                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
