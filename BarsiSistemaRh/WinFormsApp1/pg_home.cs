using Barsi.Api.Services.FeriasService;
using Barsi.Api.Services.LoginService;
using Barsi.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login;

public partial class pg_home : Form
{
    public pg_home()
    {

        InitializeComponent();
    }


    private readonly IFeriasService feriasService;

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void menulateral_Paint(object sender, PaintEventArgs e)
    {

    }

    private void txttitle_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void agendaferias_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        pg_agenda_ferias agendaFeriasForm = new pg_agenda_ferias();

        this.Hide();


        agendaFeriasForm.ShowDialog();

        this.Show();
    }


    private void folhapgt_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        pg_folha_pgto _pg_folha_pgto = new pg_folha_pgto();

        this.Hide();

        _pg_folha_pgto.ShowDialog();

        this.Show();
    }

    private void histpontos_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        pg_hist_ponto _pg_hist_ponto = new pg_hist_ponto();

        this.Hide();

        _pg_hist_ponto.ShowDialog();

        this.Show();
    }

    private void holerite_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        pg_holerite _pg_holerite = new pg_holerite();

        this.Hide();

        _pg_holerite.ShowDialog();

        this.Show();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void ponto_btn_Click(object sender, EventArgs e)
    {
        bool registrarPonto = false;

        FuncionarioControlador funcionarioControlador = new FuncionarioControlador();
        try
        {
            if (!String.IsNullOrEmpty(textIdFuncionario.Text))
            {
                registrarPonto = funcionarioControlador.RegistrarPonto(textIdFuncionario.Text);

                if (registrarPonto)
                {
                    MessageBox.Show("Ponto registrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao registrar ponto");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao registar ponto " + ex.Message);
        }
    }

    private void label7_Click(object sender, EventArgs e)
    {
        DateTime data = DateTime.Now;
        labelData.Text = data.ToString();
    }

    private void fundo_dia_Paint(object sender, PaintEventArgs e)
    {
        DateTime dataAtual = DateTime.Now;

        labelDia.Text = dataAtual.ToString("dd/MM/yyyy");
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void fundo_hextras_Paint(object sender, PaintEventArgs e)
    {

    }
}
