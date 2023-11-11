using BarsiSistemaRh.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace Barsi.Controlador
{
    public class FolhaControlador
    {

        public string conexaoSql = "Server=localhost;Database=BARSI;User Id=sa;Password=Admin2022;Trusted_Connection=true;TrustServerCertificate=true;";

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

                    cmd.Parameters.AddWithValue("@DATA_FINAL", finalFolha);


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
    
}
