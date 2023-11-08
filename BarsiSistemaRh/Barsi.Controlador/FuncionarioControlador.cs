using BarsiSistemaRh.Models;
using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Barsi.Controlador;

public class FuncionarioControlador
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

    public bool RegistrarPonto(string idFuncionario)
    {
        SqlConnection conexaodb = new SqlConnection (conexaoSql);
        try
        {
            conexaodb.Open();
            SqlCommand cmd = new SqlCommand("dbo.SP_UPD_PONTO", conexaodb);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            var pmtIdFuncionario = cmd.CreateParameter();
            pmtIdFuncionario.ParameterName = "@ID_FUNCIONARIO";
            pmtIdFuncionario.DbType = System.Data.DbType.Int16;
            pmtIdFuncionario.Value = Convert.ToInt16(idFuncionario);
            cmd.Parameters.Add(pmtIdFuncionario);

            if (cmd.ExecuteNonQuery() > 0)
            {
                conexaodb.Close();
                return true;
            }
            else
            {
                conexaodb.Close();
                return false;
            }
        }
        catch (Exception)
        {
            conexaodb.Close();
            throw;
        }
    }

    public bool ConsultarPonto(int id)
    {
        SqlConnection conexaodb = new SqlConnection(conexaoSql);
        try
        {
            conexaodb.Open();

            string query = "SELECT * FROM Pontos WHERE IDFUNCIONARIO = @ID ORDER BY idPonto DESC";
            SqlCommand cmd = new SqlCommand(query, conexaodb);

            cmd.Parameters.AddWithValue("@id", id);

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


    public string ConsultarID(string login, string senha)
    {
        string resultado = ""; 

        SqlConnection conexaodb = new SqlConnection(conexaoSql);
        try
        {
            conexaodb.Open();

            string query = "SELECT top 1 idFuncionario FROM Funcionarios where usuario = @LOGIN and senha = @SENHA";
            SqlCommand cmd = new SqlCommand(query, conexaodb);

            var pmtLogin = cmd.CreateParameter();
            pmtLogin.ParameterName = "@LOGIN";
            pmtLogin.DbType = System.Data.DbType.String;
            pmtLogin.Value = login;
            cmd.Parameters.Add(pmtLogin);

            var pmtSenha = cmd.CreateParameter();
            pmtSenha.ParameterName = "@SENHA";
            pmtSenha.DbType = System.Data.DbType.String;
            pmtSenha.Value = senha;
            cmd.Parameters.Add(pmtSenha);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                resultado = reader["idFuncionario"].ToString();
            }

            reader.Close();
            conexaodb.Close(); 

        }
        catch (Exception)
        {
            conexaodb.Close();
            throw;
        }

        return resultado; 
    }

}