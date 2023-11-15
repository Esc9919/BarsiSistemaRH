using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Barsi.Web;

namespace Barsi.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            LoginControladorWeb loginControladorWeb = new LoginControladorWeb();
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            bool autenticaLogin = false;

            try
            {
                if (!String.IsNullOrEmpty(usuario) && !String.IsNullOrEmpty(senha))
                {
                    autenticaLogin = loginControladorWeb.Login(usuario, senha);

                    if (autenticaLogin)
                    {
                        Session["UsuarioLogado"] = usuario;
                        Response.Redirect("~/Home.aspx");
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "ShowMessage", "alert('Acesso Negado!');", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "ShowMessage", "alert('PREENCHA OS CAMPOS!');", true);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}