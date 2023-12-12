using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Login;

public partial class pg_hist_ponto : Form
{
    private SqlConnection conexao;
    private SqlDataAdapter adaptador;
    private DataTable dataTable;
    private string stringConexao = "Server=localhost;Database=BARSI;User Id=sa;Password=Admin2022;Trusted_Connection=true;TrustServerCertificate=true;";

    public pg_hist_ponto()
    {
        InitializeComponent();
    }

    private void PreencherDataGridView(string cpf, DateTime diaInicial, DateTime diaFinal)
    {
        conexao = new SqlConnection(stringConexao);
        try
        {
            conexao.Open();
            string query = "SELECT B.* FROM Funcionarios A " +
                           "INNER JOIN Pontos B ON A.idFuncionario = B.idFuncionario " +
                           "WHERE A.cpf = @CPF AND CONVERT(date, B.pontoEntrada) BETWEEN @DIA_INICIAL AND @DIA_FINAL";
            adaptador = new SqlDataAdapter(query, conexao);
            adaptador.SelectCommand.Parameters.AddWithValue("@CPF", cpf);
            adaptador.SelectCommand.Parameters.AddWithValue("@DIA_INICIAL", diaInicial.ToString("yyyyMMdd"));
            adaptador.SelectCommand.Parameters.AddWithValue("@DIA_FINAL", diaFinal.ToString("yyyyMMdd"));
            dataTable = new DataTable();
            adaptador.Fill(dataTable);
            Pontos.DataSource = dataTable;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao popular DataGridView: " + ex.Message);
        }
        finally
        {
            conexao.Close();
        }
    }
    private void c_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Close();
    }

    private void histponto_btn_Click(object sender, EventArgs e)
    {

        if (string.IsNullOrEmpty(txtCPF.Text))     
        {
            MessageBox.Show("Por favor, preencha o CPF.");
            return;
        }
            string cpf = txtCPF.Text;

        
        if (string.IsNullOrEmpty(text_histponto_inci.Text) || string.IsNullOrEmpty(text_histponto_fim.Text))
        {
            MessageBox.Show("Por favor, preencha as datas de forma correta.");
            return;
        }

       
        if (DateTime.TryParseExact(text_histponto_inci.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime diaInicial)
            && DateTime.TryParseExact(text_histponto_fim.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime diaFinal))
        {
            PreencherDataGridView(cpf, diaInicial, diaFinal);
        }
        else
        {
            MessageBox.Show("Por favor, insira datas válidas no formato dd/MM/yyyy.");
        }
    }

}
