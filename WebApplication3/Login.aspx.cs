using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

			if (txtUsuario.Text == "rodolfo" && txtSenha.Text == "123456") {

				Session.Add("home", txtUsuario.Text);
				Response.Redirect("Home.aspx");
			} else 
			{

				lblMensagemErro.Text = "Usuário e/ou senha inválido(s)";
			}
        }
    }
}