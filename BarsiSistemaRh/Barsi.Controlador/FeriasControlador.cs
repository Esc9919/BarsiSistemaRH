using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarsiSistemaRh.Models;
using Microsoft.Data.SqlClient;
using System.Reflection.PortableExecutable;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Barsi.Controlador
{
public class FeriasControlador
    {

        public string conexaoSql = "Server=localhost;Database=BARSI;User Id=sa;Password=Admin2022;Trusted_Connection=true;TrustServerCertificate=true;";

        public bool GerarFerias(int id, DateTime inicioFerias)
            {
                SqlConnection conexaodb = new SqlConnection(conexaoSql);
                try
                {
                    conexaodb.Open();
                    SqlCommand cmd = new SqlCommand("dbo.SP_UPD_FERIAS", conexaodb);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    
                    var pmtIdFuncionario = cmd.CreateParameter();
                    pmtIdFuncionario.ParameterName = "@id";
                    pmtIdFuncionario.DbType = System.Data.DbType.Int16;
                    pmtIdFuncionario.Value = Convert.ToInt16(id);
                    cmd.Parameters.Add(pmtIdFuncionario);

                    cmd.Parameters.AddWithValue("@inicioFerias", inicioFerias);
                    

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


            public string ConsultarFeriasInicio(int idFuncionario)
            {
                string inicioF = "";

                SqlConnection conexaodb = new SqlConnection(conexaoSql);
                try
                {
                    conexaodb.Open();

                    string query = "SELECT \r\n    ISNULL(CONVERT(VARCHAR, inicioFerias, 103), 'NC') as inicioFerias,\r\n    ISNULL(CONVERT(VARCHAR, fimFerias, 103), 'NC') as fimFerias \r\nFROM Funcionarios \r\nWHERE idFuncionario = @ID_FUNCIONARIO;\r\n";
                    SqlCommand cmd = new SqlCommand(query, conexaodb);

                    var pmtIdFuncionario = cmd.CreateParameter();
                    pmtIdFuncionario.ParameterName = "@ID_FUNCIONARIO";
                    pmtIdFuncionario.DbType = System.Data.DbType.Int16;
                    pmtIdFuncionario.Value = Convert.ToInt16(idFuncionario);
                    cmd.Parameters.Add(pmtIdFuncionario);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        inicioF = reader["inicioFerias"].ToString();
                    }

                    reader.Close();
                    conexaodb.Close();

                }
                catch (Exception)
                {
                    conexaodb.Close();
                    throw;
                }

                return inicioF;

            }

            public string ConsultarFeriasFim(int idFuncionario)
            {
                string FimF = "";

                SqlConnection conexaodb = new SqlConnection(conexaoSql);
                try
                {
                    conexaodb.Open();

                    string query = "SELECT \r\n    ISNULL(CONVERT(VARCHAR, inicioFerias, 103), 'NC') as inicioFerias,\r\n    ISNULL(CONVERT(VARCHAR, fimFerias, 103), 'NC') as fimFerias \r\nFROM Funcionarios \r\nWHERE idFuncionario = @ID_FUNCIONARIO;\r\n";
                    SqlCommand cmd = new SqlCommand(query, conexaodb);

                    var pmtIdFuncionario = cmd.CreateParameter();
                    pmtIdFuncionario.ParameterName = "@ID_FUNCIONARIO";
                    pmtIdFuncionario.DbType = System.Data.DbType.Int16;
                    pmtIdFuncionario.Value = Convert.ToInt16(idFuncionario);
                    cmd.Parameters.Add(pmtIdFuncionario);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        FimF = reader["fimFerias"].ToString();
                    }

                    reader.Close();
                    conexaodb.Close();

                }
                catch (Exception)
                {
                    conexaodb.Close();
                    throw;
                }

                return FimF;

            }

        
}
}
