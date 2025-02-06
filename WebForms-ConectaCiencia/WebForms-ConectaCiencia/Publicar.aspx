<%@ Page Title="Publicar Artigo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Publicar.aspx.cs" Inherits="WebForms_ConectaCiencia.Publicar" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="d-flex justify-content-center align-items-center vh-100">
        <div class="publicar-box border p-4 shadow" style="width: 100%; max-width: 400px;">
            <h2 class="text-center">Publicar Artigo</h2>

            <div class="form-group d-flex justify-content-center">
                <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control" Placeholder="Titulo*" required onkeyup="verificarCampos()"></asp:TextBox>
            </div>

            <div class="form-group d-flex justify-content-center">
                <asp:TextBox ID="txtConteudo" runat="server" TextMode="MultiLine" CssClass="form-control" Rows="5" Placeholder="Conteudo*" required onkeyup="verificarCampos()"></asp:TextBox>
            </div>

            <div class="form-group d-flex justify-content-center">
                <asp:DropDownList ID="ddlCategoriaArtigo" runat="server" CssClass="form-control" required onchange="verificarCampos()">
                    <asp:ListItem Text="Selecione uma Categoria" Value="" />
                </asp:DropDownList>
            </div>

            <div class="text-center">
                <asp:Button ID="btnPublicar" runat="server" Text="Publicar" CssClass="btn btn-primary" OnClick="btnPublicar_Click" Disabled="True" />
            </div>

            <div>
                <asp:Label ID="lblMensagem" runat="server" CssClass="text-danger" Visible="false"></asp:Label>
            </div>
        </div>
    </div>

     <script type="text/javascript">
         function verificarCampos() {
             var titulo = document.getElementById('<%= txtTitulo.ClientID %>').value.trim();
             var conteudo = document.getElementById('<%= txtConteudo.ClientID %>').value.trim();
             var categoria = document.getElementById('<%= ddlCategoriaArtigo.ClientID %>').value;
             var botaoPublicar = document.getElementById('<%= btnPublicar.ClientID %>');

             botaoPublicar.disabled = !(titulo && conteudo && categoria);
         }
     </script>

</asp:Content>
