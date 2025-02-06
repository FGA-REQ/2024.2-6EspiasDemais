using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_ConectaCiencia.Model;

namespace WebForms_ConectaCiencia
{
    public partial class MeusArtigos : System.Web.UI.Page
    {
        private static readonly HttpClient client = new HttpClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IdUsuario"] == null || Session["NomeUsuario"] == null)
            {
                Response.Redirect("Acesso.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            if (!IsPostBack)
            {
                foreach (RepeaterItem item in ArticlesRepeater.Items)
                {
                    var artigoId = DataBinder.Eval(item.DataItem, "Id_Artigo").ToString();
                    string script = $"preencherModal({artigoId});"; 
                    ClientScript.RegisterStartupScript(this.GetType(), "preencherModal" + artigoId, script, true);
                }

                RegisterAsyncTask(new PageAsyncTask(async () =>
                {
                    await CarregarCategorias();
                    await BindArtigos();
                }));

                if (Session["MensagemToast"] != null)
                {
                    string mensagemToast = Session["MensagemToast"].ToString();
                    Session["MensagemToast"] = null;
                    ClientScript.RegisterStartupScript(this.GetType(), "toastMessage",
                        $"showToast('success', '{mensagemToast}');", true);
                }
            }
        }

        protected void btnPublicar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Publicar.aspx", false);
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        private async Task CarregarCategorias()
        {
            try
            {
                string apiUrl = "https://localhost:7146/api/Categoria";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var categorias = await response.Content.ReadFromJsonAsync<List<Categoria>>();
                    ddlCategorias.DataSource = categorias;
                    ddlCategorias.DataTextField = "Nome_Categoria";
                    ddlCategorias.DataValueField = "Id_Categoria";
                    ddlCategorias.DataBind();
                }
                else
                {
                    lblMensagem.Text = $"Erro ao carregar categorias: {response.ReasonPhrase}";
                    lblMensagem.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro: " + ex.Message;
                lblMensagem.Visible = true;
            }
        }

        private async Task CarregarArtigos()
        {
            try
            {
                var idUsuario = Session["IdUsuario"]?.ToString();
                if (string.IsNullOrEmpty(idUsuario))
                {
                    lblMensagem.Text = "Usuário não está logado.";
                    lblMensagem.Visible = true;
                    return;
                }

                string apiUrl = $"https://localhost:7146/api/Feed/MeusArtigos?id_usuario={idUsuario}";

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode && response.Content.Headers.ContentType.MediaType == "application/json")
                {
                    var artigos = await response.Content.ReadFromJsonAsync<List<Artigo>>();

                    if (artigos != null && artigos.Count > 0)
                    {
                        lblMensagem.Visible = false;
                        ArticlesRepeater.DataSource = artigos;
                        ArticlesRepeater.DataBind();
                    }
                    else
                    {
                        lblMensagem.Text = "Sem artigos publicados ainda, que tal fazer uma publicação?";
                        lblMensagem.Visible = true;
                        ArticlesRepeater.DataSource = null;
                        ArticlesRepeater.DataBind();
                    }
                }
                else
                {
                    lblMensagem.Text = "Sem artigos publicados ainda, que tal fazer uma publicação?";
                    lblMensagem.Visible = true;
                    ArticlesRepeater.DataSource = null;
                    ArticlesRepeater.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro: " + ex.Message;
                lblMensagem.Visible = true;
                ArticlesRepeater.DataSource = null;
                ArticlesRepeater.DataBind();
            }
        }

        private async Task BindArtigos()
        {
            await CarregarArtigos();
        }

        protected async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var artigoId = Convert.ToInt32(hfArtigoId.Value);
                var titulo = txtTitulo.Text.Trim();
                var conteudo = txtConteudo.Text.Trim();
                var categoriaId = Convert.ToInt32(ddlCategorias.SelectedValue);
                var nomeCategoria = ddlCategorias.SelectedItem.Text;

                var artigoModel = new Artigo
                {
                    Id_Artigo = artigoId,
                    Data = DateTime.UtcNow,
                    Titulo = titulo,
                    Conteudo = conteudo,
                    Categoria = new Categoria
                    {
                        Id_Categoria = categoriaId,
                        Nome_Categoria = nomeCategoria
                    },
                    Usuario = new UsuarioSimplificado
                    {
                        Id_Usuario = (int)Session["IdUsuario"],
                        Nome = (string)Session["NomeUsuario"]
                    }
                };

                string apiUrl = $"https://localhost:7146/api/Feed/Artigo/Patch/{artigoId}";
                var response = await client.PatchAsJsonAsync(apiUrl, artigoModel);

                if (response.IsSuccessStatusCode)
                {
                    lblToastMessage.Text = "Artigo editado com sucesso!";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "showToast", "showToast('success', '" + lblToastMessage.Text + "');", true);
                    await BindArtigos();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    lblMensagem.Text = $"Erro ao atualizar artigo: {response.ReasonPhrase} - {errorContent}";
                    lblMensagem.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro: " + ex.Message;
                lblMensagem.Visible = true;
            }
        }

        protected async void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var artigoId = Convert.ToInt32((sender as Button).CommandArgument);
                hfArtigoId.Value = artigoId.ToString(); 
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showDeleteModal", "$('#deleteModal').modal('show');", true);
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao preparar exclusão: " + ex.Message;
                lblMensagem.Visible = true;
            }
        }

        protected async void btnExcluirConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var artigoId = int.Parse(hfArtigoId.Value); 
                string apiUrl = $"https://localhost:7146/api/Feed/Artigo/Delete/{artigoId}";

                var response = await client.DeleteAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    lblToastMessage.Text = "Artigo excluído com sucesso!";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "showToast", "showToast('success', '" + lblToastMessage.Text + "');", true);
                    await BindArtigos(); 
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    lblMensagem.Text = $"Erro ao excluir artigo: {response.ReasonPhrase} - {errorContent}";
                    lblMensagem.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro: " + ex.Message;
                lblMensagem.Visible = true;
            }
        }
    }
}