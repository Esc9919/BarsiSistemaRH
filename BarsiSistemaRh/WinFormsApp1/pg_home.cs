﻿using Barsi.Api.Services.FeriasService;
using Barsi.Api.Services.LoginService;
using Barsi.Controlador;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
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

    public pg_home(string login, string senha) : this()
    {
        txtLogin.Text = login;
        txtSenha.Text = senha;
    }

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

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void fundo_hextras_Paint(object sender, PaintEventArgs e)
    {

    }

    private void textIdFuncionario_TextChanged(object sender, EventArgs e)
    {


    }

    private void ponto_btn_Click_1(object sender, EventArgs e)
    {
        string ConsultarID;

        FuncionarioControlador funcionarioControlador = new FuncionarioControlador();
        if (!String.IsNullOrEmpty(txtLogin.Text) && !String.IsNullOrEmpty(txtSenha.Text))
        {
            ConsultarID = funcionarioControlador.ConsultarID(txtLogin.Text, txtSenha.Text);
            textIdFuncionario.Text = ConsultarID.ToString();
        }
        bool registrarPonto = false;
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

    private void agendaferias_btn_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
    {
        pg_agenda_ferias agendaFeriasForm = new pg_agenda_ferias();

        this.Hide();


        agendaFeriasForm.ShowDialog();

        this.Show();
    }

    private void histpontos_btn_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
    {
        pg_hist_ponto _pg_hist_ponto = new pg_hist_ponto();

        this.Hide();

        _pg_hist_ponto.ShowDialog();

        this.Show();
    }

    private void folhapgt_btn_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
    {
        pg_folha_pgto _pg_folha_pgto = new pg_folha_pgto();

        this.Hide();

        _pg_folha_pgto.ShowDialog();

        this.Show();
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
        pg_login _Login = new pg_login();

        this.Hide();

        _Login.ShowDialog();

        this.Show();
    }
}