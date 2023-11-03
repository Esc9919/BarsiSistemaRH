using Microsoft.Data.SqlClient;

namespace Barsi.Controlador;

public class FeriasControlador
{
    public string conexaoSql = "Server=localhost;Database=BARSI;User Id=sa;Password=Admin2022;Trusted_Connection=true;TrustServerCertificate=true;";

    public bool GerarFerias(int id, DateTime inicioFerias, DateTime fimFerias)
    {
        SqlConnection conexaodb = new SqlConnection(conexaoSql);
        try
        {
            conexaodb.Open();

            string query = "UPDATE Funcionarios set inicioFerias = @inicioFerias, fimFerias = @fimFerias where idfuncionario = @id";
            SqlCommand cmd = new SqlCommand(query, conexaodb);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@inicioFerias", inicioFerias);
            cmd.Parameters.AddWithValue("@fimFerias", fimFerias);

            if (cmd.ExecuteNonQuery() > 0)
            {
                conexaodb.Close();
                return true;
            }
            else 
            { 
                return false;
            }
        }
        catch (Exception)
        {
            conexaodb.Close();
            throw;
        }
    }
}