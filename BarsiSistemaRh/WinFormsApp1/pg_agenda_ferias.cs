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
using Barsi.Controlador;
using BarsiSistemaRh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Login;

public partial class pg_agenda_ferias : Form
{
    private readonly IFeriasService _feriasService;

    private int funcionarioId = -1;

    //public pg_agenda_ferias(IFeriasService feriasService)
    //{
    //    InitializeComponent();
    //    _feriasService = feriasService;
    //}

    public pg_agenda_ferias()
    {
        InitializeComponent();
    }



    private void oiToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void BtnVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {


        this.Close();



    }

    private void ferias_btn_Click(object sender, EventArgs e)
    {



    }


    private void ferias_btn_Click_1(object sender, EventArgs e)
    {
        string textoData1 = textferiaini.Text;
        DateTime inicioFerias = DateTime.Parse(textoData1);

        string textoData2 = textferiafim.Text;
        DateTime fimFerias = DateTime.Parse(textoData2);

        bool retornoGerarFerias = false;

        if (funcionarioId == -1)
        {
            MessageBox.Show("Por favor, selecione um funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }



        FuncionarioControlador feriasControlador = new FuncionarioControlador();

        feriasControlador.GerarFerias(funcionarioId, inicioFerias, fimFerias);

        retornoGerarFerias = feriasControlador.GerarFerias(funcionarioId, inicioFerias, fimFerias);

        if (retornoGerarFerias)
        {
            MessageBox.Show("Ferias criadas com sucesso!!!" + "\ncomeço " + inicioFerias + "\n final " + fimFerias);
        }
        else
        {
            MessageBox.Show("Falha ao gerar Ferias");
        }

    }

    private void textBoxId_TextChanged(object sender, EventArgs e)
    {
        string textFuncionarioId = textBoxId.Text;
        funcionarioId = Convert.ToInt16(textFuncionarioId);
    }
}
