using Microsoft.AspNetCore.Mvc;
using API_ConectaCiencia.Model;
using API_ConectaCiencia.Controller;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace API_ConectaCiencia.Repository
{
    public class CategoriaRepository
    {
        private readonly string _connectionString;

        public CategoriaRepository(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("ConnectionString sem valor válido");
            }
            _connectionString = connectionString;
        }

        public IEnumerable<CategoriaModel> Pesquisa()
        {
            var categorias = new List<CategoriaModel>();

            try
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();

                using SqlCommand command = new SqlCommand("SELECT * FROM Categorias", connection);
                using SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    categorias.Add(new CategoriaModel
                    {
                        Id_Categoria = reader.GetInt32(reader.GetOrdinal("id_categoria")),
                        Nome_Categoria = reader.GetString(reader.GetOrdinal("nome_categoria"))
                    });

                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados.", ex);
            }

            return categorias;
        }
    }
}