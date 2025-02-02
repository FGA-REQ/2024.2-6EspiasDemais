using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json;
using WebForms_ConectaCiencia.Model;

namespace WebForms_ConectaCiencia
{
    public partial class Acesso : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Visible = false;
        }

        protected async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                lblMensagem.Text = "Preencha todos os campos.";
                lblMensagem.Visible = true;
                return;
            }

            var usuario = await ValidarUsuario(email, senha);

            if (usuario != null)
            {
                lblMensagem.Visible = false;

                Session["IdUsuario"] = usuario.Id_Usuario;
                Session["NomeUsuario"] = usuario.Nome;

                Response.Redirect("Perfil.aspx", false);
                HttpContext.Current.ApplicationInstance.CompleteRequest();
            }
            else
            {
                lblMensagem.Text = "E-mail ou senha inválidos.";
                lblMensagem.Visible = true;
            }
        }

        private async Task<Usuario> ValidarUsuario(string email, string senha)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string apiUrl = $"https://localhost:7146/api/Login/login?email={email}&senha={senha}";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        Usuario usuario = JsonConvert.DeserializeObject<Usuario>(responseBody);

                        if (usuario != null)
                        {
                            return usuario;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao validar o usuário: " + ex.Message;
                lblMensagem.Visible = true;
            }

            return null;
        }
    }
}