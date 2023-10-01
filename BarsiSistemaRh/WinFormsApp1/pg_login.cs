using System;
using System.Windows.Forms;
using Barsi.Api.Controllers;
using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Barsi.Api.Services.LoginService;
using BarsiSistemaRh.Data;
using Microsoft.AspNetCore.Mvc;

namespace Login;

public partial class pg_login : Form
{
    private ILoginService _loginService;


    public pg_login(ILoginService loginService)
    {
        InitializeComponent();
        _loginService = loginService;

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

    private void ponto_btn_Click(object sender, EventArgs e)
    {
        string usuario = txtlogin.Text;
        string senha = txtsenha.Text;

        LoginController _loginController = new LoginController(_loginService);

        var loginDto = new LoginDto { usuario = usuario, senha = senha };


        var resultado = _loginController.Acessar(loginDto);

        if (resultado != null)
        {
            MessageBox.Show("Login bem-sucedido!");
        }
        else
        {
            MessageBox.Show("Falha no login: " + resultado);
        }
    }
}
