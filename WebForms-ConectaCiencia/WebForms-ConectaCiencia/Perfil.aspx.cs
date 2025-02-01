using System;
using System.Web;

namespace WebForms_ConectaCiencia
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IdUsuario"] != null && Session["NomeUsuario"] != null)
            {
                if (!IsPostBack)
                {
                    string userName = Session["NomeUsuario"].ToString();
                    UserNameLiteral.Text = userName;
                }
            }
            else
            {
                Response.Redirect("Acesso.aspx");
            }
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Redirect("Acesso.aspx");
        }

        protected void btnMeusArtigos_Click(object sender, EventArgs e)
        {
            Response.Redirect("MeusArtigos.aspx", false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }
    }
}