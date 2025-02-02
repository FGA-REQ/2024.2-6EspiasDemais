using System;
using System.Collections.Generic;
using System.Linq;
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
                if (Session["IdUsuario"] != null)
                {
                    profileLink.NavigateUrl = "~/Perfil.aspx";
                    profileLink.Text = "Perfil";
                }
                else
                {
                    profileLink.NavigateUrl = "~/Acesso.aspx";
                    profileLink.Text = "Acesso";
                }
            }
        }
    }
}