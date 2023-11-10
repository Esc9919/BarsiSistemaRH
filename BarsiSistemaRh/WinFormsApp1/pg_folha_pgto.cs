using Barsi.Controlador;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class pg_folha_pgto : Form
    {
        public pg_folha_pgto()
        {
            InitializeComponent();
        }

        private void txttitle_Click(object sender, EventArgs e)
        {

        }

        private void c_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void folha_btn_Click(object sender, EventArgs e)
        {
            FolhaControlador folhaControlador = new FolhaControlador();

            bool gerarFolha = false;
            int IdFuncionario;
            DateTime inicioFolha;
            DateTime finalFolha;


            try
            {
                if (!String.IsNullOrEmpty(txtID.Text) && !String.IsNullOrEmpty(txtDataIni.Text) && !String.IsNullOrEmpty(txtDataFinal.Text))
                {
                    IdFuncionario = Convert.ToInt32(txtID.Text);

                    if (DateTime.TryParseExact(txtDataIni.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out inicioFolha)
                        && DateTime.TryParseExact(txtDataFinal.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out finalFolha))
                    {
                        gerarFolha = folhaControlador.GerarFolha(IdFuncionario, inicioFolha, finalFolha);

                        if (gerarFolha)
                        {
                            MessageBox.Show("Folha gerada com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao registrar folha de pagamentos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato de data inválido. Use o formato dd/MM/yyyy.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira o ID do funcionário, data de início da folha e data final.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar folha: " + ex.Message);
            }
        }
    }
}
