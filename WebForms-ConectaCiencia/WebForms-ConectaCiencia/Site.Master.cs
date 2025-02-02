using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_ConectaCiencia
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Verifica se o usuário está logado
                if (Session["IdUsuario"] != null)
                {
                    profileLink.NavigateUrl = "~/Perfil.aspx"; // Se estiver logado, vai para a página de perfil
                    profileLink.Text = "Perfil";
                }
                else
                {
                    profileLink.NavigateUrl = "~/Acesso.aspx"; // Se não estiver logado, vai para a página de acesso
                    profileLink.Text = "Acesso";
                }
            }
        }
    }
}
