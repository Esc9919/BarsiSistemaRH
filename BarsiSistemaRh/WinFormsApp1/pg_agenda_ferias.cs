using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using Barsi.Api.Controllers;
using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Barsi.Api.Services.FeriasService;
using BarsiSistemaRh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Login;

public partial class pg_agenda_ferias : Form
{
    private readonly IFeriasService _feriasService;

    private int funcionarioId = -1;

    public pg_agenda_ferias(IFeriasService feriasService)
    {
        InitializeComponent();
        _feriasService = feriasService;
    }

    private void oiToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void BtnVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {


        this.Close();



    }

    private void ferias_btn_Click(object sender, EventArgs e)
    {
        string textoData1 = textferiaini.Text;
        DateTime inicioFerias = DateTime.Parse(textoData1);

        string textoData2 = textferiafim.Text;
        DateTime fimFerias = DateTime.Parse(textoData2);

        if (funcionarioId == -1)
        {
            MessageBox.Show("Por favor, selecione um funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        FeriasController _feriasController = new FeriasController(_feriasService);

        FeriasDTO feriasDTO = new FeriasDTO
        {
            inicioFerias = inicioFerias,
            fimFerias = fimFerias
        };

        IActionResult resultado = (IActionResult)_feriasController.TirarFerias(funcionarioId, feriasDTO);

        if (resultado is OkObjectResult okResult && okResult.StatusCode == 200)
        {
            MessageBox.Show("Férias aceitas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (resultado is UnauthorizedResult unauthorizedResult && unauthorizedResult.StatusCode == 401)
        {
            string mensagemErro = "Erro " + unauthorizedResult.StatusCode + ": " + "Não é permitido tirar férias.";
            MessageBox.Show(mensagemErro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (resultado is NotFoundObjectResult notFoundResult && notFoundResult.StatusCode == 404)
        {
            string mensagemErro = "Erro " + notFoundResult.StatusCode + ": " + "Funcionário não encontrado.";
            MessageBox.Show(mensagemErro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }

    private void textcolaborador_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (textcolaborador.SelectedItem != null)
        {
            funcionarioId = (int)textcolaborador.SelectedValue;
        }
    }
}
