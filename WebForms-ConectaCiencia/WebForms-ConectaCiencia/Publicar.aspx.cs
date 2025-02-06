using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_ConectaCiencia.Model;

namespace WebForms_ConectaCiencia
{
    public partial class Publicar : Page
    {
        private static readonly HttpClient client = new HttpClient();

        protected async void Page_Load(object sender, EventArgs e)
        {
            if (Session["IdUsuario"] == null || Session["NomeUsuario"] == null)
            {
                Response.Redirect("Acesso.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            if (!IsPostBack)
            {
                await CarregarCategorias();
            }
        }

        private async Task CarregarCategorias()
        {
            try
            {
                string apiUrl = "https://localhost:7146/api/Categoria";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode && response.Content.Headers.ContentType.MediaType == "application/json")
                {
                    var categorias = await response.Content.ReadFromJsonAsync<List<Categoria>>();

                    if (categorias != null && categorias.Count > 0)
                    {
                        ddlCategoriaArtigo.DataSource = categorias;
                        ddlCategoriaArtigo.DataTextField = "Nome_Categoria";
                        ddlCategoriaArtigo.DataValueField = "Id_Categoria";
                        ddlCategoriaArtigo.DataBind();
                        ddlCategoriaArtigo.Items.Insert(0, new ListItem("Selecione uma Categoria", ""));
                    }
                }
            }
            catch (Exception ex)
            {
                LogError("Erro ao carregar categorias: " + ex.Message);
            }
        }

        protected async void btnPublicar_Click(object sender, EventArgs e)
        {
            await PublicarArtigo();
        }

        private async Task PublicarArtigo()
        {
            try
            {
                var novoArtigo = new Artigo
                {
                    Id_Artigo = 0,
                    Data = DateTime.UtcNow,
                    Titulo = txtTitulo.Text.Trim(),
                    Conteudo = txtConteudo.Text.Trim(),
                    Categoria = new Categoria
                    {
                        Id_Categoria = int.Parse(ddlCategoriaArtigo.SelectedValue),
                        Nome_Categoria = ddlCategoriaArtigo.SelectedItem.Text
                    },
                    Usuario = new UsuarioSimplificado
                    {
                        Id_Usuario = (int)Session["IdUsuario"],
                        Nome = (string)Session["NomeUsuario"]
                    }
                };

                string apiUrl = "https://localhost:7146/api/Feed/Artigo";
                HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, novoArtigo);

                if (response.IsSuccessStatusCode)
                {
                    Session["MensagemToast"] = "Artigo publicado com sucesso!";
                    Response.Redirect("MeusArtigos.aspx", false);
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    LogError($"Erro ao publicar artigo: {response.StatusCode} - {errorMessage}");
                    Session["MensagemToast"] = "Erro ao publicar artigo. Tente novamente.";
                    Response.Redirect("MeusArtigos.aspx", false);
                }
            }
            catch (Exception ex)
            {
                LogError("Erro ao publicar artigo: " + ex.Message);
                Session["MensagemToast"] = "Erro inesperado ao publicar o artigo.";
                Response.Redirect("MeusArtigos.aspx", false);
            }
        }

        private void LogError(string message)
        {
            string filePath = Server.MapPath("~/App_Data/ErrorLog.txt");
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}
