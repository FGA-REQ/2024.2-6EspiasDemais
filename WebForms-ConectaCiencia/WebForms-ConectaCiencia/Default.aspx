<%@ Page Title="Feed" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms_ConectaCiencia._Default" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1 class="my-4">Artigos</h1>

        <div class="container mt-4">
            <div class="d-flex flex-rows gap-3 mb-4">
                <asp:TextBox ID="txtTextoPesquisa" runat="server" CssClass="form-control" Placeholder="Busca..." />
                <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Selecione uma Categoria" Value="" />
                </asp:DropDownList>
                <asp:TextBox ID="txtDataPublicacao" runat="server" CssClass="form-control" TextMode="Date" Placeholder="Data de Publicação" />
                <asp:Button ID="BtnPesquisar" runat="server" Text="Pesquisar" OnClick="BtnPesquisar_Click" CssClass="btn btn-primary" />
            </div>

            <div class="container mt-4 text-center">
                <asp:Label ID="lblMensagem" runat="server" CssClass="alert alert-info" Visible="false"></asp:Label>
            </div>

            <asp:Repeater ID="Repeater1" runat="server">
            </asp:Repeater>
        </div>

        <asp:Repeater ID="ArticlesRepeater" runat="server">
            <ItemTemplate>
                <div class="card mb-4 border p-2 shadow">
                    <div class="card-body">
                        <h2 class="card-title"><%# Eval("Titulo") %></h2>
                        <p class="card-text"><%# Eval("Conteudo") %></p>
                        <footer class="blockquote-footer">
                            Publicado por <%# Eval("Usuario.Nome") %> em <%# Eval("Data", "{0:dd/MM/yyyy}") %>
                        </footer>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>