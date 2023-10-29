using Barsi.Api.Services.FeriasService;
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
<<<<<<< HEAD
        InitializeComponent();
    }
=======

        private readonly IFeriasService feriasService;

        public pg_home()
        {
            InitializeComponent();
        }
>>>>>>> d7cb738e044e02bfb9964608c80b279a32a288df

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

<<<<<<< HEAD
    private void agendaferias_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        //pg_agenda_ferias agendaFeriasForm = new pg_agenda_ferias(Loginserv);
=======
        private void agendaferias_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg_agenda_ferias agendaFeriasForm = new pg_agenda_ferias(feriasService);
>>>>>>> d7cb738e044e02bfb9964608c80b279a32a288df

        this.Hide();

<<<<<<< HEAD
        //agendaFeriasForm.ShowDialog();
=======
           agendaFeriasForm.ShowDialog();
>>>>>>> d7cb738e044e02bfb9964608c80b279a32a288df

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
}
