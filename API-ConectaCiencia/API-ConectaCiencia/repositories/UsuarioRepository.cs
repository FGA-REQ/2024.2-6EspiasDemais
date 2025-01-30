using API_ConectaCiencia.models;
using API_ConectaCiencia.Model;
using Microsoft.Data.SqlClient;

namespace API_ConectaCiencia.repositories 
{
    private readonly string _connectionString;
    public UsuarioRepository(string connectionString)
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new Exception("ConnectionString sem valor válido");
        }
        _connectionString = connectionString;
    }
    public UsuarioModel ObterUsuarioPorEmailESenha(string email, string senha)
    {
        UsuarioModel usuario = null;
        var sql = @"SELECT * FROM Usuarios 
                    WHERE Email = @Email AND Senha = @Senha";
        var parameters = new List<SqlParameter>
        {
            new SqlParameter("@Email", email),
            new SqlParameter("@Senha", senha)
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
                        if (reader.Read())
                        {
                            usuario = new UsuarioModel
                            {
                                Id_Usuario = reader.GetInt32(reader.GetOrdinal("Id_Usuario")),
                                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Senha = reader.GetString(reader.GetOrdinal("Senha"))
                            };
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Erro ao acessar o banco de dados.", ex);
        }
        return usuario;
    }
}


