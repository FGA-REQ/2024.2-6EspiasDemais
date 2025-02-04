using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json;
using WebForms_ConectaCiencia.Model;

namespace WebForms_ConectaCiencia
{
    public partial class Cadastro : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Visible = false; 
        }

        protected async void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            lblMensagem.Visible = true;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                lblMensagem.Text = "Preencha todos os campos obrigatórios.";
                lblMensagem.CssClass = "text-danger";
                return;
            }

            if (!ValidarEmail(email))
            {
                lblMensagem.Text = "Insira um e-mail válido.";
                lblMensagem.CssClass = "text-danger";
                return;
            }

            if (!ValidarSenha(senha))
            {
                lblMensagem.Text = "A senha deve ter pelo menos 8 caracteres, incluindo uma letra maiúscula, uma letra minúscula e um número.";
                lblMensagem.CssClass = "text-danger";
                return;
            }

            try
            {
                var usuario = await CadastrarUsuario(nome, email, senha);

                if (usuario != null)
                {
                    lblMensagem.Text = "Cadastro realizado com sucesso!";
                    lblMensagem.CssClass = "text-success";

                    Session["IdUsuario"] = usuario.Id_Usuario;
                    Session["NomeUsuario"] = usuario.Nome;

                    Response.Redirect("Perfil.aspx", false);
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    lblMensagem.Text = "Erro ao cadastrar o usuário. Por favor, tente novamente.";
                    lblMensagem.CssClass = "text-danger";
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Ocorreu um erro inesperado: " + ex.Message;
                lblMensagem.CssClass = "text-danger";
            }
        }

        private bool ValidarEmail(string email)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            return regex.IsMatch(email);
        }

        private bool ValidarSenha(string senha)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$");
            return regex.IsMatch(senha);
        }


        private async Task<Usuario> CadastrarUsuario(string nome, string email, string senha)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var usuario = new
                    {
                        Nome = nome,
                        Email = email,
                        Senha = senha
                    };

                    var json = JsonConvert.SerializeObject(usuario);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    string apiUrl = "https://localhost:7146/api/Usuario/cadastro";

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        Usuario user = JsonConvert.DeserializeObject<Usuario>(responseContent);
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao conectar com o servidor: " + ex.Message;
                lblMensagem.CssClass = "text-danger";
                lblMensagem.Visible = true;
                return null;
            }
        }
    }
}
