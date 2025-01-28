<%@ Page Title="Formulários" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Forms.aspx.cs" Inherits="WebForms_ConectaCiencia.Forms" Async="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="d-flex justify-content-center align-items-center vh-100">
        <div class="container p-4" style="max-width: 1200px;"> 
            <div class="row">

                <div class="col-md-6 d-flex justify-content-center">
                    <div class="p-4 border shadow-lg" style="width: 100%; max-width: 400px;">
                        <h2 class="text-center">Sugerir Artigo</h2>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtNomeArtigo" CssClass="form-control mb-2" runat="server" Placeholder="Nome*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtEmailArtigo" CssClass="form-control mb-2" runat="server" Placeholder="Email*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtTituloArtigo" CssClass="form-control mb-2" runat="server" Placeholder="Título*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:TextBox ID="txtConteudoArtigo" CssClass="form-control mb-2" runat="server" TextMode="MultiLine" Placeholder="Conteúdo*" />
                        </div>
                        <div class="form-group d-flex justify-content-center">
                            <asp:DropDownList ID="ddlCategoriaArtigo" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Selecione uma Categoria" Value="" />
                            </asp:DropDownList>
                        </div>
                        <div class="text-center">
                            <asp:Button ID="BtnEnviarArtigo" CssClass="btn btn-primary mt-2" runat="server" Text="Enviar" OnClick="BtnEnviarArtigo_Click" Enabled="false" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
