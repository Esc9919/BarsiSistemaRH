using BarsiSistemaRh.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barsi.Controlador
{
    public class FolhaControlador
    {

        public string conexaoSql = "Server=localhost;Database=BARSI;User Id=sa;Password=6329;Trusted_Connection=true;TrustServerCertificate=true;";

        public bool GerarFolha(int idFuncionario, DateTime inicioFolha, DateTime finalFolha)
        {
            SqlConnection conexaodb = new SqlConnection(conexaoSql);
            try
            {
                conexaodb.Open();
                SqlCommand cmd = new SqlCommand("dbo.SP_CAL_FOLHA_PGTO_MENSAL", conexaodb);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                var pmtIdFuncionario = cmd.CreateParameter();
                pmtIdFuncionario.ParameterName = "@ID_FUNCIONARIO";
                pmtIdFuncionario.DbType = System.Data.DbType.Int16;
                pmtIdFuncionario.Value = Convert.ToInt16(idFuncionario);
                cmd.Parameters.Add(pmtIdFuncionario);

                cmd.Parameters.AddWithValue("@DATA_INICIAL", inicioFolha);

                cmd.Parameters.AddWithValue("@DATA_INICIAL", finalFolha);


                if (cmd.ExecuteNonQuery() > 0)
                {
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

        public string ConsultarHoras(string dadosFuncionarios)
        {
            string inicioF = "";

            SqlConnection conexaodb = new SqlConnection(conexaoSql);
            try
            {
                conexaodb.Open();

                string query = "SELECT \r\n    ISNULL(CONVERT(VARCHAR, inicioFerias, 103), 'NC') as inicioFerias,\r\n    ISNULL(CONVERT(VARCHAR, fimFerias, 103), 'NC') as fimFerias \r\nFROM Funcionarios \r\nWHERE idFuncionario = @ID_FUNCIONARIO;\r\n";
                SqlCommand cmd = new SqlCommand(query, conexaodb);

                var pmtdadosFuncionarios = cmd.CreateParameter();
                pmtdadosFuncionarios.ParameterName = "@DADOS";
                pmtdadosFuncionarios.DbType = System.Data.DbType.Int16;
                pmtdadosFuncionarios.Value = Convert.ToString(dadosFuncionarios);
                cmd.Parameters.Add(pmtdadosFuncionarios);

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
    }
}
