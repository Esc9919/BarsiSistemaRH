using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Barsi.Web
{
    public partial class Home : System.Web.UI.Page
    {
        string usuario;
        string senha;
        string idFuncionario;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //PontoControladorWeb pontoControladorWeb = new PontoControladorWeb();

            //string consultarId;

            //if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(senha))
            //{
            //    consultarId = pontoControladorWeb.ConsultarID(usuario, senha);
            //    idFuncionario = consultarId.ToString();
            //}

            //bool registrarPonto = false;

            //try
            //{
            //    if (!String.IsNullOrEmpty(idFuncionario))
            //    {
            //        registrarPonto = pontoControladorWeb.RegistrarPonto(idFuncionario);
            //        ScriptManager.RegisterStartupScript(this, GetType(), "ShowMessage", "alert('Ponto Batido com sucesso');", true);
            //    }
            //    else
            //    {
            //        ScriptManager.RegisterStartupScript(this, GetType(), "ShowMessage", "alert('Erro ao bater ponto');", true);
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
    }
}