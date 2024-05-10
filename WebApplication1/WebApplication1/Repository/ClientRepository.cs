using Microsoft.Data.SqlClient;

namespace WebApplication1.Repository;

public class ClientRepository : IClientRepository
{
    private readonly IConfiguration _connectionString;

    public ClientRepository(IConfiguration connectionString)
    {
        _connectionString = connectionString;
    }
    
    public int deleteClient(int id)
    {
        using var con = new SqlConnection(_connectionString["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "DELETE FROM Client WHERE IdClient = @IdClient";
        cmd.Parameters.AddWithValue("@IdClient", id);

        var affectedCount = cmd.ExecuteNonQuery();
        return affectedCount;
    }
}