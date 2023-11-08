using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
using Castle.Core.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.IdentityModel.Tokens;

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




    private void ferias_btn_Click_2(object sender, EventArgs e)
    {
        FeriasControlador feriasControlador = new FeriasControlador();

        bool gerarFerias = false;
        int IdFuncionario;
        DateTime inicioFerias;

        //if (funcionarioId == -1)
        //{
        //    MessageBox.Show("Por favor, selecione um funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    return;
        //}

        try
        {
            if (!String.IsNullOrEmpty(textBoxId.Text) && !String.IsNullOrEmpty(textferiaini.Text))
            {
                IdFuncionario = Convert.ToInt32(textBoxId.Text);

                if (DateTime.TryParseExact(textferiaini.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out inicioFerias))
                {
                    gerarFerias = feriasControlador.GerarFerias(IdFuncionario, inicioFerias);

                    if (gerarFerias)
                    {
                        MessageBox.Show("Férias registradas com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao registrar Férias");
                    }
                }
                else
                {
                    MessageBox.Show("Formato de data inválido. Use o formato dd/MM/yyyy.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira o ID do funcionário e a data de início de férias.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao registrar Férias: " + ex.Message);
        }
    }

    private void BtnVoltar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Close();
    }
}
