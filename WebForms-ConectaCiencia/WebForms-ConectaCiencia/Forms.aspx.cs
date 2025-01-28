using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_ConectaCiencia.Model;
using static WebForms_ConectaCiencia.Model.Formularios;

namespace WebForms_ConectaCiencia
{
    public partial class Forms : Page
    {
        private static readonly HttpClient client = new HttpClient();

        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                await CarregarCategorias();
            }
        }

        private async Task CarregarCategorias()
        {
            try
            {
                string apiUrl = "https://localhost:5140/api/Categoria";

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode && response.Content.Headers.ContentType.MediaType == "application/json")
                {
                    var categorias = await response.Content.ReadFromJsonAsync<List<Categoria>>();

                    if (categorias != null && categorias.Count > 0)
                    {
                        ddlCategoriaTema.DataSource = categorias;
                        ddlCategoriaTema.DataTextField = "Nome_Categoria";
                        ddlCategoriaTema.DataValueField = "Id_Categoria";
                        ddlCategoriaTema.DataBind();
                        ddlCategoriaTema.Items.Insert(0, new ListItem("Selecione uma Categoria", ""));

                        ddlCategoriaArtigo.DataSource = categorias;
                        ddlCategoriaArtigo.DataTextField = "Nome_Categoria";
                        ddlCategoriaArtigo.DataValueField = "Id_Categoria";
                        ddlCategoriaArtigo.DataBind();
                        ddlCategoriaArtigo.Items.Insert(0, new ListItem("Selecione uma Categoria", ""));
                    }
                    else
                    {
                        ExibirMensagem("alertError", "Nenhuma categoria encontrada.");
                    }
                }
                else
                {
                    ExibirMensagem("alertError", $"Erro ao buscar categorias: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                ExibirMensagem("alertError", "Erro ao carregar categorias: " + ex.Message);
            }
        }
    }
}
