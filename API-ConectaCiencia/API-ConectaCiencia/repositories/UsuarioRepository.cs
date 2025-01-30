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
}


