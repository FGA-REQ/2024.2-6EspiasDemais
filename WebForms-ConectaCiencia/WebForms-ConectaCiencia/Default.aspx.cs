using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_ConectaCiencia.Model;

namespace WebForms_ConectaCiencia
{
    public partial class _Default : Page
    {
        private static readonly HttpClient client = new HttpClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RegisterAsyncTask(new PageAsyncTask(async () =>
                {
                    await CarregarCategorias();
                    await BindArtigos();
                }));
            }
        }
        private async Task CarregarCategorias()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string apiUrl = "https://localhost:7259/api/Categoria";

                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode && response.Content.Headers.ContentType.MediaType == "application/json")
                    {
                        var categorias = await response.Content.ReadFromJsonAsync<List<Categoria>>();

                        if (categorias != null && categorias.Count > 0)
                        {
                            ddlCategoria.DataSource = categorias;
                            ddlCategoria.DataTextField = "Nome_Categoria";
                            ddlCategoria.DataValueField = "Id_Categoria";
                            ddlCategoria.DataBind();

                            ddlCategoria.Items.Insert(0, new ListItem("Selecione uma Categoria", ""));
                        }
                        else
                        {
                            lblMensagem.Text = "Nenhuma categoria encontrada.";
                            lblMensagem.Visible = true;
                        }
                    }
                    else
                    {
                        lblMensagem.Text = $"Erro ao buscar categorias: {response.StatusCode}";
                        lblMensagem.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro: " + ex.Message;
                lblMensagem.Visible = true;
            }
        }
        private async Task BindArtigos()
        {
            await CarregarArtigos(null, null, null);
        }
    }
}