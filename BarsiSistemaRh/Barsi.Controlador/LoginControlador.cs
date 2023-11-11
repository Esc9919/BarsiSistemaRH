using Microsoft.Data.SqlClient;
using System;

namespace Barsi.Controlador;

public class LoginControlador
{
    public string conexaoSql = "Server=localhost;Database=BARSI;User Id=sa;Password=Admin2022;Trusted_Connection=true;TrustServerCertificate=true;";

    public bool Login(string usuario, string senha)
    {
        SqlConnection conexaodb = new SqlConnection(conexaoSql);

        try
        {
            conexaodb.Open();

            var query = "SELECT COUNT(1) FROM Funcionarios WHERE Usuario = @Usuario AND Senha = @Senha";
            var cmd = new SqlCommand(query, conexaodb);

            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Senha", senha);

            var result = (int)cmd.ExecuteScalar();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro no login: " + ex.Message);
            return false;
        }
        finally
        {
            conexaodb.Close();
        }
    }
}
