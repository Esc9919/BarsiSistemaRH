using System;
using System.Windows.Forms;
using Barsi.Api.Controllers;
using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Barsi.Api.Services.LoginService;
using Barsi.Controlador;
using BarsiSistemaRh.Data;
using Microsoft.AspNetCore.Mvc;

namespace Login;

public partial class pg_login : Form
{


    public pg_login()
    {
        InitializeComponent();

        // Defina a cor de fundo do cabecalho como R:53, G:58, B:64
        cabecalho1.BackColor = System.Drawing.Color.FromArgb(53, 58, 64);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void txtlogin_TextChanged(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private async void ponto_btn_Click(object sender, EventArgs e)
    {
        LoginControlador loginControlador = new LoginControlador();

        string usuario = txtlogin.Text;
        string senha = txtsenha.Text;

        bool autenticaLogin = false;

        try
        {
            if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(senha))
            {
                autenticaLogin = loginControlador.Login(usuario, senha);

                if (autenticaLogin)
                {
                    pg_home homePage = new pg_home(txtlogin.Text, txtsenha.Text);

                    this.Hide();

                    homePage.ShowDialog();

                    this.Show();
                }
                else
                {
                    MessageBox.Show("Dados invalidos");
                }
            }
            else
            {
                MessageBox.Show("Por favor inserir os dados");
            }
        }
        catch (Exception)
        {

            throw;
        }


    }

    private void txtsenha_TextChanged(object sender, EventArgs e)
    {

    }

}
