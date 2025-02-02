<%@ Page Title="Meus Artigos" Language="C#" AutoEventWireup="true" CodeBehind="MeusArtigos.aspx.cs" Inherits="WebForms_ConectaCiencia.MeusArtigos" MasterPageFile="~/Site.master" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1 class="my-4">Meus Artigos</h1>

        <div class="form-group d-flex justify-content-center">
            <asp:Button ID="btnPublicar" runat="server" Text="Publicar" CssClass="btn btn-primary w-100" OnClick="btnPublicar_Click"/>
        </div>

        <div class="container mt-4 text-center">
            <asp:Label ID="lblMensagem" runat="server" CssClass="alert alert-info" Visible="false"></asp:Label>
        </div>

        <asp:Repeater ID="ArticlesRepeater" runat="server">
            <ItemTemplate>
                <div class="card mb-4 border p-2 shadow">
                    <div class="card-body">
                        <h2 class="card-title d-flex justify-content-between align-items-center">
                            <%# Eval("Titulo") %>
                            <button class="btn btn-light" type="button" data-bs-toggle="collapse" data-bs-target="#optionsCollapse<%# Container.ItemIndex %>" aria-expanded="false" aria-controls="optionsCollapse<%# Container.ItemIndex %>">
                                <i class="fas fa-ellipsis-v"></i>
                            </button>
                        </h2>
                        <div class="collapse" id="optionsCollapse<%# Container.ItemIndex %>">
                            <div class="row justify-content-end">
                                <div class="col-auto">
                                    <div class="list-group">
                                        <a href="#" class="list-group-item list-group-item-action" style="width: 200px;" 
                                           data-bs-toggle="modal" data-bs-target="#editModal" 
                                           onclick="preencherModal('<%# Eval("Id_Artigo") %>', '<%# Eval("Titulo") %>', 
                                           '<%# Eval("Conteudo") %>', '<%# Eval("Categoria.Id_Categoria") %>', 
                                           '<%# Eval("Categoria.Nome_Categoria") %>')">
                                           <i class="fas fa-edit"></i> Editar
                                        </a>
                                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="list-group-item list-group-item-action text-danger" CommandArgument='<%# Eval("Id_Artigo") %>' OnClick="btnExcluir_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <p class="card-text"><%# Eval("Conteudo") %></p>
                        <footer class="blockquote-footer">
                            Publicado por <%# Eval("Usuario.Nome") %> em <%# Eval("Data", "{0:dd/MM/yyyy}") %>
                        </footer>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">
    </div>

    <div class="modal fade" id="editModal" tabindex="-1" aria-labelledby="editModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header justify-content-center">
                    <h5 class="modal-title" id="editModalLabel">Editar Artigo</h5>
                </div>
                <div class="modal-body">
                    <asp:HiddenField ID="hfArtigoId" runat="server" />
                    <div class="mb-3 text-center">
                        <label for="txtTitulo" class="form-label">Título</label>
                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control mx-auto" style="max-width: 300px;" />
                    </div>
                    <div class="mb-3 text-center">
                        <label for="txtConteudo" class="form-label">Conteúdo</label>
                        <asp:TextBox ID="txtConteudo" runat="server" TextMode="MultiLine" CssClass="form-control mx-auto" Rows="5" style="max-width: 300px;" />
                    </div>
                    <div class="mb-3 text-center">
                        <label for="ddlCategorias" class="form-label">Categoria</label>
                        <asp:DropDownList ID="ddlCategorias" runat="server" CssClass="form-select mx-auto" style="max-width: 300px;"></asp:DropDownList>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Fechar</button>
                    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-primary" OnClick="btnSalvar_Click" />
                </div>
            </div>
        </div>
    </div>

    <script>
        function preencherModal(id, titulo, conteudo, categoriaId, nomeCategoria) {
            document.getElementById('<%= hfArtigoId.ClientID %>').value = id;
            document.getElementById('<%= txtTitulo.ClientID %>').value = titulo;
            document.getElementById('<%= txtConteudo.ClientID %>').value = conteudo;
            document.getElementById('<%= ddlCategorias.ClientID %>').value = categoriaId;
        }
    </script>

</asp:Content>
