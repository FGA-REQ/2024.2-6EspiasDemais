using API_ConectaCiencia.models;
using Microsoft.Data.SqlClient;

namespace API_ConectaCiencia.repositories
{
    public class FormularioRepository
    {
        private readonly string _connectionString;

        public FormularioRepository(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("ConnectionString sem valor válido");
            }
            _connectionString = connectionString;
        }

        public async Task AdicionarTema(FormularioModel.FormularioTema formularioTema)
        {
            var sql = @"INSERT INTO FormularioTema (nome, email, tema, id_categoria)
                        VALUES (@nome, @email, @tema, @id_categoria)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nome", formularioTema.Nome);
                    command.Parameters.AddWithValue("@email", formularioTema.Email);
                    command.Parameters.AddWithValue("@tema", formularioTema.Tema);
                    command.Parameters.AddWithValue("@id_categoria", formularioTema.Id_Categoria);

                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
